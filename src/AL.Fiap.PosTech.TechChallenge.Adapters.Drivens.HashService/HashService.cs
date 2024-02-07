using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Services;
using Microsoft.AspNetCore.Identity;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Drivens.HashService
{
    public class HashService<TSalt> : IHashService<TSalt>
         where TSalt : class
    {
        private readonly IPasswordHasher<TSalt> _passwordHasher;

        public HashService(IPasswordHasher<TSalt> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public string HashPassword(TSalt salt, string password)
        {
            return _passwordHasher.HashPassword(salt, password);
        }
    }
}