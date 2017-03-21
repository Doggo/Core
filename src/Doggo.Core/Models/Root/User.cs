using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test
{
    public class User : Entity, IUser<long>
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }

        public User(DoggoClient client) 
            : base(client) { }

        public Task<IEnumerable<ICommunity<long>>> GetCommunitiesAsync()
            => throw new NotImplementedException();
        public Task<IEnumerable<IConnection<long>>> GetConnectionsAsync()
            => throw new NotImplementedException();
        public Task SaveChangesAsync()
            => throw new NotImplementedException();
    }
}
