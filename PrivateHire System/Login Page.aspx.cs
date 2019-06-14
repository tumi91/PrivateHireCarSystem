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
    public partial class Login_Page : System.Web.UI.Page
    {
        public  static String user;
        //public static String email;
        //public static String name;
        Items items = new Items();
        protected void Page_Load(object sender, EventArgs e)
        {
            items.ChangeStatus_Delete();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Create connection to link database
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            conn.Open();
            
            //command that allow to select data from table matching with specific textbox
            SqlCommand comm = new SqlCommand(" SELECT * from Login WHERE email = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", conn);
           

                
            SqlDataReader dt;

            dt = comm.ExecuteReader();
           

            int count = 0;

            while (dt.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                //Redirect to another page if successful

                user = TextBox1.Text;  
                Server.Transfer("Home2.aspx");

            }
            else if (TextBox1.Text == "admin" && TextBox2.Text == "1234")
            {
               
                Server.Transfer("Home3.aspx");
            }
            else if(count !=1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please key in correct details." + "'); ", true);
                TextBox1.Text = "";
                TextBox2.Text = "";
                return;
            }
        }
    }
}