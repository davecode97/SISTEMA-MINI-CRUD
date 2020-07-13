using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProd(string Nombre, string Descripcion, string Marca, string Precio, string Stock)
        {
            // -- Es reponsabilidad de la capa de negocio convertir los datos que van a hacer enviados a la
            // -- capa de presentación, si se llega a realizar la conversión de datos en la capa de presentación
            // -- se estaría violando los principios de NCAPAS.

            objetoCD.Insertar(Nombre, Descripcion, Marca, Convert.ToDouble(Precio), Convert.ToInt32(Stock));
        }

        public void EditarProd(string Nombre, string Descripcion, string Marca, string Precio, string Stock, string Id)
        {
            objetoCD.Editar(Nombre, Descripcion, Marca, Convert.ToDouble(Precio), Convert.ToInt32(Stock), Convert.ToInt32(Id));
        }

        public void Eliminar(string Id)
        {
            objetoCD.Eliminar(Convert.ToInt32(Id));
        }

        public List<E_Productos>ListadoProductos(string buscar)
        {
            return objetoCD.ListaBusqueda(buscar);
        }
      
    }
}
