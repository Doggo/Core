namespace Test
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
