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

namespace Tema2_Imagen {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void OpacidadAltaButton_Checked(object sender, RoutedEventArgs e) {
            portadaImage.Opacity = 1;
        }

        private void OpacidadMediaButton_Checked(object sender, RoutedEventArgs e) {
            portadaImage.Opacity = 0.6;
        }

        private void OpacidadBajaButton_Checked(object sender, RoutedEventArgs e) {
            portadaImage.Opacity = 0.3;
        }

        private void AjusteRellenoButton_Checked(object sender, RoutedEventArgs e) {
            portadaImage.Stretch = Stretch.Fill;
        }

        private void AjusteUniformeButton_Checked(object sender, RoutedEventArgs e) {
            portadaImage.Stretch = Stretch.Uniform;
        }

        private void AjusteRellenoUniformeButton_Checked(object sender, RoutedEventArgs e) {
            portadaImage.Stretch = Stretch.UniformToFill;
        }

        private void AjusteSinAjusteButton_Checked(object sender, RoutedEventArgs e) {
            portadaImage.Stretch = Stretch.None;
        }
    }
}
