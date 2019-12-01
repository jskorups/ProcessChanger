using ProcessChanger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessChanger.Validators
{
    public interface IModelValidator<T>
    {
        IEnumerable<ValidationResult> Validate(T model);
    }
}
