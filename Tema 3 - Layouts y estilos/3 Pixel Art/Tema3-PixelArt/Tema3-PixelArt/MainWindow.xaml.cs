using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace Tema3_PixelArt {
    public partial class MainWindow : Window {
        private UniformGrid cuadricula;
        private Brush colorSeleccionado;

        public MainWindow() {
            InitializeComponent();
            cuadricula = new UniformGrid();
            colorSeleccionado = Brushes.White;
            this.BordeCuadriculaBorder.Visibility = Visibility.Hidden;
        }

        private void GeneraCuadricula(int tamanyoCuadricula) {
            // Hace visible la cuadricula con el borde
            this.BordeCuadriculaBorder.Visibility = Visibility.Visible;
            // Eliminar cuadricula
            cuadricula.Children.RemoveRange(0, cuadricula.Children.Count);

            cuadricula.Rows = tamanyoCuadricula;
            cuadricula.Columns = tamanyoCuadricula;

            for (int i = 0; i < tamanyoCuadricula; i++) {
                for (int j = 0; j < tamanyoCuadricula; j++) {
                    Border pixel = new Border();
                    pixel.Style = (Style) this.Resources["EstiloPixelBorder"];
                    cuadricula.Children.Add(pixel);
                }
            }

            this.BordeCuadriculaBorder.Child = cuadricula;
        }

        private bool CuadriculaVacia() {
            bool vacia = true;

            for (int i = 0; i < cuadricula.Children.Count && vacia; i++) if(((Border)cuadricula.Children[i]).Background.ToString() != "#FFFFFFFF") vacia = false; 

            return vacia;
        }

        // Elimina placeholder
        private void TamanyoPersonalizadoTextBox_GotFocus(object sender, RoutedEventArgs e) {
            if(TamanyoPersonalizadoTextbox.Text == "ej. 60") {
                TamanyoPersonalizadoTextbox.Foreground = Brushes.Black;
                TamanyoPersonalizadoTextbox.Text = string.Empty;
            }
        }

        // Añade placeholder
        private void TamanyoPersonalizadoTextBox_LostFocus(object sender, RoutedEventArgs e) {
            if(string.IsNullOrEmpty(TamanyoPersonalizadoTextbox.Text.ToString())) {
                TamanyoPersonalizadoTextbox.Foreground = Brushes.LightGray;
                TamanyoPersonalizadoTextbox.Text = "ej. 60";
            }
        }

        private void PixelBorder_MouseEnter(object sender, RoutedEventArgs e) { 
            Border pixel = (Border) sender;

            if (Mouse.LeftButton == MouseButtonState.Pressed) ((Border)sender).Background = colorSeleccionado;
        }
        private void PixelBorder_MouseLeftButtonDown(object sender, RoutedEventArgs e) {
            ((Border)sender).Background = colorSeleccionado;
        }

        private void GeneraCuadriculaButton_Click(object sender, RoutedEventArgs e) {
            if (!CuadriculaVacia()) {
                if (MessageBox.Show("¿Seguro que quieres perder tu dibujo?", "Nuevo dibujo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) {
                    GeneraCuadricula(int.Parse(((Button)sender).Tag.ToString()));
                }
            } else {
                GeneraCuadricula(int.Parse(((Button)sender).Tag.ToString()));
            }            
        }

        private void ActivaBordeButton_Click(object sender, RoutedEventArgs e) {
            this.BordeCuadriculaBorder.BorderBrush = Brushes.Black;
        }

        private void DesactivaBordeButton_Click(object sender, RoutedEventArgs e) {
            this.BordeCuadriculaBorder.BorderBrush = Brushes.White;
        }

        private void RellenaCuadriculaButton_Click(object sender, RoutedEventArgs e) {
            foreach (Border pixel in cuadricula.Children) pixel.Background = colorSeleccionado;
        }

        private void ColorRadioButton_Checked(object sender, RoutedEventArgs e) {
            try {
                colorSeleccionado = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString(((RadioButton)sender).Tag.ToString()));
                Keyboard.ClearFocus();
            } catch (FormatException ex) {
                MessageBox.Show("Código de color no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ColorPersonalizadoRadioButton_Checked(object sender, RoutedEventArgs e) {
            if(!ColorPersonalizadoTextBox.Text.Equals("")) colorSeleccionado = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString(ColorPersonalizadoTextBox.Text));
            ColorPersonalizadoTextBox.IsEnabled = true;
        }

        private void ColorPersonalizadoRadioButton_Unchecked(object sender, RoutedEventArgs e) {
            ColorPersonalizadoTextBox.IsEnabled = false;
        }

        private void ColorPersonalizadoTextBox_KeyUp(object sender, KeyEventArgs e) {
            if(Key.Enter == e.Key && !ColorPersonalizadoTextBox.Text.Equals("")) {
                try {
                    ColorSeleccionadoRectangle.Fill = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString(ColorPersonalizadoTextBox.Text));
                    colorSeleccionado = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString(ColorPersonalizadoTextBox.Text));
                    Keyboard.ClearFocus();
                } catch(FormatException ex) {
                    MessageBox.Show("Código de color no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void TamanyoPersonalizadoTextbox_KeyUp(object sender, KeyEventArgs e) {
            if (Key.Enter == e.Key && !TamanyoPersonalizadoTextbox.Text.Equals("")) {
                try {
                    GeneraCuadricula(int.Parse(TamanyoPersonalizadoTextbox.Text));
                    Keyboard.ClearFocus();
                } catch (FormatException ex) {
                    MessageBox.Show("El formato del tamaño introducido no es válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}