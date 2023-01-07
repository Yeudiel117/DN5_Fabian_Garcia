using GymManager.Core.MembershipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipTypes
{
	public interface IMembershipTypesAppService
	{

		List<MembershipType> GetMembershipTypes();

		int AddMembershipType(MembershipType membershipType);

		void DeleteMembership(int membershipId);

        MembershipType GetMembership(int membershipId);

        void EditMembershipType(MembershipType membershipType);

    }
}
