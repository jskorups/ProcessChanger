using ProcessChanger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessChanger.Repositories
{
    public interface ICompanyRepository
    {
        Company GetEntity(long id);
        IList<Company> GetCompanies();
    }
}
