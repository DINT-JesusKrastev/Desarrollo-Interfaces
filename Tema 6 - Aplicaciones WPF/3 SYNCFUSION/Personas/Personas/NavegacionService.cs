using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    public class NavegacionService
    {
        private UserControlListadoPersonas userControlListadoPersonas { get; }

        public NavegacionService() {
            userControlListadoPersonas = new UserControlListadoPersonas();
        }

        public UserControl ObtenUserControlNuevaPersona() => new UserControlNuevaPersona();
        public UserControl ObtenUserControlListadoPersonas() => userControlListadoPersonas;

        public UserControl ObtenUserControlConsultaPersona() => new UserControlConsultaPersona();

        public void AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogo = new DialogoNacionalidad();

            dialogo.ShowDialog();
        }
    }
}
