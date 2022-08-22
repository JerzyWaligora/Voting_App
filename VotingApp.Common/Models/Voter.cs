using VotingApp.Common.Helpers;
using VotingApp.Common.Interfaces;

namespace VotingApp.Common.Models
{
    public class Voter : IVoter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool HasVoted
        {
            get
            {
                return CandidateName != null;
            }
        }
        public string? CandidateName { get; set; }

        public Voter(string name)
        {
            ThrowIf.Argument.IsNull(() => name);

            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
