using System;
using System.Threading.Tasks;

namespace Doggo
{
    public interface IConnection<TId>
    {
        DateTime CreatedAt { get; }
        string Name { get; }
        string Description { get; }
        string Url { get; }
        TId OwnerId { get; }
        ConnectionType Type { get; }

        Task<IUser<TId>> GetOwnerAsync();
        Task<ICommunity<TId>> GetCommunityAsync();
        Task SaveChangesAsync();
    }
}
