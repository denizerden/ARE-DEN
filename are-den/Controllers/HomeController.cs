using are_den.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace are_den.Controllers
{
    public class HomeController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: Home
        public ActionResult Index()
        {

            var projects = db.Projects.Select(i => new ProjectModel()
            {

                Id = i.Id,
                ProjectName = i.ProjectName.Length > 50 ? i.ProjectName.Substring(0, 20) + "..." : i.ProjectName,
                AgreementType = i.AgreementType,
                Contractor = i.Contractor,
                Employer = i.Employer,
                Placement = i.Placement,
                StartDate = i.StartDate,
                EndDate = i.EndDate,
                Duty = i.Duty,
                OperationTime = i.OperationTime,
                ProjectImage = i.ProjectImage


            });

            return View(projects.ToList());
            
        }

        public ActionResult About()
        {
            return View();
        }



        public ActionResult Career()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(SendEmailModel emailModel)
        {
            string server = ConfigurationManager.AppSettings["server"];
            int port = int.Parse(ConfigurationManager.AppSettings["port"]);
            bool ssl = ConfigurationManager.AppSettings["ssl"].ToString() == "1" ? true : false;


            string frommail = ConfigurationManager.AppSettings["frommail"];
            string password = ConfigurationManager.AppSettings["password"];
            string fromname = ConfigurationManager.AppSettings["fromname"];
            string to = ConfigurationManager.AppSettings["to"];

            var client = new SmtpClient();
            client.Host = server;
            client.Port = port;
            client.EnableSsl = ssl;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(frommail, password);

            var email = new MailMessage();
            email.From = new MailAddress(frommail, fromname);
            email.To.Add(to);

            email.Subject = "new mail";
            email.IsBodyHtml = true;
            email.Body = $"ad soyad : {emailModel.contact_name} \r\n mail : {emailModel.contact_email}  \r\n telefon : {emailModel.contact_phone} \r\n mesaj : {emailModel.contact_message} "; 
            try
            {
                client.Send(email);
                ViewData["result"] = true;

            }
            catch(Exception e)
            {
                ViewData["result"] = false;
            }
            
            
            return View();
        }

        //   public ActionResult Project()
        //  {
        //    return View(context.Projects.ToList());
        //}
    }
}