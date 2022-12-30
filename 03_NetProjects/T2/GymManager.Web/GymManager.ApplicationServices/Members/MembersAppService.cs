using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {
        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();
            members.Add(new Member
            {
                Name = "Fabian",
                LastName = "Garcia",
                BirthDay = new DateTime(2000, 9, 24),
                AlowNewsletter = true,
                CityId = 1,
                Email = "fabian@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Yeudiel",
                LastName = "Magana",
                BirthDay = new DateTime(2000, 5, 13),
                AlowNewsletter = true,
                CityId = 2,
                Email = "yeudiel@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Rodolfo",
                LastName = "Martinez",
                BirthDay = new DateTime(2000, 10, 22),
                AlowNewsletter = true,
                CityId = 3,
                Email = "rodolfo@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Arturo",
                LastName = "Zaragosa",
                BirthDay = new DateTime(2001, 11, 11),
                AlowNewsletter = true,
                CityId = 4,
                Email = "arturo@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Daniela",
                LastName = "Rodriguez",
                BirthDay = new DateTime(2000, 3, 30),
                AlowNewsletter = true,
                CityId = 5,
                Email = "dani@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Marta",
                LastName = "Vazques",
                BirthDay = new DateTime(2002, 1, 1),
                AlowNewsletter = true,
                CityId = 6,
                Email = "marta@gmail.com"
            });

            return members;
        }
    }
}
