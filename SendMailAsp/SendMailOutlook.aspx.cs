using Microsoft.Office.Interop.Outlook;
using SendMailAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendMailAsp
{
    public partial class SendMailOutlook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListEmail.Items.Add("someone@live.com");
                DropDownListEmail.Items.Add("someone@yahoo.com");
            }
        }

        protected void ButtonSendMail_Click(object sender, EventArgs e)
        {
            SendEmailViaOutLook();
            DropDownListEmail.Text = "";
        }

        public void SendEmailViaOutLook()
        {
            try
            {
                Application OutlookApplication = new Application();
                MailItem message = (MailItem)OutlookApplication.CreateItem(OlItemType.olMailItem);
                MailAddress toAddress = new MailAddress(DropDownListEmail.Text);
                //MailAddress ccAddress = new MailAddress("ccmail@gmail.com");

                message.To = toAddress.ToString();
                //message.CC = ccAddress.ToString();
                message.Subject = "Mail Subject";
                message.Body = "Hello";
                message.BodyFormat = OlBodyFormat.olFormatHTML;

                //Send email
                message.Send();
                MessageBox.Show("Mesaj trimis cu succes!");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}