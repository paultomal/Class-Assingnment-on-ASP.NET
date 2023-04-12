using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Interfaces;
using DLL.Models;
using DLL.Repos;

namespace DLL
{
   public class DataAccessFactory
    {
        public static PMRepo<Project,int,Project> Projectdata()
        {
            return new ProjectRepo();
        }
        public static PMRepo<Member,int,Member> Memberdata()
        {
            return new MemberRepo();
        }
    }
}
