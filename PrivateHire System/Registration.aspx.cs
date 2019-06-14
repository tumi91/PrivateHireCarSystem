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
using System.Net;
using System.Net.Mail;

namespace PrivateHire_System
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Items items = new Items();
        SqlConnection conn  = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        public static String user;
        //public static String password;
        //public static String name;
        public static string Username;
        public static string Email;
        string PhoneNO;
        string Gender;
        string DOB ;
        public static string Password;
        string SecurityQ ;
        string Codeactivation;
        string Code;
        string status = "Unverified";
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
           
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Username = TextBox1.Text;
                Email = TextBox2.Text;
                PhoneNO = TextBox3.Text;
                Gender = DropDownList1.Text;
                DOB = TextBox5.Text;
                Password = TextBox6.Text;
                SecurityQ = TextBox7.Text;
                Code = TextBox8.Text;
               




                Random random = new Random();
                Codeactivation = random.Next(1001, 9999).ToString();
               
                

                SqlCommand cmd = new SqlCommand("INSERT into Login (email,Username,PhoneNO,Gender,DOB,Password,SecurityQ,status,Codeactivation) values (@email,@Username,@PhoneNO,@Gender,@DOB,@Password,@SecurityQ,@status,@Codeactivation)");

                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@PhoneNO", PhoneNO);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@SecurityQ", SecurityQ);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@Codeactivation", Codeactivation);

                if (TextBox1.Text == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in all details." + "'); ", true); //alert shown.
                    return;
                }
                else if (TextBox2.Text == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in all details." + "'); ", true); //alert shown.
                    return;
                }
                else if (TextBox3.Text == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in all details." + "'); ", true); //alert shown.
                    return;
                }
                else if (DropDownList1.SelectedIndex == 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in all details." + "'); ", true); //alert shown.
                    return;
                }
                else if (TextBox5.Text == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in all details." + "'); ", true); //alert shown.
                    return;
                }
                else if (TextBox6.Text == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in all details." + "'); ", true); //alert shown.
                    return;
                }
                else if (TextBox7.Text == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in all details." + "'); ", true); //alert shown.
                    return;
                }
                

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                items.Mydatabase(Username, Codeactivation, Email);

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please check your email to get the activation code." + "'); ", true);

            }
            catch (FormatException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert1", "alert('" + "Please key in all details." + "'); ", true); //alert shown.
            }

        }
                protected void Button2_Click(object sender, EventArgs e)
                {
            try
                {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                conn.Open();
                SqlCommand comm = new SqlCommand(" SELECT * from Login WHERE email = '" + TextBox2.Text + "' AND Codeactivation = '" + TextBox8.Text + "'", conn);



                SqlDataReader dt;

                dt = comm.ExecuteReader();


                int count = 0;

                while (dt.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {

                    items.Registeration_completed(TextBox1.Text, TextBox2.Text);
                    items.ChangeStatus(TextBox8.Text);
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    DropDownList1.SelectedIndex = 0;
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    //Label33.Text = "Your Email Has Verified Successfully";
                    
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Your email has been verified,Registration Complete." + "'); ", true);


                }
        
                else if (Codeactivation != TextBox8.Text   || TextBox8.Text == null )
                    {
                        items.ChangeStatus_Delete();
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        DropDownList1.SelectedIndex = 0;
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        Label33.Text = "You Have Entered Invalid Activation Code ,Please Try Again ";
                    }
                else if (TextBox8.Text == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert1", "alert('" + "Please key in your Activation Code." + "'); ", true); //alert shown.
                }             
            }
            
        
            catch (FormatException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert1", "alert('" + "Please Key in all details." + "'); ", true); //alert shown.
                return;
            }
            conn.Close();

             }

       



    }

}
