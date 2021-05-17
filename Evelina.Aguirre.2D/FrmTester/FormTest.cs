using Publicación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FrmTester
{
    public partial class FrmTester : Form
    {
        Vendedor miVendedor;

        public FrmTester()
        {
            InitializeComponent();
            miVendedor = new Vendedor("/..o Vendedora : María Luisa Del Valle");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            lstStock.Items.Add(p1);  //Agrego las publicaciones al listBox
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);



        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            if(this.miVendedor + (Publicacion)this.lstStock.SelectedItem)
            {
                MessageBox.Show("Venta Exitosa", "Vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Hay Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_VerInformne_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Text = Vendedor.InformeDeVentas(miVendedor);
        }


        private void FrmTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
