using AppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeb.Services
{
    public interface IDataAccessDB
    {
        List<UserPojo> GetAllUsers(); //Get all users//
        List<ProductPojo> GetAllProducts(); //Get all products//
        List<CategoryPojo> GetAllCategories(); //Get all categories//
        void InsertCategory(CategoryPojo category); //Insert category//
        void DeleteCategory(string category); //delete category//
        void EditCategory(CategoryPojo category); //Edit category//
        void DeleteUser(int id); //Delete user//
        void EditUser(UserPojo user); //Edit user//
        void InsertUser(UserPojo user); //Insert user//
        void InsertProduct(ProductPojo product); //Insert product//
        void DeleteProduct(int id); //Delete Product//
        void UpdateProduct(ProductPojo product); //Update product//
        void ProcessPurchase(int user, int id); //Purchase item//
        List<ReceipPojo> ItemsPurchased(); //Get all items purchased//
    }
}
