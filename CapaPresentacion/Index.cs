using CapaSoporte;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Index : Form
    {
        private UserControl userControlActivo = null; //variable para manipular en el metodo del ControlUser Activo en el panel

        public Index()
        {
            InitializeComponent();
            btnVerL.Visible = false;
            btnNuevaL.Visible = false;
            timer1.Enabled = true;
            lblActiveUSer.Text = CS_UsuarioActivo.Usuario;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }
        private void AbrirUC(UserControl UControlActivo)
        {
            //Controla que solo haya un UserControl abierto dentro del Panel
            if (userControlActivo != null) userControlActivo.Dispose();
            userControlActivo = UControlActivo;
            panelPrincipal.Controls.Add(UControlActivo);
            panelPrincipal.Tag = UControlActivo;
            UControlActivo.BringToFront();
            UControlActivo.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            btnVerL.Visible = false;
            btnNuevaL.Visible = false;
            AbrirUC(new ControlesDeUsuario.UC_Personal());
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            btnVerL.Visible = false;
            btnNuevaL.Visible = false;
            AbrirUC(new ControlesDeUsuario.UC_Puestos());
        }

        private void btnLiquidaciones_Click(object sender, EventArgs e)
        {
            if (btnNuevaL.Visible) btnNuevaL.Visible = false;
            if (btnVerL.Visible) btnVerL.Visible = false;
            else
            {
                btnVerL.Visible = true;
                btnNuevaL.Visible = true;
            }
        }

        private void btnVerL_Click(object sender, EventArgs e)
        {

            btnVerL.Visible = false;
            btnNuevaL.Visible = false;
            AbrirUC(new ControlesDeUsuario.UC_VerLiquidaciones());
        }

        private void btnNuevaL_Click(object sender, EventArgs e)
        {
            btnVerL.Visible = false;
            btnNuevaL.Visible = false;

            AbrirUC(new ControlesDeUsuario.UC_GenerarLiquidacion());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
