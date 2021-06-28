using AppWeb.Models;
using AppWeb.Services;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class CategoriesController : Controller
    {
        IDataAccessDB Data = new DataDB();
        // GET: Categories
        public ActionResult Index()
        {           
            try
            {
                var obtaincategories = Data.GetAllCategories();
                if (obtaincategories.Count != 0)
                {
                    return View(obtaincategories);
                }
                else
                {
                    return View();
                }               
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
                return View();
            }
        }     
        //Delete Category//
        [HttpGet]
        public RedirectToRouteResult DeleteCategory(string model)
        {
            Data.DeleteCategory(model);
            return RedirectToAction("Index","Categories");
        }

        //Redirect to edit the category//
        public ActionResult EditCategory(int? model)
        {
            if (model != null)
            {
                var x = Data.GetAllCategories().Find(elem => elem.CategoryId == model);
                return View(x);               
            }
            else
            {
                return RedirectToAction("Index", "Categories");
            }           
        }

        //Update catgory method//
        [HttpPost]
        public ActionResult EditCategory(CategoryPojo id) 
        {
            if (id != null)
            {
                Data.EditCategory(id);
                return RedirectToAction("Index", "Categories");
            }
            else
            {
                return View(id);
            }              
                    
        }

    }
}