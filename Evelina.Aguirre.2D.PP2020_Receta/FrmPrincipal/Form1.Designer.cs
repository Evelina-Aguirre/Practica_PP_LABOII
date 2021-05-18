
namespace FrmPrincipal
{
    partial class Form1
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
            this.rtbSalidaDeText = new System.Windows.Forms.RichTextBox();
            this.btnImprimirReceta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSalidaDeText
            // 
            this.rtbSalidaDeText.Location = new System.Drawing.Point(12, 12);
            this.rtbSalidaDeText.Name = "rtbSalidaDeText";
            this.rtbSalidaDeText.Size = new System.Drawing.Size(776, 398);
            this.rtbSalidaDeText.TabIndex = 0;
            this.rtbSalidaDeText.Text = "";
            this.rtbSalidaDeText.TextChanged += new System.EventHandler(this.rtbSalidaDeText_TextChanged);
            // 
            // btnImprimirReceta
            // 
            this.btnImprimirReceta.Location = new System.Drawing.Point(147, 415);
            this.btnImprimirReceta.Name = "btnImprimirReceta";
            this.btnImprimirReceta.Size = new System.Drawing.Size(528, 23);
            this.btnImprimirReceta.TabIndex = 1;
            this.btnImprimirReceta.Text = "Imprimir Receta";
            this.btnImprimirReceta.UseVisualStyleBackColor = true;
            this.btnImprimirReceta.Click += new System.EventHandler(this.btnImprimirReceta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimirReceta);
            this.Controls.Add(this.rtbSalidaDeText);
            this.Name = "Form1";
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalidaDeText;
        private System.Windows.Forms.Button btnImprimirReceta;
    }
}

