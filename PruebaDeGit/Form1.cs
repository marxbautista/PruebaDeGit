﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeGit
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void marioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo Git");
        }

        private void isaiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void imprimeParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
Procesos objeto = new Procesos();

            frmPares pares = new frmPares();
            pares.MdiParent = this;
            pares.Texto = objeto.pares(2, 10);
            pares.Show();
        }
    }
}
