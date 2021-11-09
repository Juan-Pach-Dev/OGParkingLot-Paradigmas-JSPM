
namespace OGParkingLot_Paradigmas_JSPM.Parqueadero
{
    partial class Parking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lblnombre = new System.Windows.Forms.Label();
            this.Lblplacavehiculo = new System.Windows.Forms.Label();
            this.Lbltipovehiculo = new System.Windows.Forms.Label();
            this.Btningresar = new System.Windows.Forms.Button();
            this.Btnsacar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbltipovehiculo);
            this.panel1.Controls.Add(this.Lblplacavehiculo);
            this.panel1.Controls.Add(this.Lblnombre);
            this.panel1.Location = new System.Drawing.Point(346, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 133);
            this.panel1.TabIndex = 0;
            // 
            // Lblnombre
            // 
            this.Lblnombre.AutoSize = true;
            this.Lblnombre.Location = new System.Drawing.Point(3, 9);
            this.Lblnombre.Name = "Lblnombre";
            this.Lblnombre.Size = new System.Drawing.Size(44, 13);
            this.Lblnombre.TabIndex = 0;
            this.Lblnombre.Text = "Nombre";
            // 
            // Lblplacavehiculo
            // 
            this.Lblplacavehiculo.AutoSize = true;
            this.Lblplacavehiculo.Location = new System.Drawing.Point(3, 60);
            this.Lblplacavehiculo.Name = "Lblplacavehiculo";
            this.Lblplacavehiculo.Size = new System.Drawing.Size(34, 13);
            this.Lblplacavehiculo.TabIndex = 1;
            this.Lblplacavehiculo.Text = "Placa";
            // 
            // Lbltipovehiculo
            // 
            this.Lbltipovehiculo.AutoSize = true;
            this.Lbltipovehiculo.Location = new System.Drawing.Point(3, 113);
            this.Lbltipovehiculo.Name = "Lbltipovehiculo";
            this.Lbltipovehiculo.Size = new System.Drawing.Size(87, 13);
            this.Lbltipovehiculo.TabIndex = 2;
            this.Lbltipovehiculo.Text = "Tipo de Vehiculo";
            // 
            // Btningresar
            // 
            this.Btningresar.Location = new System.Drawing.Point(226, 138);
            this.Btningresar.Name = "Btningresar";
            this.Btningresar.Size = new System.Drawing.Size(91, 51);
            this.Btningresar.TabIndex = 1;
            this.Btningresar.Text = "Ingresar un Vehiculo";
            this.Btningresar.UseVisualStyleBackColor = true;
            this.Btningresar.Click += new System.EventHandler(this.Btningresar_Click);
            // 
            // Btnsacar
            // 
            this.Btnsacar.Location = new System.Drawing.Point(226, 208);
            this.Btnsacar.Name = "Btnsacar";
            this.Btnsacar.Size = new System.Drawing.Size(91, 47);
            this.Btnsacar.TabIndex = 2;
            this.Btnsacar.Text = "Retirar un Vehiculo";
            this.Btnsacar.UseVisualStyleBackColor = true;
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnsacar);
            this.Controls.Add(this.Btningresar);
            this.Controls.Add(this.panel1);
            this.Name = "Parking";
            this.Text = "Parking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbltipovehiculo;
        private System.Windows.Forms.Label Lblplacavehiculo;
        private System.Windows.Forms.Label Lblnombre;
        private System.Windows.Forms.Button Btningresar;
        private System.Windows.Forms.Button Btnsacar;
    }
}