using VotingApp.Common.Helpers;
using VotingApp.Common.Interfaces;
using VotingApp.Infrastructure.Interfaces.Factories;
using VotingApp.Infrastructure.Interfaces.Repositories;

namespace VotingApp.Infrastructure.Repositories
{
    public class CandidatesRepository : IBaseRepository<ICandidate>
    {
        private readonly Dictionary<string, ICandidate> _candidates = new Dictionary<string, ICandidate>();
        private IBaseFactory<ICandidate> _candidateFactory;

        public CandidatesRepository(IBaseFactory<ICandidate> candidateFactory)
        {
            _candidateFactory = candidateFactory;
        }

        public void Add(string entityName)
        {
            ThrowIf.Argument.IsNull(() => entityName);
            _candidates.TryAdd(entityName, _candidateFactory.Create(entityName));
        }

        public ICandidate GetByName(string entityName)
        {
            ThrowIf.Argument.IsNull(() => entityName);
            _candidates.TryGetValue(entityName, out ICandidate voter);

            return voter;
        }

        public IEnumerable<ICandidate> GetAll()
        {
            return _candidates.Values;
        }

        public ICandidate GetById(Guid id)
        {
            return _candidates.Values.FirstOrDefault(item => item.Id == id);
        }
    }
}
