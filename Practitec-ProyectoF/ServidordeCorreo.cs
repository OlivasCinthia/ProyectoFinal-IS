using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Practitec_ProyectoF
{
    //ENCARGADA DE ENVIAR LOS CORREOS
    public abstract class ServidordeCorreo
    {
        private SmtpClient smtpclient;
        protected string sendermail { get; set;}
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void InitializedSmtpClient()
        {
            smtpclient = new SmtpClient();
            smtpclient.Credentials = new NetworkCredential(sendermail, password);
            smtpclient.Host = host;
            smtpclient.Port = port;
            smtpclient.EnableSsl = ssl;
        }

        public void sendMail (string subject, string body, List<string> correodestinatario)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(sendermail);
                foreach (string mail in correodestinatario)
                    {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpclient.Send(mailMessage);

                
            }
            catch (Exception e)
            {

            }
            finally
            {
                mailMessage.Dispose();
                smtpclient.Dispose();
            }

        }

    }
}
