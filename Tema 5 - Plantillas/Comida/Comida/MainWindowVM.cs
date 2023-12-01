using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;
        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set
            {
                listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }

        private Plato platoSeleccionado;
        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }


        public MainWindowVM() 
        {
            ListaPlatos = Plato.GetSamples("./Resources/");
            PlatoSeleccionado = null;
        }
        public void DeshabilitarEditorPlato() => PlatoSeleccionado = null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}