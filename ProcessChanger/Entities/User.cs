using System.Web;

namespace ProcessChanger.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DepartmentType Department { get; set; }
        public bool IsActive { get; set; }

    }
        public enum DepartmentType
        {
            Quality = 1,
            Logistics = 2,
            Engineering = 3
        }

    }
