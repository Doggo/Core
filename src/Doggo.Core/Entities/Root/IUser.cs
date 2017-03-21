using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggo
{
    public interface IUser<TId>
    {
        DateTime CreatedAt { get; }
        string Name { get; }
        string Description { get; }
        string IconUrl { get; }
        
        Task<IEnumerable<ICommunity<TId>>> GetCommunitiesAsync();
        Task<IEnumerable<IConnection<TId>>> GetConnectionsAsync();
        Task SaveChangesAsync();
    }
}
