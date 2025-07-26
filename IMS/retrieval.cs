using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class retrieval
    {
        public void showUsers(DataGridView gv , DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statusGV, string data=null)
        {
            try
            {
                SqlCommand cmd;
                if(data == null)
                {
                    cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUsersDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
               
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch(Exception)
            {

            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catnameGV,DataGridViewColumn statGV, string data=null)
        {
            try
            {

                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getCategoriesDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catnameGV.DataPropertyName = dt.Columns["Category"].ToString();            
                statGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data." , "Error..." , "Error");
            }
        }

        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..."};
                dt.Rows.InsertAt(dr,0);
               
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                //cb.Items.Insert(0, "Select ...");
                cb.DataSource = dt;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void showSalesDataViaID(Int64 salesID , DataGridView gv, DataGridViewColumn salesIDGV, DataGridViewColumn barcodeGV, DataGridViewColumn productGV,
            DataGridViewColumn quantityGV, DataGridViewColumn totDiscGV, DataGridViewColumn totAmountGV, DataGridViewColumn amountGivenGV,
            DataGridViewColumn amountReturnGV, DataGridViewColumn dateGV , DataGridViewColumn productPriceGV, DataGridViewColumn perProductDiscGV,
            DataGridViewColumn perProductTotGV, DataGridViewColumn userGV, DataGridViewColumn paymentGV, DataGridViewColumn proIDGV,string data = null)
        {
            try
            {

                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSalesReceiptWRTSalesID", MainClass.con);
                    cmd.Parameters.AddWithValue("@salesID", salesID);
                }
                else
                {
                    cmd = new SqlCommand("st_getSalesReceiptWRTSalesIDDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salesIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                productGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                totDiscGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                amountGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                amountReturnGV.DataPropertyName = dt.Columns["Amount Return"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                productPriceGV.DataPropertyName = dt.Columns["Product Price"].ToString();
                perProductDiscGV.DataPropertyName = dt.Columns["Per Product Discount"].ToString();
                perProductTotGV.DataPropertyName = dt.Columns["Per Product Total"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                paymentGV.DataPropertyName = dt.Columns["Pay Type"].ToString();
               

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MainClass.ShowMSG("Unable to load categories data.", "Error...", "Error");
                MainClass.ShowMSG("Unable to load categories data. Error: " + ex.Message, "Error...", "Error");
                Console.WriteLine(ex.StackTrace); // Print stack trace for debugging
            }
        }

        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn pronameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV,  DataGridViewColumn barcodeGV , DataGridViewColumn catIDGV , string data = null)
        {
            try
            {
         
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getProductsData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getProductsDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                   proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                   pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                   barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                   expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
     
                   catGV.DataPropertyName = dt.Columns["Category"].ToString();
                  catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
             
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MainClass.ShowMSG("Unable to load categories data.", "Error...", "Error");
                MainClass.ShowMSG("Unable to load categories data. Error: " + ex.Message, "Error...", "Error");
                Console.WriteLine(ex.StackTrace); // Print stack trace for debugging
            }
        }


        public void showDailySales(DateTime date, DataGridView gv, DataGridViewColumn saleIDGV, DataGridViewColumn userGV, DataGridViewColumn totAmountGV, DataGridViewColumn totDiscGV, DataGridViewColumn amountGivenGV, DataGridViewColumn amountReturnedGV, DataGridViewColumn userIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDailySales", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                saleIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                totDiscGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                amountGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                amountReturnedGV.DataPropertyName = dt.Columns["Returned Amount"].ToString();
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MainClass.ShowMSG("Unable to load categories data.", "Error...", "Error");
                MainClass.ShowMSG("Unable to load categories data. Error: " + ex.Message, "Error...", "Error");
                Console.WriteLine(ex.StackTrace); // Print stack trace for debugging
            }
        }

        public static int USER_ID
        {
            get;
            private set;
        }
        public static string EMP_NAME
        {
            get;
            private set;
        }


        public void showReport(string reportName,ReportDocument rd ,CrystalReportViewer crv,string proc, string param1 = null, object val1 = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param1 != null && val1 != null)
                {
                    cmd.Parameters.AddWithValue(param1, val1);
                }
                else
                {

                }
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
         
                rd.Load(Application.StartupPath + "\\Reports\\"+reportName);
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex)
            {

                MainClass.ShowMSG(ex.Message,"Error", "Error");
            }
        }

        private string[] productsData = new string[3];

        public string[] getProductsWRTBarcode(string barcode)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("barcode", barcode);
                MainClass.con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString(); // productID
                        productsData[1] = dr[1].ToString(); // product
                        productsData[2] = dr[2].ToString(); // barcode
                 
                    }
                }
                else
                {
                    Array.Clear(productsData, 0, productsData.Length);
                    // MainClass.ShowMSG("No product available", "Error...", "Error");
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                throw;
            }
            return productsData;
        }
        //  private static string user_name = null;
        //  private static string pass_word = null;
        //  private static bool checkLogin;

        //public static bool getUserDetails(string username, string password)
        //{
        //    bool checkLogin = false;
        //    string user_name = null;
        //    string pass_word = null;

        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.VarChar, 30)).Value = username;
        //            cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.NVarChar, 30)).Value = password;

        //            MainClass.con.Open();
        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {
        //                if (dr.HasRows)
        //                {
        //                    checkLogin = true;
        //                    while (dr.Read())
        //                    {
        //                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
        //                        EMP_NAME = dr["Name"].ToString();
        //                        user_name = dr["Username"].ToString();
        //                        pass_word = dr["Password"].ToString();
        //                    }
        //                }
        //                else
        //                {
        //                    MainClass.ShowMSG("Invalid Username and/or Password", "Error...", "Error");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MainClass.ShowMSG("Unable to login: " + ex.Message, "Error...", "Error");
        //    }
        //    finally
        //    {
        //        if (MainClass.con.State == ConnectionState.Open)
        //            MainClass.con.Close();
        //    }
        //    return checkLogin;
        //}





        //    from GPT   //
        public static bool getUserDetails(string username, string password)
        {
            bool checkLogin = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@user", SqlDbType.VarChar, 30).Value = username;
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 30).Value = password;

                    MainClass.con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            checkLogin = true;
                            while (dr.Read())
                            {
                                USER_ID = Convert.ToInt32(dr["ID"]);
                                EMP_NAME = dr["Name"].ToString();
                            }
                        }
                        else
                        {
                            MainClass.ShowMSG("Invalid Username and/or Password", "Error...", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG("Unable to login: " + ex.Message, "Error...", "Error");
            }
            finally
            {
                if (MainClass.con.State == ConnectionState.Open)
                    MainClass.con.Close();
            }
            return checkLogin;
        }









        public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn compnameGV, DataGridViewColumn personGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV, string data=null)
        {
            try
            {
               // SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getSuppliersDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                compnameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MainClass.ShowMSG("Unable to load categories data.", "Error...", "Error");
                MainClass.ShowMSG("Unable to load supplier data. Error: " + ex.Message, "Error...", "Error");
                Console.WriteLine(ex.StackTrace); // Print stack trace for debugging
            }
        }

        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember,string param1, object val1, string param2, object val2)
        {
            try
            {
               // cb.Items.Clear();
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);

                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                //cb.Items.Insert(0, "Select ...");
                cb.DataSource = dt;
            }
            catch (Exception ex)
            {
               // throw;
            }
        }


        private object productStockCount = 0;
        public object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
              
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                   // Convert.ToInt32(cmd.ExecuteNonQuery());
                MainClass.con.Close();
            }
            catch(Exception)
            { 

            }
            return productStockCount;
        }

        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                productStockCount = cmd.ExecuteScalar();
            }
            catch (Exception)
            {

            }
            return productStockCount;
        }

        public void showPurchaseInvoiceDetails(Int64 pid,DataGridView gv, DataGridViewColumn mPIDgv,DataGridViewColumn proIDGV, DataGridViewColumn pronameGV, DataGridViewColumn quantityGV, DataGridViewColumn pupGV, DataGridViewColumn totalGV, string data=null)
        {

            try // GV ko bs small krdya gv
            {

                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                    cmd.Parameters.AddWithValue("@pid", pid);
                }
                else
                {
                    cmd = new SqlCommand("st_getPurchaseInvoiceDetailsDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
              
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDgv.DataPropertyName = dt.Columns["MPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totalGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MainClass.ShowMSG("Unable to load categories data.", "Error...", "Error");
                MainClass.ShowMSG("Unable to load categories data. Error: " + ex.Message, "Error...", "Error");
                Console.WriteLine(ex.StackTrace); // Print stack trace for debugging
            }
        }


        private object[] productPriceDetail = new object[5];
        public object[] checkProductPriceExistance(Int64 proID)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);

                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productPriceDetail[0] = dr[0].ToString(); //proID
                        productPriceDetail[1] = dr[1].ToString(); //bp
                        productPriceDetail[2] = dr[2].ToString(); //sp
                        productPriceDetail[3] = dr[3].ToString(); //disPercentag
                        productPriceDetail[4] = dr[4].ToString(); //profitPercentag

                    }
                }
                else
                {
                    Array.Clear(productPriceDetail, 0, productPriceDetail.Length);
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                throw new Exception("Error fetching product price existence: " + ex.Message);
            }

            return productPriceDetail;
        }


        private string[] productData = new string[6];

        // for sales window
        public string[] GetProductPricing(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcodeforSales", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productData[0] = dr[0].ToString();
                        productData[1] = dr[1].ToString();
                        productData[2] = dr[2].ToString();
                        productData[3] = dr[3].ToString();
                        productData[4] = dr[4].ToString();
                        productData[5] = dr[5].ToString();
                    }
                }
                else
                {
                    Array.Clear(productData, 0, productData.Length);
                }

                MainClass.con.Close();
     
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return productData;
        }

        //object[] result = new object[5]; // Adjust the size based on the expected number of columns
        // public object[] checkProductPriceExistance(Int64 proID)
        // {

        //     try
        //     {
        //         SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
        //         cmd.CommandType = CommandType.StoredProcedure;
        //         cmd.Parameters.AddWithValue("@proID", proID);
        //         MainClass.con.Open();
        //         SqlDataReader dr = cmd.ExecuteReader();
        //         if (dr.HasRows)
        //         {

        //             while (dr.Read())
        //             {
        //                 result[0] = dr["Column1"]; // Adjust according to actual column names
        //                 result[1] = dr["Column2"];
        //                 result[2] = dr["Column3"];
        //                 result[3] = dr["DiscountPercentage"];
        //                 result[4] = dr["ProfitPercentage"];
        //             }
        //         }
        //         MainClass.con.Close();
        //     }
        //     catch (Exception ex)
        //     {
        //         MainClass.con.Close();
        //         throw new Exception("Error fetching product price existence: " + ex.Message);
        //     }
        //     return result;
        // }


        // FIRST CODE

        //private bool checkPPExistance;
        //public bool checkProductPriceExistance(Int64 proID)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@proID", proID);
        //        MainClass.con.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            checkPPExistance = true;
        //        }
        //        else
        //        {
        //            checkPPExistance = false;
        //        }
        //        MainClass.con.Close();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    return checkPPExistance;
        //}
        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcodeGV, DataGridViewColumn expiryGV, DataGridViewColumn bpGV,DataGridViewColumn spGV ,DataGridViewColumn categoryGV, DataGridViewColumn availstGV, DataGridViewColumn statusGV, DataGridViewColumn totalGV, string data=null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getALLStock", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getStocksDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                availstGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totalGV.DataPropertyName = dt.Columns["Total Amount"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MainClass.ShowMSG("Unable to load categories data.", "Error...", "Error");
                MainClass.ShowMSG("Unable to load stock data. Error: " + ex.Message, "Error...", "Error");
                Console.WriteLine(ex.StackTrace); // Print stack trace for debugging
            }
        }

        public void showProductsWRTCategory(int catID,DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn pronameGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn disGV, DataGridViewColumn profitPerGV,string data = null)
        {
            try
            {
                
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                    cmd.Parameters.AddWithValue("@catID", catID);
                }
                else
                {
                    cmd = new SqlCommand("st_getproductsWRTCategoryDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                disGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitPerGV.DataPropertyName = dt.Columns["Proft Percentage"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MainClass.ShowMSG("Unable to load categories data.", "Error...", "Error");
                MainClass.ShowMSG("Unable to load products data. Error: " + ex.Message, "Error...", "Error");
                Console.WriteLine(ex.StackTrace); // Print stack trace for debugging
            }
        }
    }
}
