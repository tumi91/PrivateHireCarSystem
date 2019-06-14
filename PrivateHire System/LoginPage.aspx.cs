using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrivateHire_System
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox2.Text == "admin123456") //Textbox 1 and textbox 2 must be key in exactly value as the code to perform code below.
            {
                Response.Redirect("AdminAddPet.aspx"); //Redirect to AdminAddPet Page.
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Invalid ID or Password" + "'); ", true); //alert shown
            }
        }
    }
}