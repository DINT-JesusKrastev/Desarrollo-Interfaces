using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Persona : ObservableObject
    {
        private string? nombre;
        public string? Nombre {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        private int? edad;
        public int? Edad
        {
            get { return edad; }
            set { SetProperty(ref  edad, value); }
        }
        private string? nacionalidad;
        public string? Nacionalidad { 
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public Persona() {
            
        }

        public Persona(string Nombre, int Edad, string Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Nacionalidad = Nacionalidad;
        }
    }
}
