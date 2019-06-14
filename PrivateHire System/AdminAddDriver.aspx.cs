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
    public partial class AdminAddDriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //declaration 
                string DName = DriverName.Text;
                string DNumber = DriverNumber.Text;
                string DEmail = DriverEmail.Text;
                //string DGender = DriverGender.Text;
                string DCarModel = DriverCarModel.Text;
                int DAge = int.Parse(DriverAge.Text);
                string DCarNo = DriverCarNumber.Text;


                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                connection.Open();

                //specify database column by orders, and specify parameter
                SqlCommand cmd = new SqlCommand("insert into DriverDetail (Driver_Name,Driver_Contact_Number,Driver_Email,Driver_Gender,Driver_Car_Model,Driver_Age,cab_Number,SizeOfCab) values (@DriverName,@DriverContactNumber,@DriverEmail,@DriverGender,@DriverCarModel,@DriverAge,@cab_Number,@SizeOfCab)");

                
                cmd.Parameters.AddWithValue("@DriverName", DName);
                cmd.Parameters.AddWithValue("@DriverContactNumber", DNumber);
                cmd.Parameters.AddWithValue("@DriverEmail", DEmail);
                //cmd.Parameters.AddWithValue("@DriverGender", DGender);
                cmd.Parameters.AddWithValue("@DriverCarModel", DCarModel);
                cmd.Parameters.AddWithValue("@DriverAge", DAge);
                cmd.Parameters.AddWithValue("@cab_Number", DCarNo);


                //if the first content of the dropdownlist is chosen, perform code below 
                if (DropDownList1.SelectedIndex == 1)
                {
                    cmd.Parameters.AddWithValue("@DriverGender", "Male");

                }
                else if (DropDownList1.SelectedIndex == 2) //if 2nd content of the dropdownlist is chosen, perform code below
                {
                    cmd.Parameters.AddWithValue("@DriverGender", "Female");

                }               

                else if (DropDownList1.SelectedIndex == 0)
                {
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Valid Gender." + "'); ", true);

                        return;
                    }

                }

                if (DropDownList2.SelectedIndex == 1)
                {
                    cmd.Parameters.AddWithValue("@SizeOfCab", "Five Seater");
                    
                }
                else if (DropDownList2.SelectedIndex == 2)
                {
                    cmd.Parameters.AddWithValue("@SizeOfCab", "Seven Seater");

                }

                else if (DropDownList2.SelectedIndex == 0)
                {
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Select Valid Seating." + "'); ", true);

                        return;
                    }

                }
              
                //ShowMcost.Text = MCost.ToString(); //Mcost parse back to string
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();


                connection.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Data Saved." + "'); ", true); //Alert shows "Data Saved."
                DriverName.Text = "";               
                DriverNumber.Text = "";
                DriverEmail.Text = "";
                DriverCarModel.Text = "";
                DropDownList1.SelectedIndex = 0;
                DriverAge.Text = "";
                DriverCarNumber.Text = "";
            }
            catch (FormatException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Key in all details." + "'); ", true); //alert shown.
            }

        }
    }

}