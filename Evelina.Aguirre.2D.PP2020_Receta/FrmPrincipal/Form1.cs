﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Evelina.Aguirre._2D.PP2020_Receta;

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        Receta receta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.receta = new Receta(45);
            bool pudo = this.receta + new Rucula("Eruca sativa", 10);
            pudo = this.receta + new Rucula("Diplotaxis muralis", 15);
            pudo = this.receta + new QuesoAzul("Roquefort", 3,
            QuesoAzul.Procedencia.Francia);
            pudo = this.receta + new QuesoAzul("Clásico", 5);
            pudo = this.receta + new Pera("Dulce", 12, "Williams");
            if (this.receta + new Pera("Seca", 1, "Blanquilla"))
            {
                MessageBox.Show("Error", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void rtbSalidaDeText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnImprimirReceta_Click(object sender, EventArgs e)
        {
            rtbSalidaDeText.Text = receta.ToString();
        }
    }
}
