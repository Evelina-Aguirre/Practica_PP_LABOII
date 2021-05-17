using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Contador_Evelina_Aguirre_2D
{
    public partial class Informes : Form
    {
        Bar miBar;
        public Informes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                MessageBox.Show("Error, completar los campos");
            }
           else
            {
                

            }
        }
    }
}
