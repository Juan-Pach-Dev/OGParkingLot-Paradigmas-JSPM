
namespace OGParkingLot_Paradigmas_JSPM.Parqueadero
{
    partial class SalidaParking
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
            this.Lblsalida = new System.Windows.Forms.Label();
            this.Lblsalidaplaca = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lblsalida
            // 
            this.Lblsalida.AutoSize = true;
            this.Lblsalida.Location = new System.Drawing.Point(232, 55);
            this.Lblsalida.Name = "Lblsalida";
            this.Lblsalida.Size = new System.Drawing.Size(286, 13);
            this.Lblsalida.TabIndex = 0;
            this.Lblsalida.Text = "Para salir del Parking ingrese los datos del vehiculo a retirar";
            // 
            // Lblsalidaplaca
            // 
            this.Lblsalidaplaca.AutoSize = true;
            this.Lblsalidaplaca.Location = new System.Drawing.Point(232, 107);
            this.Lblsalidaplaca.Name = "Lblsalidaplaca";
            this.Lblsalidaplaca.Size = new System.Drawing.Size(34, 13);
            this.Lblsalidaplaca.TabIndex = 1;
            this.Lblsalidaplaca.Text = "Placa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // SalidaParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lblsalidaplaca);
            this.Controls.Add(this.Lblsalida);
            this.Name = "SalidaParking";
            this.Text = "SalidaParking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblsalida;
        private System.Windows.Forms.Label Lblsalidaplaca;
        private System.Windows.Forms.TextBox textBox1;
    }
}