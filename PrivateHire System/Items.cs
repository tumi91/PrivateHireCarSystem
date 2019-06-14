using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI.WebControls;

namespace PrivateHire_System
{
    public class Items

    {
        public String username { get; set; }
        public String email { get; set; }

        public Items(String username, String email)
        {
            this.username = username;
            this.email = email;
        }

        public Items()
        {

        }

        public void Mydatabase(string Username,  string Codeactivation, string Email)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("carprivatehire@gmail.com", "55854Aslibya");
            smtp.EnableSsl = true;
            MailMessage mgs = new MailMessage();
            mgs.Subject = "Activation Code to Verify Email Address";
            mgs.Body = "Dear" + "  " + Username + "  " + "Your Activation Code " + Codeactivation + "\n\nThanks & Regards\nPrivateHire Cars";
            string toaddress = Email;
            mgs.To.Add(toaddress);
            string fromaddress = "Private Hire Cars <carprivatehire@gmail.com>";
            mgs.From = new MailAddress(fromaddress);

            smtp.Send(mgs);
        }


        public void Registeration_completed(string Username,  string Email)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("carprivatehire@gmail.com", "55854Aslibya");
            smtp.EnableSsl = true;
            MailMessage mgs = new MailMessage();
            mgs.Subject = "Registration Successful ";
            mgs.Body = "Dear" + "  " + Username + "  " + "Your Registration Complete Successfully " + "\n\nCongratulations you have received a promo code for next trip\n The Promo Code = DISCOUNT\n " + "\n\nThanks & Regards\nPrivateHire Cars";
            string toaddress = Email;
            mgs.To.Add(toaddress);
            string fromaddress = "Private Hire Cars <carprivatehire@gmail.com>";
            mgs.From = new MailAddress(fromaddress);

            smtp.Send(mgs);
        }

        //public void booking_completed(string Email, string date, string time, string Origin, string Destination, string Price, string DiscountPrice)
        //{
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.Port = 587;
        //    smtp.Credentials = new System.Net.NetworkCredential("carprivatehire@gmail.com", "55854Aslibya");
        //    smtp.EnableSsl = true;
        //    MailMessage mgs = new MailMessage();
        //    mgs.Subject = "Payment Successful ";
        //    mgs.Body = "Your Booking have been made successfully " +  "\n\nBooking Details " + "\n\nEmail: " + " "  + Email + "\nData:" + " " + date +
        //        "\nTime:"+ " " + time + "\nOrigin:" + " " + Origin  + "\nDestination:" + " " + Destination + "\nPrice:" + " " + Price + "\nDiscountPrice:" + " " + DiscountPrice +
        //        "\n\nThanks & Regards\nPrivateHire Cars";
        //    string toaddress = Email;
        //    mgs.To.Add(toaddress);
        //    string fromaddress = "Private Hire Cars <carprivatehire@gmail.com>";
        //    mgs.From = new MailAddress(fromaddress);

        //    smtp.Send(mgs);
        //}

      

        public void booking_completed(string Email, string nCreditCardNo, string nDate, string nPricePaid, string TotalPricewithDiscount)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("carprivatehire@gmail.com", "55854Aslibya");
            smtp.EnableSsl = true;
            MailMessage mgs = new MailMessage();
            mgs.Subject = "Receipt Details ";
            mgs.Body = "Your Receipt Details " + "\n\nEmail: " + " " + Email + "\nCredit Card No:" + " " + nCreditCardNo +
                "\nDate:" + " " + nDate + "\nTotal Price with Discount:" + " " + TotalPricewithDiscount + "\nAmount Paid:" + " " + nPricePaid +
                "\n\nThanks & Regards\nPrivate Hire Cars";
            string toaddress = Email;
            mgs.To.Add(toaddress);
            string fromaddress = "Private Hire Cars <carprivatehire@gmail.com>";
            mgs.From = new MailAddress(fromaddress);

            smtp.Send(mgs);
        }

        public void ChangeStatus(string code)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            String query  = " UPDATE Login SET status = 'Verified' where Codeactivation =  '" + code + "'";
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = query;
            com.Connection = conn;
            com.ExecuteNonQuery();
        }

        public void ChangeStatus_Delete()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            String query = "DELETE FROM Login WHERE status ='Unverified'";
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = query;
            com.Connection = conn;
            com.ExecuteNonQuery();
            
        }





    }
}

