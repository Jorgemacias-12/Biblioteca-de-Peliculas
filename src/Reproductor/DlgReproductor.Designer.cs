namespace Biblioteca_de_Peliculas.src.Reproductor
{
    partial class DlgReproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgReproductor));
            this.PnlReproductorContainer = new System.Windows.Forms.Panel();
            this.PnlControls = new System.Windows.Forms.Panel();
            this.PnlVolumeControls = new System.Windows.Forms.Panel();
            this.MtbVolume = new XComponent.SliderBar.MACTrackBar();
            this.LblVolumeIndicator = new System.Windows.Forms.Label();
            this.BtnAudio = new System.Windows.Forms.Button();
            this.PnlControlContainer = new System.Windows.Forms.Panel();
            this.BtnTimeIncrease = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnTimeDecrease = new System.Windows.Forms.Button();
            this.LblTimeEnd = new System.Windows.Forms.Label();
            this.LblTimeStart = new System.Windows.Forms.Label();
            this.MtbTimeLine = new XComponent.SliderBar.MACTrackBar();
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MsMenu = new System.Windows.Forms.MenuStrip();
            this.TsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Counter = new System.Windows.Forms.Timer(this.components);
            this.PnlReproductorContainer.SuspendLayout();
            this.PnlControls.SuspendLayout();
            this.PnlVolumeControls.SuspendLayout();
            this.PnlControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.MsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlReproductorContainer
            // 
            this.PnlReproductorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PnlReproductorContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlReproductorContainer.Controls.Add(this.PnlControls);
            this.PnlReproductorContainer.Controls.Add(this.wmpPlayer);
            this.PnlReproductorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlReproductorContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlReproductorContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlReproductorContainer.Name = "PnlReproductorContainer";
            this.PnlReproductorContainer.Size = new System.Drawing.Size(1280, 720);
            this.PnlReproductorContainer.TabIndex = 0;
            // 
            // PnlControls
            // 
            this.PnlControls.Controls.Add(this.PnlVolumeControls);
            this.PnlControls.Controls.Add(this.PnlControlContainer);
            this.PnlControls.Controls.Add(this.LblTimeEnd);
            this.PnlControls.Controls.Add(this.LblTimeStart);
            this.PnlControls.Controls.Add(this.MtbTimeLine);
            this.PnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlControls.Location = new System.Drawing.Point(0, 591);
            this.PnlControls.Name = "PnlControls";
            this.PnlControls.Size = new System.Drawing.Size(1278, 127);
            this.PnlControls.TabIndex = 2;
            // 
            // PnlVolumeControls
            // 
            this.PnlVolumeControls.Controls.Add(this.MtbVolume);
            this.PnlVolumeControls.Controls.Add(this.LblVolumeIndicator);
            this.PnlVolumeControls.Controls.Add(this.BtnAudio);
            this.PnlVolumeControls.Location = new System.Drawing.Point(901, 36);
            this.PnlVolumeControls.Name = "PnlVolumeControls";
            this.PnlVolumeControls.Size = new System.Drawing.Size(303, 51);
            this.PnlVolumeControls.TabIndex = 15;
            // 
            // MtbVolume
            // 
            this.MtbVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MtbVolume.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MtbVolume.BorderStyle = XComponent.SliderBar.MACBorderStyle.Inset;
            this.MtbVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbVolume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbVolume.IndentHeight = 17;
            this.MtbVolume.IndentWidth = 5;
            this.MtbVolume.LargeChange = 1;
            this.MtbVolume.Location = new System.Drawing.Point(48, 0);
            this.MtbVolume.Maximum = 100;
            this.MtbVolume.Minimum = 0;
            this.MtbVolume.Name = "MtbVolume";
            this.MtbVolume.Size = new System.Drawing.Size(212, 50);
            this.MtbVolume.TabIndex = 13;
            this.MtbVolume.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtbVolume.TickColor = System.Drawing.Color.White;
            this.MtbVolume.TickHeight = 1;
            this.MtbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MtbVolume.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.MtbVolume.TrackerSize = new System.Drawing.Size(16, 16);
            this.MtbVolume.TrackLineColor = System.Drawing.Color.White;
            this.MtbVolume.TrackLineHeight = 3;
            this.MtbVolume.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MtbVolume.Value = 50;
            this.MtbVolume.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtbVolume_ValueChanged);
            // 
            // LblVolumeIndicator
            // 
            this.LblVolumeIndicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblVolumeIndicator.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVolumeIndicator.ForeColor = System.Drawing.Color.White;
            this.LblVolumeIndicator.Location = new System.Drawing.Point(260, 0);
            this.LblVolumeIndicator.Name = "LblVolumeIndicator";
            this.LblVolumeIndicator.Size = new System.Drawing.Size(43, 51);
            this.LblVolumeIndicator.TabIndex = 12;
            this.LblVolumeIndicator.Text = "50";
            this.LblVolumeIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAudio
            // 
            this.BtnAudio.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAudio.FlatAppearance.BorderSize = 0;
            this.BtnAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAudio.Image = global::Biblioteca_de_Peliculas.Properties.Resources.no_audio;
            this.BtnAudio.Location = new System.Drawing.Point(0, 0);
            this.BtnAudio.Name = "BtnAudio";
            this.BtnAudio.Size = new System.Drawing.Size(48, 51);
            this.BtnAudio.TabIndex = 7;
            this.BtnAudio.UseVisualStyleBackColor = true;
            this.BtnAudio.Click += new System.EventHandler(this.BtnAudio_Click);
            // 
            // PnlControlContainer
            // 
            this.PnlControlContainer.AutoSize = true;
            this.PnlControlContainer.Controls.Add(this.BtnTimeIncrease);
            this.PnlControlContainer.Controls.Add(this.BtnNext);
            this.PnlControlContainer.Controls.Add(this.BtnStart);
            this.PnlControlContainer.Controls.Add(this.BtnPrevious);
            this.PnlControlContainer.Controls.Add(this.BtnTimeDecrease);
            this.PnlControlContainer.Location = new System.Drawing.Point(95, 36);
            this.PnlControlContainer.Name = "PnlControlContainer";
            this.PnlControlContainer.Size = new System.Drawing.Size(178, 51);
            this.PnlControlContainer.TabIndex = 14;
            // 
            // BtnTimeIncrease
            // 
            this.BtnTimeIncrease.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnTimeIncrease.FlatAppearance.BorderSize = 0;
            this.BtnTimeIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimeIncrease.Image = global::Biblioteca_de_Peliculas.Properties.Resources.fast_forward;
            this.BtnTimeIncrease.Location = new System.Drawing.Point(146, 0);
            this.BtnTimeIncrease.Name = "BtnTimeIncrease";
            this.BtnTimeIncrease.Size = new System.Drawing.Size(32, 51);
            this.BtnTimeIncrease.TabIndex = 20;
            this.BtnTimeIncrease.UseVisualStyleBackColor = true;
            this.BtnTimeIncrease.Click += new System.EventHandler(this.BtnTimeIncrease_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Image = global::Biblioteca_de_Peliculas.Properties.Resources.next;
            this.BtnNext.Location = new System.Drawing.Point(114, 0);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(32, 51);
            this.BtnNext.TabIndex = 19;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Image = global::Biblioteca_de_Peliculas.Properties.Resources.stop;
            this.BtnStart.Location = new System.Drawing.Point(64, 0);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(50, 51);
            this.BtnStart.TabIndex = 18;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnPrevious.FlatAppearance.BorderSize = 0;
            this.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevious.Image = global::Biblioteca_de_Peliculas.Properties.Resources.previous;
            this.BtnPrevious.Location = new System.Drawing.Point(32, 0);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(32, 51);
            this.BtnPrevious.TabIndex = 14;
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnTimeDecrease
            // 
            this.BtnTimeDecrease.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnTimeDecrease.FlatAppearance.BorderSize = 0;
            this.BtnTimeDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimeDecrease.Image = global::Biblioteca_de_Peliculas.Properties.Resources.rewind;
            this.BtnTimeDecrease.Location = new System.Drawing.Point(0, 0);
            this.BtnTimeDecrease.Name = "BtnTimeDecrease";
            this.BtnTimeDecrease.Size = new System.Drawing.Size(32, 51);
            this.BtnTimeDecrease.TabIndex = 12;
            this.BtnTimeDecrease.UseVisualStyleBackColor = true;
            this.BtnTimeDecrease.Click += new System.EventHandler(this.BtnTimeDecrease_Click);
            // 
            // LblTimeEnd
            // 
            this.LblTimeEnd.AutoSize = true;
            this.LblTimeEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblTimeEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeEnd.ForeColor = System.Drawing.Color.White;
            this.LblTimeEnd.Location = new System.Drawing.Point(1210, 30);
            this.LblTimeEnd.Name = "LblTimeEnd";
            this.LblTimeEnd.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.LblTimeEnd.Size = new System.Drawing.Size(68, 17);
            this.LblTimeEnd.TabIndex = 3;
            this.LblTimeEnd.Text = "00:00:00";
            this.LblTimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTimeStart
            // 
            this.LblTimeStart.AutoSize = true;
            this.LblTimeStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTimeStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeStart.ForeColor = System.Drawing.Color.White;
            this.LblTimeStart.Location = new System.Drawing.Point(0, 30);
            this.LblTimeStart.Margin = new System.Windows.Forms.Padding(0);
            this.LblTimeStart.Name = "LblTimeStart";
            this.LblTimeStart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LblTimeStart.Size = new System.Drawing.Size(68, 17);
            this.LblTimeStart.TabIndex = 2;
            this.LblTimeStart.Text = "00:00:00";
            this.LblTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MtbTimeLine
            // 
            this.MtbTimeLine.BackColor = System.Drawing.Color.Transparent;
            this.MtbTimeLine.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.MtbTimeLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.MtbTimeLine.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbTimeLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbTimeLine.IndentHeight = 6;
            this.MtbTimeLine.Location = new System.Drawing.Point(0, 0);
            this.MtbTimeLine.Maximum = 100;
            this.MtbTimeLine.Minimum = 0;
            this.MtbTimeLine.Name = "MtbTimeLine";
            this.MtbTimeLine.Size = new System.Drawing.Size(1278, 30);
            this.MtbTimeLine.TabIndex = 1;
            this.MtbTimeLine.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtbTimeLine.TickColor = System.Drawing.Color.Transparent;
            this.MtbTimeLine.TickHeight = 1;
            this.MtbTimeLine.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.MtbTimeLine.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.MtbTimeLine.TrackerSize = new System.Drawing.Size(16, 16);
            this.MtbTimeLine.TrackLineColor = System.Drawing.Color.White;
            this.MtbTimeLine.TrackLineHeight = 5;
            this.MtbTimeLine.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MtbTimeLine.Value = 0;
            this.MtbTimeLine.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtbTimeLine_ValueChanged);
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(0, 0);
            this.wmpPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(1278, 718);
            this.wmpPlayer.TabIndex = 1;
            // 
            // MsMenu
            // 
            this.MsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiOptions});
            this.MsMenu.Location = new System.Drawing.Point(0, 0);
            this.MsMenu.Name = "MsMenu";
            this.MsMenu.Size = new System.Drawing.Size(1280, 25);
            this.MsMenu.TabIndex = 17;
            this.MsMenu.Text = "menuStrip1";
            // 
            // TsmiOptions
            // 
            this.TsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.abrirCarpetaToolStripMenuItem});
            this.TsmiOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmiOptions.ForeColor = System.Drawing.Color.White;
            this.TsmiOptions.Name = "TsmiOptions";
            this.TsmiOptions.Size = new System.Drawing.Size(75, 21);
            this.TsmiOptions.Text = "Opciones";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.AbrirArchivoToolStripMenuItem_Click);
            // 
            // abrirCarpetaToolStripMenuItem
            // 
            this.abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
            this.abrirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.abrirCarpetaToolStripMenuItem.Text = "Abrir carpeta";
            this.abrirCarpetaToolStripMenuItem.Click += new System.EventHandler(this.AbrirCarpetaToolStripMenuItem_Click);
            // 
            // Counter
            // 
            this.Counter.Tick += new System.EventHandler(this.Counter_Tick);
            // 
            // DlgReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MsMenu);
            this.Controls.Add(this.PnlReproductorContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgReproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.DlgReproductor_Load);
            this.Resize += new System.EventHandler(this.DlgReproductor_Resize);
            this.PnlReproductorContainer.ResumeLayout(false);
            this.PnlControls.ResumeLayout(false);
            this.PnlControls.PerformLayout();
            this.PnlVolumeControls.ResumeLayout(false);
            this.PnlControlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.MsMenu.ResumeLayout(false);
            this.MsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlReproductorContainer;
        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        private System.Windows.Forms.Panel PnlControls;
        private XComponent.SliderBar.MACTrackBar MtbTimeLine;
        private System.Windows.Forms.Label LblTimeStart;
        private System.Windows.Forms.Label LblTimeEnd;
        private System.Windows.Forms.Button BtnTimeDecrease;
        private System.Windows.Forms.Panel PnlControlContainer;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnTimeIncrease;
        private System.Windows.Forms.Panel PnlVolumeControls;
        private System.Windows.Forms.Button BtnAudio;
        private System.Windows.Forms.Label LblVolumeIndicator;
        private XComponent.SliderBar.MACTrackBar MtbVolume;
        private System.Windows.Forms.MenuStrip MsMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaToolStripMenuItem;
        private System.Windows.Forms.Timer Counter;
    }
}