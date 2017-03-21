using Newtonsoft.Json;

namespace Test
{
    public class Entity : IEntity<long>
    {
        [JsonIgnore]
        public DoggoClient Client { get; }
        public long Id { get; set; }

        public Entity(DoggoClient client)
        {
            Client = client;
        }
    }
}
