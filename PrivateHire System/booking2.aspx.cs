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
using System.Net.Mail;

namespace PrivateHire_System
{
    public partial class booking2 : System.Web.UI.Page
    {

       Items item  = new Items();

        double result;
        public static String username;
        double resultD;
        public static GridView MygridView;
        public static string UName;

        public double Special()
        {
            resultD = (result - 5);
            return resultD;
        }

        public double GombakToSetapak() //create methods for each conversion
        {

            result = (4 * 3);
            return result;
        }

        public double GombakToMurtabak() //create methods for each conversion
        {

            result = (4 * 4);
            return result;
        }

        public double GombakToRawang() //create methods for each conversion
        {

            result = (4 * 5);
            return result;
        }

        public double SetapakToMurtabak() //create methods for each conversion
        {

            result = (4 * 6);
            return result;
        }

        public double SetapakToRawang() //create methods for each conversion
        {

            result = (4 * 7);
            return result;
        }

        public double MurtabakToRawang() //create methods for each conversion
        {

            result = (4 * 8);
            return result;
        }

        public double GombakToSetapakDP() //create methods for each conversion
        {

            result = (4 * 3) * 0.85;
            return result;
        }

        public double GombakToMurtabakDP() //create methods for each conversion
        {

            result = (4 * 4) * 0.85;
            return result;
        }

        public double GombakToRawangDP() //create methods for each conversion
        {

            result = (4 * 5) * 0.85;
            return result;
        }

        public double SetapakToMurtabakDP() //create methods for each conversion
        {

            result = (4 * 6) * 0.85;
            return result;
        }

        public double SetapakToRawangDP() //create methods for each conversion
        {

            result = (4 * 7) * 0.85;
            return result;
        }

        public double MurtabakToRawangDP() //create methods for each conversion
        {

            result = (4 * 8) * 0.85;
            return result;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Login_Page.user;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //declaration 
                UName = TextBox1.Text;
                string BDate = TextBox2.Text;
                string BTime = TextBox3.Text;
                MygridView = GridView1;

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                connection.Open();

                //specify database column by orders, and specify parameter
                SqlCommand cmd = new SqlCommand("insert into Booking (Id,Driver_Name,Email,Date,Time,Origin,Destination,Price,DiscountPrice,NumberOfSeat,SizeOfCab) values (@Id,@DriverName,@Email,@Date,@Time,@Origin,@Destination,@Price,@DiscountPrice,@NumberOfSeat,@SizeOfCab)");

                cmd.Parameters.AddWithValue("@Email", UName);
                cmd.Parameters.AddWithValue("@Date", BDate);
                cmd.Parameters.AddWithValue("@Time", BTime);
                cmd.Parameters.AddWithValue("@Id", MygridView.SelectedRow.Cells[1].Text);
                cmd.Parameters.AddWithValue("@DriverName", MygridView.SelectedRow.Cells[2].Text);




                if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 2)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {


                        Label10.Text = "£" + GombakToSetapak();
                        Label12.Text = "£" + GombakToSetapakDP();
                        cmd.Parameters.AddWithValue("@Origin", "Gombak");
                        cmd.Parameters.AddWithValue("@Destination", "Setapak");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToSetapak();
                        Label12.Text = "£" + GombakToSetapakDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Gombak");
                        cmd.Parameters.AddWithValue("@Destination", "Setapak");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }


                }

