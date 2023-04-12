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
   public class MemberService
    {
          
      
        public static List<MemberDTO> Get()
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
        }*/
        public static Member Insert(MemberDTO member)
        {
            var data = Convert(member);
            return DataAccessFactory.Memberdata().Insert(data);
        }

        /* public static bool Insert(MemberDTO member)
        {
            var data = Convert(member);
            if( DataAccessFactory.Memberdata().Insert(data)>0)
                return null;

        } */
         public static Member Update(Member member)
        {
            var data = Convert(member);
            return DataAccessFactory.Memberdata().Update(member);
        }
         public static Member Delete(int id)
        {
            return DataAccessFactory.Memberdata().Delete(id);
        }










        static MemberDTO Convert(Member member)
        {
            return new MemberDTO()
            {
                Id = member.Id,
                Role = member.Role,
                Name = member.Name,
                project = new ProjectDTO
                {
                    Id = member.project.Id,
                    Title = member.project.Title,
                    Status = member.project.Status,
                    StartDate = member.project.StartDate,
                    EndDate = member.project.EndDate
                }

              
            };

        }
        static Member Convert(MemberDTO member)
        {
            return new Member()
            {

                Id = member.Id,
                Role = member.Role,
                Name = member.Name,
                project = new Project
                {
                    Id = member.project.Id,
                    Title = member.project.Title,
                    Status = member.project.Status,
                    StartDate = member.project.StartDate,
                    EndDate = member.project.EndDate
                }

               
            };
        }


        public static List<MemberDTO> Convert(List<Member> members)
        {
            var data = new List<MemberDTO>();
            foreach (var member in members)
            {
                data.Add(Convert(member));
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

