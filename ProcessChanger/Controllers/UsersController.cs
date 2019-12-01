using System.Web.Mvc;
using ProcessChanger.Infrastructure;
using ProcessChanger.Models;
using ProcessChanger.Repositories;

namespace ProcessChanger.Controllers
{
    public class UsersController : BaseController
    {
        
        private IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            this._repository = repository;
        }

        // Add
        [HttpPost]
        public ActionResult Add(AddUserModel model)
        {
            Validate(model);
            if (ModelState.IsValid)
            {
                _repository.Add(model);
                return RedirectToAction("List");
            }           
            // mozemy przkeazac nowy model
            return View(model);
        }
        [HttpGet]

        public ActionResult Add()
        {
            

            var model = new AddUserModel();        
            return View(model);
        }

        //Edit
        [HttpPost]
        public ActionResult Edit (EditUserModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model); 
                return RedirectToAction("List");
              
            }
            return View(model);

        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var model = _repository.FindUserById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult List()

        {
            return View(_repository.GetAllActiveUsers());
        }

      
    }
}