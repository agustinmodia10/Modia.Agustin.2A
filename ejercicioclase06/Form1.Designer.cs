﻿namespace ejercicioclase06
{
    partial class btnsalir
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tINTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLUMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(243, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINISTRARToolStripMenuItem
            // 
            this.aDMINISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tINTAToolStripMenuItem,
            this.pLUMAToolStripMenuItem});
            this.aDMINISTRARToolStripMenuItem.Name = "aDMINISTRARToolStripMenuItem";
            this.aDMINISTRARToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.aDMINISTRARToolStripMenuItem.Text = "ADMINISTRAR";
            // 
            // tINTAToolStripMenuItem
            // 
            this.tINTAToolStripMenuItem.Name = "tINTAToolStripMenuItem";
            this.tINTAToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.tINTAToolStripMenuItem.Text = "TINTA";
            this.tINTAToolStripMenuItem.Click += new System.EventHandler(this.tINTAToolStripMenuItem_Click);
            // 
            // pLUMAToolStripMenuItem
            // 
            this.pLUMAToolStripMenuItem.Name = "pLUMAToolStripMenuItem";
            this.pLUMAToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.pLUMAToolStripMenuItem.Text = "PLUMA";
            this.pLUMAToolStripMenuItem.Click += new System.EventHandler(this.pLUMAToolStripMenuItem_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(121, 170);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 1;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // btnsalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 223);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "btnsalir";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tINTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLUMAToolStripMenuItem;
        private System.Windows.Forms.Button salir;
    }
}