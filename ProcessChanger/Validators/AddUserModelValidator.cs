using ProcessChanger.Models;
using ProcessChanger.Repositories;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace ProcessChanger.Validators
{
    public class AddUserModelValidator: IModelValidator<AddUserModel>
    {

        private IUserRepository _userRepository;

        public AddUserModelValidator(IUserRepository repository)
        {
            _userRepository = repository;
        }


        public IEnumerable<ValidationResult> Validate(AddUserModel model)
        {
            var result = new List<ValidationResult>();
            var isEmailExists = _userRepository.GetUsers(u => u.Email == model.Email).Any();
            //*
            var isFullNameExists = _userRepository.GetUsers(u => u.Firstname == model.Firstname && u.Lastname == model.Lastname).Any();

            if (isEmailExists)
            {
                result.Add(new ValidationResult(nameof(AddUserModel.Email), "Podany email juz istnieje" ));
            }
            else if (isFullNameExists)
            {
                result.Add(new ValidationResult(nameof(AddUserModel.Firstname), "Podane imię juz istnieje"));
                result.Add(new ValidationResult(nameof(AddUserModel.Lastname), "Podane nazwisko juz istnieje"));
            }

            return result;

           // _userRepository.GetUsers(u => u.Firstname == model.Firstname && u.Lastname == model.Lastname).Any();
        }
    }
}