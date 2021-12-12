using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public struct VoteTransferProportion
    {
        /// <summary>
        /// The party from which voters will leave; the lesser party in any one constituency pact.
        /// </summary>
        string From { get; set; }
        /// <summary>
        /// The party to which new voters will turn; the greater party in any one constituency pact.
        /// </summary>
        string To { get; set; }
        /// <summary>
        /// The proportion of lesser party members willing to vote for the greater alliance member.
        /// </summary>
        double Will { get; set; }
    }
}
