using BLL.DTOs;
using DLL;
using DLL.Models;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
   public class ProjectService
    {

        /*public static List<MemberDTO> Get()
        {
            var data = DataAccessFactory.Memberdata().Get();
            return Convert(data);

        }
        public static List<MemberDTO> Get10()
        {
            var mem = DataAccessFactory.Memberdata().Get();
            var data = from e in mem
                       where e.Id < 10
                       select e;
            return Convert(data.ToList());
        }
        /*public static bool Insert(MemberDTO member) {

            var data = Convert(member);
            var mem = DataAccessFactory.Memberdata().Insert();
        }
        public static Member Insert(MemberDTO member)
        {
            var data = Convert(member);
            return DataAccessFactory.Memberdata().Insert(data);
        }
            public static bool Insert(MemberDTO member)
        {
            var data = Convert(member);
            if( DataAccessFactory.Memberdata().Insert(data)>0)
                return null;

        } 
        public static Member Update(Member member)
        {
            var data = Convert(member);
            return DataAccessFactory.Memberdata().Update(member);
        }
        public static Member Delete(int id)
        {
            return DataAccessFactory.Memberdata().Delete(id);
        }
               */






        static ProjectDTO Convert(Project pro)
        {
            return new ProjectDTO()
            {
               
                    Id = pro.Id,
                    Title = pro.Title,
                    Status = pro.Status,
                    StartDate =pro.StartDate,
                    EndDate = pro.EndDate
                    Member = new MemberDTO
                    {
                        Id = pro.Member.Id,
                        Role =pro.Member.Role,
                        Name =pro.Member.Name,
                    }
             


            };

        }
        static Project Convert(ProjectDTO pro)
        {
            return new Project()
            {

                Id = pro.Id,
                Title = pro.Title,
                Status = pro.Status,
                StartDate = pro.StartDate,
                EndDate = pro.EndDate

            };
        }


        public static List<ProjectDTO> Convert(List<Project> Projects)
        {
            var data = new List<MemberDTO>();
            foreach (var pro in Projects)
            {
                data.Add(Convert(pro));
            }
            return data;
        }
        public static List<Member> Convert(List<MemberDTO> members)
        {
            var data = new List<Member>();
            foreach (var member in members)
            {
                data.Add(Convert(member));
            }
            return data;
        }



    }
}
