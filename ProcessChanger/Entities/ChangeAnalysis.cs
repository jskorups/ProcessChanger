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
        //Requester
        public DepartmentType Department { get; set; }
        public Company Company { get; set; }
        public string ReasonForChange { get; set; }
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
    }