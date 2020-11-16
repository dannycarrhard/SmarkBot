using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Swagger.CustomModel
{
    public class BetSet
    {
        public int BetSetId { get; set; }

        public int BetCycleId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime? DeletedDateTime { get; set; }

        public string Description { get; set; }

        public DateTime BetSetStartDateTime { get; set; }

        public DateTime BetSetEndDateTime { get; set; }

        public List<Contract> Contracts { get; set; }

        public decimal SetTargetAmount { get; set; }

        public decimal ContractStakeBaseAmount { get; set; }

        public decimal ContractStakeLimitAmount { get; set; }
    }
}
