using ProcessChanger.Entities;
using System.ComponentModel.DataAnnotations;

namespace ProcessChanger.Models
{
    public class AddUserModel
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public  DepartmentType Department { get; set; }

    }

}