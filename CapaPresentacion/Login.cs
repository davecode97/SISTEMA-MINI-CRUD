using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        CN_Acceso objetoCN = new CN_Acceso();

        public Login()
        {
            InitializeComponent();
        }

        #region Mover/Arrastrar Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Buttom Acceder
        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "USUARIO")
            {
                lbErrorUsuario.Visible = false;
                

                if (txtContraseña.Text != "CONTRASEÑA") 
                {
                    lbErrorContra.Visible = false;
                    CN_Acceso objLogin = new CN_Acceso();
                    var validarAcceso = objLogin.Acceso(txtUsuario.Text, txtContraseña.Text);
                    if(validarAcceso == true)
                    {   
                        FormInventario form1  = new FormInventario();
                        MessageBox.Show("Bienvenido!");
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgErrorAcceso("Nombre o Contraseña incorrecto.\nVuelva a intertalo.");
                        lbErrorUsuario.Visible = false;
                        lbErrorContra.Visible = false;
                    }

                }
                else msgErrorContraseña("Ingrese su contraseña por favor");
            }
            else msgErrorUsuario("Por favor ingresa tu nombre");
          
        }

        #endregion

        #region mensajeErrorUsuario
        private void msgErrorUsuario(string msg)
        {
            lbErrorUsuario.Text = msg;
            lbErrorUsuario.Visible = true;    
        }

        #endregion

        #region mensajeErrorContraseña
        private void msgErrorContraseña(string msg)
        {
            lbErrorContra.Text = msg;
            lbErrorContra.Visible = true;
        }

        #endregion

        #region mensajeErrorContraseña
        private void msgErrorAcceso(string msg)
        {
            lb_ErrorAcceso.Text = msg;
            lb_ErrorAcceso.Visible = true;
        }

        #endregion

        #region mensajeErrorUsuario
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        #endregion

        #region mensajeErrorUsuario
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        #endregion

        #region PlaceHolder Login
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
            }
                
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
            }
        }
        #endregion
    }
}
