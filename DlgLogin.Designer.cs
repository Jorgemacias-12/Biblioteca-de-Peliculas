namespace Biblioteca_de_Peliculas
{
    partial class DlgLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgLogin));
            this.PnlIzquierdoLogin = new System.Windows.Forms.Panel();
            this.TxtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.LblUsuarioLogin = new System.Windows.Forms.Label();
            this.TxtContraseñaLogin = new System.Windows.Forms.TextBox();
            this.LblContraseñaLogin = new System.Windows.Forms.Label();
            this.LblTituloLogin = new System.Windows.Forms.Label();
            this.BtnEntrarLogin = new System.Windows.Forms.Button();
            this.LnblContraseñaLogin = new System.Windows.Forms.LinkLabel();
            this.PnlLoginStatusBar = new System.Windows.Forms.Panel();
            this.BtnShowPassword = new System.Windows.Forms.Button();
            this.PtbCerrarLogin = new System.Windows.Forms.PictureBox();
            this.PtbMinimizarLogin = new System.Windows.Forms.PictureBox();
            this.PtbIzquierdoLogin = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdoLogin.SuspendLayout();
            this.PnlLoginStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIzquierdoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlIzquierdoLogin
            // 
            this.PnlIzquierdoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlIzquierdoLogin.Controls.Add(this.PtbIzquierdoLogin);
            this.PnlIzquierdoLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdoLogin.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierdoLogin.Name = "PnlIzquierdoLogin";
            this.PnlIzquierdoLogin.Size = new System.Drawing.Size(283, 362);
            this.PnlIzquierdoLogin.TabIndex = 0;
            // 
            // TxtUsuarioLogin
            // 
            this.TxtUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TxtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioLogin.ForeColor = System.Drawing.Color.White;
            this.TxtUsuarioLogin.Location = new System.Drawing.Point(354, 115);
            this.TxtUsuarioLogin.Name = "TxtUsuarioLogin";
            this.TxtUsuarioLogin.Size = new System.Drawing.Size(445, 20);
            this.TxtUsuarioLogin.TabIndex = 1;
            this.TxtUsuarioLogin.Text = "USUARIO";
            this.TxtUsuarioLogin.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.TxtUsuarioLogin.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // LblUsuarioLogin
            // 
            this.LblUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUsuarioLogin.ForeColor = System.Drawing.Color.DimGray;
            this.LblUsuarioLogin.Location = new System.Drawing.Point(351, 198);
            this.LblUsuarioLogin.Name = "LblUsuarioLogin";
            this.LblUsuarioLogin.Size = new System.Drawing.Size(448, 2);
            this.LblUsuarioLogin.TabIndex = 3;
            // 
            // TxtContraseñaLogin
            // 
            this.TxtContraseñaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TxtContraseñaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseñaLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseñaLogin.ForeColor = System.Drawing.Color.White;
            this.TxtContraseñaLogin.Location = new System.Drawing.Point(351, 175);
            this.TxtContraseñaLogin.Name = "TxtContraseñaLogin";
            this.TxtContraseñaLogin.Size = new System.Drawing.Size(415, 20);
            this.TxtContraseñaLogin.TabIndex = 2;
            this.TxtContraseñaLogin.Text = "CONTRASEÑA";
            this.TxtContraseñaLogin.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseñaLogin.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // LblContraseñaLogin
            // 
            this.LblContraseñaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblContraseñaLogin.ForeColor = System.Drawing.Color.DimGray;
            this.LblContraseñaLogin.Location = new System.Drawing.Point(351, 138);
            this.LblContraseñaLogin.Name = "LblContraseñaLogin";
            this.LblContraseñaLogin.Size = new System.Drawing.Size(448, 2);
            this.LblContraseñaLogin.TabIndex = 5;
            // 
            // LblTituloLogin
            // 
            this.LblTituloLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloLogin.ForeColor = System.Drawing.Color.White;
            this.LblTituloLogin.Location = new System.Drawing.Point(286, 39);
            this.LblTituloLogin.Name = "LblTituloLogin";
            this.LblTituloLogin.Size = new System.Drawing.Size(600, 33);
            this.LblTituloLogin.TabIndex = 6;
            this.LblTituloLogin.Text = "LOGIN";
            this.LblTituloLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTituloLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTituloLogin_MouseDown);
            // 
            // BtnEntrarLogin
            // 
            this.BtnEntrarLogin.BackColor = System.Drawing.Color.DimGray;
            this.BtnEntrarLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnEntrarLogin.FlatAppearance.BorderSize = 0;
            this.BtnEntrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnEntrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrarLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrarLogin.ForeColor = System.Drawing.Color.White;
            this.BtnEntrarLogin.Location = new System.Drawing.Point(354, 231);
            this.BtnEntrarLogin.Name = "BtnEntrarLogin";
            this.BtnEntrarLogin.Size = new System.Drawing.Size(445, 40);
            this.BtnEntrarLogin.TabIndex = 3;
            this.BtnEntrarLogin.Text = "ENTRAR";
            this.BtnEntrarLogin.UseVisualStyleBackColor = false;
            this.BtnEntrarLogin.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LnblContraseñaLogin
            // 
            this.LnblContraseñaLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LnblContraseñaLogin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LnblContraseñaLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnblContraseñaLogin.ForeColor = System.Drawing.Color.Black;
            this.LnblContraseñaLogin.LinkColor = System.Drawing.Color.White;
            this.LnblContraseñaLogin.Location = new System.Drawing.Point(351, 287);
            this.LnblContraseñaLogin.Name = "LnblContraseñaLogin";
            this.LnblContraseñaLogin.Size = new System.Drawing.Size(448, 25);
            this.LnblContraseñaLogin.TabIndex = 0;
            this.LnblContraseñaLogin.TabStop = true;
            this.LnblContraseñaLogin.Text = "¿Ha olvidado su contraseña?";
            this.LnblContraseñaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlLoginStatusBar
            // 
            this.PnlLoginStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PnlLoginStatusBar.Controls.Add(this.PtbCerrarLogin);
            this.PnlLoginStatusBar.Controls.Add(this.PtbMinimizarLogin);
            this.PnlLoginStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLoginStatusBar.Location = new System.Drawing.Point(283, 0);
            this.PnlLoginStatusBar.Name = "PnlLoginStatusBar";
            this.PnlLoginStatusBar.Size = new System.Drawing.Size(603, 36);
            this.PnlLoginStatusBar.TabIndex = 14;
            this.PnlLoginStatusBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLoginStatusBar_MouseDown);
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.FlatAppearance.BorderSize = 0;
            this.BtnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPassword.Image = global::Biblioteca_de_Peliculas.Properties.Resources.blind;
            this.BtnShowPassword.Location = new System.Drawing.Point(767, 163);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.Size = new System.Drawing.Size(32, 32);
            this.BtnShowPassword.TabIndex = 15;
            this.BtnShowPassword.UseVisualStyleBackColor = false;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // PtbCerrarLogin
            // 
            this.PtbCerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarLogin.Image")));
            this.PtbCerrarLogin.Location = new System.Drawing.Point(571, 0);
            this.PtbCerrarLogin.Name = "PtbCerrarLogin";
            this.PtbCerrarLogin.Size = new System.Drawing.Size(32, 36);
            this.PtbCerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbCerrarLogin.TabIndex = 9;
            this.PtbCerrarLogin.TabStop = false;
            this.PtbCerrarLogin.Click += new System.EventHandler(this.PtbCerrar_Click);
            // 
            // PtbMinimizarLogin
            // 
            this.PtbMinimizarLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbMinimizarLogin.Image")));
            this.PtbMinimizarLogin.Location = new System.Drawing.Point(542, 0);
            this.PtbMinimizarLogin.Name = "PtbMinimizarLogin";
            this.PtbMinimizarLogin.Size = new System.Drawing.Size(32, 36);
            this.PtbMinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbMinimizarLogin.TabIndex = 10;
            this.PtbMinimizarLogin.TabStop = false;
            this.PtbMinimizarLogin.Click += new System.EventHandler(this.PtbMinimizar_Click);
            // 
            // PtbIzquierdoLogin
            // 
            this.PtbIzquierdoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PtbIzquierdoLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbIzquierdoLogin.Image = global::Biblioteca_de_Peliculas.Properties.Resources.Fondo;
            this.PtbIzquierdoLogin.Location = new System.Drawing.Point(0, 0);
            this.PtbIzquierdoLogin.Name = "PtbIzquierdoLogin";
            this.PtbIzquierdoLogin.Size = new System.Drawing.Size(283, 362);
            this.PtbIzquierdoLogin.TabIndex = 11;
            this.PtbIzquierdoLogin.TabStop = false;
            this.PtbIzquierdoLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PtbIzquierdoLogin_MouseDown);
            // 
            // DlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(886, 362);
            this.Controls.Add(this.BtnShowPassword);
            this.Controls.Add(this.PnlLoginStatusBar);
            this.Controls.Add(this.LnblContraseñaLogin);
            this.Controls.Add(this.BtnEntrarLogin);
            this.Controls.Add(this.LblTituloLogin);
            this.Controls.Add(this.TxtContraseñaLogin);
            this.Controls.Add(this.LblContraseñaLogin);
            this.Controls.Add(this.TxtUsuarioLogin);
            this.Controls.Add(this.PnlIzquierdoLogin);
            this.Controls.Add(this.LblUsuarioLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DlgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DlgLogin_FormClosing);
            this.Load += new System.EventHandler(this.DlgLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgLogin_MouseDown);
            this.PnlIzquierdoLogin.ResumeLayout(false);
            this.PnlLoginStatusBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIzquierdoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlIzquierdoLogin;
        private System.Windows.Forms.TextBox TxtUsuarioLogin;
        private System.Windows.Forms.Label LblUsuarioLogin;
        private System.Windows.Forms.TextBox TxtContraseñaLogin;
        private System.Windows.Forms.Label LblContraseñaLogin;
        private System.Windows.Forms.Label LblTituloLogin;
        private System.Windows.Forms.Button BtnEntrarLogin;
        private System.Windows.Forms.LinkLabel LnblContraseñaLogin;
        private System.Windows.Forms.PictureBox PtbCerrarLogin;
        private System.Windows.Forms.PictureBox PtbMinimizarLogin;
        private System.Windows.Forms.PictureBox PtbIzquierdoLogin;
        private System.Windows.Forms.Panel PnlLoginStatusBar;
        private System.Windows.Forms.Button BtnShowPassword;
    }
}

