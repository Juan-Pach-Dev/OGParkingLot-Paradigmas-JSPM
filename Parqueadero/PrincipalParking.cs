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
    public partial class PrincipalParking : Form
    {
        public Dictionary<int, Vehicle> principalparking;

        public PrincipalParking(Dictionary<int, Vehicle> auto)
        {
            InitializeComponent();
            principalparking = auto;
            for (int p = 0; p < 10; p++)
            {
                try
                {
                    if (principalparking[p].Placa==null)
                    { 
                        if (p == 0)
                        {
                            lbl1.Text = $"Ocupado\n  {principalparking[p].Placa}\n";
                        }
                        if (p == 1)
                        {
                            lbl2.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                        if (p == 2)
                        {
                            lbl3.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                        if (p == 3)
                        {
                            lbl4.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                        if (p == 4)
                        {
                            lbl5.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                        if (p == 5)
                        {
                            lbl6.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                        if (p == 6)
                        {
                            lbl7.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                        if (p == 7)
                        {
                            lbl8.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                        if (p == 8)
                        {
                            lbl9.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                        if (p == 9)
                        {
                            lbl10.Text = $"Ocupado\n{principalparking[p].Placa}";
                        }
                    }
                    

                }
                catch
                {
                    continue;
                }

            }
        }


        private void Btningresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarParking PLot = new IngresarParking
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = new Size(PLot.Size.Width + 20, PLot.Size.Height + 43);
            PLot.Show();
            this.Close();
        }

        private void ParkingLot_Load(object sender, EventArgs e)
        {
            // for (int x )
        }

        private void Btnsacar_Click (object sender, EventArgs e)
        {
            this.Hide();
            SalidaParking sacar = new SalidaParking
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = new Size(sacar.Size.Width + 20, sacar.Size.Height + 43);
            sacar.Show();
            this.Close();
        }
    }

}
