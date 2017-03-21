using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Doggo
{
    internal class RestClient : IDisposable
    {
        private HttpClient _client = null;
        
        private string _host;
        private string _token;
        private bool _disposed = false;
        
        public RestClient(string host, string token)
        {
            _host = host;
            _token = token;
        }
        
        public Task<RestResponse> SendAsync(string method, string endpoint)
            => SendAsync(new RestRequest(method, endpoint));

        public async Task<RestResponse> SendAsync(RestRequest request)
        {
            var endpoint = string.Format(request.Endpoint, request.GetParameterString());
            var message = new HttpRequestMessage(new HttpMethod(request.Method), endpoint);

            if (!string.IsNullOrWhiteSpace(request.JsonBody))
            {
                string content = JsonConvert.SerializeObject(request.JsonBody);
                message.Content = new StringContent(content);
            }

            var response = await SendInternalAsync(message);
            return response;
        }

        internal async Task<RestResponse> SendInternalAsync(HttpRequestMessage message)
        {
            EnsureClientExists();

            var reply = await _client.SendAsync(message);

            try
            {
                reply.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new HttpException(reply.StatusCode, ex);
            }

            var content = await reply.Content.ReadAsStringAsync();
            return new RestResponse(reply.StatusCode, content);
        }

        private void EnsureClientExists()
        {
            if (_client == null)
            {
                var client = new HttpClient();

                client.BaseAddress = new Uri(_host);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("User-Agent", $"Doggo {ConfigurationBase.Version}");
                client.DefaultRequestHeaders.Add("Authorization", _token);

                _client = client;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _client.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
