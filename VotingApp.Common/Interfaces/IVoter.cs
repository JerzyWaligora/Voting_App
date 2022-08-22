using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Common.Interfaces
{
    public interface IVoter
    {
        Guid Id { get; }
        string Name { get; }
        bool HasVoted { get; }
        string CandidateName { get; set; }
    }
}
