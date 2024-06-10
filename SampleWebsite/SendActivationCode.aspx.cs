using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace SampleWebsite
{
    public partial class SendActivationCode : System.Web.UI.Page
    {
        SqlConnection Cn = Connection.GetCon();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter Adp = new SqlDataAdapter();
        SqlDataReader Dr;
        static string activationcode;

        private void sendcode()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("email@gmail.com", "password");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Activation Code to Verify Email Address";
            msg.Body = "Dear " + TextBox1.Text + ", Your Activation Code is  " + activationcode + "\n\n\nThanks & Regards\nSayed Asad Jamal\nWeb Developemnt\nwww.sayedasadjamal.tech";
            string toaddress = TextBox2.Text;
            msg.To.Add(toaddress);
            string fromaddress = "Nomaan Ahmad Siddiqui <email@gmail.com>";
            msg.From = new MailAddress(fromaddress);
            try
            {
                smtp.Send(msg);
            }
            catch
            {
                throw;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Cmd.Connection = Cn;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            activationcode = random.Next(1001, 9999).ToString();
            Cn.Open();
            Cmd = new SqlCommand("select * from OTP where AdminEmail='" + TextBox2.Text + "' and AdminUserName='" + TextBox1.Text + "'", Cn);
            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Dr.Close();
                Cmd.CommandText = "update OTP set status='Unfarified', activationcode='" + activationcode + "' where AdminEmail='" + TextBox2.Text + "'";
                Cmd.ExecuteNonQuery();
                Cn.Close();
                sendcode();
                Session["un"] = TextBox1.Text;
                Response.Redirect("VerificationCode.aspx?AdminEmail=" + TextBox2.Text);
            }
            else
            {
                Label1.Text = "Please enter valid username or email address!";
            }
        }
    }
}