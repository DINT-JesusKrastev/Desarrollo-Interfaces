using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace Comida
{
    class Plato : INotifyPropertyChanged
    {
        private string nombre { get; set; }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                NotifyPropertyChanged("Nombre");
            }
        }
        private string imagen { get; set; }
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                NotifyPropertyChanged("Imagen");
            }
        }
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
                NotifyPropertyChanged("Tipo");
            }
        }

        private bool gluten;
        public bool Gluten
        {
            get { return gluten; }
            set
            {
                gluten = value;
                NotifyPropertyChanged("Gluten");
            }
        }

        private bool soja;
        public bool Soja
        {
            get { return soja; }
            set
            {
                soja = value;
                NotifyPropertyChanged("Soja");
            }
        }

        private bool leche;
        public bool Leche
        {
            get { return leche; }
            set
            {
                leche = value;
                NotifyPropertyChanged("Leche");
            }
        }

        private bool sulfitos;
        public bool Sulfitos
        {
            get { return sulfitos; }
            set
            {
                sulfitos = value;
                NotifyPropertyChanged("Sulfitos");
            }
        }


        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static ObservableCollection<Plato> GetSamples(string rutaImagenes)
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }
    }
}