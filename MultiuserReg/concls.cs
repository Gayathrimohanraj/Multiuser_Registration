using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MultiuserReg
{
    public class concls
    {
        SqlConnection con;
        SqlCommand cmd;
        public concls()
        {
            con = new SqlConnection(@"server=DESKTOP-GI533FU\SQLEXPRESS;database=Multiuserdb;Integrated security=true");
        }
        public int Fun_Non_Query(string sql) //insert,update,delete
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fun_scalar(string sql) //aggregate functions
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}