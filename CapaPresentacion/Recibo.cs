using CapaPresentacion;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Recibo : Form
    {
        private DataTable dt;

        public Recibo(string idLiquidacion)
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
            CargarRecibos(idLiquidacion);
        }

        private void CargarRecibos(string idLiquidacion) {
            CN_Liquidaciones cN_Liquidaciones = new CN_Liquidaciones();
           

            dt = cN_Liquidaciones.MostrarLiquidacionId(idLiquidacion);

            DataRow fila = dt.Rows[0];
            lblAnio.Text = Convert.ToString(fila["Año"]);//se accede a los miembros por nombre de la columna de la consulta
            lblMes.Text = Convert.ToString(fila["Mes"]);
            lblConcepto.Text = Convert.ToString(fila["Tipo"]);
            lblNombre.Text = Convert.ToString(fila["Nombre"]);
            lblApellido.Text = Convert.ToString(fila["Apellido"]);
            lblCUIL.Text = Convert.ToString(fila["CUIL"]);
            lblLegajo.Text = Convert.ToString(fila["Legajo"]);
            lblIngreso.Text = Convert.ToString(fila["FechaIngreso"]);
            lblPuesto.Text = Convert.ToString(fila["Puesto"]);
            lblBruto.Text = Convert.ToString(fila["Bruto"]);
            lblAportes.Text = Convert.ToString(fila["Jubilación"]);
            lblOS.Text = Convert.ToString(fila["ObraSocial"]);
            lblPAMI.Text = Convert.ToString(fila["PAMI"]);
            lblBonos.Text = Convert.ToString(fila["Bonos"]);
            lblExtras.Text = Convert.ToString(fila["HsExtra"]);
            lblAnticipos.Text = Convert.ToString(fila["Anticipos"]);
            lblNro.Text = "0122"+Convert.ToString(fila["IdLiquidacion"]);

            decimal neto = Convert.ToDecimal(fila["Neto"]);
            lblNeto.Text = neto.ToString();
            lblSonPesos.Text = neto.NumeroALetras();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            Exportar.ExportarComoImagen(this);
        }       
    }
}
