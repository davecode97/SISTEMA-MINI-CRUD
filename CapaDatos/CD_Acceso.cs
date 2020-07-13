using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Acceso
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlCommand comando = new SqlCommand();

        #region Acceso
        public bool Acceso(string Nombre, string Password) 
        {
           comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM ACCESO WHERE NOMBRE_ACCESO = @nombre AND PASSWORD =  @pass ";
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@pass", Password);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }
        #endregion
    }
}
