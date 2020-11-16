using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IO.Swagger.CustomModel
{
    public class BetCycle
    {
        public int BetCycleId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime? DeletedDateTime { get; set; }

        public string Description { get; set; }

        public DateTime BetCycleStartDateTime { get; set; }

        public DateTime BetCycleEndDateTime { get; set; }

        public List<BetSet> BetSets { get; set; }

        public decimal CycleTargetAmount { get; set; }


    }
}
