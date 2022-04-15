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
            this.PtbIzquierdoLogin = new System.Windows.Forms.PictureBox();
            this.TxtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.LblUsuarioLogin = new System.Windows.Forms.Label();
            this.TxtContraseñaLogin = new System.Windows.Forms.TextBox();
            this.LblContraseñaLogin = new System.Windows.Forms.Label();
            this.LblTituloLogin = new System.Windows.Forms.Label();
            this.BtnEntrarLogin = new System.Windows.Forms.Button();
            this.LnblContraseñaLogin = new System.Windows.Forms.LinkLabel();
            this.PtbMinimizarLogin = new System.Windows.Forms.PictureBox();
            this.PtbCerrarLogin = new System.Windows.Forms.PictureBox();
            this.PtbVerContraseñaLogin = new System.Windows.Forms.PictureBox();
            this.PtbTaparContraseñaLogin = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIzquierdoLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbVerContraseñaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbTaparContraseñaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlIzquierdoLogin
            // 
            this.PnlIzquierdoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlIzquierdoLogin.Controls.Add(this.PtbIzquierdoLogin);
            this.PnlIzquierdoLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdoLogin.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierdoLogin.Name = "PnlIzquierdoLogin";
            this.PnlIzquierdoLogin.Size = new System.Drawing.Size(250, 330);
            this.PnlIzquierdoLogin.TabIndex = 0;
            // 
            // PtbIzquierdoLogin
            // 
            this.PtbIzquierdoLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbIzquierdoLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbIzquierdoLogin.Image")));
            this.PtbIzquierdoLogin.Location = new System.Drawing.Point(0, 0);
            this.PtbIzquierdoLogin.Name = "PtbIzquierdoLogin";
            this.PtbIzquierdoLogin.Size = new System.Drawing.Size(250, 330);
            this.PtbIzquierdoLogin.TabIndex = 11;
            this.PtbIzquierdoLogin.TabStop = false;
            // 
            // TxtUsuarioLogin
            // 
            this.TxtUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.TxtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuarioLogin.Location = new System.Drawing.Point(292, 77);
            this.TxtUsuarioLogin.Name = "TxtUsuarioLogin";
            this.TxtUsuarioLogin.Size = new System.Drawing.Size(437, 20);
            this.TxtUsuarioLogin.TabIndex = 1;
            this.TxtUsuarioLogin.Text = "USUARIO";
            this.TxtUsuarioLogin.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.TxtUsuarioLogin.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // LblUsuarioLogin
            // 
            this.LblUsuarioLogin.AutoSize = true;
            this.LblUsuarioLogin.ForeColor = System.Drawing.Color.DimGray;
            this.LblUsuarioLogin.Location = new System.Drawing.Point(289, 81);
            this.LblUsuarioLogin.Name = "LblUsuarioLogin";
            this.LblUsuarioLogin.Size = new System.Drawing.Size(448, 17);
            this.LblUsuarioLogin.TabIndex = 3;
            this.LblUsuarioLogin.Text = "_______________________________________________________\r\n";
            // 
            // TxtContraseñaLogin
            // 
            this.TxtContraseñaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.TxtContraseñaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseñaLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseñaLogin.ForeColor = System.Drawing.Color.Black;
            this.TxtContraseñaLogin.Location = new System.Drawing.Point(292, 127);
            this.TxtContraseñaLogin.Name = "TxtContraseñaLogin";
            this.TxtContraseñaLogin.Size = new System.Drawing.Size(437, 20);
            this.TxtContraseñaLogin.TabIndex = 2;
            this.TxtContraseñaLogin.Text = "CONTRASEÑA";
            this.TxtContraseñaLogin.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseñaLogin.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // LblContraseñaLogin
            // 
            this.LblContraseñaLogin.AutoSize = true;
            this.LblContraseñaLogin.ForeColor = System.Drawing.Color.DimGray;
            this.LblContraseñaLogin.Location = new System.Drawing.Point(289, 131);
            this.LblContraseñaLogin.Name = "LblContraseñaLogin";
            this.LblContraseñaLogin.Size = new System.Drawing.Size(448, 17);
            this.LblContraseñaLogin.TabIndex = 5;
            this.LblContraseñaLogin.Text = "_______________________________________________________\r\n";
            // 
            // LblTituloLogin
            // 
            this.LblTituloLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTituloLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloLogin.ForeColor = System.Drawing.Color.Black;
            this.LblTituloLogin.Location = new System.Drawing.Point(250, 0);
            this.LblTituloLogin.Name = "LblTituloLogin";
            this.LblTituloLogin.Size = new System.Drawing.Size(530, 33);
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
            this.BtnEntrarLogin.Location = new System.Drawing.Point(292, 190);
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
            this.LnblContraseñaLogin.LinkColor = System.Drawing.Color.DimGray;
            this.LnblContraseñaLogin.Location = new System.Drawing.Point(289, 243);
            this.LnblContraseñaLogin.Name = "LnblContraseñaLogin";
            this.LnblContraseñaLogin.Size = new System.Drawing.Size(448, 25);
            this.LnblContraseñaLogin.TabIndex = 0;
            this.LnblContraseñaLogin.TabStop = true;
            this.LnblContraseñaLogin.Text = "¿Ha olvidado su contraseña?";
            this.LnblContraseñaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PtbMinimizarLogin
            // 
            this.PtbMinimizarLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbMinimizarLogin.Image")));
            this.PtbMinimizarLogin.Location = new System.Drawing.Point(732, 0);
            this.PtbMinimizarLogin.Name = "PtbMinimizarLogin";
            this.PtbMinimizarLogin.Size = new System.Drawing.Size(20, 20);
            this.PtbMinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbMinimizarLogin.TabIndex = 10;
            this.PtbMinimizarLogin.TabStop = false;
            this.PtbMinimizarLogin.Click += new System.EventHandler(this.PtbMinimizar_Click);
            // 
            // PtbCerrarLogin
            // 
            this.PtbCerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarLogin.Image")));
            this.PtbCerrarLogin.Location = new System.Drawing.Point(758, 0);
            this.PtbCerrarLogin.Name = "PtbCerrarLogin";
            this.PtbCerrarLogin.Size = new System.Drawing.Size(20, 20);
            this.PtbCerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbCerrarLogin.TabIndex = 9;
            this.PtbCerrarLogin.TabStop = false;
            this.PtbCerrarLogin.Click += new System.EventHandler(this.PtbCerrar_Click);
            // 
            // PtbVerContraseñaLogin
            // 
            this.PtbVerContraseñaLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbVerContraseñaLogin.Image")));
            this.PtbVerContraseñaLogin.Location = new System.Drawing.Point(702, 121);
            this.PtbVerContraseñaLogin.Name = "PtbVerContraseñaLogin";
            this.PtbVerContraseñaLogin.Size = new System.Drawing.Size(27, 26);
            this.PtbVerContraseñaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbVerContraseñaLogin.TabIndex = 12;
            this.PtbVerContraseñaLogin.TabStop = false;
            this.PtbVerContraseñaLogin.Click += new System.EventHandler(this.PtbVerContraseña_Click);
            // 
            // PtbTaparContraseñaLogin
            // 
            this.PtbTaparContraseñaLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbTaparContraseñaLogin.Image")));
            this.PtbTaparContraseñaLogin.Location = new System.Drawing.Point(702, 121);
            this.PtbTaparContraseñaLogin.Name = "PtbTaparContraseñaLogin";
            this.PtbTaparContraseñaLogin.Size = new System.Drawing.Size(27, 26);
            this.PtbTaparContraseñaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbTaparContraseñaLogin.TabIndex = 13;
            this.PtbTaparContraseñaLogin.TabStop = false;
            this.PtbTaparContraseñaLogin.Click += new System.EventHandler(this.PtbTaparContraseña_Click);
            // 
            // DlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.PtbVerContraseñaLogin);
            this.Controls.Add(this.PtbMinimizarLogin);
            this.Controls.Add(this.PtbCerrarLogin);
            this.Controls.Add(this.LnblContraseñaLogin);
            this.Controls.Add(this.BtnEntrarLogin);
            this.Controls.Add(this.LblTituloLogin);
            this.Controls.Add(this.TxtContraseñaLogin);
            this.Controls.Add(this.LblContraseñaLogin);
            this.Controls.Add(this.TxtUsuarioLogin);
            this.Controls.Add(this.PnlIzquierdoLogin);
            this.Controls.Add(this.LblUsuarioLogin);
            this.Controls.Add(this.PtbTaparContraseñaLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DlgLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DlgLogin_FormClosing);
            this.Load += new System.EventHandler(this.DlgLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgLogin_MouseDown);
            this.PnlIzquierdoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbIzquierdoLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbVerContraseñaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbTaparContraseñaLogin)).EndInit();
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
        private System.Windows.Forms.PictureBox PtbVerContraseñaLogin;
        private System.Windows.Forms.PictureBox PtbTaparContraseñaLogin;
    }
}

