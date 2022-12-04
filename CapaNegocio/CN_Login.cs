using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSoporte;
using CapaDatos;

namespace CapaPresentacion
{
    public class LoginCN
    {
        public string Usuario { private get; set; }
        public string Clave { private get; set; }



        public static bool Permissions(string action)
        {
            if (CS_UsuarioActivo.TipoPermiso.Contains(action)) return true;
            else return false;
        }

        public string Login_Validate()
        {
            if (new CD_Login { Usuario = Usuario }.Users_Search() == 1) //Valido que exista el usuario
            {
                int directorio = new CD_Login { Usuario = Usuario }.UsersDirectory_Search();
                if (directorio == 1)
                {
                    if (new CD_Login { Usuario = Usuario, Clave = Clave }.UsersPass_Search() == 1) // valido que exista clave y usuario
                    {
                        new CD_Login { Usuario = Usuario, Clave = Clave }.Users_Read(); //cargo los datos del usuario en la capa soporte
                        new CD_Login { Usuario = Usuario, Intentos = 0 }.UpdateUserLoginTry();// limpio INTENTOS
                        return "";
                    }
                    else
                    {
                        int intentos = new CD_Login { Usuario = Usuario }.UsersLoginTry_Search();
                        new CD_Login { Usuario = Usuario, Intentos = intentos + 1 }.UpdateUserLoginTry(); //incremento INTENTOS
                        if (intentos < 2)                                                                       //valido que sean menos de 3 INTENTOS
                        {
                            return "Constraseña Incorrecta";
                        }
                        else
                        {
                            new CD_Login { Usuario = Usuario }.BlockUserLoginTry();
                            return "Usuario Bloqueado";
                        }
                    }
                }
                else
                {
                    if (directorio == 2) return "Usuario Bloqueado";
                    else return "Usuario Desactivado";
                }
            }
            else return "Usuario inexistente";
        }
    }
}
