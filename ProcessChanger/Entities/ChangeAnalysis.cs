using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Entities
{
    public class ChangeAnalysis
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public ModificationType ModificationType { get; set; }
        public ModificationOrigin ModificationOrigin { get; set; }

        public User Requester { get; set; }
        public DepartmentType Department { get; set; }
        public Company Company { get; set; }

        public string ReasonForChange { get; set; }
        public Product Product { get; set; }
        public ProcessType ProcessType { get; set; }
        public Project Project { get; set; }
        public Customer Customer { get; set; }
        public string ChangeDescription { get; set; }
        public string PreliminaryAnalysis { get; set; }
    }


    public enum ModificationType
    {
        Product,
        Process
    }


    public enum ModificationOrigin
    {
        Internal,
        External
    }

    public enum ProcessType
    {
        Wedling,
        Assembly,
        Injection
    }
}