using ProcessChanger.Infrastructure;
using ProcessChanger.Models;
using ProcessChanger.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace ProcessChanger.Controllers
{
    public class ChangeAnalysisController : BaseController
    {


        private readonly ICompanyRepository _companyRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;
        private readonly IProjectRepository _projectRepository;

        public ChangeAnalysisController(
            ICompanyRepository companyRepository, 
            ICustomerRepository customerRepository, 
            IProductRepository productRepository,
            IProjectRepository projecRepository)
        {
            _companyRepository = companyRepository;
            _customerRepository= customerRepository;
            _productRepository = productRepository;
            _projectRepository = projecRepository;
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new AddChangeAnalysisModel();
            BuildRequest(model);
            return View(model);

        }
        [HttpPost]
        public ActionResult Add(AddChangeAnalysisModel model)
        {
            BuildRequest(model);
            return View();
        }

        private void BuildRequest(AddChangeAnalysisModel model)
        {
            model.Companies = _companyRepository.GetCompanies()
                .ToSelectListItem(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString()
                }); 

              //.Select(c => new SelectListItem
              //{

              //    Text = c.Name,
              //    Value = c.Id.ToString()
              //});

            model.Customers = _customerRepository.GetCustomers()
            .Select(c => new SelectListItem
            {

                Text = c.Name,
                Value = c.Id.ToString()
            });


            model.Products = _productRepository.GetProducts()
            .Select(c => new SelectListItem
            {

                Text = c.PartName,
                Value = c.Id.ToString()
            });


            model.Projects = _projectRepository.GetProjects()
            .Select(c => new SelectListItem
            {

                Text = c.Name,
                Value = c.Id.ToString()
            });
        }

    }
}