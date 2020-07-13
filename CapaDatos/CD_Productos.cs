using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;


namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        #region Mostrar Producto
        public DataTable Mostrar()
        {
            // TRANSCT SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader(); // Devuelve datos de la BD
            tabla.Load(leer);
            conexion.CerrarConexion(); // Es recomendable cerrar la conexion después de una instruccion
            return tabla;
        }
        #endregion

        #region Insertar Producto
        public void Insertar(string Nombre, string Descripcion, string Marca, double Precio, int Stock)
        {
            //    ------TRANSACT SQL------//
            //comando.Connection = conexion.AbrirConexion();
            //comando.CommandText = "INSERT INTO Productos VALUES('"+Nombre+"','"+Descuento+"','"+Marca+"','"+Precio+"','"+Stock+"')";
            //comando.CommandType = CommandType.Text; // Si no se llega a agregar este comando el compilador tomara como instrucción "StoreProcedure"
            //comando.ExecuteNonQuery(); // Instrucciones CRUD
            //conexion.CerrarConexion();

            //   -------PROCEDURE------  //

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Marca", Marca);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@STOCK", Stock);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); // Esto para que pueda ser reutilizado el objeto
            conexion.CerrarConexion();
        }
        #endregion 

        #region Editar Producto
        public void Editar(string Nombre, string Descripcion, string Marca, double Precio, int Stock, int Id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Marca", Marca);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@STOCK", Stock);
            comando.Parameters.AddWithValue("@Id", Id);

            comando.ExecuteNonQuery();

            // Esto para que pueda ser reutilizado el objeto
            // y para refrescar los parametros
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        #endregion

        #region Eliminar Producto
        public void Eliminar(int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.Parameters.AddWithValue("@IdProd", Id);
            comando.CommandType = CommandType.StoredProcedure;

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        #endregion     

        #region Busqueda Producto
        public List<E_Productos>ListaBusqueda(string buscar)
        {


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BusquedaProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Condicion", buscar);

            conexion.AbrirConexion();

            leer = comando.ExecuteReader();
            List<E_Productos> Listar = new List<E_Productos>(); // Instancia de comunicación
           
            while (leer.Read())
            {
                Listar.Add(new E_Productos { 
                    Id = leer.GetInt32(0),
                    Nombre = leer.GetString(1),
                    Descripcion = leer.GetString(2),
                    Marca = leer.GetString(3),
                    Precio = leer.GetDecimal(4),
                    Stock = leer.GetInt32(5)
                });
            }
            leer.Close();
            conexion.CerrarConexion();
            return Listar;
        }
        #endregion
    }
}
            