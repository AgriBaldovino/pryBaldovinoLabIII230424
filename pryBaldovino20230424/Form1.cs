using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaldovino20230424
{
    public partial class frmMinYMax : Form
    {
        public frmMinYMax()
        {
            InitializeComponent();
        }

        Int32 minima;
        Int32 maxima;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void frmMinYMax_Load(object sender, EventArgs e)
        {
            clsLocalidades Loc = new clsLocalidades();
            cbLocalidades.DisplayMember = "Nombre";
            cbLocalidades.ValueMember = "Localidad";
            cbLocalidades.DataSource = Loc.getLocalidades();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int localidadSeleccionada = Convert.ToInt32(cbLocalidades.SelectedValue);
            string fechaForm = dtpFecha.Value.ToString("dd/MM/yyyy");

            clsTemperaturas Temperatura = new clsTemperaturas();
            DataTable tabla = Temperatura.getTemperaturas();
            foreach (DataRow fila in tabla.Rows)
            {
                if (Convert.ToInt32(fila["localidad"]) == localidadSeleccionada)
                {
                    DateTime fechaBase = Convert.ToDateTime(fila["fecha"]);
                    string fechaFormBase = fechaBase.ToString("dd/MM/yyyy");
                    

                    if ( fechaForm == fechaFormBase)
                    {
                        minima = Convert.ToInt32(fila["minima"]);
                        maxima = Convert.ToInt32(fila["maxima"]);
                    }
                                
                }


                txtMinima.Text = Convert.ToString(minima);
                txtMaxima.Text = Convert.ToString(maxima);
            }
        }
    }
}
