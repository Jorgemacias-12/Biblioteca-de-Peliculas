namespace Biblioteca_de_Peliculas
{
    partial class DlgAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgAcercaDe));
            this.PnlArribaMenu = new System.Windows.Forms.Panel();
            this.PtbMinimizarMenu = new System.Windows.Forms.PictureBox();
            this.PtbCerrarMenu = new System.Windows.Forms.PictureBox();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblRepositorio = new System.Windows.Forms.Label();
            this.LnkLblAutor = new System.Windows.Forms.LinkLabel();
            this.LnkLblRepositorio = new System.Windows.Forms.LinkLabel();
            this.PnlArribaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlArribaMenu
            // 
            this.PnlArribaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.PnlArribaMenu.Controls.Add(this.PtbMinimizarMenu);
            this.PnlArribaMenu.Controls.Add(this.PtbCerrarMenu);
            this.PnlArribaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArribaMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlArribaMenu.Name = "PnlArribaMenu";
            this.PnlArribaMenu.Size = new System.Drawing.Size(291, 23);
            this.PnlArribaMenu.TabIndex = 1;
            // 
            // PtbMinimizarMenu
            // 
            this.PtbMinimizarMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PtbMinimizarMenu.Image = ((System.Drawing.Image)(resources.GetObject("PtbMinimizarMenu.Image")));
            this.PtbMinimizarMenu.Location = new System.Drawing.Point(251, 0);
            this.PtbMinimizarMenu.Name = "PtbMinimizarMenu";
            this.PtbMinimizarMenu.Size = new System.Drawing.Size(20, 23);
            this.PtbMinimizarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbMinimizarMenu.TabIndex = 13;
            this.PtbMinimizarMenu.TabStop = false;
            this.PtbMinimizarMenu.Click += new System.EventHandler(this.PtbMinimizarMenu_Click);
            // 
            // PtbCerrarMenu
            // 
            this.PtbCerrarMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PtbCerrarMenu.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarMenu.Image")));
            this.PtbCerrarMenu.Location = new System.Drawing.Point(271, 0);
            this.PtbCerrarMenu.Name = "PtbCerrarMenu";
            this.PtbCerrarMenu.Size = new System.Drawing.Size(20, 23);
            this.PtbCerrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbCerrarMenu.TabIndex = 11;
            this.PtbCerrarMenu.TabStop = false;
            this.PtbCerrarMenu.Click += new System.EventHandler(this.PtbCerrarMenu_Click);
            // 
            // LblVersion
            // 
            this.LblVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.Location = new System.Drawing.Point(0, 23);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(291, 48);
            this.LblVersion.TabIndex = 2;
            this.LblVersion.Text = "Versión:\r\n1.0";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblAutor
            // 
            this.LblAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblAutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Location = new System.Drawing.Point(0, 71);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(291, 24);
            this.LblAutor.TabIndex = 3;
            this.LblAutor.Text = "Perfil de GitHub:";
            this.LblAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblRepositorio
            // 
            this.LblRepositorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblRepositorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRepositorio.Location = new System.Drawing.Point(0, 118);
            this.LblRepositorio.Name = "LblRepositorio";
            this.LblRepositorio.Size = new System.Drawing.Size(291, 24);
            this.LblRepositorio.TabIndex = 4;
            this.LblRepositorio.Text = "Repositorio:";
            this.LblRepositorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LnkLblAutor
            // 
            this.LnkLblAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LnkLblAutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblAutor.Location = new System.Drawing.Point(0, 95);
            this.LnkLblAutor.Name = "LnkLblAutor";
            this.LnkLblAutor.Size = new System.Drawing.Size(291, 23);
            this.LnkLblAutor.TabIndex = 5;
            this.LnkLblAutor.TabStop = true;
            this.LnkLblAutor.Text = "Aarón Flores Pasos";
            this.LnkLblAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LnkLblAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblAutor_LinkClicked);
            // 
            // LnkLblRepositorio
            // 
            this.LnkLblRepositorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.LnkLblRepositorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblRepositorio.Location = new System.Drawing.Point(0, 142);
            this.LnkLblRepositorio.Name = "LnkLblRepositorio";
            this.LnkLblRepositorio.Size = new System.Drawing.Size(291, 23);
            this.LnkLblRepositorio.TabIndex = 6;
            this.LnkLblRepositorio.TabStop = true;
            this.LnkLblRepositorio.Text = "Biblioteca-de-Peliculas";
            this.LnkLblRepositorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LnkLblRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblRepositorio_LinkClicked);
            // 
            // DlgAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 174);
            this.Controls.Add(this.LnkLblRepositorio);
            this.Controls.Add(this.LblRepositorio);
            this.Controls.Add(this.LnkLblAutor);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.PnlArribaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DlgAcercaDe_FormClosing);
            this.PnlArribaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlArribaMenu;
        private System.Windows.Forms.PictureBox PtbMinimizarMenu;
        private System.Windows.Forms.PictureBox PtbCerrarMenu;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblRepositorio;
        private System.Windows.Forms.LinkLabel LnkLblAutor;
        private System.Windows.Forms.LinkLabel LnkLblRepositorio;
    }
}