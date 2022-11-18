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
            MostrarPersonal();
            dgvPersonal.Columns["Id"].Visible = false;


            //Boton Borrar
            Icon iconoBorrar = new Icon(Environment.CurrentDirectory + @"\\delete2.ico");
            DataGridViewImageColumn columnaBorrar = new DataGridViewImageColumn();
            columnaBorrar.Image = iconoBorrar.ToBitmap();
            columnaBorrar.Name = "Eliminar";
            columnaBorrar.HeaderText = "Eliminar";
            columnaBorrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaBorrar.ToolTipText =  "Borrar Registros";
            dgvPersonal.Columns.Insert(7, columnaBorrar);

            //Boton Editar
            Icon iconoEditar = new Icon(Environment.CurrentDirectory + @"\\edit2.ico");
            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            columnaEditar.Image = iconoEditar.ToBitmap();
            columnaEditar.Name = "Modificar";
            columnaEditar.HeaderText = "Modificar";
            columnaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaEditar.ToolTipText = "Modificar Registros";
            dgvPersonal.Columns.Insert(8, columnaEditar);
            MostrarPuestos();
            cmbPuestos.SelectedIndex = -1;

        }
        #endregion

        #region METODOS
        private void MostrarPersonal()
        {
            CN_Personal tablaPersonal = new CN_Personal();
            OpcionesDgv();
            dgvPersonal.DataSource = tablaPersonal.MostrarPersonal();
        }

        private void MostrarPuestos()
        {
            CN_Puestos PuestosCN = new CN_Puestos();
            cmbPuestos.ValueMember = "Id";
            cmbPuestos.DisplayMember = "Puesto";
            cmbPuestos.DataSource = PuestosCN.MostrarPuestos(); //dt es el datatable
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

        }

        private void limpiarForm()
        {

            txtNombre.Clear();
            txtApellido.Clear();
            txtCuil.Text = "";
            cmbPuestos.SelectedIndex = -1;
            txtIngreso.Clear();
            cbxActivo.CheckState = CheckState.Unchecked;
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
                    bool activo = false;
                    if (cbxActivo.Checked) activo = true;
                    else activo = false;

                    PersonalCN.InsertarPersonal(txtNombre.Text, txtApellido.Text, txtCuil.Text, txtIngreso.Text, cmbPuestos.SelectedValue.ToString(), activo);
                    MessageBox.Show("se inserto correctamente");
                    MostrarPersonal();
                    limpiarForm();
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
                    bool activo = false;
                    if (cbxActivo.Checked) activo = true;
                    else activo = false;

                    PersonalCN.EditarPersonal(txtNombre.Text, txtApellido.Text, txtCuil.Text, txtIngreso.Text, cmbPuestos.Text, activo, idPersonal);
                    MessageBox.Show("se edito correctamente");
                    MostrarPersonal();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        #endregion

        private void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonal.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult resultado = MessageBox.Show("Eliminar registro de manera permanente",
                "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK)
                {
                    idPersonal = dgvPersonal.CurrentRow.Cells["Id"].Value.ToString();
                    PersonalCN.EliminarPersonal(idPersonal);
                    MessageBox.Show("Eliminado correctamente");
                    limpiarForm();
                    MostrarPersonal();
                }


            }
            else if (dgvPersonal.Columns[e.ColumnIndex].Name == "Modificar")
            {
                limpiarForm();
                Editar = true;
                txtNombre.Text = dgvPersonal.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvPersonal.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCuil.Text = dgvPersonal.CurrentRow.Cells["CUIL"].Value.ToString();
                cmbPuestos.SelectedValue = Convert.ToInt32(dgvPersonal.CurrentRow.Cells["PuestosId"].Value);//TODO acceder a los puestos y poner los puestos en el deplegable tb
                txtIngreso.Text = dgvPersonal.CurrentRow.Cells["FechaIngreso"].Value.ToString();
                string estado = dgvPersonal.CurrentRow.Cells["Activo"].Value.ToString();
                if (estado == "True") cbxActivo.Checked = true;
                idPersonal = dgvPersonal.CurrentRow.Cells["Id"].Value.ToString();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}
