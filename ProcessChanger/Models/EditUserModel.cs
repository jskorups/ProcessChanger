using ProcessChanger.Entities;

namespace ProcessChanger.Models
{
    public class EditUserModel
    {
        public long ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DepartmentType Department { get; set; }
        public bool IsActive { get; set; }
    }

  

}