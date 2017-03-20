using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Doggo
{
    public class Community : Entity<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Url { get; set; }
        public bool IsPrivate { get; set; }
        
        public Community(DoggoClient client, long id)
            : base(client, id) { }

        public Task GetUsersAsync()
            => Task.CompletedTask;
        public Task GetConnectionsAsync()
            => Task.CompletedTask;
    }
}
