namespace VotingApp.Infrastructure.Interfaces.Factories
{
    public interface IBaseFactory<T>
    {
        T Create(string entityName);
    }
}
