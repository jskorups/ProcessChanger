using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProcessChanger.Entities;

namespace ProcessChanger.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private IList<Company> _companies = new List<Company>()
        {
            new Company
            {
                Id = 1,
                Name  = "sdfsdf"

            }
        };
        


        

        public IList<Company> GetCompanies()
        {
            return _companies;
        }

        public Company GetEntity(long id)
        {
            return _companies.SingleOrDefault(c => c.Id == id);
        }
    }
}