                else if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 3)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToMurtabak();
                        Label12.Text = "£" + GombakToMurtabakDP();
                        cmd.Parameters.AddWithValue("@Origin", "Gombak");
                        cmd.Parameters.AddWithValue("@Destination", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }
                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToMurtabak();
                        Label12.Text = "£" + GombakToMurtabakDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Gombak");
                        cmd.Parameters.AddWithValue("@Destination", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);

                    }
                }

                else if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 4)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToRawang();
                        Label12.Text = "£" + GombakToRawangDP();
                        cmd.Parameters.AddWithValue("@Origin", "Gombak");
                        cmd.Parameters.AddWithValue("@Destination", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToRawang();
                        Label12.Text = "£" + GombakToRawangDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Gombak");
                        cmd.Parameters.AddWithValue("@Destination", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }
                }

                else if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 1)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToSetapak();
                        Label12.Text = "£" + GombakToSetapakDP();
                        cmd.Parameters.AddWithValue("@Origin", "Setapak");
                        cmd.Parameters.AddWithValue("@Destination", "Gombak");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToSetapak();
                        Label12.Text = "£" + GombakToSetapakDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Setapak");
                        cmd.Parameters.AddWithValue("@Destination", "Gombak");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }
                }

                else if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 3)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£ " + SetapakToMurtabak();
                        Label12.Text = "£ " + SetapakToMurtabakDP();
                        cmd.Parameters.AddWithValue("@Origin", "Setapak");
                        cmd.Parameters.AddWithValue("@Destination", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£ " + SetapakToMurtabak();
                        Label12.Text = "£" + SetapakToMurtabakDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Setapak");
                        cmd.Parameters.AddWithValue("@Destination", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                }

                else if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 4)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + SetapakToRawang();
                        Label12.Text = "£" + SetapakToRawangDP();
                        cmd.Parameters.AddWithValue("@Origin", "Setapak");
                        cmd.Parameters.AddWithValue("@Destination", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + SetapakToRawang();
                        Label12.Text = "£" + SetapakToRawangDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Setapak");
                        cmd.Parameters.AddWithValue("@Destination", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }


                }

                else if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 1)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToMurtabak();
                        Label12.Text = "£" + GombakToMurtabakDP();
                        cmd.Parameters.AddWithValue("@Origin", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Gombak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToMurtabak();
                        Label12.Text = "£" + GombakToMurtabakDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Gombak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }
                }

                else if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 2)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + SetapakToMurtabak();
                        Label12.Text = "£" + SetapakToMurtabakDP();
                        cmd.Parameters.AddWithValue("@Origin", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Setapak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + SetapakToMurtabak();
                        Label12.Text = "£" + SetapakToMurtabakDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Setapak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                }

                else if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 4)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + MurtabakToRawang();
                        Label12.Text = "£" + MurtabakToRawangDP();
                        cmd.Parameters.AddWithValue("@Origin", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + MurtabakToRawang();
                        Label12.Text = "£" + MurtabakToRawangDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }
                }

                else if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 1)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToRawang();
                        Label12.Text = "£" + GombakToRawangDP();
                        cmd.Parameters.AddWithValue("@Origin", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Gombak");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + GombakToRawang();
                        Label12.Text = "£" + GombakToRawangDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Gombak");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }
                }

                else if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 2)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {


                        Label10.Text = "£ " + SetapakToRawang();
                        Label12.Text = "£ " + SetapakToRawangDP();
                        cmd.Parameters.AddWithValue("@Origin", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Setapak");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);

                    }


                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£ " + SetapakToRawang();
                        Label12.Text = "£ " + SetapakToRawangDP() + Special();
                        Label12.Text = "£ " + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Setapak");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                }

                else if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 3)
                {
                    if (TextBox4.Text != "DISCOUNT")
                    {
                        Label10.Text = "£" + MurtabakToRawang();
                        Label12.Text = "£" + MurtabakToRawangDP();
                        cmd.Parameters.AddWithValue("@Origin", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }

                    else if (TextBox4.Text == "DISCOUNT")
                    {
                        Label10.Text = "£" + MurtabakToRawang();
                        Label12.Text = "£" + MurtabakToRawangDP() + Special();
                        Label12.Text = "£" + Special();
                        cmd.Parameters.AddWithValue("@Origin", "Rawang Airport");
                        cmd.Parameters.AddWithValue("@Destination", "Murtabak Airport");
                        cmd.Parameters.AddWithValue("@Price", Label10.Text);
                        cmd.Parameters.AddWithValue("@DiscountPrice", Label12.Text);
                    }
                }
                else if (DropDownList1.SelectedIndex == 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Valid Location." + "'); ", true);

                    return;
                }
                else if (DropDownList2.SelectedIndex == 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Valid Location." + "'); ", true);

                    return;
                }

                else if (DropDownList1.SelectedIndex == 0 && DropDownList2.SelectedIndex == 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Valid Location." + "'); ", true);

                    return;
                }

                else if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 1)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Valid Location." + "'); ", true);

                    return;
                }

                else if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 3)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Valid Location." + "'); ", true);

                    return;
                }

                else if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 4)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Valid Location." + "'); ", true);

                    return;
                }               

                if (DropDownList3.SelectedIndex == 1)
                {

                    cmd.Parameters.AddWithValue("@NumberOfSeat", "1");

                }

                else if (DropDownList3.SelectedIndex == 2)
                {

                    cmd.Parameters.AddWithValue("@NumberOfSeat", "2");

                }

                else if (DropDownList3.SelectedIndex == 3)
                {

                    cmd.Parameters.AddWithValue("@NumberOfSeat", "3");

                }

                else if (DropDownList3.SelectedIndex == 4)
                {

                    cmd.Parameters.AddWithValue("@NumberOfSeat", "4");

                }

                else if (DropDownList3.SelectedIndex == 5)
                {

                    cmd.Parameters.AddWithValue("@NumberOfSeat", "5");

                }

                else if (DropDownList3.SelectedIndex == 6)
                {

                    cmd.Parameters.AddWithValue("@NumberOfSeat", "6");

                }

                else if (DropDownList3.SelectedIndex == 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Number of Seat." + "'); ", true);

                    return;

                }

                if (DropDownList4.SelectedIndex == 0)
                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Size Of Cab." + "'); ", true);

                    return;

                }

                else if (DropDownList4.SelectedIndex == 1)
                {

                    cmd.Parameters.AddWithValue("@SizeOfCab", "Five Seater");

                }

                else if (DropDownList4.SelectedIndex == 2)
                {

                    cmd.Parameters.AddWithValue("@SizeOfCab", "Seven Seater");

                }

                SqlCommand command = new SqlCommand("Select Driver where Id = '" + MygridView.SelectedRow.Cells[1].Text + "'");

                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                Session["Username"] = TextBox1.Text;
                Session["Date"] = TextBox2.Text;
                Session["Time"] = TextBox3.Text;
                Session["Price"] = Label10.Text;
                Session["DiscountPrice"] = Label12.Text;
                Session["PaidPrice"] = Label12.Text;
                Session["Origin"] = DropDownList1.SelectedValue;
                Session["Destination"] = DropDownList2.SelectedValue;

              
                connection.Close();


                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Taxi Booked." + "'); ", true); //Alert shows "Data Saved."
               
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                Label10.Text = "";

                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
               
                Response.Redirect("Payment.aspx");

            }
            catch (FormatException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Key in all details." + "'); ", true); //alert shown.
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 2)
            {
                //Label10.Text = "£ 12";
                //Label12.Text = "£ " + GombakToSetapakDP();
                if (TextBox4.Text != "DISCOUNT")
                {

                    Label10.Text = "£" + GombakToSetapak();
                    Label12.Text = "£" + GombakToSetapakDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToSetapak();
                    Label12.Text = "£" + GombakToSetapakDP() + Special();
                    Label12.Text = "£" + Special();
                }

            }

            else if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 3)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToMurtabak();
                    Label12.Text = "£" + GombakToMurtabakDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToMurtabak();
                    Label12.Text = "£" + GombakToMurtabakDP() + Special();
                    Label12.Text = "£" + Special();
                }

            }

            else if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 4)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToRawang();
                    Label12.Text = "£" + GombakToRawangDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToRawang();
                    Label12.Text = "£" + GombakToRawangDP() + Special();
                    Label12.Text = "£" + Special();
                }

            }

            else if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 1)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToSetapak();
                    Label12.Text = "£" + GombakToSetapakDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToSetapak();
                    Label12.Text = "£" + GombakToSetapakDP() + Special();
                    Label12.Text = "£" + Special();
                }
            }

            else if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 3)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + SetapakToMurtabak();
                    Label12.Text = "£ " + SetapakToMurtabakDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + SetapakToMurtabak();
                    Label12.Text = "£" + SetapakToMurtabakDP() + Special();
                    Label12.Text = "£" + Special();
                }
            }

            else if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 4)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + SetapakToRawang();
                    Label12.Text = "£" + SetapakToRawangDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + SetapakToRawang();
                    Label12.Text = "£" + SetapakToRawangDP() + Special();
                    Label12.Text = "£" + Special();
                }
            }

            else if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 1)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToMurtabak();
                    Label12.Text = "£" + GombakToMurtabakDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToMurtabak();
                    Label12.Text = "£" + GombakToMurtabakDP() + Special();
                    Label12.Text = "£" + Special();
                }

            }

            else if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 2)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + SetapakToMurtabak();
                    Label12.Text = "£" + SetapakToMurtabakDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + SetapakToMurtabak();
                    Label12.Text = "£" + SetapakToMurtabakDP() + Special();
                    Label12.Text = "£" + Special();
                }
            }

            else if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 4)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + MurtabakToRawang();
                    Label12.Text = "£" + MurtabakToRawangDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + MurtabakToRawang();
                    Label12.Text = "£" + MurtabakToRawangDP() + Special();
                    Label12.Text = "£" + Special();
                }
            }

            else if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 1)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToRawang();
                    Label12.Text = "£" + GombakToRawangDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + GombakToRawang();
                    Label12.Text = "£" + GombakToRawangDP() + Special();
                    Label12.Text = "£" + Special();
                }
            }

            else if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 2)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + SetapakToRawang();
                    Label12.Text = "£ " + SetapakToRawangDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + SetapakToRawang();
                    Label12.Text = "£" + SetapakToRawangDP() + Special();
                    Label12.Text = "£" + Special();
                }
            }

            else if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 3)
            {
                if (TextBox4.Text != "DISCOUNT")
                {
                    Label10.Text = "£" + MurtabakToRawang();
                    Label12.Text = "£" + MurtabakToRawangDP();
                }

                else if (TextBox4.Text == "DISCOUNT")
                {
                    Label10.Text = "£" + MurtabakToRawang();
                    Label12.Text = "£" + MurtabakToRawangDP() + Special();
                    Label12.Text = "£" + Special();
                }
            }
            

        }

        
        public static void getDriver_Data()

        {

           driver_Details.Driver_Details(MygridView.SelectedRow.Cells[1].Text, MygridView.SelectedRow.Cells[2].Text, MygridView.SelectedRow.Cells[3].Text, MygridView.SelectedRow.Cells[4].Text, MygridView.SelectedRow.Cells[5].Text, MygridView.SelectedRow.Cells[6].Text, MygridView.SelectedRow.Cells[7].Text, MygridView.SelectedRow.Cells[8].Text, MygridView.SelectedRow.Cells[9].Text, UName);
        }
    }

    public static class driver_Details
    {
        
        public static void Driver_Details(string id, string DriverName, string Number, string driverEmail, string gender, string carModel, string age, string carPalte, string sizeOfCab, string Email)
        {

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("carprivatehire@gmail.com", "55854Aslibya");
            smtp.EnableSsl = true;
            MailMessage mgs = new MailMessage();
            mgs.Subject = " Your Driver Details ";
            mgs.Body = "Your driver will pick you up within 5 minutes  " + "\n\nDriver Details: " + "\n\nDriver ID: " + " " + id + "\nDriver Name:" + " " + DriverName + "\nDriver Number:" + " " + Number +
                "\nDriver Email :" + " " + driverEmail + "\n Driver Gender:" + " " + gender + "\nCar Model:" + carModel + " " + "\nCar Palte:" + " " + carPalte + "\nsize Of Cab:" + " " + sizeOfCab +
                "\n\nThanks & Regaeds\nPrivate Hire Cars";
            string toaddress = Email;
            mgs.To.Add(toaddress);
            string fromaddress = "Private Hire Cars <carprivatehire@gmail.com>";
            mgs.From = new MailAddress(fromaddress);

            smtp.Send(mgs);

            
        }
    }
}