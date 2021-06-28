using AppWeb.Models;
using AppWeb.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class ProductController : Controller
    {
        private List<SelectListItem> selectListItems;
        IDataAccessDB Data = new DataDB();
        // GET: Product
        public ActionResult Index()
        {
            try
            {
                var obtainprodcuts = Data.GetAllProducts();
                return View(obtainprodcuts);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return View();
            }
        }      
       
        //New product//
        public ActionResult NewProduct()
        {           
            ProductPojo product = new ProductPojo();
            FillDropDownList();
            try
            {
                string btnclick = Request["addproduct"];
                if (btnclick == "Create")
                {
                    product.FullName = Request["nametxt"];
                    product.Price = Request["pricetxt"];
                    product.CategoryId = Convert.ToInt32(Request["category"]);

                    if (!string.IsNullOrEmpty(product.FullName) &&  !string.IsNullOrEmpty(product.Price) && !string.IsNullOrEmpty(product.CategoryId.ToString()))
                    {
                        Data.InsertProduct(product);
                        return RedirectToAction("Index", "Product");
                    }
                    return View();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error en: {ex.Message}");
            }
            return View();
        }
        //Delete product in db//
        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                if (id > 0)
                {
                    Data.DeleteProduct(id);
                }
                else
                {
                    return RedirectToAction("Index", "Product");
                }
                return RedirectToAction("Index", "Product");

            }
            catch (Exception ea)
            {
                Debug.WriteLine($"Error: {ea.Message}");
                return RedirectToAction("Index", "Product");
            }            
        }
        
        //Edit product//
        public ActionResult EditProduct(int? id)
        {
            try
            {
                var obtaincategories = Data.GetAllCategories(); 
                selectListItems = new List<SelectListItem>();
                foreach (var item in obtaincategories)//Fill list of categories//
                {
                    selectListItems.Add(new SelectListItem
                    {
                        Selected = true,
                        Text = item.CategoryName,
                        Value = item.CategoryId.ToString()
                    });
                }
                ViewBag.categ = selectListItems;


                if (id != null)
                {
                    var x = Data.GetAllProducts().Find(elem => elem.ProductId == id);
                    return View(x);
                }
                else
                {
                    return RedirectToAction("Index", "Product");
                }
            }
            catch (Exception ea)
            {
                Debug.WriteLine($"Error: {ea.Message}");
                return RedirectToAction("Index", "Product");
            }
        }
        
        //Edit product in db//
        [HttpPost]
        public ActionResult EditProduct(ProductPojo model)
        {
            try
            {
                model.CategoryId = Convert.ToInt32(Request["category"]);
                if (model.FullName != null && model.Price != null && model.CategoryId != 0)
                {
                    Data.UpdateProduct(model);
                }
                else
                {
                   return RedirectToAction("Index", "Product");
                }
                return RedirectToAction("Index", "Product");
            }
            catch (Exception ea)
            {
                Debug.WriteLine($"Error: {ea.Message}");
                return RedirectToAction("Index", "Product");
            }
            
        }
        //Fill Dropdown//
        public void FillDropDownList()
        {
            var obtaincategories = Data.GetAllCategories();
            selectListItems = new List<SelectListItem>();
            foreach (var item in obtaincategories)
            {
                selectListItems.Add(new SelectListItem
                {
                    Selected = true,
                    Text = item.CategoryName,
                    Value = item.CategoryId.ToString()
                });
            }
            ViewBag.categ = selectListItems;
        }
    }
}