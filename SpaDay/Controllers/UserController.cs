using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;
using SpaDay.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            // add form submission handling code here
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password
                    
                };
                UserData.Add(newUser);
                return Redirect("Index");
            }
            else 
            {
                ViewBag.username = addUserViewModel.Username;
                ViewBag.email = addUserViewModel.Email;
                ViewBag.error = "error";
                return View("Add");
            }
        }
    }
}

