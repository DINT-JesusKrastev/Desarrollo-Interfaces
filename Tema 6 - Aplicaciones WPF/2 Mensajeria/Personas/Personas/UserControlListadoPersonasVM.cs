using CommunityToolkit.Mvvm.ComponentModel;
<<<<<<< HEAD
using CommunityToolkit.Mvvm.Messaging;
=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Windows;
=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2

namespace Personas
{
    public class UserControlListadoPersonasVM : ObservableObject
    {
        private ObservableCollection<Persona> personas;
        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }
<<<<<<< HEAD
        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }   
        }
=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
        private PersonaService personaService;

        public UserControlListadoPersonasVM()
        {
            this.personaService = new PersonaService();
            this.personas = personaService.GetSamples();
<<<<<<< HEAD
            WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>(this, (r, m) =>
            {
                Personas.Add(m.Value);
                MessageBox.Show("Persona añadida");
            });
            // Viene consulta
            WeakReferenceMessenger.Default.Register<UserControlListadoPersonasVM, PersonaSeleccionadaMessage>(this, (r, m) =>
            {
                m.Reply(PersonaSeleccionada);
            });
=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
        }
    }
}
