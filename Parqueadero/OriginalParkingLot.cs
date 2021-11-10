using System;
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
    public partial class OriginalParkingLot : Form
    {

        public OriginalParkingLot()
        {
            InitializeComponent();
        }

        public Dictionary<int, Vehicle> carro = new Dictionary<int, Vehicle>();

        private void OriginalParkingLot_Load(object sender, EventArgs e)
        {
            PrincipalParking principalparking = new PrincipalParking(carro)
            {
                MdiParent = this
            };
            this.Size = new Size(principalparking.Size.Width + 100, principalparking.Size.Height + 100);
            principalparking.Show();

        }

    }
}
