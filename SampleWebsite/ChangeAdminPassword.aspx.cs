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
    public partial class ChangeAdminPassword : System.Web.UI.Page
    {
        SqlConnection Cn = Connection.GetCon();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter Adp = new SqlDataAdapter();

        
        protected void Page_Load(object sender, EventArgs e)
        {
            Cmd.Connection = Cn;
            
            Label3.Text = Session["un"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == TextBox2.Text)
            {
                Cn.Open();
                Cmd.CommandText = "update AdminLogin set AdminPassword='" + TextBox1.Text + "' where AdminUserName='" + Label3.Text + "'";
                Cmd.ExecuteNonQuery();
                Cn.Close();
                Label1.Text = "Password has been changed successfully.";
                TextBox1.Text = "";
                TextBox2.Text = "";
                Response.Redirect("Login.aspx");
            }
            else
            {
                Label1.Text = "Confirm password did not match!";
            }
            
        }
    }
}