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

namespace Tema2_CaracteresLimitados
{
    public partial class MainWindow : Window {
        private int cantidadCaracteresIntroducidos;
        private const int LIMITE_CARACTERES = 140;
        
        public MainWindow() {
            InitializeComponent();
            this.cantidadCaracteresIntroducidos = 0;
            limiteCaracteresTextBlock.Text = $"{this.cantidadCaracteresIntroducidos}/{LIMITE_CARACTERES}";
        }

        private void TextoIntroducidoTexBox_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Back && textoIntroducidoTextBox.Text.Length > 0)
                cantidadCaracteresIntroducidos--;
            else if(e.Key != Key.Back && e.Key != Key.Enter)
                cantidadCaracteresIntroducidos++;
            limiteCaracteresTextBlock.Text = $"{this.cantidadCaracteresIntroducidos}/{LIMITE_CARACTERES}";

            if (cantidadCaracteresIntroducidos == LIMITE_CARACTERES) {
                textoIntroducidoTextBox.IsReadOnly = true;
                Keyboard.ClearFocus();
            }
        }
    }
}
