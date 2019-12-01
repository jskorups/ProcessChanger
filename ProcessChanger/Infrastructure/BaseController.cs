using Ninject;
using ProcessChanger.Validators;
using System.Web.Mvc;

namespace ProcessChanger.Infrastructure
{
    public class BaseController : Controller
    {
        [Inject]
        public IKernel Kernel { get; set; }

        protected void Validate<T>(T model)
        {
            var validator = Kernel.Get<IModelValidator<T>>();

            if(validator != null)
            {
                var validationResult = validator.Validate(model);

                foreach (var validation in validationResult)
                {
                    ModelState.AddModelError(validation.Key, validation.ErrorMessage);
                }

            }
        }
    }
}