using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using Microsoft.Extensions.Logging;

namespace GymManager.Web.Controllers
{
    public class MembersController : Controller
    {

        private readonly ILogger<MembersController> _logger;

        public MembersController(ILogger<MembersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                _logger.LogDebug("Debug message Called Index method in MembersController");
                _logger.LogInformation("Called Index method in MembersController");
                return View();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
            
        }

        
    }
}
