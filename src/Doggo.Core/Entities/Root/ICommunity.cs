using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test
{
    public interface ICommunity<TId>
    {
        DateTime CreatedAt { get; }
        string Name { get; }
        string Description { get; }
        string IconUrl { get; }
        string Url { get; }
        bool? IsPrivate { get; }

        Task<IEnumerable<IUser<TId>>> GetUsersAsync();
        Task<IEnumerable<IConnection<TId>>> GetConnectionsAsync();
        Task SaveChangesAsync();
    }
}
