
using ProyectoCine.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoCine.ListaPeliculas
{
    public partial class ListaPeliculasScreen : UserControl
    {
        private ListaPeliculasScreenVM vm;

        public ListaPeliculasScreen()
        {
            InitializeComponent();
            vm = new ListaPeliculasScreenVM();
            this.DataContext = vm;
        }

        private void ListaPeliculas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem is Pelicula pelicula)
            {
                vm.NavegarAFichaPelicula(pelicula);
            }
        }
    }
}
