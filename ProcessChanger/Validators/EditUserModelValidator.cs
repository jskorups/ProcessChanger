using ProcessChanger.Models;
using ProcessChanger.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Validators
{
    public class EditUserModelValidator : IModelValidator<EditUserModel>
    {

        private IUserRepository _repository;

        public EditUserModelValidator (IUserRepository repository)
        {
            this._repository = repository;
        }

        public IEnumerable<ValidationResult> Validate(EditUserModel model)
        {
            return Enumerable.Empty<ValidationResult>();
        }
    }
}