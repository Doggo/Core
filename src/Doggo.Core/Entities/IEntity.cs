namespace Doggo
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
