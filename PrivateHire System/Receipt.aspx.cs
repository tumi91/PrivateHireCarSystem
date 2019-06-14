using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Xml.Linq;
using System.Drawing.Printing;

namespace PrivateHire_System
{
    public partial class Receipt : System.Web.UI.Page
    {

        Items i = new Items();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserName"] != null)
            {
               
                Label6.Text = Session["UserName"].ToString();
                Label9.Text = Session["Date"].ToString();
                //Label5.Text = Session["TypeService"].ToString();
                //Label10.Text = Session["Amounttopay"].ToString();
                Label13.Text = Session["DiscountPrice"].ToString();
                Label10.Text = Session["DiscountPrice"].ToString();
                Label16.Text = Session["CreditCardNo"].ToString();
               

            }
            else
            {
                Response.Redirect("Receipt.aspx");
            }
        }

        //public int Balance()
        //{
        //    int result;
        //    result = int.Parse(Label13.Text) - int.Parse(Label10.Text);

        //    return result;
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            i.booking_completed(Label6.Text, Label16.Text, Label9.Text, Label10.Text, Label13.Text);
            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {

                    StringBuilder sb = new StringBuilder();

                    string companyName = "Private Hire Car";

                    sb.Append("<h1 style= text-align:center; >" + companyName + "</h1>");
                    sb.Append("<br />");
                    sb.Append("<h2 style= text-align:center; >" + Label1.Text + "</h2>");
                    sb.Append("<br />");
                    sb.Append("<br />");
                    sb.Append(Label2.Text + "           " + "<ins>" + Label6.Text + "</ins>");
                    sb.Append("<br />");
                    sb.Append("<br />");
                    sb.Append(Label15.Text + "           " + "<ins>" + Label16.Text + "</ins>");
                    sb.Append("<br />");
                    sb.Append("<br />");
                    sb.Append(Label8.Text + "           " + "<ins>" + Label9.Text + "</ins>");
                    sb.Append("<br />");
                    sb.Append("<br />");
                    sb.Append(Label7.Text + "           " + "<ins>" + Label10.Text + "</ins>");
                    sb.Append("<br />");
                    sb.Append("<br />");
                    sb.Append(Label12.Text + "           " + "<ins>" + Label13.Text + "</ins>");
                    sb.Append("<br />");
                    sb.Append("<br />");




                    StringReader sr = new StringReader(sb.ToString());
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=Invoice_.pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Write(pdfDoc);
                    Response.End();

                   


                }
            }
        }
    }
}