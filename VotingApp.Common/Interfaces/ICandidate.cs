using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Common.Interfaces
{
    public interface ICandidate
    {
        Guid Id { get; }
        string Name { get; }
    }
}
