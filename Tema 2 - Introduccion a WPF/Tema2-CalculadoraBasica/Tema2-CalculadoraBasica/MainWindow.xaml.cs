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

namespace Tema2_CalculadoraBasica {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e) {
            double resultado, operador1, operador2;

            try {
                operador1 = double.Parse(operando1TextBox.Text);
                operador2 = double.Parse(operando2TextBox.Text);

                resultado = operadorTextBox.Text switch {
                    "+" => operador1 + operador2,
                    "-" => operador1 - operador2,
                    "*" => operador1 * operador2,
                    "/" => operador1 / operador2
                };

                resultadoTextBox.Text = resultado.ToString();
            } catch(Exception ex) {
                MessageBox.Show("Se ha producido un error. Revise los operandos.");
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e) {
            operando1TextBox.Text = string.Empty;
            operando2TextBox.Text = string.Empty;
            operadorTextBox.Text = string.Empty;
            resultadoTextBox.Text = string.Empty;
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            string patronOperador = @"^[+\-*/]$";

            if (Regex.IsMatch(operadorTextBox.Text, patronOperador)) {
                calcularButton.IsEnabled = true;
            }
            else {
                calcularButton.IsEnabled = false;
            }
        }
    }
}
