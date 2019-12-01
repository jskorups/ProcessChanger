using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Entities
{
    public class EconomicalAnalysis
    {
        public long Id { get; set; }
        public string Asset { get; set; }
        public string Remarks { get; set; }
        public decimal AssociatedCost { get; set; }
        public Concept Concept { get; set; }
        public EconomicalHeader Header { get; set; }
    }

    public enum Concept
    {
        ManuFacturingControlMeans = 1,
        Product = 2,
        Process = 3,
        Quality = 4,
        Logistic = 5,
        Purchasing =6
    }
}