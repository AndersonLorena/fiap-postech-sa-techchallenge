namespace AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Services
{
    public interface IHashService<TSalt>
        where TSalt : class
    {
        string HashPassword(TSalt salt, string password);
    }
}