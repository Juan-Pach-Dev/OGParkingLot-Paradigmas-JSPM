﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OGParkingLot_Paradigmas_JSPM.Parqueadero;

namespace OGParkingLot_Paradigmas_JSPM.Parqueadero
{
    public partial class PrincipalParking : Form
    {
        public PrincipalParking()
        {
            InitializeComponent();
        }
        
        private void Btningresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarParking ingresarvehiculo = new IngresarParking
            {
                MdiParent = this.MdiParent
            };
            MdiParent.Size = new Size(ingresarvehiculo.Size.Width + 100, ingresarvehiculo.Size.Height + 100);
            ingresarvehiculo.Show();
            this.Close();

        }
    }
}
