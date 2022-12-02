using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.ControlesDeUsuario
{
    public partial class UC_Puestos : UserControl
    {

        #region ATRIBUTOS
        private string idPuesto = null;
        private bool Editar = false;
        #endregion

        #region CONSTRUCTOR
        public UC_Puestos()
        {
            InitializeComponent();
            MostrarPuestos("");
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

        private void MostrarPuestos(string dato)
        {
            CN_Puestos PuestosCN = new CN_Puestos();
            dgvPuestos.DataSource = null;
            dgvPuestos.Columns.Clear();
            dgvPuestos.DataSource = PuestosCN.MostrarPuestos(busqueda.Text);
            OpcionesDgv();
            BotonEliminar();
            dgvPuestos.Columns["Id"].Visible = false;
            limpiarForm();
        }

        private void limpiarForm()
        {
            txtDenominacion.Clear();
            txtDias.Clear();
            txtHs.Clear();
            gbx.Enabled = false;
            btnEliminar.Visible = false;
            btnGuardar.Visible = false;
        }

        private void OpcionesDgv()
        {
            dgvPuestos.BringToFront();
            dgvPuestos.RowHeadersVisible = false; // no muestra la primera columna
            dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgvPuestos.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvPuestos.RowsDefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;//alterna colores de las filas
            dgvPuestos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;//alterna colores de las filas
            dgvPuestos.AllowUserToAddRows = false; //desactiva la ultima fila 
            dgvPuestos.MultiSelect = false; //desactiva la seleccion multiple
            dgvPuestos.RowTemplate.Height = 35;// altura de row
            dgvPuestos.DefaultCellStyle.Font = new Font("Roboto", 13, GraphicsUnit.Pixel);// fijo font
            dgvPuestos.DefaultCellStyle.SelectionBackColor = Color.Black; //color seleccion de row
            dgvPuestos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;// color font de seleccion de row
            dgvPuestos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            dgvPuestos.Columns.Insert(5, columnaBorrar);
        }

        private void dgvPuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //paso los datos al form
            txtDenominacion.Text = dgvPuestos.CurrentRow.Cells["Puesto"].Value.ToString();
            txtHs.Text = dgvPuestos.CurrentRow.Cells["HsSemanales"].Value.ToString();
            txtDias.Text = dgvPuestos.CurrentRow.Cells["DiasSemana"].Value.ToString();
            txtSueldo.Text = dgvPuestos.CurrentRow.Cells["SueldoBruto"].Value.ToString();
            txtExtras.Text = dgvPuestos.CurrentRow.Cells["ValorHoraExtra"].Value.ToString();
            idPuesto = dgvPuestos.CurrentRow.Cells["Id"].Value.ToString();
            gbx.Enabled = true;

            if (dgvPuestos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                btnEliminar_Click(null, null);
            }
            else
            {
                Editar = true;
                btnEliminar.Visible = true;
                btnGuardar.Visible = true;
            }
        }

        #endregion

        #region BOTONES
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Eliminar puesto  \r\n" + txtDenominacion.Text.ToUpper()+ "\r\n de manera permanente?",
            "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (resultado == DialogResult.OK)
            {
                CN_Puestos PuestosCN = new CN_Puestos();
                //idPuesto = dgvPuestos.CurrentRow.Cells["Id"].Value.ToString();
                PuestosCN.EliminarPuestos(idPuesto);
                MessageBox.Show("Eliminado correctamente");
                MostrarPuestos("");
            }
            else
            {
                MostrarPuestos("");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CN_Puestos PuestosCN = new CN_Puestos();
            //INSERTAR
            if (Editar == false)
            {
                try
                {                    
                    PuestosCN.InsertarPuestos(txtDenominacion.Text, txtDias.Text, txtHs.Text,txtSueldo.Text,txtExtras.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarPuestos("");
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
                    PuestosCN.EditarPuestos(txtDenominacion.Text, txtDias.Text, txtHs.Text, txtSueldo.Text, txtExtras.Text, idPuesto);
                    MessageBox.Show("se edito correctamente");
                    MostrarPuestos("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarPuestos("");
            Editar = false;
            gbx.Enabled = true;
        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarPuestos(busqueda.Text);
        }
        #endregion

    }
}
