
namespace Campo_
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSalidaDeText
            // 
            this.rtbSalidaDeText.Location = new System.Drawing.Point(28, 62);
            this.rtbSalidaDeText.Name = "rtbSalidaDeText";
            this.rtbSalidaDeText.Size = new System.Drawing.Size(760, 376);
            this.rtbSalidaDeText.TabIndex = 0;
            this.rtbSalidaDeText.Text = "";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(28, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(760, 44);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Información Campo";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rtbSalidaDeText);
            this.Name = "Form1";
            this.Text = "Campo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalidaDeText;
        private System.Windows.Forms.Button btnMostrar;
    }
}

