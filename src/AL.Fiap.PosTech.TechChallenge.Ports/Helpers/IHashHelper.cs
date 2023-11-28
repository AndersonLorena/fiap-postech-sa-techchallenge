namespace AL.Fiap.PosTech.TechChallenge.Ports.Helpers
{
    public interface IHashHelper<TSalt>
    {
        string HashPassword(TSalt salt, string password);
    }
}