using ProcessChanger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private IList<Project> _projects = new List<Project>()
        {
            new Project
            {
                Id = 1,
                Name = "B515"
            }
        };

        public Project GetEntity(long id)
        {
            return _projects.SingleOrDefault(c => c.Id == id);
        }

        public IList<Project> GetProjects()
        {
            return _projects;
     
        }
    }
}