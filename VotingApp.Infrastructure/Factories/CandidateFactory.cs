using VotingApp.Common.Interfaces;
using VotingApp.Common.Models;
using VotingApp.Infrastructure.Interfaces.Factories;

namespace VotingApp.Infrastructure.Factories
{
    public class CandidateFactory : IBaseFactory<ICandidate>
    {
        public ICandidate Create(string entityName)
        {
            return new Candidate( entityName );
        }
    }
}
