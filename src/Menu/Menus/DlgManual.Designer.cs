namespace Biblioteca_de_Peliculas
{
    partial class DlgManual
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgManual));
            this.PnlArribaManual = new System.Windows.Forms.Panel();
            this.PtbMinimizarManual = new System.Windows.Forms.PictureBox();
            this.PtbCerrarManual = new System.Windows.Forms.PictureBox();
            this.TbcManuales = new System.Windows.Forms.TabControl();
            this.TpManualReproducir = new System.Windows.Forms.TabPage();
            this.PtbImagenReproducir = new System.Windows.Forms.PictureBox();
            this.PnlControlesReproducir = new System.Windows.Forms.Panel();
            this.BtnAutomaticoReproducir = new System.Windows.Forms.Button();
            this.BtnPausarReproducir = new System.Windows.Forms.Button();
            this.BtnContinuarReproducir = new System.Windows.Forms.Button();
            this.LblInfoReproducir = new System.Windows.Forms.Label();
            this.TpManualModos = new System.Windows.Forms.TabPage();
            this.PtbImagenModos = new System.Windows.Forms.PictureBox();
            this.PnlControlesModos = new System.Windows.Forms.Panel();
            this.BtnAutomaticoModos = new System.Windows.Forms.Button();
            this.BtnPausarModos = new System.Windows.Forms.Button();
            this.BtnContinuarModos = new System.Windows.Forms.Button();
            this.LblInfoModos = new System.Windows.Forms.Label();
            this.TimerReproducir = new System.Windows.Forms.Timer(this.components);
            this.PnlArribaManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizarManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarManual)).BeginInit();
            this.TbcManuales.SuspendLayout();
            this.TpManualReproducir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagenReproducir)).BeginInit();
            this.PnlControlesReproducir.SuspendLayout();
            this.TpManualModos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagenModos)).BeginInit();
            this.PnlControlesModos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlArribaManual
            // 
            this.PnlArribaManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.PnlArribaManual.Controls.Add(this.PtbMinimizarManual);
            this.PnlArribaManual.Controls.Add(this.PtbCerrarManual);
            this.PnlArribaManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArribaManual.Location = new System.Drawing.Point(0, 0);
            this.PnlArribaManual.Name = "PnlArribaManual";
            this.PnlArribaManual.Size = new System.Drawing.Size(1239, 23);
            this.PnlArribaManual.TabIndex = 1;
            this.PnlArribaManual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlArribaManual_MouseDown);
            // 
            // PtbMinimizarManual
            // 
            this.PtbMinimizarManual.Dock = System.Windows.Forms.DockStyle.Right;
            this.PtbMinimizarManual.Image = ((System.Drawing.Image)(resources.GetObject("PtbMinimizarManual.Image")));
            this.PtbMinimizarManual.Location = new System.Drawing.Point(1199, 0);
            this.PtbMinimizarManual.Name = "PtbMinimizarManual";
            this.PtbMinimizarManual.Size = new System.Drawing.Size(20, 23);
            this.PtbMinimizarManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbMinimizarManual.TabIndex = 13;
            this.PtbMinimizarManual.TabStop = false;
            this.PtbMinimizarManual.Click += new System.EventHandler(this.PtbMinimizarManual_Click);
            // 
            // PtbCerrarManual
            // 
            this.PtbCerrarManual.Dock = System.Windows.Forms.DockStyle.Right;
            this.PtbCerrarManual.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarManual.Image")));
            this.PtbCerrarManual.Location = new System.Drawing.Point(1219, 0);
            this.PtbCerrarManual.Name = "PtbCerrarManual";
            this.PtbCerrarManual.Size = new System.Drawing.Size(20, 23);
            this.PtbCerrarManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbCerrarManual.TabIndex = 11;
            this.PtbCerrarManual.TabStop = false;
            this.PtbCerrarManual.Click += new System.EventHandler(this.PtbCerrarManual_Click);
            // 
            // TbcManuales
            // 
            this.TbcManuales.Controls.Add(this.TpManualReproducir);
            this.TbcManuales.Controls.Add(this.TpManualModos);
            this.TbcManuales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcManuales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbcManuales.Location = new System.Drawing.Point(0, 23);
            this.TbcManuales.Name = "TbcManuales";
            this.TbcManuales.SelectedIndex = 0;
            this.TbcManuales.Size = new System.Drawing.Size(1239, 677);
            this.TbcManuales.TabIndex = 3;
            // 
            // TpManualReproducir
            // 
            this.TpManualReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.TpManualReproducir.Controls.Add(this.PtbImagenReproducir);
            this.TpManualReproducir.Controls.Add(this.PnlControlesReproducir);
            this.TpManualReproducir.Controls.Add(this.LblInfoReproducir);
            this.TpManualReproducir.Location = new System.Drawing.Point(4, 30);
            this.TpManualReproducir.Name = "TpManualReproducir";
            this.TpManualReproducir.Padding = new System.Windows.Forms.Padding(3);
            this.TpManualReproducir.Size = new System.Drawing.Size(1231, 643);
            this.TpManualReproducir.TabIndex = 0;
            this.TpManualReproducir.Text = "Reproducir";
            // 
            // PtbImagenReproducir
            // 
            this.PtbImagenReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.PtbImagenReproducir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbImagenReproducir.Location = new System.Drawing.Point(3, 29);
            this.PtbImagenReproducir.Name = "PtbImagenReproducir";
            this.PtbImagenReproducir.Size = new System.Drawing.Size(1225, 530);
            this.PtbImagenReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbImagenReproducir.TabIndex = 0;
            this.PtbImagenReproducir.TabStop = false;
            // 
            // PnlControlesReproducir
            // 
            this.PnlControlesReproducir.Controls.Add(this.BtnAutomaticoReproducir);
            this.PnlControlesReproducir.Controls.Add(this.BtnPausarReproducir);
            this.PnlControlesReproducir.Controls.Add(this.BtnContinuarReproducir);
            this.PnlControlesReproducir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlControlesReproducir.Location = new System.Drawing.Point(3, 559);
            this.PnlControlesReproducir.Name = "PnlControlesReproducir";
            this.PnlControlesReproducir.Size = new System.Drawing.Size(1225, 81);
            this.PnlControlesReproducir.TabIndex = 1;
            // 
            // BtnAutomaticoReproducir
            // 
            this.BtnAutomaticoReproducir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAutomaticoReproducir.Location = new System.Drawing.Point(0, -3);
            this.BtnAutomaticoReproducir.Name = "BtnAutomaticoReproducir";
            this.BtnAutomaticoReproducir.Size = new System.Drawing.Size(1225, 28);
            this.BtnAutomaticoReproducir.TabIndex = 3;
            this.BtnAutomaticoReproducir.Text = "Automatico";
            this.BtnAutomaticoReproducir.UseVisualStyleBackColor = true;
            this.BtnAutomaticoReproducir.Click += new System.EventHandler(this.BtnAutomaticoReproducir_Click);
            // 
            // BtnPausarReproducir
            // 
            this.BtnPausarReproducir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPausarReproducir.Location = new System.Drawing.Point(0, 25);
            this.BtnPausarReproducir.Name = "BtnPausarReproducir";
            this.BtnPausarReproducir.Size = new System.Drawing.Size(1225, 28);
            this.BtnPausarReproducir.TabIndex = 2;
            this.BtnPausarReproducir.Text = "Pausar";
            this.BtnPausarReproducir.UseVisualStyleBackColor = true;
            this.BtnPausarReproducir.Click += new System.EventHandler(this.BtnPausarReproducir_Click);
            // 
            // BtnContinuarReproducir
            // 
            this.BtnContinuarReproducir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnContinuarReproducir.Location = new System.Drawing.Point(0, 53);
            this.BtnContinuarReproducir.Name = "BtnContinuarReproducir";
            this.BtnContinuarReproducir.Size = new System.Drawing.Size(1225, 28);
            this.BtnContinuarReproducir.TabIndex = 4;
            this.BtnContinuarReproducir.Text = "Continuar";
            this.BtnContinuarReproducir.UseVisualStyleBackColor = true;
            this.BtnContinuarReproducir.Click += new System.EventHandler(this.BtnContinuarReproducir_Click);
            // 
            // LblInfoReproducir
            // 
            this.LblInfoReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(178)))), ((int)(((byte)(203)))));
            this.LblInfoReproducir.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblInfoReproducir.Location = new System.Drawing.Point(3, 3);
            this.LblInfoReproducir.Name = "LblInfoReproducir";
            this.LblInfoReproducir.Size = new System.Drawing.Size(1225, 26);
            this.LblInfoReproducir.TabIndex = 0;
            this.LblInfoReproducir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TpManualModos
            // 
            this.TpManualModos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.TpManualModos.Controls.Add(this.PtbImagenModos);
            this.TpManualModos.Controls.Add(this.PnlControlesModos);
            this.TpManualModos.Controls.Add(this.LblInfoModos);
            this.TpManualModos.Location = new System.Drawing.Point(4, 30);
            this.TpManualModos.Name = "TpManualModos";
            this.TpManualModos.Padding = new System.Windows.Forms.Padding(3);
            this.TpManualModos.Size = new System.Drawing.Size(1231, 643);
            this.TpManualModos.TabIndex = 1;
            this.TpManualModos.Text = "Modos";
            // 
            // PtbImagenModos
            // 
            this.PtbImagenModos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.PtbImagenModos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbImagenModos.Location = new System.Drawing.Point(3, 29);
            this.PtbImagenModos.Name = "PtbImagenModos";
            this.PtbImagenModos.Size = new System.Drawing.Size(1225, 530);
            this.PtbImagenModos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbImagenModos.TabIndex = 4;
            this.PtbImagenModos.TabStop = false;
            // 
            // PnlControlesModos
            // 
            this.PnlControlesModos.Controls.Add(this.BtnAutomaticoModos);
            this.PnlControlesModos.Controls.Add(this.BtnPausarModos);
            this.PnlControlesModos.Controls.Add(this.BtnContinuarModos);
            this.PnlControlesModos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlControlesModos.Location = new System.Drawing.Point(3, 559);
            this.PnlControlesModos.Name = "PnlControlesModos";
            this.PnlControlesModos.Size = new System.Drawing.Size(1225, 81);
            this.PnlControlesModos.TabIndex = 3;
            // 
            // BtnAutomaticoModos
            // 
            this.BtnAutomaticoModos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAutomaticoModos.Location = new System.Drawing.Point(0, -3);
            this.BtnAutomaticoModos.Name = "BtnAutomaticoModos";
            this.BtnAutomaticoModos.Size = new System.Drawing.Size(1225, 28);
            this.BtnAutomaticoModos.TabIndex = 3;
            this.BtnAutomaticoModos.Text = "Automatico";
            this.BtnAutomaticoModos.UseVisualStyleBackColor = true;
            this.BtnAutomaticoModos.Click += new System.EventHandler(this.BtnAutomaticoModos_Click);
            // 
            // BtnPausarModos
            // 
            this.BtnPausarModos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPausarModos.Location = new System.Drawing.Point(0, 25);
            this.BtnPausarModos.Name = "BtnPausarModos";
            this.BtnPausarModos.Size = new System.Drawing.Size(1225, 28);
            this.BtnPausarModos.TabIndex = 2;
            this.BtnPausarModos.Text = "Pausar";
            this.BtnPausarModos.UseVisualStyleBackColor = true;
            this.BtnPausarModos.Click += new System.EventHandler(this.BtnPausarModos_Click);
            // 
            // BtnContinuarModos
            // 
            this.BtnContinuarModos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnContinuarModos.Location = new System.Drawing.Point(0, 53);
            this.BtnContinuarModos.Name = "BtnContinuarModos";
            this.BtnContinuarModos.Size = new System.Drawing.Size(1225, 28);
            this.BtnContinuarModos.TabIndex = 4;
            this.BtnContinuarModos.Text = "Continuar";
            this.BtnContinuarModos.UseVisualStyleBackColor = true;
            this.BtnContinuarModos.Click += new System.EventHandler(this.BtnContinuarModos_Click);
            // 
            // LblInfoModos
            // 
            this.LblInfoModos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(178)))), ((int)(((byte)(203)))));
            this.LblInfoModos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblInfoModos.Location = new System.Drawing.Point(3, 3);
            this.LblInfoModos.Name = "LblInfoModos";
            this.LblInfoModos.Size = new System.Drawing.Size(1225, 26);
            this.LblInfoModos.TabIndex = 2;
            this.LblInfoModos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerReproducir
            // 
            this.TimerReproducir.Interval = 2000;
            this.TimerReproducir.Tick += new System.EventHandler(this.TimerReproducir_Tick);
            // 
            // DlgManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 700);
            this.Controls.Add(this.TbcManuales);
            this.Controls.Add(this.PnlArribaManual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DlgManual_FormClosing);
            this.PnlArribaManual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizarManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarManual)).EndInit();
            this.TbcManuales.ResumeLayout(false);
            this.TpManualReproducir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagenReproducir)).EndInit();
            this.PnlControlesReproducir.ResumeLayout(false);
            this.TpManualModos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagenModos)).EndInit();
            this.PnlControlesModos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlArribaManual;
        private System.Windows.Forms.PictureBox PtbMinimizarManual;
        private System.Windows.Forms.PictureBox PtbCerrarManual;
        private System.Windows.Forms.TabControl TbcManuales;
        private System.Windows.Forms.TabPage TpManualReproducir;
        private System.Windows.Forms.Panel PnlControlesReproducir;
        private System.Windows.Forms.TabPage TpManualModos;
        private System.Windows.Forms.Button BtnPausarReproducir;
        private System.Windows.Forms.Label LblInfoReproducir;
        private System.Windows.Forms.PictureBox PtbImagenReproducir;
        private System.Windows.Forms.Timer TimerReproducir;
        private System.Windows.Forms.Button BtnAutomaticoReproducir;
        private System.Windows.Forms.Button BtnContinuarReproducir;
        private System.Windows.Forms.Panel PnlControlesModos;
        private System.Windows.Forms.Button BtnAutomaticoModos;
        private System.Windows.Forms.Button BtnPausarModos;
        private System.Windows.Forms.Button BtnContinuarModos;
        private System.Windows.Forms.Label LblInfoModos;
        private System.Windows.Forms.PictureBox PtbImagenModos;
    }
}