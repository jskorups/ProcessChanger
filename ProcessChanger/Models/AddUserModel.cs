using ProcessChanger.Entities;
using ProcessChanger.Infrastructure.Validators;
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
        [EmailDomainValidation]
        public string Email { get; set; }
        [Required]
        public  DepartmentType Department { get; set; }

    }

}