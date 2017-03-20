using System;

namespace Doggo
{
    public class UserCredentials
    {
        public DateTime ExpiresAt { get; set; }
        public string Hash { get; set; }
    }
}
