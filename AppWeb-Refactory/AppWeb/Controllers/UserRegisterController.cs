using AppWeb.Models;
using AppWeb.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class UserRegisterController : Controller
    {
        IDataAccessDB Data = new DataDB();
        UserPojo user = new UserPojo();
        private List<SelectListItem> selectListItems;

        // GET: UserRegister
        public ActionResult Index()
        {
            try
            {
                string btnclick = Request["signuser"];

                FillDropDownList();             

                if (btnclick == "SignUp")
                {
                    user.FirstName = Request["nametxt"];
                    user.LastName = Request["lasttxt"];
                    user.User = Request["usertxt"];
                    user.Pass = Request["passtxt"];
                    user.Rol = Request["Roles"];

                    var searchuser = Data.GetAllUsers().Where(elem => elem.User == user.User).ToList(); //Search user with the same username//
                    if (searchuser.Count == 0)
                    {
                        if (string.IsNullOrEmpty(user.FirstName) ||
                       string.IsNullOrEmpty(user.LastName) ||
                       string.IsNullOrEmpty(user.Pass) ||
                       string.IsNullOrEmpty(user.User) ||
                       string.IsNullOrEmpty(user.Rol))
                        {
                            Debug.WriteLine("Empty fields");
                        }
                        else
                        {
                            Data.InsertUser(user);
                        }
                    }
                    else
                    {
                        Response.Write($"<script>alert('A user with {user.User} already exists');</script>");
                    }                   
                   
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error en: {ex.Message}");
            }
            return View();
        }

        public void FillDropDownList() //This is for fill the dropdownlist//
        {
            List<string> roles = new List<string>() { "ADMINISTRADOR", "USUARIO" };
            selectListItems = new List<SelectListItem>();
            foreach (var item in roles)
            {
                selectListItems.Add(new SelectListItem
                {
                    Selected = true,
                    Text = item,
                    Value = item
                });
            }

            ViewBag.categ = selectListItems;
        }
    }
}