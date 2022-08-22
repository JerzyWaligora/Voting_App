using VotingApp.Common.Helpers;
using VotingApp.Common.Interfaces;
using VotingApp.Infrastructure.Interfaces.Factories;
using VotingApp.Infrastructure.Interfaces.Repositories;

namespace VotingApp.Infrastructure.Repositories
{
    public class VotersRepository :  IBaseRepository<IVoter>
    {
        private readonly Dictionary<string, IVoter> _voters = new Dictionary<string, IVoter>() ;
        private IBaseFactory<IVoter> _voterFactory;

        public VotersRepository(IBaseFactory<IVoter> voterFactory)
        {
            _voterFactory = voterFactory;
        }

        public void Add(string entityName)
        {
            ThrowIf.Argument.IsNull(() => entityName);
            _voters.TryAdd(entityName, _voterFactory.Create(entityName));
        }
        public IVoter GetByName(string entityName)
        {
            ThrowIf.Argument.IsNull(() => entityName);
            _voters.TryGetValue(entityName, out IVoter voter);

            return voter;
        }
        public IEnumerable<IVoter> GetAll()
        {
            return _voters.Values;
        }
        public IVoter GetById(Guid id)
        {
            return _voters.Values.FirstOrDefault(item => item.Id == id);
        }
    }
}
