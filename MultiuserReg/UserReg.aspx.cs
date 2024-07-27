using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiuserReg
{
    public partial class UserReg : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Login_Tab";
            string regid = obj.Fun_scalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ins = "insert into User_reg_tab values(" + reg_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + ")";
            int i = obj.Fun_Non_Query(ins);
            if (i == 1)
            {
                string inslog = "insert into Login_Tab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','user','active')";
                int j = obj.Fun_Non_Query(inslog);
                Label1.Text = "Registered successfully !";
                Label1.Visible = true;
            }

        } 
    }
}