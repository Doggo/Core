using System;
using System.Threading.Tasks;

namespace Doggo
{
    public class DoggoClient
    {
        private RedisClient _redis;
        private RestClient _rest;

        public Task LoginAsync(string token)
        {
            return Task.CompletedTask;
        }

        public Task SubscribeAsync(string topic, Func<string, Task> callback)
        {
            return Task.CompletedTask;
        }

        public Task UnsubscribeAsync(string topic)
        {
            return Task.CompletedTask;
        }

        public Task GetCommunityAsync(ulong id)
            => Task.CompletedTask;
        public Task GetCommunityAsync(long id)
            => Task.CompletedTask;
        public Task GetCommunitiesAsync()
            => Task.CompletedTask;
    }
}
