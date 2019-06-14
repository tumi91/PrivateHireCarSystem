using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;
using System.Web.UI.WebControls;

namespace PrivateHire_System
{
    public partial class FeedBack : System.Web.UI.Page
    {
        public static String username;
        DateTime today = DateTime.Today;
        String date;
        String time;


        protected void Page_Load(object sender, EventArgs e)
        {
            date = today.ToString("dd/MM/yyyy");
            time = DateTime.Now.ToString("h:mm:ss tt");
            Label2.Text = date;
            Label1.Text = Login_Page.user;
            Label3.Text = time;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

               

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT into FeedBack (Email,date,Feedback,time)values (@Email,@date,@Feedback,@time)");

                cmd.Parameters.AddWithValue("@Email", Label1.Text);
                cmd.Parameters.AddWithValue("@date", Label2.Text);
                cmd.Parameters.AddWithValue("@Feedback", TextBox4.Text);
                cmd.Parameters.AddWithValue("@time", Label3.Text);
    
                 if (TextBox4.Text == "")
                {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Key in all details." + "'); ", true); //alert shown.
                return;
                 }
                 else
                 {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Feedback Complete." + "'); ", true);

                Label2.Text = date;
                Label1.Text = Login_Page.user;
                Label3.Text = time;
                TextBox4.Text = "";
                    }
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();

                //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Feedback Complete." + "'); ", true);

                //Label2.Text = date;
                //Label1.Text = Login_Page.user;
                //Label3.Text = time;
                //TextBox4.Text = "";

            //if (TextBox4.Text == "")
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Key in all details." + "'); ", true); //alert shown.
            //    return;
            //}
            //else
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Feedback Complete." + "'); ", true);

            //    Label2.Text = date;
            //    Label1.Text = Login_Page.user;
            //    Label3.Text = time;
            //    TextBox4.Text = "";
            //}
         }
    }
}