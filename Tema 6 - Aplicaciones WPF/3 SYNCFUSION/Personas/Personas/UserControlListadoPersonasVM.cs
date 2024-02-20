using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }   
        }
        private PersonaService personaService;

        public UserControlListadoPersonasVM()
        {
            this.personaService = new PersonaService();
            this.personas = personaService.GetSamples();
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
        }
    }
}
