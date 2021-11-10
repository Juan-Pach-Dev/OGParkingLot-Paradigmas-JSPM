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
                            Lblnombre1.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo1.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo1.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";

                        }
                        if (p == 1)
                        {
                            Lblnombre2.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo2.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo2.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
                        }
                        if (p == 2)
                        {
                            Lblnombre3.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo3.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo3.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
                        }
                        if (p == 3)
                        {
                            Lblnombre4.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo4.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo4.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
                        }
                        if (p == 4)
                        {
                            Lblnombre5.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo5.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo5.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
                        }
                        if (p == 5)
                        {
                            Lblnombre6.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo6.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo6.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
                        }
                        if (p == 6)
                        {
                            Lblnombre7.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo7.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo7.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
                        }
                        if (p == 7)
                        {
                            Lblnombre8.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo8.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo8.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
                        }
                        if (p == 8)
                        {
                            Lblnombre9.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo9.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo9.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
                        }
                        if (p == 9)
                        {
                            Lblnombre10.Text = $"No Disponible\n  {principalparking[p].Marca}\n";
                            Lblplacavehiculo10.Text = $"No Disponible\n  {principalparking[p].Placa}\n";
                            Lbltipovehiculo10.Text = $"No Disponible\n  {principalparking[p].Tipo}\n";
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
            IngresarParking PLot = new IngresarParking(principalparking)
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
