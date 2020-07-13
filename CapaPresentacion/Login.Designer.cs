namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAcceder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_ErrorAcceso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbErrorContra = new System.Windows.Forms.Label();
            this.lbErrorUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(87, 226);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(260, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(90, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bienvenido!";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(153)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(113, 240);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(204, 24);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(153)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.Location = new System.Drawing.Point(110, 332);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(204, 24);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcceder.BorderRadius = 3;
            this.btnAcceder.ButtonText = "ACCEDER";
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btnAcceder.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAcceder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAcceder.Iconimage")));
            this.btnAcceder.Iconimage_right = null;
            this.btnAcceder.Iconimage_right_Selected = null;
            this.btnAcceder.Iconimage_Selected = null;
            this.btnAcceder.IconMarginLeft = 0;
            this.btnAcceder.IconMarginRight = 0;
            this.btnAcceder.IconRightVisible = true;
            this.btnAcceder.IconRightZoom = 0D;
            this.btnAcceder.IconVisible = true;
            this.btnAcceder.IconZoom = 90D;
            this.btnAcceder.IsTab = false;
            this.btnAcceder.Location = new System.Drawing.Point(113, 410);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAcceder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btnAcceder.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnAcceder.selected = false;
            this.btnAcceder.Size = new System.Drawing.Size(179, 46);
            this.btnAcceder.TabIndex = 0;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceder.Textcolor = System.Drawing.Color.DimGray;
            this.btnAcceder.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lb_ErrorAcceso
            // 
            this.lb_ErrorAcceso.AutoSize = true;
            this.lb_ErrorAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ErrorAcceso.ForeColor = System.Drawing.Color.Red;
            this.lb_ErrorAcceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_ErrorAcceso.ImageKey = "(ninguno)";
            this.lb_ErrorAcceso.Location = new System.Drawing.Point(110, 162);
            this.lb_ErrorAcceso.Name = "lb_ErrorAcceso";
            this.lb_ErrorAcceso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_ErrorAcceso.Size = new System.Drawing.Size(76, 15);
            this.lb_ErrorAcceso.TabIndex = 15;
            this.lb_ErrorAcceso.Text = "Error Acceso";
            this.lb_ErrorAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_ErrorAcceso.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbErrorContra
            // 
            this.lbErrorContra.AutoSize = true;
            this.lbErrorContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorContra.ForeColor = System.Drawing.Color.Red;
            this.lbErrorContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErrorContra.ImageKey = "(ninguno)";
            this.lbErrorContra.Location = new System.Drawing.Point(110, 373);
            this.lbErrorContra.Name = "lbErrorContra";
            this.lbErrorContra.Size = new System.Drawing.Size(64, 15);
            this.lbErrorContra.TabIndex = 16;
            this.lbErrorContra.Text = "Error Pass";
            this.lbErrorContra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbErrorContra.Visible = false;
            // 
            // lbErrorUsuario
            // 
            this.lbErrorUsuario.AutoSize = true;
            this.lbErrorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.lbErrorUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErrorUsuario.ImageKey = "(ninguno)";
            this.lbErrorUsuario.Location = new System.Drawing.Point(107, 282);
            this.lbErrorUsuario.Name = "lbErrorUsuario";
            this.lbErrorUsuario.Size = new System.Drawing.Size(80, 15);
            this.lbErrorUsuario.TabIndex = 17;
            this.lbErrorUsuario.Text = "Error Usuario";
            this.lbErrorUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbErrorUsuario.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(148)))), ((int)(((byte)(99)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(411, 575);
            this.Controls.Add(this.lbErrorUsuario);
            this.Controls.Add(this.lbErrorContra);
            this.Controls.Add(this.lb_ErrorAcceso);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso Cafe Premium";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private Bunifu.Framework.UI.BunifuFlatButton btnAcceder;
        private System.Windows.Forms.Label lb_ErrorAcceso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbErrorUsuario;
        private System.Windows.Forms.Label lbErrorContra;
    }
}