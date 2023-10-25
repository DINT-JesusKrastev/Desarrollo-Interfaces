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

namespace Tema2_TamanyoTexto
{
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void TamanyoTextoRadioButton_Checked(object sender, RoutedEventArgs e) {
            string tagRadioButtonSeleccionado = ((RadioButton)sender).Tag.ToString();
            const int tamanyoPequenyo = 36, tamanyoMedio = 48, tamanyoGrande = 72;
            int tamanyoTexto = tamanyoMedio;

            if (tamanyoPequenyoRadioButton.Tag.ToString().Equals(tagRadioButtonSeleccionado)) {
                tamanyoTexto = tamanyoPequenyo;
            } else if(tamanyoMedioRadioButton.Tag.ToString().Equals(tagRadioButtonSeleccionado)) {
                tamanyoTexto = tamanyoMedio;
            } else if(tamanyoGrandeRadioButton.Tag.ToString().Equals(tagRadioButtonSeleccionado)) {
                tamanyoTexto = tamanyoGrande;
            }

            tituloTextBlock.FontSize = tamanyoTexto;
        }
    }
}
