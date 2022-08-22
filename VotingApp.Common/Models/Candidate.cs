using VotingApp.Common.Helpers;
using VotingApp.Common.Interfaces;

namespace VotingApp.Common.Models
{
    public class Candidate : ICandidate
    {
        public Guid Id { get; }
        public string Name { get; }

        public Candidate(string name)
        {
            ThrowIf.Argument.IsNull(() => name);

            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
