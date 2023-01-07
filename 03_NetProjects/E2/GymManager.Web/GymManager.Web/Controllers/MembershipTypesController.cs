using GymManager.ApplicationServices.MembershipTypes;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.Web.Controllers
{
	public class MembershipTypesController : Controller
	{

		private readonly IMembershipTypesAppService _membershipTypesAppService;

		public MembershipTypesController(IMembershipTypesAppService membershipTypesAppService) 
		{
			_membershipTypesAppService= membershipTypesAppService;
		}

		public IActionResult Index()
		{
			List<MembershipType> membershipTypes = _membershipTypesAppService.GetMembershipTypes();

			MembershipTypeListViewModel viewModel = new MembershipTypeListViewModel();

			viewModel.MembershipTypes = membershipTypes;

			return View(viewModel);
		}

        public IActionResult Create()
        {
            return View();
        }

		[HttpPost]
        public IActionResult Create(MembershipType membershipType)
        {
            _membershipTypesAppService.AddMembershipType(membershipType);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int membershipId)
        {
			_membershipTypesAppService.DeleteMembership(membershipId);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(MembershipType membershipType)
        {
            _membershipTypesAppService.EditMembershipType(membershipType);

            return RedirectToAction("Index");
        }

        
        public IActionResult Edit(int membershipId)
        {
            MembershipType membership = _membershipTypesAppService.GetMembership(membershipId);

            return View(membership);
        }
    }
}
