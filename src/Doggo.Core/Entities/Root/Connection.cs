using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Doggo
{
    public class Connection : Entity<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public long OwnerId { get; set; }
        public int Type { get; set; } // ConnectionType enum

        public Connection(DoggoClient client, long id)
            : base(client, id) { }

        public Task GetCommunitiesAsync()
            => Task.CompletedTask;
        public Task GetOwnerAsync()
            => Task.CompletedTask;
    }
}
