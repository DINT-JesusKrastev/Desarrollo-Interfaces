using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Personas
{
    public class UserControlNuevaPersonaVM : ObservableObject
    {
        private Persona nuevaPersona;
        public Persona NuevaPersona
        {
            get { return nuevaPersona; }
            set { SetProperty(ref nuevaPersona, value); }
        }
        public ObservableCollection<string> Nacionalidades { get; set; }
        private NacionalidadService nacionalidadService;
        public RelayCommand AbrirDialogoNacionalidadCommand { get; }
        public RelayCommand AnyadirPersonaCommand { get; }
        private NavegacionService navegacionService;

        public UserControlNuevaPersonaVM()
        {
            this.nacionalidadService = new NacionalidadService();
            navegacionService = new NavegacionService();
            AnyadirPersonaCommand = new RelayCommand(AnyadirPersona);
            AbrirDialogoNacionalidadCommand = new RelayCommand(AbrirDialogoNacionalidad);
            this.NuevaPersona = new Persona();
            this.Nacionalidades = nacionalidadService.GetSamples();

            WeakReferenceMessenger.Default.Register<NuevaNacionalidadMessage>(this, (r, m) =>
            {
                Nacionalidades.Add(m.Value);
            });
        }

        public void AbrirDialogoNacionalidad() => navegacionService.AbrirDialogoNacionalidad();

        private void AnyadirPersona() => WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(NuevaPersona));
    }
}