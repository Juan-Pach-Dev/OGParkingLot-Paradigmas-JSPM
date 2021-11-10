
namespace OGParkingLot_Paradigmas_JSPM.Parqueadero
{
    partial class IngresarParking
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
            this.Btnconfirmar = new System.Windows.Forms.Button();
            this.Lblafil = new System.Windows.Forms.Label();
            this.Txtidentificacion = new System.Windows.Forms.TextBox();
            this.Txtgenero = new System.Windows.Forms.TextBox();
            this.Lbltipo = new System.Windows.Forms.Label();
            this.Txtplaca = new System.Windows.Forms.TextBox();
            this.Lbldatovehiculo = new System.Windows.Forms.Label();
            this.Lbldatoconductor = new System.Windows.Forms.Label();
            this.Chbafiliado = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lblplaca = new System.Windows.Forms.Label();
            this.Lblgenero = new System.Windows.Forms.Label();
            this.Lblidentificacion = new System.Windows.Forms.Label();
            this.Lbldescripcion = new System.Windows.Forms.Label();
            this.Lblbienvenida = new System.Windows.Forms.Label();
            this.Txtmarca = new System.Windows.Forms.TextBox();
            this.Lblmarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnconfirmar
            // 
            this.Btnconfirmar.Location = new System.Drawing.Point(336, 393);
            this.Btnconfirmar.Name = "Btnconfirmar";
            this.Btnconfirmar.Size = new System.Drawing.Size(132, 30);
            this.Btnconfirmar.TabIndex = 36;
            this.Btnconfirmar.Text = "Confirmar Datos";
            this.Btnconfirmar.UseVisualStyleBackColor = true;
            this.Btnconfirmar.Click += new System.EventHandler(this.Btnconfirmar_Click);
            // 
            // Lblafil
            // 
            this.Lblafil.AutoSize = true;
            this.Lblafil.Location = new System.Drawing.Point(474, 306);
            this.Lblafil.Name = "Lblafil";
            this.Lblafil.Size = new System.Drawing.Size(147, 13);
            this.Lblafil.TabIndex = 35;
            this.Lblafil.Text = "Si es afiliado marque la casilla";
            // 
            // Txtidentificacion
            // 
            this.Txtidentificacion.Location = new System.Drawing.Point(320, 331);
            this.Txtidentificacion.Name = "Txtidentificacion";
            this.Txtidentificacion.Size = new System.Drawing.Size(100, 20);
            this.Txtidentificacion.TabIndex = 34;
            // 
            // Txtgenero
            // 
            this.Txtgenero.Location = new System.Drawing.Point(182, 332);
            this.Txtgenero.Name = "Txtgenero";
            this.Txtgenero.Size = new System.Drawing.Size(100, 20);
            this.Txtgenero.TabIndex = 33;
            // 
            // Lbltipo
            // 
            this.Lbltipo.AutoSize = true;
            this.Lbltipo.Location = new System.Drawing.Point(474, 173);
            this.Lbltipo.Name = "Lbltipo";
            this.Lbltipo.Size = new System.Drawing.Size(87, 13);
            this.Lbltipo.TabIndex = 32;
            this.Lbltipo.Text = "Tipo de Vehiculo";
            // 
            // Txtplaca
            // 
            this.Txtplaca.Location = new System.Drawing.Point(320, 207);
            this.Txtplaca.Name = "Txtplaca";
            this.Txtplaca.Size = new System.Drawing.Size(100, 20);
            this.Txtplaca.TabIndex = 31;
            // 
            // Lbldatovehiculo
            // 
            this.Lbldatovehiculo.AutoSize = true;
            this.Lbldatovehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldatovehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbldatovehiculo.Location = new System.Drawing.Point(332, 135);
            this.Lbldatovehiculo.Name = "Lbldatovehiculo";
            this.Lbldatovehiculo.Size = new System.Drawing.Size(145, 21);
            this.Lbldatovehiculo.TabIndex = 30;
            this.Lbldatovehiculo.Text = "Datos del Vehiculo";
            // 
            // Lbldatoconductor
            // 
            this.Lbldatoconductor.AutoSize = true;
            this.Lbldatoconductor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldatoconductor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbldatoconductor.Location = new System.Drawing.Point(332, 261);
            this.Lbldatoconductor.Name = "Lbldatoconductor";
            this.Lbldatoconductor.Size = new System.Drawing.Size(161, 21);
            this.Lbldatoconductor.TabIndex = 29;
            this.Lbldatoconductor.Text = "Datos del Conductor";
            // 
            // Chbafiliado
            // 
            this.Chbafiliado.AutoSize = true;
            this.Chbafiliado.Location = new System.Drawing.Point(477, 331);
            this.Chbafiliado.Name = "Chbafiliado";
            this.Chbafiliado.Size = new System.Drawing.Size(60, 17);
            this.Chbafiliado.TabIndex = 28;
            this.Chbafiliado.Text = "Afiliado";
            this.Chbafiliado.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Carro",
            "Camioneta",
            "Microbus"});
            this.comboBox1.Location = new System.Drawing.Point(474, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // Lblplaca
            // 
            this.Lblplaca.AutoSize = true;
            this.Lblplaca.Location = new System.Drawing.Point(317, 173);
            this.Lblplaca.Name = "Lblplaca";
            this.Lblplaca.Size = new System.Drawing.Size(34, 13);
            this.Lblplaca.TabIndex = 26;
            this.Lblplaca.Text = "Placa";
            // 
            // Lblgenero
            // 
            this.Lblgenero.AutoSize = true;
            this.Lblgenero.Location = new System.Drawing.Point(179, 306);
            this.Lblgenero.Name = "Lblgenero";
            this.Lblgenero.Size = new System.Drawing.Size(42, 13);
            this.Lblgenero.TabIndex = 25;
            this.Lblgenero.Text = "Genero";
            // 
            // Lblidentificacion
            // 
            this.Lblidentificacion.AutoSize = true;
            this.Lblidentificacion.Location = new System.Drawing.Point(317, 306);
            this.Lblidentificacion.Name = "Lblidentificacion";
            this.Lblidentificacion.Size = new System.Drawing.Size(70, 13);
            this.Lblidentificacion.TabIndex = 24;
            this.Lblidentificacion.Text = "Identificacion";
            // 
            // Lbldescripcion
            // 
            this.Lbldescripcion.AutoSize = true;
            this.Lbldescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbldescripcion.Location = new System.Drawing.Point(215, 71);
            this.Lbldescripcion.Name = "Lbldescripcion";
            this.Lbldescripcion.Size = new System.Drawing.Size(380, 21);
            this.Lbldescripcion.TabIndex = 23;
            this.Lbldescripcion.Text = "Para ingresar al Parking rellene los siguientes datos";
            // 
            // Lblbienvenida
            // 
            this.Lblbienvenida.AutoSize = true;
            this.Lblbienvenida.BackColor = System.Drawing.SystemColors.Window;
            this.Lblbienvenida.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblbienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lblbienvenida.Location = new System.Drawing.Point(294, 28);
            this.Lblbienvenida.Name = "Lblbienvenida";
            this.Lblbienvenida.Size = new System.Drawing.Size(207, 25);
            this.Lblbienvenida.TabIndex = 22;
            this.Lblbienvenida.Text = "Bienvenido al Parking";
            // 
            // Txtmarca
            // 
            this.Txtmarca.Location = new System.Drawing.Point(182, 207);
            this.Txtmarca.Name = "Txtmarca";
            this.Txtmarca.Size = new System.Drawing.Size(100, 20);
            this.Txtmarca.TabIndex = 21;
            // 
            // Lblmarca
            // 
            this.Lblmarca.AutoSize = true;
            this.Lblmarca.Location = new System.Drawing.Point(179, 173);
            this.Lblmarca.Name = "Lblmarca";
            this.Lblmarca.Size = new System.Drawing.Size(40, 13);
            this.Lblmarca.TabIndex = 20;
            this.Lblmarca.Text = "Marca ";
            // 
            // IngresarParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnconfirmar);
            this.Controls.Add(this.Lblafil);
            this.Controls.Add(this.Txtidentificacion);
            this.Controls.Add(this.Txtgenero);
            this.Controls.Add(this.Lbltipo);
            this.Controls.Add(this.Txtplaca);
            this.Controls.Add(this.Lbldatovehiculo);
            this.Controls.Add(this.Lbldatoconductor);
            this.Controls.Add(this.Chbafiliado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Lblplaca);
            this.Controls.Add(this.Lblgenero);
            this.Controls.Add(this.Lblidentificacion);
            this.Controls.Add(this.Lbldescripcion);
            this.Controls.Add(this.Lblbienvenida);
            this.Controls.Add(this.Txtmarca);
            this.Controls.Add(this.Lblmarca);
            this.Name = "IngresarParking";
            this.Text = "IngresarParking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnconfirmar;
        private System.Windows.Forms.Label Lblafil;
        private System.Windows.Forms.TextBox Txtidentificacion;
        private System.Windows.Forms.TextBox Txtgenero;
        private System.Windows.Forms.Label Lbltipo;
        private System.Windows.Forms.TextBox Txtplaca;
        private System.Windows.Forms.Label Lbldatovehiculo;
        private System.Windows.Forms.Label Lbldatoconductor;
        private System.Windows.Forms.CheckBox Chbafiliado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Lblplaca;
        private System.Windows.Forms.Label Lblgenero;
        private System.Windows.Forms.Label Lblidentificacion;
        private System.Windows.Forms.Label Lbldescripcion;
        private System.Windows.Forms.Label Lblbienvenida;
        private System.Windows.Forms.TextBox Txtmarca;
        private System.Windows.Forms.Label Lblmarca;
    }
}