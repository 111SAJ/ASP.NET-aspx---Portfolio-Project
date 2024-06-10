using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace SampleWebsite
{
    public partial class VerificationCode : System.Web.UI.Page
    {
        SqlConnection Cn = Connection.GetCon();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter Adp = new SqlDataAdapter();

        private void changestatus()
        {
            Cn.Open();
            Cmd.CommandText = "update OTP set status='Verified' where AdminEmail='" + Request.QueryString["AdminEmail"] + "'";
            Cmd.ExecuteNonQuery();
            Cn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Cmd.Connection = Cn;
            Label1.Text = "Your Email is " + Request.QueryString["AdminEmail"].ToString() + ", Kindly Check your Email";
            Label3.Text = Session["un"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("select * from OTP where AdminEmail='" + Request.QueryString["AdminEmail"] + "'", Cn);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                String activationcode;
                activationcode = Dt.Rows[0]["activationcode"].ToString();
                if (activationcode == TextBox1.Text)
                {
                    changestatus();
                    Label2.Text = "Your email has been verified successfully";
                    Response.Redirect("ChangeAdminPassword.aspx");
                }
                else
                {
                    Label2.Text = "You have entered invalid Activation Code, Kindly check your mail inbox";
                }
            }
        }
    }
}