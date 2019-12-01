using ProcessChanger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Models
{
    public class UserListItemModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string email { get; set; }
        public DepartmentType Department{ get; set; }
    }
}