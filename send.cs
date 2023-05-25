using System;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;

public class EmailSenderController : Controller
{
    [HttpPost]
    public IActionResult SendEmail(string email, string name, string message, string website)
    {
        // Fetch SMTP settings from configuration file
 /*        string smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
        int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
        string smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
        string smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"]; */

        // Fetch SMTP settings from configuration file
        string smtpHost = "smtp.gmail.com";
        int smtpPort = 587;
        string smtpUsername = "arieljordz@gmail.com";
        string smtpPassword = "P@ssw0rdjordz";

        // Create a new MailMessage object
        MailMessage message = new MailMessage();
        message.From = new MailAddress(email);
        message.To.Add(new MailAddress(smtpUsername));
        message.Subject = name + " " + website;
        message.Body = message;

        // Create an SMTP client and send the email
        SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
        smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
        smtpClient.EnableSsl = true; // Enable SSL encryption if required
        smtpClient.Send(message);

        // Return a response or redirect to another page as needed
        return RedirectToAction("index");
    }

}
