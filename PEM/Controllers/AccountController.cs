using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PEM.Models;
using PEM.Service.Helpers.Clients;
using PEM.Service.Helpers.POCO;

namespace PEM.Controllers
{
    public class AccountController : Controller
    {
        private readonly IPowersoftApiProvider loginClient;

        public AccountController(IPowersoftApiProvider loginClient)
        {
            this.loginClient = loginClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        // GET: Login
        public async Task<IActionResult> Login([FromQuery] LoginModel login)
        {

            StatusMessage statusMessage = new StatusMessage();

            try
            {
                if (ModelState.IsValid)
                {
                    string uname = login.Username;
                    string pword = login.Password;

                    statusMessage = await loginClient.Login(uname, pword);

                    if (statusMessage.status == "Success")
                    {
                        //fill session variable with globally needed data across application
                        //life span
                    }
                }
                else
                {
                    ViewBag.Message = "Invalid Username or Password";

                    statusMessage.status = "Failed";
                    statusMessage.message = "Login credentials not in corect format";
                }
            }
            catch (Exception ex)
            {
            }

            return Json(statusMessage);

        }

        /* // GET: AccountController/Details/5
         public ActionResult Details(int id)
         {
             return View();
         }

         // GET: AccountController/Create
         public ActionResult Create()
         {
             return View();
         }

         // POST: AccountController/Create
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Create(IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: AccountController/Edit/5
         public ActionResult Edit(int id)
         {
             return View();
         }

         // POST: AccountController/Edit/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Edit(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: AccountController/Delete/5
         public ActionResult Delete(int id)
         {
             return View();
         }

         // POST: AccountController/Delete/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Delete(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }*/
     }
    
}
