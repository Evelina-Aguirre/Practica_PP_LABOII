
namespace FrmTester
{
    partial class FrmTester
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstStock = new System.Windows.Forms.ListBox();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.btn_VerInformne = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.Location = new System.Drawing.Point(12, 12);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(271, 264);
            this.lstStock.TabIndex = 0;
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(289, 12);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.ReadOnly = true;
            this.rtbInforme.Size = new System.Drawing.Size(499, 426);
            this.rtbInforme.TabIndex = 1;
            this.rtbInforme.Text = "";
            // 
            // btn_Vender
            // 
            this.btn_Vender.Location = new System.Drawing.Point(12, 282);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(260, 43);
            this.btn_Vender.TabIndex = 2;
            this.btn_Vender.Text = "Vender";
            this.btn_Vender.UseVisualStyleBackColor = true;
            this.btn_Vender.Click += new System.EventHandler(this.btn_Vender_Click);
            // 
            // btn_VerInformne
            // 
            this.btn_VerInformne.Location = new System.Drawing.Point(12, 332);
            this.btn_VerInformne.Name = "btn_VerInformne";
            this.btn_VerInformne.Size = new System.Drawing.Size(260, 43);
            this.btn_VerInformne.TabIndex = 3;
            this.btn_VerInformne.Text = "Ver Informe";
            this.btn_VerInformne.UseVisualStyleBackColor = true;
            this.btn_VerInformne.Click += new System.EventHandler(this.btn_VerInformne_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(12, 381);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(260, 43);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FrmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_VerInformne);
            this.Controls.Add(this.btn_Vender);
            this.Controls.Add(this.rtbInforme);
            this.Controls.Add(this.lstStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testear App de Evelina Aguirre (2°D)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTester_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.Button btn_Vender;
        private System.Windows.Forms.Button btn_VerInformne;
        private System.Windows.Forms.Button btn_Salir;
    }
}

