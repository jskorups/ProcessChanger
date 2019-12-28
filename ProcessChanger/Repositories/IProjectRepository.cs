using ProcessChanger.Entities;
using System.Collections.Generic;

namespace ProcessChanger.Repositories
{
    public interface IProjectRepository
    {
        Project GetEntity(long id);
        IList<Project> GetProjects();
    }
}

