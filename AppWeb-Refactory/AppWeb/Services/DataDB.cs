using AppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Configuration;
using System.Diagnostics;

namespace AppWeb.Services
{
    public class DataDB : IDataAccessDB
    {
        public List<UserPojo> GetAllUsers() //Obtain Users from DB//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    var output = dbConnection.Query<UserPojo>("sp_GetAllUser", CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }                
            }
        }

        public List<ProductPojo> GetAllProducts() //Obtain Products from DB//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    var output = dbConnection.Query<ProductPojo>("sp_GetAllProducts", CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public List<CategoryPojo> GetAllCategories() //Obtain Categories from DB//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    var output = dbConnection.Query<CategoryPojo>("sp_GetAllCategories", CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    
        public void InsertCategory(CategoryPojo category)  //Insert new Category//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {                    
                    dbConnection.Execute($"sp_InsertCategory '{category.CategoryName}','{category.Description}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);                 
                }
            }
        }
    
        public void DeleteCategory(string category) //Delete Category//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    dbConnection.Execute($"sp_DeleteCategory '{category}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    
        public void EditCategory(CategoryPojo category) //Update Category//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    dbConnection.Execute($"sp_UpdateCategory '{category.CategoryId}', '{category.CategoryName}','{category.Description}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    
        public void DeleteUser(int id) //Delete User//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    dbConnection.Execute($"sp_DeleteUser '{id}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    
        public void EditUser(UserPojo user) //Edit User//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    dbConnection.Execute($"sp_UpdateUser '{user.UserId}', '{user.FirstName}','{user.LastName}','{user.Pass}','{user.User}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        } 
    
        public void InsertUser(UserPojo user) //Insert user//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {                  
                  
                     dbConnection.Execute($"sp_InsertUser '{user.FirstName}', '{user.LastName}','{user.User}','{user.Pass}', '{user.Rol}'");
                         
                   
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public void InsertProduct(ProductPojo product) //Insert Product//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    dbConnection.Execute($"sp_InsertProduct '{product.FullName}', '{product.Price}','{product.CategoryId}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public void DeleteProduct(int product) //Delete Product//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    dbConnection.Execute($"sp_DeleteProduct '{product}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        
        public void UpdateProduct(ProductPojo product) //Update Product//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    dbConnection.Execute($"sp_UpdateProduct '{product.ProductId}','{product.FullName}','{product.Price}','{product.CategoryId}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
       
        public void ProcessPurchase(int userId, int id) //Purchase Product//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    dbConnection.Execute($"sp_PurchaseItems '{userId}', '{id}'");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public List<ReceipPojo> ItemsPurchased() //Get items purchased by users//
        {
            using (IDbConnection dbConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                try
                {
                    var output = dbConnection.Query<ReceipPojo>("sp_Receips", CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}