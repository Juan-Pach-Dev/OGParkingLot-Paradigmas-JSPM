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
    public partial class IngresarParking : Form
    {
        public Dictionary<int, Vehicle> guardar;
        public IngresarParking(Dictionary<int, Vehicle> almacenar)
        {
            InitializeComponent();
            almacenar = guardar;
        }

        private void Btnconfirmar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    if (guardar.Count == 0)
                    {
                        guardar.Add(i, new Vehicle { Marca = Txtmarca.Text, Placa = Txtplaca.Text, Tipo = Cbxtipo.Text, Genero = Txtgenero.Text, Identificacion = Txtidentificacion.Text , Afiliado = Chbafiliado.Checked, Time = DateTime.Now});
                        break;
                    }

                    if (guardar[i].Placa != null)
                    {
                        continue;
                    }
                }
                catch
                {                   
                    guardar.Add(i, new Vehicle { Marca = Txtmarca.Text, Placa = Txtplaca.Text, Tipo = Cbxtipo.Text, Genero = Txtgenero.Text, Identificacion = Txtidentificacion.Text, Afiliado = Chbafiliado.Checked, Time = DateTime.Now });
                    break;
                }
            }
        }
    }
}

