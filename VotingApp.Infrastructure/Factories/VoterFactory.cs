using VotingApp.Common.Interfaces;
using VotingApp.Common.Models;
using VotingApp.Infrastructure.Interfaces.Factories;

namespace VotingApp.Infrastructure.Factories
{
    public class VoterFactory : IBaseFactory<IVoter>
    {
        public IVoter Create(string entityName)
        {
            return new Voter(entityName);
        }
    }
}
