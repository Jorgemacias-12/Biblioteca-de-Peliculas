namespace Biblioteca_de_Peliculas.src.Categoria
{
    partial class DlgCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgCategoria));
            this.PnlCategoryContainer = new System.Windows.Forms.Panel();
            this.FlpMoviesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpStatusBar = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblCategory = new System.Windows.Forms.Label();
            this.PnlCategoryContainer.SuspendLayout();
            this.FlpStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCategoryContainer
            // 
            this.PnlCategoryContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PnlCategoryContainer.Controls.Add(this.FlpMoviesContainer);
            this.PnlCategoryContainer.Controls.Add(this.FlpStatusBar);
            this.PnlCategoryContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCategoryContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlCategoryContainer.Name = "PnlCategoryContainer";
            this.PnlCategoryContainer.Size = new System.Drawing.Size(968, 668);
            this.PnlCategoryContainer.TabIndex = 0;
            // 
            // FlpMoviesContainer
            // 
            this.FlpMoviesContainer.AutoScroll = true;
            this.FlpMoviesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpMoviesContainer.Location = new System.Drawing.Point(0, 32);
            this.FlpMoviesContainer.Margin = new System.Windows.Forms.Padding(0);
            this.FlpMoviesContainer.Name = "FlpMoviesContainer";
            this.FlpMoviesContainer.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.FlpMoviesContainer.Size = new System.Drawing.Size(968, 636);
            this.FlpMoviesContainer.TabIndex = 1;
            // 
            // FlpStatusBar
            // 
            this.FlpStatusBar.Controls.Add(this.BtnClose);
            this.FlpStatusBar.Controls.Add(this.LblCategory);
            this.FlpStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlpStatusBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpStatusBar.Location = new System.Drawing.Point(0, 0);
            this.FlpStatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.FlpStatusBar.Name = "FlpStatusBar";
            this.FlpStatusBar.Size = new System.Drawing.Size(968, 32);
            this.FlpStatusBar.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = global::Biblioteca_de_Peliculas.Properties.Resources.close;
            this.BtnClose.Location = new System.Drawing.Point(936, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(32, 32);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblCategory
            // 
            this.LblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.ForeColor = System.Drawing.Color.White;
            this.LblCategory.Location = new System.Drawing.Point(0, 0);
            this.LblCategory.Margin = new System.Windows.Forms.Padding(0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblCategory.Size = new System.Drawing.Size(936, 32);
            this.LblCategory.TabIndex = 1;
            this.LblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DlgCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 668);
            this.ControlBox = false;
            this.Controls.Add(this.PnlCategoryContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgCategoria";
            this.Load += new System.EventHandler(this.DlgCategoria_Load);
            this.Shown += new System.EventHandler(this.DlgCategoria_Shown);
            this.PnlCategoryContainer.ResumeLayout(false);
            this.FlpStatusBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCategoryContainer;
        private System.Windows.Forms.FlowLayoutPanel FlpStatusBar;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.FlowLayoutPanel FlpMoviesContainer;
    }
}