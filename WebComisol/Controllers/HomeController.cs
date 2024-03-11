using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace WebComisol.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NuestraEmpresa()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Servicios()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Ventajas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cobertura()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contactanos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contacto(string name, string phone, string email, string message)
        {
            try
            {
                if (message == "")
                {
                    message = "El cliente no escribio ningun mensaje, solo sus datos de comunicación, ponte en contacto lo mas pronto posible";
                }

                string messageBody = "<html><head><style> body {font-family: Candara; font-weight: 700; font-size: 1rem; margin: 0px;} .ff-serif {font-family: 'Open Sans' !important;font-weight: 600;}" +
                        ".txt-bluelight {color: #10cfc9;} .txt-bluedark {color: #00a19b;}</style></head>" +
                        "<body>" +
                        "<div style='margin-left: 60px; margin-right: 60px; text-align: center;'>" +
                        "<p style='color:#3b71ca;'>Estimado(a) Administrador(a):</p><p style='text-align: center;'> Se ha recibido una nueva solicitud de contacto desde nuestra web, los datos se describen a continuacion:<br>" +
                        "<p text-align: start;> Nombre: " + name + " <br> Teléfono: " + phone + "<br>Correo Electronico: " + email + "<br>Mensaje: <br>" + message + "<br></p>" +
                        "<p class='text-align:center' style='color:#3b71ca;'>Gracias por tu atención</p></div></body></html>";

                string mesage;
                string subject = "Solicitud de Contacto";
                string from = "tecnologias@raciti.com.mx"; /*change After*/ /*changed*/
                string to = "oscarc@raciti.com.mx"; /*change After*/ /*changed*/
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = messageBody;
                mail.Priority = MailPriority.Normal;

                //configureServerSMTP

                //variables
                string host = "smtp.office365.com";
                string credential = from;
                string passwordCredential = "Inicio.123";

                SmtpClient smtp = new SmtpClient();
                smtp.Host = host;
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(credential, passwordCredential);
                smtp.Send(mail);

                return Json(new { mesage = "Datos enviados Correctamente" });
            }

            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Exception = ex;
                return View("Error");

            }
        }
    }
}