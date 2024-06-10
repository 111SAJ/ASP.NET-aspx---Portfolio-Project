using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SampleWebsite
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection cn = Connection.GetCon();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter Adp = new SqlDataAdapter();
        SqlDataReader Dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            Cmd.Connection = cn;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            Cmd = new SqlCommand("select * from AdminLogin where AdminUserName='" + TextBox1.Text + "' and AdminPassword='" + TextBox2.Text + "'", cn);
            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Session["UserName"] = TextBox1.Text.ToString();
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Label1.Text = "Username or password is incorrect";
            }
        }
    }
}