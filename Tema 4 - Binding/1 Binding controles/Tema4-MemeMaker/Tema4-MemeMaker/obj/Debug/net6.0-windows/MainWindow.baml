   M S B A M L   `   `   `  ����J  FTema4-MemeMaker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Tema4_MemeMakerTema4_MemeMaker  5   	        Tema4_MemeMaker.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Tema4_MemeMaker     5   	     � Title$  	MemeMaker��5   	   $	��750��5	   	   $	��730��5
   	   $	��750��5   	   $	��730��5   	    � Icon$ ./Resources/Logo.ico��5   	    � 	Resources 5      -  'Tema4_MemeMaker.ConversorCheckBoxBorder   conversorCheckBoxBorder �� 
TargetType  etiquetaCampo �� Property �� Value  	textoMeme3  -System.Windows.Media.Effects.DropShadowEffect��%  &	        &	      '�� j     &	 �     '�� �      5   
   6J   �� 5   
   " ��6   .�5      ��  � ��$ 0,10,0,0q�5      6(   5      �� 5   
   " ��6   .�5      ��  � ��$ 	0,10,20,0q�5      6)   5      �� 5   
   " ��6   .�5      ��  � ��
 �����5   %   �� 5        � ��$ Impact)�5!      6&   �� 5"       � ��$ 36(�5#      6"   �� 5$       � ��$ Center=�5%      6&   �� 5&       � ��$
 Wrap=�5'      6$   �� 5(       �@��TextAlignment$ Center=�5)      6&   �� 5*       � ��$ 0,-5,0,0q�5+      6(   �� 5,       �@J�Effect 5-        5.      50      51      �� 53   
   " ��6   .�54      ��  �@�Minimum$	 100Q�55      6#   �� 56       �@�Maximum$
 1000Q�57      6$   �� 58       �@�Value$	 500Q�59      6#   �� 5:       � ��$	 600��5;      6#   �� 5<       � ��$ 0,10,0,0q�5=      6(   �� 5>       � ��$
 Left=�5?      6$   5@      5A      .��5C      �� $
��Auto=�6   $
��Auto=�5D      .��5E   
   �� .+�5F      � $��5,10,5,0q�6    � ColumnDefinitions 5G      �� 5H      $��80 �6'   �� 5I      $��* �6'    � RowDefinitions 5K      �� 5L      �� 5M      �� 5N      �� 5O      �� 5P      �� 5Q      .+�5T      �� $��0��6   $��0��5U      #��[ 5V      Texto superior6S   �� 5W      $��1��6   $��0��5X      #��[ 5Y      Texto inferior6S   �� 5Z      $��2��6   $��0��5[      #��[ 5\      Alto6I   �� 5]      $��3��6   $��0��5^      #��[ 5_      Ancho6J   �� 5`      $��4��6   $��0��5a      #��[ 5b      Imagen6K   �� 5c      $��5��6   $��0��5d      #��[ 5e      Borde6J   �� 5f      -   5         ��Name$ superiorTextBox��5h      $��0��5f      $��1��5g      .��5h   3   Texto superior6C   �� 5i      -   5        $ inferiorTextBox��5k      $��1��5i      $��1��5j      .��5k   3   Texto inferior6C   �� 5l      -   5        	 ��Name$	 
altoSlider��5n      $��2��5l      $��1��5m      5n   /   �� 5o      -   5        $	 anchoSlider��5q      $��3��5o      $��1��5p      5q   0   �� 5r      -   5        $ imagenTextBox��5t      $��4��5r      $��1��5s      5t   3   �� 5u      -   5        
 ��Name$
 bordeCheckBox��5w      $��5��5u      $��1��5v      $��0,10,0,0q�5x       d� 	IsChecked$
 TrueY�5y      6.   5z      �� 5{      ���	#FFF3D2D2
���   �$��10q�5~      ��5}      ��  �� ElementName$ bordeCheckBox�� �� Path$ 	IsChecked� �� 	Converter# [  ��5      �� $ anchoSlider��$ Value���5�      �� $ 
altoSlider��$ Value�._�5�      � .+�5�      �� $
��Fill=�6   ��6+   �� $ imagenTextBox��$
 Text��� 5�      #��[ 6    $	��Top=�5�       ��5�       �� $ superiorTextBox��$
 Text�6Z   �� 5�      #��[ 6    $��Bottom=�5�       ��5�       �� $ inferiorTextBox��$
 Text�6Z   5�      5�      5�      5�      5�      