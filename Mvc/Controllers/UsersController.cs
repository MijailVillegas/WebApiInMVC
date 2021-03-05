using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            IEnumerable<MVCUsersModel> userList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Users").Result;
            userList = response.Content.ReadAsAsync<IEnumerable<MVCUsersModel>>().Result;

            return View(userList);
        }

        public ActionResult AddOrEdit(int id  = 0)
        {
            return View(new MVCUsersModel());
        }
        public ActionResult AddOrEdit()
        {
            return View();
        }
    }
}