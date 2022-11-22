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
        private string idPuesto = null;
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
            limpiarForm();
        }

        private void limpiarForm()
        {
            txtDenominacion.Clear();
            txtDias.Clear();
            txtHs.Clear();
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
            dgvLiquidaciones.Columns.Insert(9, columnaBorrar);

            //Boton Editar
            Icon iconoEditar = new Icon(Environment.CurrentDirectory + @"\\edit2.ico");
            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            columnaEditar.Image = iconoEditar.ToBitmap();
            columnaEditar.Name = "Modificar";
            columnaEditar.HeaderText = "Modificar";
            columnaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaEditar.ToolTipText = "Modificar Registros";
            dgvLiquidaciones.Columns.Insert(10, columnaEditar);
        }

        private void dgvLiquidaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //paso los datos al form
            txtDenominacion.Text = dgvLiquidaciones.CurrentRow.Cells["Puesto"].Value.ToString();
            txtHs.Text = dgvLiquidaciones.CurrentRow.Cells["HsSemanales"].Value.ToString();
            txtDias.Text = dgvLiquidaciones.CurrentRow.Cells["DiasSemana"].Value.ToString();
            txtSueldo.Text = dgvLiquidaciones.CurrentRow.Cells["SueldoBruto"].Value.ToString();
            txtExtras.Text = dgvLiquidaciones.CurrentRow.Cells["ValorHoraExtra"].Value.ToString();
            idPuesto = dgvLiquidaciones.CurrentRow.Cells["Id"].Value.ToString();
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

        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
