﻿using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.Web.Controllers
{
    public class MembersController : Controller
    {

        private readonly IMembersAppService _membersAppService;

        public MembersController(IMembersAppService membersAppService) 
        {
            _membersAppService = membersAppService;
        }

        public IActionResult Index()
        {

            var members = _membersAppService.GetMembers();

            return View(members);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int memberId)
        {
            _membersAppService.DeleteMember(memberId);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int memberId)
        {

            Member member = _membersAppService.GetMember(memberId);

            return View(member);
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {

            _membersAppService.AddMember(member);

            return RedirectToAction("Index");
        }

		[HttpPost]
		public IActionResult Edit(Member member)
		{

			_membersAppService.EditMember(member);

			return RedirectToAction("Index");
		}

		public IActionResult Test()
        {
            return View();
        }
    }
}
