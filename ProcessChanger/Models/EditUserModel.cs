using ProcessChanger.Entities;
using ProcessChanger.Infrastructure.Validators;
using System.ComponentModel.DataAnnotations;

namespace ProcessChanger.Models
{
    public class EditUserModel
    {
        public long ID { get; set; }
        //?
    
        [Required] //*
        public string FullName { get; set; }
        [EmailAddress] //*
        public string Email { get; set; }
        [Required] //*
        public DepartmentType Department { get; set; }
        [Required] //*
        public bool IsActive { get; set; }
    }
}