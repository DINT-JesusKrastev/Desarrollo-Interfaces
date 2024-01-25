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

<<<<<<< HEAD
        public UserControl ObtenUserControlConsultaPersona() => new UserControlConsultaPersona();

=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
        public void AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogo = new DialogoNacionalidad();

            dialogo.ShowDialog();
        }
    }
}
