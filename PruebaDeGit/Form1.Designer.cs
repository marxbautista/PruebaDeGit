﻿namespace PruebaDeGit
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isaiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimeParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.abrirPDFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marioToolStripMenuItem,
            this.isaiasToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // marioToolStripMenuItem
            // 
            this.marioToolStripMenuItem.Name = "marioToolStripMenuItem";
            this.marioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marioToolStripMenuItem.Text = "Mario";
            this.marioToolStripMenuItem.Click += new System.EventHandler(this.marioToolStripMenuItem_Click);
            // 
            // isaiasToolStripMenuItem
            // 
            this.isaiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimeParesToolStripMenuItem});
            this.isaiasToolStripMenuItem.Name = "isaiasToolStripMenuItem";
            this.isaiasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.isaiasToolStripMenuItem.Text = "Isaias";
            this.isaiasToolStripMenuItem.Click += new System.EventHandler(this.isaiasToolStripMenuItem_Click);
            // 
            // imprimeParesToolStripMenuItem
            // 
            this.imprimeParesToolStripMenuItem.Name = "imprimeParesToolStripMenuItem";
            this.imprimeParesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.imprimeParesToolStripMenuItem.Text = "Imprime pares";
            this.imprimeParesToolStripMenuItem.Click += new System.EventHandler(this.imprimeParesToolStripMenuItem_Click);
            // 
            // abrirPDFToolStripMenuItem
            // 
            this.abrirPDFToolStripMenuItem.Name = "abrirPDFToolStripMenuItem";
            this.abrirPDFToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.abrirPDFToolStripMenuItem.Text = "Abrir PDF";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 511);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Formuladio principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isaiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimeParesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPDFToolStripMenuItem;
    }
}

