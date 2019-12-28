using ProcessChanger.Entities;
using ProcessChanger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Repositories
{
    public class ChangeAnalysisRepository : IChangeAnalysisRepository
    {

        private IList<ChangeAnalysis> _analysis = new List<ChangeAnalysis>();

        private ICompanyRepository _companyRepository;
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        private IProjectRepository _projectRepository;

        public ChangeAnalysisRepository (ICompanyRepository companyRepository, ICustomerRepository customerRepository, IProductRepository productRepository, IProjectRepository projectRepository)
        {
            _companyRepository = companyRepository;
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _projectRepository = projectRepository;

        }

        public void Add(AddChangeAnalysisModel model)
        {
            ChangeAnalysis change = new ChangeAnalysis
            {
                Id = GetId(),
                Created = DateTime.UtcNow,
                ModificationType = model.ModificationType,
                ModificationOrigin = model.ModificationOrigin,


                //Requester

                Department = model.Department,
                Company = _companyRepository.GetEntity(model.CompanyId),
                ReasonForChange = model.ReasonForChange,
                Product = _productRepository.GetEntity(model.ProductId),
                ProcessType = model.ProcessType,
                Project = _projectRepository.GetEntity(model.ProjectId),
                Customer = _customerRepository.GetEntity(model.CompanyId),
                ChangeDescription = model.ChangeDescription,
                PreliminaryAnalysis = model.PreliminaryAnalysis

            };
            _analysis.Add(change);
        }

        private long GetId()
        {
            return _analysis.Count > 0 ? _analysis.Max(u => u.Id) + 1 : 1;
        }

    }
}