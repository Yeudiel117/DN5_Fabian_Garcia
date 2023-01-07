using GymManager.Core.MembershipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipTypes
{
	public class MembershipTypesAppService : IMembershipTypesAppService
	{
		private static List<MembershipType> MembershipTypes = new List<MembershipType>();

        public int AddMembershipType(MembershipType membershipType)
        {
            membershipType.Id = new Random().Next();

			MembershipTypes.Add(membershipType);

			return membershipType.Id;
        }

        public void DeleteMembership(int membershipId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipId).FirstOrDefault();

            MembershipTypes.Remove(m);
        }

        public void EditMembershipType(MembershipType membershipType)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipType.Id).FirstOrDefault();
            m.Duration = membershipType.Duration;
            m.CreatedOn = membershipType.CreatedOn; 
            m.Cost = membershipType.Cost;
            m.Name= membershipType.Name;
        }

        public MembershipType GetMembership(int membershipId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipId).FirstOrDefault();

            return m;
        }

        public List<MembershipType> GetMembershipTypes()
		{
			return MembershipTypes;
		}

	}
}
