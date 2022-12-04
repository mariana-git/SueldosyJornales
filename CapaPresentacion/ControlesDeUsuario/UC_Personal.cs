using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.ControlesDeUsuario
{
    public partial class UC_Personal : UserControl
    {
        #region ATRIBUTOS

        CN_Personal PersonalCN = new CN_Personal();
        CN_Puestos PuestosCN = new CN_Puestos();

        private string idPersonal = null;
        private bool Editar = false;
        #endregion

        #region CONSTRUCTOR
        public UC_Personal()
        {
            InitializeComponent();
            MostrarPersonalActivo("");
            MostrarPuestos();
        }
        #endregion

        #region METODOS
        private void MostrarPersonal(string dato)
        {
            dgvPersonal.DataSource = null;
            dgvPersonal.Columns.Clear();
            CN_Personal PersonalCN = new CN_Personal();
            dgvPersonal.DataSource = PersonalCN.MostrarPersonal(busqueda.Text.Trim());
            if (dgvPersonal != null)
            {
                OpcionesDgv();
                BotonEliminar();
                dgvPersonal.Columns["Id"].Visible = false;
                dgvPersonal.Columns["PuestoId"].Visible = false;
                btnExportar.Enabled = true;
                limpiarForm();
            }
           
        }

        private void MostrarPersonalActivo(string dato)
        {
            dgvPersonal.DataSource = null;
            dgvPersonal.Columns.Clear();
            CN_Personal PersonalCN = new CN_Personal();
            dgvPersonal.DataSource = PersonalCN.MostrarPersonalActivo(dato);
            if (dgvPersonal != null)
            {
                OpcionesDgv();
                BotonEliminar();
                dgvPersonal.Columns["Id"].Visible = false;
                dgvPersonal.Columns["PuestoId"].Visible = false;

                btnExportar.Enabled = true;
                limpiarForm();
            }
        }

        private void MostrarPuestos()
        {
            cmbPuestos.ValueMember = "Id";
            cmbPuestos.DisplayMember = "Puesto";
            cmbPuestos.DataSource = PuestosCN.MostrarPuestos(""); 
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
            dgvPersonal.Columns.Insert(0, columnaBorrar);

        }

        private void limpiarForm()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCuil.Text = "";
            cmbPuestos.SelectedIndex = -1;
            cbxActivo.CheckState = CheckState.Checked;
            cbxActivos.CheckState = CheckState.Checked;

            gbx.Enabled = false;
            btnEliminar.Visible = false;
        }

        private void OpcionesDgv()
        {
            dgvPersonal.BringToFront();
            dgvPersonal.RowHeadersVisible = false; // no muestra la primera columna
            dgvPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgvPersonal.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvPersonal.RowsDefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;//alterna colores de las filas
            dgvPersonal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;//alterna colores de las filas
            dgvPersonal.AllowUserToAddRows = false; //desactiva la ultima fila 
            dgvPersonal.MultiSelect = false; //desactiva la seleccion multiple
            dgvPersonal.RowTemplate.Height = 35;// altura de row
            dgvPersonal.DefaultCellStyle.Font = new Font("Roboto", 13, GraphicsUnit.Pixel);// fijo font
            dgvPersonal.DefaultCellStyle.SelectionBackColor = Color.Black; //color seleccion de row
            dgvPersonal.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;// color font de seleccion de row
            dgvPersonal.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        #endregion

        #region BOTONES
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    CN_Personal PersonalCN = new CN_Personal();
                    PersonalCN.InsertarPersonal(txtNombre.Text, txtApellido.Text, txtCuil.Text, dtpIngreso.Text, cmbPuestos.SelectedValue.ToString(), cbxActivo.Checked);
                    MessageBox.Show("se inserto correctamente");
                    MostrarPersonal("");
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
                    PersonalCN.EditarPersonal(txtNombre.Text, txtApellido.Text, txtCuil.Text, dtpIngreso.Text, cmbPuestos.SelectedValue, cbxActivo.Checked, idPersonal);
                    MessageBox.Show("se edito correctamente");
                    MostrarPersonal("");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //paso los datos al form
            txtNombre.Text = dgvPersonal.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvPersonal.CurrentRow.Cells["Apellido"].Value.ToString();
            txtCuil.Text = dgvPersonal.CurrentRow.Cells["CUIL"].Value.ToString();
            cmbPuestos.SelectedValue = Convert.ToInt32(dgvPersonal.CurrentRow.Cells["PuestoId"].Value);
            dtpIngreso.Value = (DateTime)dgvPersonal.CurrentRow.Cells["FechaIngreso"].Value;
            cbxActivo.Checked = (bool)dgvPersonal.CurrentRow.Cells["Activo"].Value;
            idPersonal = dgvPersonal.CurrentRow.Cells["Id"].Value.ToString();
            gbx.Enabled = true;

            if (dgvPersonal.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                btnEliminar_Click(null, null);
            }
            else
            {
                Editar = true;
                btnEliminar.Visible= true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            limpiarForm();
            gbx.Enabled = true;
            dgvPersonal.DataSource = null;
            dgvPersonal.Columns.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((cbxActivos.Checked))
            {
                MostrarPersonalActivo(busqueda.Text.Trim());
            }
            else
            {
                MostrarPersonal(busqueda.Text.Trim());
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Eliminar registro de \r\n" + txtNombre.Text.ToUpper() + " " + txtApellido.Text.ToUpper() + "\r\n de manera permanente?",
               "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            CN_Personal PersonalCN = new CN_Personal();
            if (resultado == DialogResult.OK)
            {
                idPersonal = dgvPersonal.CurrentRow.Cells["Id"].Value.ToString();
                PersonalCN.EliminarPersonal(idPersonal);
                MessageBox.Show("Eliminado correctamente");
                MostrarPersonal("");
            }
            else
            {
                MostrarPersonal("");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar.ExportarExcel(dgvPersonal);
        }
    }
    #endregion

}
