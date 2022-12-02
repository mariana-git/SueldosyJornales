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
    public partial class UC_VerLiquidaciones : UserControl
    {
        #region ATRIBUTOS
        private string idLiquidacion = null;
        private bool Editar = false;
        string busqueda = "";
        string periodo = "";
        string mes = "";
        string tipo = "";
        string idperiodo = "";
        CN_Liquidaciones LiquidacionesCN = new CN_Liquidaciones();
        #endregion

        #region CONSTRUCTOR
        public UC_VerLiquidaciones()
        {
            InitializeComponent();
            //MostrarAnios();
            //MostrarMeses();
            //MostrarTipo();
            MostrarPeriodos();
            MostrarLiquidaciones();
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

        private void MostrarLiquidaciones()
        {
            CN_Liquidaciones PuestosCN = new CN_Liquidaciones();
            dgvLiquidaciones.DataSource = null;
            dgvLiquidaciones.Columns.Clear();
            dgvLiquidaciones.DataSource = PuestosCN.MostrarLiquidaciones("","");
            OpcionesDgv();
            BotonEliminar();
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
            foreach(Control controlGrup in gbx.Controls)
                    {
                if (controlGrup is TextBox) controlGrup.Text = "";
                if (controlGrup is ComboBox) ((ComboBox)controlGrup).SelectedIndex = -1;
                if (controlGrup is CheckBox) ((CheckBox)controlGrup).Checked = false;
            }
            //cmbMes.SelectedIndex = -1;
            //cmbTipo.SelectedIndex = -1;
            cmbPeriodo.SelectedIndex = -1;
            gbx.Enabled = false;
            btnEliminar.Visible = false;
            btnGuardar.Visible = false;
            btnRecibo.Visible = false;
        }
        private void MostrarPeriodos()
        {
            CN_Liquidaciones LiquidacionesCN1 = new CN_Liquidaciones();
            cmbPeriodo.DataSource = LiquidacionesCN1.MostrarPeriodos();
            cmbPeriodo.ValueMember = "IdPeriodo";
            cmbPeriodo.DisplayMember = "Descripcion";
            cmbPeriodo.SelectedIndex = -1;
        }

        //private void MostrarMeses()
        //{
        //    CN_Liquidaciones LiquidacionesCN1 = new CN_Liquidaciones();
        //    cmbMes.DataSource = LiquidacionesCN1.MostrarMeses();
        //    cmbMes.ValueMember = "Id";
        //    cmbMes.DisplayMember = "Mes";
        //    cmbMes.SelectedIndex = -1;
        //}
        //private void MostrarTipo()
        //{
        //    CN_Liquidaciones LiquidacionesCN2 = new CN_Liquidaciones();
        //    cmbTipo.DataSource = LiquidacionesCN2.MostrarTipos();
        //    cmbTipo.ValueMember = "Id";
        //    cmbTipo.DisplayMember = "Tipo";
        //    cmbTipo.SelectedIndex = -1;
        //}
        //private void MostrarAnios() {
        //    CN_Liquidaciones LiquidacionesCN3 = new CN_Liquidaciones();
        //    cmbPeriodo.DataSource = LiquidacionesCN3.MostrarAnios();
        //    cmbPeriodo.ValueMember = "Id";
        //    cmbPeriodo.DisplayMember = "Año";
        //    cmbPeriodo.SelectedIndex = -1;
        //}

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
            dgvLiquidaciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void BotonEliminar()
        {

            //Boton Borrar
            Icon iconoBorrar = new Icon(Environment.CurrentDirectory + @"\\delete2.ico");
            DataGridViewImageColumn columnaBorrar = new DataGridViewImageColumn();
            columnaBorrar.Image = iconoBorrar.ToBitmap();
            columnaBorrar.Name = "Eliminar";
            columnaBorrar.HeaderText = "Eliminar";
            columnaBorrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            columnaBorrar.ToolTipText = "Borrar Registros";
            dgvLiquidaciones.Columns.Insert(18, columnaBorrar);

        }


        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Eliminar la liquidacion de \r\n" + txtNombre.Text.ToUpper() + " " + txtApellido.Text.ToUpper() + "\r\n de manera permanente?",
             "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            CN_Liquidaciones LiquidacionCN = new CN_Liquidaciones();
            if (resultado == DialogResult.OK)
            {
                idLiquidacion = dgvLiquidaciones.CurrentRow.Cells["Id"].Value.ToString();
                LiquidacionCN.EliminarLiquidacion(idLiquidacion);
                MessageBox.Show("Eliminado correctamente");
                MostrarLiquidaciones();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CN_Liquidaciones LiquidacionesCN = new CN_Liquidaciones();
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    LiquidacionesCN.EditarLiquidaciones(idLiquidacion, txtExtras.Text, txtAnticipos.Text, txtBono.Text, txtBruto.Text);
                    MessageBox.Show("se edito correctamente");
                    MostrarLiquidaciones();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
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
            idperiodo = dgvLiquidaciones.CurrentRow.Cells["IdPeriodo"].Value.ToString();
            gbx.Enabled = true;

            if (dgvLiquidaciones.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                btnEliminar_Click(null, null);
            }
            else
            {
                Editar = true;
                btnEliminar.Visible = true;
                btnRecibo.Visible = true;
                btnGuardar.Visible = true;
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            Liquidacion formulario2 = new Liquidacion(idLiquidacion);
            formulario2.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda = txtbusqueda.Text.Trim();
            if (cmbPeriodo.SelectedValue!= null)
            {
            periodo = cmbPeriodo.SelectedValue.ToString();
            }
            limpiarForm();
            dgvLiquidaciones.DataSource = null;
            dgvLiquidaciones.Columns.Clear();
            dgvLiquidaciones.DataSource = LiquidacionesCN.MostrarLiquidaciones(busqueda, periodo);
            OpcionesDgv();
        }
    }
}
