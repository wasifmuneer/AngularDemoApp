using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SSOAdmin.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string username,string pass,string returnUrl)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, "Brock"));
            claims.Add(new Claim(ClaimTypes.Email, "brockallen@gmail.com"));
            var id = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;
            authenticationManager.SignIn(id);

            return RedirectToAction("Index", "Home");
        }
    }
}