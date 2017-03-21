using System;
using System.Threading.Tasks;

namespace Test
{
    public class Connection : Entity, IConnection<long>
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public long OwnerId { get; set; }
        public ConnectionType Type { get; set; }
        
        public Connection(DoggoClient client) 
            : base(client) { }

        public Task<Community> GetCommunityAsync()
            => throw new NotImplementedException();
        public Task<User> GetOwnerAsync()
            => throw new NotImplementedException();
        public Task SaveChangesAsync()
            => throw new NotImplementedException();

        // IConnection
        Task<IUser<long>> IConnection<long>.GetOwnerAsync()
            => throw new NotSupportedException();
        Task<ICommunity<long>> IConnection<long>.GetCommunityAsync()
            => throw new NotSupportedException();
        Task IConnection<long>.SaveChangesAsync()
            => throw new NotSupportedException();
    }
}
