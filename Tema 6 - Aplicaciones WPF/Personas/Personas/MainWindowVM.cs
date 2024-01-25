using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Personas
{
    public class MainWindowVM : ObservableObject 
    {
        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }
        public RelayCommand VistaNuevaPersonaCommand { get; }
        public RelayCommand VistaListadoPersonasCommand { get; }
<<<<<<< HEAD
        public RelayCommand VistaConsultaPersonaCommand { get; }
=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
        private NavegacionService navegacionService;

        public MainWindowVM()
        {
            VistaNuevaPersonaCommand = new RelayCommand(CargaVistaNuevaPersona);
            VistaListadoPersonasCommand = new RelayCommand(CargaVistaListaPersonas);
<<<<<<< HEAD
            VistaConsultaPersonaCommand = new RelayCommand(CargaVistaConsultaPersona);
=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
            navegacionService = new NavegacionService();
        }

        public void CargaVistaNuevaPersona() => ContenidoVista = navegacionService.ObtenUserControlNuevaPersona();

        public void CargaVistaListaPersonas() => ContenidoVista = navegacionService.ObtenUserControlListadoPersonas();
<<<<<<< HEAD

        public void CargaVistaConsultaPersona() => ContenidoVista = navegacionService.ObtenUserControlConsultaPersona();
=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
    }
}
