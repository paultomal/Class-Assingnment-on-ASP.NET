using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Interfaces;
using DLL.Models;

namespace DLL.Repos
{
    internal class MemberRepo : Repo, PMRepo<Member, int, Member>
    {
        public Member Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> Get()
        {
            return db.Members.ToList();
        }

        public Member Get(int id)
        {
            return db.Members.Find(id);
        }

        public Member Insert(Member obj)
        {
            db.Members.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return obj;
        }

        public Member Update(Member obj)
        {
            throw new NotImplementedException();
        }
    }
}
