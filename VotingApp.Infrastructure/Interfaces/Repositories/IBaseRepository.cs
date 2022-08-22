namespace VotingApp.Infrastructure.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        public T GetById(Guid id);
        public T GetByName(string entityName);
        public IEnumerable<T> GetAll();
        public void Add(string entityName);
    }   
}
