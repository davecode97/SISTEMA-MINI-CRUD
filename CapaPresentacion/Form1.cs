using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class FormInventario : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null; // Variable para el método editar
        private bool Editar = false;

        public FormInventario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            limpiarForm();

        }

        #region Mover Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

        #region Mostrar Productos
        private void MostrarProductos()
        {
            // Se crea un nuevo objeto para evitar que se almacen los datos en cola en la variable global "objetoCN"
            // y se refleje en esta nueva instacia
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
            limpiarForm();

        }
        #endregion


        #region Buttom Guardar
        private void button1_Click(object sender, EventArgs e)
        {
            // I  N   S  E  R  T  A  R
            if (Editar == false)
            {

                try
                {
                    objetoCN.InsertarProd(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("Se agrego correctamente!");
                    MostrarProductos();
                    limpiarForm();
                }
                catch (Exception EX)
                {
                    MessageBox.Show("No se pudo agregar los datos"+EX);
                }

            }

            // E  D  I  T  A  R
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarProd(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                    MessageBox.Show("Se edito correctamente");
                    MostrarProductos();
                    limpiarForm();
                    Editar = false; // Esto para que vuelva a insertar

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo editar");
                }
            }

        }

        #endregion


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Buttom Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["STOCK"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione una fila");
                limpiarForm();
            }
        }
        #endregion

        #region Limpiar Formulario      
        private void limpiarForm()
        {
            txtNombre.Clear();
            txtDescripcion.Text = "";
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
        #endregion

        #region Buttom Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    objetoCN.Eliminar(idProducto);
                    MessageBox.Show("Se ha eliminado correctamente");
                    MostrarProductos();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado un fila completa");
            }

        }

        #endregion

        #region Minimizar Ventana
        //private void btnminimizar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;

        //}

        #endregion

        #region Buttom Cerrar
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Arrastrar Formulario
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region PlaceHoler txtBuscar
        private void txtBuscar_Enter_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }


        private void txtBuscar_Leave_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        #endregion


        #region Método Filtrado
        private void Filtrado(string condicion)
        {
            CN_Productos ObjetoCN = new CN_Productos();
            dataGridView1.DataSource = ObjetoCN.ListadoProductos(condicion);

        }

     

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrado(txtBuscar.Text);
        }
        #endregion

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por David Llanes\n 5 de Abril del 2020\n");
        }


        #region Condicionales STOCK
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //try
            //{    // EXCEPCION PERMITE EL USO NULLS, PERO EN ESTE CASO 
                 // SE OPMITIO EL USO DE NULL YA QUE AFECTA LA BUSQUEDA
                //if (e.Value.GetType() != typeof(System.DBNull))
                //{
                    if (this.dataGridView1.Columns[e.ColumnIndex].Name == "STOCK")
                    {
                        if (Convert.ToInt32(e.Value) <= 20)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.BackColor = Color.Orange;

                            if (Convert.ToInt32(e.Value) <= 10)
                            {
                                e.CellStyle.ForeColor = Color.BlueViolet;
                                e.CellStyle.BackColor = Color.Gray;
                            }
                        }

                    }
                //}
            //}
            //catch(NullReferenceException ex)
            //{
            //    MessageBox.Show("" + ex);
            //}
           
        }
        #endregion


        private void FormInventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    } 
}
