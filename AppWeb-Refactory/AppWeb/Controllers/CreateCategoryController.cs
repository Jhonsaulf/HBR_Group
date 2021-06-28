using AppWeb.Models;
using AppWeb.Services;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class CreateCategoryController : Controller
    {
        IDataAccessDB Data = new DataDB();
        CategoryPojo category = new CategoryPojo();

        // GET: CreateCategory
        public ActionResult Index()
        {
            try
            {
                string btnclick = Request["createcategory"];
                if (btnclick == "Create")
                {
                    category.CategoryName = Request["categorytxt"];
                    category.Description = Request["desctxt"];

                    if (!string.IsNullOrEmpty(category.CategoryName) || !string.IsNullOrEmpty(category.Description))
                    {
                        Data.InsertCategory(category);
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message}");
                return View();
            }
            return View();
        }
    }
}