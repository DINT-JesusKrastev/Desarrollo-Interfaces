<<<<<<< HEAD
﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
=======
﻿using System;
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
<<<<<<< HEAD
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
=======
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Nacionalidad { get; set; }
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2

        public Persona(string Nombre, int Edad, string Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Nacionalidad = Nacionalidad;
        }
    }
}
