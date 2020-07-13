using System;
using System.Data;
using System.Text;
using System.Linq;

namespace CapaEntidades
{
    public class E_Productos
    {
        // Atributos de la Entidad Productos
        private int _Id;
        private string _Nombre;
        private string _Descripcion;
        private string _Marca;
        private decimal _Precio;
        private int _Stock;
        
        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public decimal Precio { get => _Precio; set => _Precio = value; }
        public int Stock { get => _Stock; set => _Stock = value; }

      
    }
}
