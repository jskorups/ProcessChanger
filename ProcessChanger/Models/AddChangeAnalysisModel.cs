using ProcessChanger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProcessChanger.Models
{
    public class AddChangeAnalysisModel
    {       
        public ModificationType ModificationType { get; set; }
        public ModificationOrigin ModificationOrigin { get; set; }

        //public User Requester { get; set; }

        public DepartmentType Department { get; set; }

        public long CompanyId { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }


        public string ReasonForChange { get; set; }

        //TODO
        //public Product Product { get; set; }

        public ProcessType ProcessType { get; set; }

    
        public long ProductId { get; set; }
        public IEnumerable<SelectListItem> Products { get; set; }

        public long ProjectId { get; set; }
        public IEnumerable<SelectListItem> Projects { get; set; }


        public long CustomerId { get; set; }
        public IEnumerable<SelectListItem> Customers { get; set; }

        public string ChangeDescription { get; set; }
        public string PreliminaryAnalysis { get; set; }
    }
}