using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class deletion
    {
        public void delete(object id, string proc, string param) // object for any datatype & everything is on runtime
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
              
                MainClass.con.Open();
                cmd.ExecuteNonQuery(); // execute command for code just like execute for SQL.
                MainClass.con.Close();
                MainClass.ShowMSG("Data deleted succesffulyy ", "Success ...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error ...", "Error");
            }
        }
    }
}
