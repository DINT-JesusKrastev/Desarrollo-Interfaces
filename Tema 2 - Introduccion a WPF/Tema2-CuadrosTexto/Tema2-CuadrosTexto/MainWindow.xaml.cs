using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NombreTexbox_KeyUp(object sender, KeyEventArgs e) {
            if(e.Key == Key.F1) ayudaUsuarioNombre.Visibility = (ayudaUsuarioNombre.Visibility != Visibility.Visible) ? Visibility.Visible : Visibility.Hidden;
        }

        private void ApellidoTextBox_KeyUp(object sender, KeyEventArgs e) {
            if (e.Key == Key.F1) ayudaUsuarioApellido.Visibility = (ayudaUsuarioApellido.Visibility != Visibility.Visible) ? Visibility.Visible : Visibility.Hidden;
        }

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e) {
            String patronNumero = @"^\d$";

            if (e.Key == Key.F2) errorUsuarioEdad.Visibility = Regex.IsMatch(edadTextBox.Text, patronNumero) ? Visibility.Hidden : Visibility.Visible; 
        }
    }
}
