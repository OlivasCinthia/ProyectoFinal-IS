using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practitec_ProyectoF
{
    class AdministrarCorreos : ServidordeCorreo
    {
        public AdministrarCorreos()
        {
            sendermail = "soportesystempractitec@gmail.com";
            password = "Itt12345";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            InitializedSmtpClient();

        }
    }
}
