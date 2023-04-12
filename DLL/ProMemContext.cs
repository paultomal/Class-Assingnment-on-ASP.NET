using DLL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
   class ProMemContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Project>Projects { get; set; }
    }
}
