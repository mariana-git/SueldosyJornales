using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ControlesDeUsuario
{
    public partial class UC_Liquidaciones : UserControl
    {
        #region ATRIBUTOS
        private string idLiquidacion = null;
        private bool Editar = false;
        #endregion

        #region CONSTRUCTOR
        public UC_Liquidaciones()
        {
            InitializeComponent();
            MostrarLiquidaciones("");
        }
        #endregion

        #region METODOS
        private void txtHs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar) | char.ToString(e.KeyChar) == ",") e.Handled = false;
            else e.Handled = true;
        }
        private void txtExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar) | char.ToString(e.KeyChar) == ",") e.Handled = false;
            else e.Handled = true;
        }

        private void MostrarLiquidaciones(string dato)
        {
            CN_Liquidaciones PuestosCN = new CN_Liquidaciones();
            dgvLiquidaciones.DataSource = null;
            dgvLiquidaciones.Columns.Clear();
            dgvLiquidaciones.DataSource = PuestosCN.MostrarLiquidaciones(busqueda.Text);
            OpcionesDgv();
            BotonesEditarEliminar();
            dgvLiquidaciones.Columns["IdLiquidacion"].Visible = false;
            dgvLiquidaciones.Columns["Jubilación"].Visible = false; 
            dgvLiquidaciones.Columns["ObraSocial"].Visible = false;
            dgvLiquidaciones.Columns["PAMI"].Visible = false;
            dgvLiquidaciones.Columns["Bonos"].Visible = false;
            dgvLiquidaciones.Columns["HsExtra"].Visible = false;
            dgvLiquidaciones.Columns["Anticipos"].Visible = false;


            limpiarForm();
        }

        private void limpiarForm()
        {
            //txtDenominacion.Clear();
            txtJubilacion.Clear();
            txtBruto.Clear();
            gbx.Enabled = false;
            btnEliminar.Visible = false;
        }

        private void OpcionesDgv()
        {
            dgvLiquidaciones.BringToFront();
            dgvLiquidaciones.RowHeadersVisible = false; // no muestra la primera columna
            dgvLiquidaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgvLiquidaciones.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvLiquidaciones.RowsDefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;//alterna colores de las filas
            dgvLiquidaciones.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;//alterna colores de las filas
            dgvLiquidaciones.AllowUserToAddRows = false; //desactiva la ultima fila 
            dgvLiquidaciones.MultiSelect = false; //desactiva la seleccion multiple
            dgvLiquidaciones.RowTemplate.Height = 35;// altura de row
            dgvLiquidaciones.DefaultCellStyle.Font = new Font("Roboto", 13, GraphicsUnit.Pixel);// fijo font
            dgvLiquidaciones.DefaultCellStyle.SelectionBackColor = Color.Black; //color seleccion de row
            dgvLiquidaciones.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;// color font de seleccion de row


        }

        private void BotonesEditarEliminar()
        {

            //Boton Borrar
            Icon iconoBorrar = new Icon(Environment.CurrentDirectory + @"\\delete2.ico");
            DataGridViewImageColumn columnaBorrar = new DataGridViewImageColumn();
            columnaBorrar.Image = iconoBorrar.ToBitmap();
            columnaBorrar.Name = "Eliminar";
            columnaBorrar.HeaderText = "Eliminar";
            columnaBorrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaBorrar.ToolTipText = "Borrar Registros";
            dgvLiquidaciones.Columns.Insert(18, columnaBorrar);

            //Boton Editar
            Icon iconoEditar = new Icon(Environment.CurrentDirectory + @"\\edit2.ico");
            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            columnaEditar.Image = iconoEditar.ToBitmap();
            columnaEditar.Name = "Modificar";
            columnaEditar.HeaderText = "Modificar";
            columnaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaEditar.ToolTipText = "Modificar Registros";
            dgvLiquidaciones.Columns.Insert(19, columnaEditar);
        }


        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Liquidacion formulario2 = new Liquidacion(idLiquidacion);
            formulario2.Show();
        }

        private void dgvLiquidaciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //paso los datos al form

            txtMes.Text = dgvLiquidaciones.CurrentRow.Cells["Mes"].Value.ToString();
            txtAnio.Text = dgvLiquidaciones.CurrentRow.Cells["Año"].Value.ToString();
            txtConcepto.Text = dgvLiquidaciones.CurrentRow.Cells["Tipo"].Value.ToString();

            txtLegajo.Text = dgvLiquidaciones.CurrentRow.Cells["Legajo"].Value.ToString();
            txtNombre.Text = dgvLiquidaciones.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvLiquidaciones.CurrentRow.Cells["Apellido"].Value.ToString();
            txtCuil.Text = dgvLiquidaciones.CurrentRow.Cells["CUIL"].Value.ToString();

            txtIngreso.Text = dgvLiquidaciones.CurrentRow.Cells["FechaIngreso"].Value.ToString();
            txtPuesto.Text = dgvLiquidaciones.CurrentRow.Cells["Puesto"].Value.ToString();
            txtBruto.Text = dgvLiquidaciones.CurrentRow.Cells["Bruto"].Value.ToString();

            txtJubilacion.Text = dgvLiquidaciones.CurrentRow.Cells["Jubilación"].Value.ToString();
            txtOS.Text = dgvLiquidaciones.CurrentRow.Cells["ObraSocial"].Value.ToString();
            txtPAMI.Text = dgvLiquidaciones.CurrentRow.Cells["PAMI"].Value.ToString();

            txtBono.Text = dgvLiquidaciones.CurrentRow.Cells["Bonos"].Value.ToString();
            txtExtras.Text = dgvLiquidaciones.CurrentRow.Cells["HsExtra"].Value.ToString();
            txtAnticipos.Text = dgvLiquidaciones.CurrentRow.Cells["Anticipos"].Value.ToString();

            txtNeto.Text = dgvLiquidaciones.CurrentRow.Cells["Neto"].Value.ToString();
            idLiquidacion = dgvLiquidaciones.CurrentRow.Cells["IdLiquidacion"].Value.ToString();
            gbx.Enabled = true;

            if (dgvLiquidaciones.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                btnEliminar_Click(null, null);
            }
            else
            {
                Editar = true;
                btnEliminar.Visible = true;
            }
        }
    }
}
