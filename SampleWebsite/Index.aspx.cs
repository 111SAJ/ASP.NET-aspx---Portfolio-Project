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

namespace SampleWebsite.Pic
{
    public partial class Index : System.Web.UI.Page
    {
        SqlConnection Cn = Connection.GetCon();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter Adp = new SqlDataAdapter();
        private void sendusermail(string Name1, string Email1, string Phone1, string Message1)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("email@gmail.com", "password");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "New User Contact Details";
            msg.Body = "New User Contact Details \n\n-------------------------\n\nName: " + Name1 + " \nEmail: " + Email1 + " \nPhone: " + Phone1 + " \nMessage: " + Message1 + "";
            string toaddress = "email@gmail.com";
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
            Cn.Open();
            Cmd.CommandText = "insert into Contact values('" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "')";
            Cmd.ExecuteNonQuery();
            Label1.Text = "Message Sent!";
            sendusermail(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            Cn.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}