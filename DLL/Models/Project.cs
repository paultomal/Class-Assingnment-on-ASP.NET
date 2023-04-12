using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
  public  class Project
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public  virtual ICollection<Member> Member { get; set; }
        

    }
}
