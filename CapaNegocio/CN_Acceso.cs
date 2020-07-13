using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocio
{
    public class CN_Acceso
    {
        private CD_Acceso objetoCD = new CD_Acceso();

        public bool Acceso(string Nombre, string Password)
        {
            return objetoCD.Acceso(Nombre, Password);
        }
    }
}
