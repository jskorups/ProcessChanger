using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Entities
{
    public class EconomicalHeader
    {
        public long Id { get; set; }
        public bool IsFeasible { get; set; }
        public bool PaidByCustomer { get; set; }
        public ChangeAnalysis ChangeAnalysis { get; set; }
    }
}