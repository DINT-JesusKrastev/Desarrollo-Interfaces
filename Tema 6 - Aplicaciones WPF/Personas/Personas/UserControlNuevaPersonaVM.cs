<<<<<<< HEAD
﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
=======
﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Personas
{
<<<<<<< HEAD
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
=======
    public class UserControlNuevaPersonaVM
    {
        public ObservableCollection<string> Nacionalidades { get; set; }
        private NacionalidadService nacionalidadService;
        public RelayCommand AbrirDialogoNacionalidadCommand { get; }
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
        private NavegacionService navegacionService;

        public UserControlNuevaPersonaVM()
        {
            this.nacionalidadService = new NacionalidadService();
            navegacionService = new NavegacionService();
<<<<<<< HEAD
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
=======
            AbrirDialogoNacionalidadCommand = new RelayCommand(AbrirDialogoNacionalidad);
            this.Nacionalidades = nacionalidadService.GetSamples();
        }

        public void AbrirDialogoNacionalidad() => navegacionService.AbrirDialogoNacionalidad();
    }
}
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
