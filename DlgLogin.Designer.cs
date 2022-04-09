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
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LnblContraseña = new System.Windows.Forms.LinkLabel();
            this.CkbMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.PtbMinimizar = new System.Windows.Forms.PictureBox();
            this.PtbCerrar = new System.Windows.Forms.PictureBox();
            this.PtbIzquierdo = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIzquierdo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlIzquierdo.Controls.Add(this.PtbIzquierdo);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(250, 330);
            this.PnlIzquierdo.TabIndex = 0;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsuario.Location = new System.Drawing.Point(292, 77);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(437, 20);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Text = "USUARIO";
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.LblUsuario.Location = new System.Drawing.Point(289, 81);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(448, 17);
            this.LblUsuario.TabIndex = 3;
            this.LblUsuario.Text = "_______________________________________________________\r\n";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.TxtContraseña.Location = new System.Drawing.Point(292, 127);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(437, 20);
            this.TxtContraseña.TabIndex = 2;
            this.TxtContraseña.Text = "CONTRASEÑA";
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.LblContraseña.Location = new System.Drawing.Point(289, 131);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(448, 17);
            this.LblContraseña.TabIndex = 5;
            this.LblContraseña.Text = "_______________________________________________________\r\n";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.LblTitulo.Location = new System.Drawing.Point(250, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(530, 33);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "LOGIN";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.DimGray;
            this.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Location = new System.Drawing.Point(292, 204);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(445, 40);
            this.BtnEntrar.TabIndex = 3;
            this.BtnEntrar.Text = "ENTRAR";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LnblContraseña
            // 
            this.LnblContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LnblContraseña.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LnblContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnblContraseña.LinkColor = System.Drawing.Color.DimGray;
            this.LnblContraseña.Location = new System.Drawing.Point(289, 254);
            this.LnblContraseña.Name = "LnblContraseña";
            this.LnblContraseña.Size = new System.Drawing.Size(448, 25);
            this.LnblContraseña.TabIndex = 0;
            this.LnblContraseña.TabStop = true;
            this.LnblContraseña.Text = "¿Ha olvidado su contraseña?";
            this.LnblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CkbMostrarContraseña
            // 
            this.CkbMostrarContraseña.AutoSize = true;
            this.CkbMostrarContraseña.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.CkbMostrarContraseña.FlatAppearance.BorderSize = 0;
            this.CkbMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CkbMostrarContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbMostrarContraseña.Location = new System.Drawing.Point(292, 158);
            this.CkbMostrarContraseña.Name = "CkbMostrarContraseña";
            this.CkbMostrarContraseña.Size = new System.Drawing.Size(157, 22);
            this.CkbMostrarContraseña.TabIndex = 11;
            this.CkbMostrarContraseña.Text = "Mostrar contraseña";
            this.CkbMostrarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CkbMostrarContraseña.UseVisualStyleBackColor = true;
            this.CkbMostrarContraseña.CheckedChanged += new System.EventHandler(this.CkbMostrarContraseña_CheckedChanged);
            // 
            // PtbMinimizar
            // 
            this.PtbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PtbMinimizar.Image")));
            this.PtbMinimizar.Location = new System.Drawing.Point(732, 0);
            this.PtbMinimizar.Name = "PtbMinimizar";
            this.PtbMinimizar.Size = new System.Drawing.Size(20, 20);
            this.PtbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbMinimizar.TabIndex = 10;
            this.PtbMinimizar.TabStop = false;
            this.PtbMinimizar.Click += new System.EventHandler(this.PtbMinimizar_Click);
            // 
            // PtbCerrar
            // 
            this.PtbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrar.Image")));
            this.PtbCerrar.Location = new System.Drawing.Point(758, 0);
            this.PtbCerrar.Name = "PtbCerrar";
            this.PtbCerrar.Size = new System.Drawing.Size(20, 20);
            this.PtbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbCerrar.TabIndex = 9;
            this.PtbCerrar.TabStop = false;
            this.PtbCerrar.Click += new System.EventHandler(this.PtbCerrar_Click);
            // 
            // PtbIzquierdo
            // 
            this.PtbIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbIzquierdo.Image = ((System.Drawing.Image)(resources.GetObject("PtbIzquierdo.Image")));
            this.PtbIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PtbIzquierdo.Name = "PtbIzquierdo";
            this.PtbIzquierdo.Size = new System.Drawing.Size(250, 330);
            this.PtbIzquierdo.TabIndex = 11;
            this.PtbIzquierdo.TabStop = false;
            // 
            // DlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.CkbMostrarContraseña);
            this.Controls.Add(this.PtbMinimizar);
            this.Controls.Add(this.PtbCerrar);
            this.Controls.Add(this.LnblContraseña);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.PnlIzquierdo);
            this.Controls.Add(this.LblUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DlgLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DlgLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgLogin_MouseDown);
            this.PnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIzquierdo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.LinkLabel LnblContraseña;
        private System.Windows.Forms.PictureBox PtbCerrar;
        private System.Windows.Forms.PictureBox PtbMinimizar;
        private System.Windows.Forms.PictureBox PtbIzquierdo;
        private System.Windows.Forms.CheckBox CkbMostrarContraseña;
    }
}

