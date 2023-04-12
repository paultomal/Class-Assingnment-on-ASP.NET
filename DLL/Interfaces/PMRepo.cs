using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
  public  interface PMRepo <TYPE,ID,RET>
    {
        List<TYPE> Get();
        TYPE Get(ID id);
        RET Insert(TYPE obj);
        RET Update(TYPE obj);
        RET Delete(ID id);
    }
}
