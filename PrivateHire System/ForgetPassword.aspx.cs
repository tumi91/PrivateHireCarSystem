using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrivateHire_System
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
    //        //Create connection to link database
    //        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

    //        conn.Open();

    //        //command that allow to select data from table matching with specific textbox
    //        SqlCommand comm = new SqlCommand(" SELECT * from Login WHERE email = '" + TextBox1.Text + "' AND SecurityQ = '" + TextBox2.Text  +  "'", conn);
            


    //        SqlDataReader dt;

    //        dt = comm.ExecuteReader();


    //        int count = 0;

    //        while (dt.Read())
    //        {
    //            count += 1;
                
    //        }
    //        if (count == 1)
    //        {
                
                    

    //             SmtpClient smtp = new SmtpClient();
    //            smtp.Host = "smtp.gmail.com";
    //            smtp.Port = 587;
    //            smtp.Credentials = new System.Net.NetworkCredential("tumi3920@gmail.com", "55854Aslibya");
    //            smtp.EnableSsl = true;
    //            MailMessage mgs = new MailMessage();
    //            mgs.Subject = "You have Been Recovered Your Password Sucessfully";
    //            mgs.Body = "Dear" + "  " +  + "  " + " Your Password " +  + "\n\n\nThanks & Regaeds\nPrivate Hire Cars";
    //            string toaddress = TextBox1.Text;
    //            mgs.To.Add(toaddress);
    //            string fromaddress = "Private Hire Cars <tumi3920@gmail.com>";
    //            mgs.From = new MailAddress(fromaddress);

    //            smtp.Send(mgs);
            
    //    }
    //        else
    //        {
    //            ClientScript.RegisterStartupScript(this.GetType(), "Alert1", "alert('" + "Please Key in all details." + "'); ", true); //alert shown.

    //        }

    //        conn.Close();
    //    }


       


    }

    //public static class getPasswordAndUsername
    //{



       

    }
}