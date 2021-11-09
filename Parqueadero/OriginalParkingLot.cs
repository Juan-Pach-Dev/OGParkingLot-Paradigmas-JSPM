using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGParkingLot_Paradigmas_JSPM.Parqueadero
{
    public partial class OriginalParkingLot : Form
    {
        private int childFormNumber = 0;

        public OriginalParkingLot()
        {
            InitializeComponent();
        }

        private void OriginalParkingLot_Load(object sender, EventArgs e)
        {
            PrincipalParking principalparking = new PrincipalParking
            {
                MdiParent = this
            };
            this.Size = new Size(principalparking.Size.Width + 35, principalparking.Size.Height + 60);
            principalparking.Show();

        }
    }
}
