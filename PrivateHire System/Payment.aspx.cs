using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;

namespace PrivateHire_System
{
    public partial class Payment : System.Web.UI.Page
    {
        //double price2;
        //public double DiscountPrice(double OriPrice) //method for conversation EuroToPounds
        //{
        //    price2 = OriPrice * 0.75; //number key in * 0.75
        //    return Math.Round(price2, 2); //return result in 2 decimal place
        //}

        //Items i = new Items();
        booking2 data = new booking2();
        


        protected void Page_Load(object sender, EventArgs e)
        {
              

            if (Session["Username"] != null)
            {
               
                Label1.Text = Session["Username"].ToString();
                Label2.Text = Session["Date"].ToString();
                Label3.Text = Session["Time"].ToString();
                Label4.Text = Session["Origin"].ToString();
                Label5.Text = Session["Destination"].ToString();
                Label6.Text = Session["Price"].ToString();
                Label7.Text = Session["DiscountPrice"].ToString();
                //i.booking_completed(Label1.Text, Label2.Text, Label3.Text, Label4.Text, Label5.Text, Label6.Text, Label7.Text);
            }

            else
            {
                Response.Redirect("Booking2.aspx");//change this to your booking page geh link ltr

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            booking2.getDriver_Data();

            if (TextBox1.Text == "")
            {
                
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE  from Booking WHERE email = '" + Label1.Text + "' AND date = '" + Label2.Text + "'", connection);  
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
                
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in your credit card number." + "'); ", true);
                //Response.Redirect("Booking2.aspx");

            }

            else if (TextBox2.Text == "")
            {
                
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE  from Booking WHERE email = '" + Label1.Text + "' AND date = '" + Label2.Text + "'", connection);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
                
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in your expiry date." + "'); ", true);
                //Response.Redirect("Booking2.aspx");

            }

            else if (TextBox3.Text == "")
            {
                
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE  from Booking WHERE email = '" + Label1.Text + "' AND date = '" + Label2.Text + "'", connection);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
                
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in your CVC." + "'); ", true);
                //Response.Redirect("Booking2.aspx");

            }

           
            else
            {

                Session["CreditCardNo"] = TextBox1.Text;
                Session["ExpiryDate"] = TextBox2.Text;
                Session["CVC"] = TextBox3.Text;
                Session["Date"] = Label2.Text;
                //i.booking_completed(Label1.Text, Label2.Text, Label3.Text, Label4.Text, Label5.Text, Label6.Text, Label7.Text);
                
                Response.Redirect("Receipt.aspx" );
            }



            //SqlDataAdapter adapter;
            //DataSet ds = new DataSet();



            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            //connection.Open();

            //SqlCommand comm = new SqlCommand(" SELECT Password from Login WHERE Password = '" + TextBox7.Text + "'", connection);          


            //SqlCommand comm2 = new SqlCommand(" SELECT Password from Login WHERE Password = '" + TextBox7.Text + "'", connection);
            //adapter = new SqlDataAdapter(comm2,connection);

            //comm.Connection = connection;
            //comm.ExecuteNonQuery();
            //connection.Close();

            
        }
    }
}