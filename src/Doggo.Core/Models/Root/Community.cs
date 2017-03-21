using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggo
{
    public class Community : Entity, ICommunity<long>
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Url { get; set; }
        public bool? IsPrivate { get; set; }

        public Community(DoggoClient client) 
            : base(client) { }

        public Task<IEnumerable<IConnection<long>>> GetConnectionsAsync()
            => throw new NotImplementedException();
        public Task<IEnumerable<IUser<long>>> GetUsersAsync()
            => throw new NotImplementedException();
        public Task SaveChangesAsync()
            => throw new NotImplementedException();
    }
}
