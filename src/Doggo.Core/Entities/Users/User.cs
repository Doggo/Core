using System.Threading.Tasks;

namespace Doggo
{
    public class User : Entity<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        
        public User(DoggoClient client, long id)
            : base(client, id) { }

        public Task GetCommunitiesAsync()
            => Task.CompletedTask;
    }
}
