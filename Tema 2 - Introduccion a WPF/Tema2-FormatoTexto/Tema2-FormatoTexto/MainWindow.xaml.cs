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

namespace Tema2_FormatoTexto {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void EntradaUsuarioTextBox_KeyDown(object sender, KeyEventArgs e) {
            caracteresIntroducidosTextBlock.Text = entradaUsuarioTextBox.Text;
        }

        private void TextoNegritaCheckBox_Checked(object sender, RoutedEventArgs e) => caracteresIntroducidosTextBlock.FontWeight = FontWeights.Bold;

        private void TextoNegritaCheckBox_Unchecked(object sender, RoutedEventArgs e) => caracteresIntroducidosTextBlock.FontWeight = FontWeights.Normal;

        private void TextoCursivaCheckBox_Unchecked(object sender, RoutedEventArgs e) => caracteresIntroducidosTextBlock.FontStyle = FontStyles.Italic;

        private void TextoCursivaCheckBox_Checked(object sender, RoutedEventArgs e) => caracteresIntroducidosTextBlock.FontStyle = FontStyles.Normal;

        private void ColorAzulRadioButton_Checked(object sender, RoutedEventArgs e) => caracteresIntroducidosTextBlock.Foreground = Brushes.Blue;

        private void ColorRojoRadioButton_Checked(object sender, RoutedEventArgs e) => caracteresIntroducidosTextBlock.Foreground = Brushes.Red;

        private void ColorVerdeRadioButton_Checked(object sender, RoutedEventArgs e) => caracteresIntroducidosTextBlock.Foreground = Brushes.Green;
    }
}
