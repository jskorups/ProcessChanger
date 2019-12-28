using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
    }
}