using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class updation
    {
        public void updateUsers(int id,string name, string username, string pass, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);

                MainClass.con.Open();
                cmd.ExecuteNonQuery(); // execute command for code just like execute for SQL.
                MainClass.con.Close();
                MainClass.ShowMSG(name + "updated to the system succesffulyy ", "Success ...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error ...", "Error");
            }
        }

        public void updateCat(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status); //cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);

                MainClass.con.Open();
                cmd.ExecuteNonQuery(); // execute command for code just like execute for SQL.
                MainClass.con.Close();
                MainClass.ShowMSG(name + " updated succesfully ", "Success ...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error ...", "Error");
            }
        }

        public void updateProduct(Int64 proID,string product, string barcode,  int catID, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productUpdate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
  
                if (expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@proID", proID);

                MainClass.con.Open();
                cmd.ExecuteNonQuery(); // execute command for code just like execute for SQL.
                MainClass.con.Close();
                MainClass.ShowMSG(product + " updated to the system succesfully ", "Success ...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error ...", "Error");
            }
        }

        public void updateSupplier(int supID, string companyName, string person, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", companyName);
                cmd.Parameters.AddWithValue("@conPerson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }

                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }
                cmd.Parameters.AddWithValue("@suppID", supID);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@status", status);

                MainClass.con.Open();
                cmd.ExecuteNonQuery(); // execute command for code just like execute for SQL.
                MainClass.con.Close();
                MainClass.ShowMSG(companyName + " updated succesfully ", "Success ...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error ...", "Error");
            }
        }

        public void updateStock(Int64 proID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quantity);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }

        }

        public void updateStockWithoutConnection(Int64 proID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quantity);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }

        }

        public void updateSalesQuantity(Int64 SalesID, Int16 quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateQuantityInSalesDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@quan", SalesID);
                cmd.Parameters.AddWithValue("@salID", quantity);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }

        }

        public void updateProductPrice(Int64 proID, float bp, float sp=0, float dis=0 , float profitPer=0)
        {
            try
            {
                SqlCommand cmd;
                if (sp == 0 && dis == 0 && profitPer == 0)
                {
                    cmd = new SqlCommand("st_updateProductPrice1", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@bp", bp);
                }
                else
                {
                    cmd = new SqlCommand("st_updateProductPrice", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@bp", bp);
                    cmd.Parameters.AddWithValue("@sp", sp);
                    cmd.Parameters.AddWithValue("@dis", dis);
                    cmd.Parameters.AddWithValue("@profPer", profitPer);

                }

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }

        }


    }
}
