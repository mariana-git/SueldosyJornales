using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
        }
        #region BUTTONS
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //antes de consultar la BD valido a nivel formulario que los textbox tengan datos
            if (txtUser.Text == string.Empty)
            {
                ErrorMessage("Ingresar Usuario");
            }
            else if (txtPass.Text == string.Empty)
            {
                ErrorMessage("Ingresar Clave");
            }
            else
            {
                //Abro este form de login en un diálogo modal desde el MAIN, si se valida el Usuario, se abre el form principal, sino se cierra toda la aplicacion
                try
                {
                    string result = new LoginCN { Usuario = txtUser.Text, Clave = txtPass.Text }.Login_Validate();

                    if (result == "")
                    {

                        DialogResult = DialogResult.OK;
                    }
                    else ErrorMessage(result);
                    txtPass.Text = "";
                    txtUser.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No pudo realizarse la operacion solicitada.\n\n Verifique los datos y vuelva a intentarlo\n\n\n\n" + ex.ToString());
                }
                btnLogin.Focus();
            }
        }
        #endregion

        #region METHODS
        private void ErrorMessage(string mensaje)
        {
            //muestra mensajes de error en un label de este formulario de login
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }

        #endregion

        #region EVENTS
        private void txtUser_Enter_1(object sender, EventArgs e)
        {
            if (lblMensajeError.Visible) lblMensajeError.Visible = false;
        }

        private void txtPass_Enter_1(object sender, EventArgs e)
        {
            if (lblMensajeError.Visible) lblMensajeError.Visible = false;
        }


        #endregion

        private void Login_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
