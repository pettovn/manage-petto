using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PET_MANAGEMENT.Models;

namespace PET_MANAGEMENT.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger _logger;

        public IActionResult Index()
        {
            return View();
        }

        #region Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string user_login, string password)
        {
            _logger.LogInformation("User logged out.");
            return View();
        }
        #endregion

        #region Register
        public IActionResult Register()
        {
            return View();
        }
        #endregion

        #region ForgotPassword
        public IActionResult ForgotPassword()
        {
            return View();
        }
        #endregion
    }
}