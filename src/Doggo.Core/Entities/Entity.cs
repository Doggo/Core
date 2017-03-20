namespace Doggo
{
    public class Entity<T>
    {
        T Id { get; }
        DoggoClient Client { get; }

        public Entity(DoggoClient client, T id)
        {
            Id = id;
            Client = client;
        }
    }
}
