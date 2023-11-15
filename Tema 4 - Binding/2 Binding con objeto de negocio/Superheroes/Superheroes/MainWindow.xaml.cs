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

namespace Superheroes
{
    public partial class MainWindow : Window
    {
        private int posicionPersonajeActual;
        private List<Superheroe> personajes;

        public MainWindow()
        {
            InitializeComponent();
            this.posicionPersonajeActual = 0;
            this.personajes = Superheroe.GetSamples();
            ActualizaPersonaje();
        }

        private void ActualizaPersonaje() {
            numeracionPersonaje.Text = $"{posicionPersonajeActual + 1}/{personajes.Count}";
            PanelPrincipal.DataContext = personajes[posicionPersonajeActual];
        }

        private void FlechaButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image btnFlecha = (Image) sender;

            if(btnFlecha.Name == "btnFlechaIzq") {
                posicionPersonajeActual = (posicionPersonajeActual == 0) ? personajes.Count-1 : posicionPersonajeActual - 1;
            } else if (btnFlecha.Name == "btnFlechaDrch") {
                posicionPersonajeActual = (posicionPersonajeActual == personajes.Count-1) ? 0 : posicionPersonajeActual + 1;
            }

            ActualizaPersonaje();
        }
    }
}