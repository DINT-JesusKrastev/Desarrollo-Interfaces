   M S B A M L   `   `   `  ����R  NTema2-CalculadoraBasica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Tema2_CalculadoraBasicaTema2_CalculadoraBasica  5   	   (    "Tema2_CalculadoraBasica.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Tema2_CalculadoraBasica     5   	     � Title$  Calculadora básica��5   	   $	��281��6$   $	��559��61    � Icon$ /Resources/Logo.ico��6=   .��5	      � .+�5
   
   �� $
��Left=�5      $��	46,66,0,0q�5      $
��Wrap=�5      $��
Operando 1��5      $	��Top=�5      �� 5   
   $
��Left=�5      $��
46,106,0,0q�5      $
��Wrap=�5      $��
Operando 2��5      $	��Top=�5      �� 5   
   $
��Left=�5      $��
46,146,0,0q�5      $
��Wrap=�5      $��Operador��5      $	��Top=�5      �� 5   
   $
��Left=�5      $��
46,183,0,0q�5      $
��Wrap=�5      $��	Resultado��5       $	��Top=�5!      �� 5"   
   -   5         ��Name$ operando1TextBox��5#      $
��Left=�5$      $��
121,65,0,0q�5%       �� TextWrapping$
 Wrap=�5&      $�� ��5'      $	��Top=�5(      $��88��5)      �� 5*   
   -   5        $ operando2TextBox��5+      $
��Left=�5,      $��121,106,0,0q�5-      $
 Wrap=�5.      $�� ��5/      $	��Top=�50      $��88��51      �� 52   
   -   5        $ operadorTextBox��53      $
��Left=�54      $��121,145,0,0q�55      $
 Wrap=�56      $�� ��57      $	��Top=�58      $��88��59      5:      �� 5;   
   -   5        $ resultadoTextBox��5<      $
��Left=�5=      $��121,182,0,0q�5>      $
 Wrap=�5?      $�� ��5@      $	��Top=�5A      $��88��5B       �� 
IsReadOnly$
 True��5C      �� 5D   
   -   5         ��Name$ calcularButton��5E      $��Calcular��5F      $
��Left=�5G      $��
443,64,0,0q�5H      $	��Top=�5I      $
��12px(�5J      $��68��5K      $��22��5L      ${�false��5N      �� 5O   
   -   5        $ limpiarButton��5P      $��Limpiar��5Q      $
��Left=�5R      $��
443,93,0,0q�5S      $	��Top=�5T      $
��12px(�5U      $��68��5V      $��22��5W      5X      5Y      5Z      