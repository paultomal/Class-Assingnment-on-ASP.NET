using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Interfaces;
using DLL.Models;

namespace DLL.Repos
{
    internal class ProjectRepo : Repo, PMRepo<Project, int, Project>
    {
        public Project Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> Get()
        {
            return db.Projects.ToList();
        }

        public Project Get(int id)
        {
            return db.Projects.Find(id);
        }

        public Project Insert(Project obj)
        {
            db.Projects.Add(obj);
            if (db.SaveChanges()>0)
            {
                return obj;
            }
            return obj;
        }

        public Project Update(Project obj)
        {
            throw new NotImplementedException();
        }
    }
}
