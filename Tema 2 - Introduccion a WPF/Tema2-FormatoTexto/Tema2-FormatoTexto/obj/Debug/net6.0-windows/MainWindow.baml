   M S B A M L   `   `   `  ����M  ITema2-FormatoTexto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Tema2_FormatoTextoTema2_FormatoTexto  5   	   #    Tema2_FormatoTexto.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Tema2_FormatoTexto     5   	     � Title$  Texto con formato��5   	   $	��266��6#   $	��582��60    � Icon$ /Resources/Logo.ico��6<   .��5	      � .+�5
   
   �� $
��Left=�5      $��	52,54,0,0q�5      $
��Wrap=�5      $��Texto��5      $	��Top=�5      �� 5   
   -   5         ��Name$ entradaUsuarioTextBox��5      $
��Left=�5      $��	52,75,0,0q�5       �� TextWrapping$
 Wrap=�5      $�� ��5      $	��Top=�5      $	��120��5      $��64��5      6   �� 5   
   -   5         ��Name$% caracteresIntroducidosTextBlock��5      $��CharacterEllipsis=�5      $
��Left=�5      $��
52,168,0,0q�5      $��NoWrap=�5       �� TextAlignment$ Center=�5      $�� ��5       $	��Top=�5!      $	��496��5"      $��38��5#      $
��15px(�5$      ���	#FFDDF5A0���#6589395&      �� 5'   
   -   5         ��Name$ negritaCheckBox��5(      $��Negrita��5)      $
��Bold"�5*      $
��Left=�5+      $��
216,75,0,0q�5,      $	��Top=�5-      6L   �� 5.   
   -   5        $ cursivaCheckBox��5/      $��Cursiva��50      $��Italic$�51      $
��Left=�52      $��
300,75,0,0q�53      $	��Top=�54      6P   �� 55   
   $
��Left=�56      $��
400,75,0,0q�57      $
��Wrap=�58      $��Color del texto��59      $	��Top=�5:      	� 5;   
   -   5         	�Name$ 	colorAzul��5<       d� 	IsChecked$
 TrueY�5=      $
��Azul��5>      $
��Left=�5?      $��
494,63,0,0q�5@      $	��Top=�5A      	 	� 	GroupName$	 Color��5B      6   	� 5C   
   -   5        $ 	colorRojo��5D      $
��Rojo��5E      $
��Left=�5F      $��
494,83,0,0q�5G      $	��Top=�5H      $	 Color��5I      6   	� 5J   
   -   5        $ 
colorVerde��5K      $��Verde��5L      $
��Left=�5M      $��494,103,0,0q�5N      $	��Top=�5O      $	 Color��5P      6   5Q      5R      