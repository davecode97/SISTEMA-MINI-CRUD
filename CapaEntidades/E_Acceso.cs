using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class E_Acceso
    {
        //Atributos de Accesso
        private string _nombreLogin;
        private string _password;

        public string NombreLogin { get => _nombreLogin; set => _nombreLogin = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
