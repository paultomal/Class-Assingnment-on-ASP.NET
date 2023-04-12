using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
   public class Member
    {   [Key]
        public int Id { get; set; }
        public string Role { get; set; }
        public string  Name { get; set; }
        public virtual Project project { get; set; }
    }
}
