   M S B A M L   `   `   `  ����J  FSuperheroesMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SuperheroesMVVMSuperheroesMVVM  5   	        SuperheroesMVVM.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SuperheroesMVVM     5   	     � Title$  Superhéroes��5   	   $	��700��5	   	   $
��1000��5
   	   $	��500��5   	   $	��700��5   	   
������� � Icon$ assets/shield.ico��5   	    � 	Resources 5      $  SuperheroesMVVM.FondoConverter   conversorFondo)  #SuperheroesMVVM.VisibilityConverter  conversorVisibilidad �� 
TargetType  flechas �� Property �� Value  contador��%Z  &	        &	      &	 &     &	 �       5   
   68     5   
   6C   �� 5   
   " ��6   .�5      ��  � ��$ 24��5      6"   �� 5       � ��$ assets/arrow.png��5      60   5      �� 5   
   " ��6   .�5      ��  � ��$ 20(�5      6"   �� 5       � ��$
 Bold"�5       6$   5!      5"       J� InputBindings 5$      �� 5%   
   
 �� Key$ A��6?    �� 	Modifiers$
 Ctrlf�6G   	 �� Command	 6   �� 
 �� Path$
 SiguienteCommand�6G   �� 5&   
   $ R��6>   $
 Ctrlf�6F   	 6   �� $
 AnteriorCommand�6F   .��5)      ]� -   5         ]�Name$ superheroeDockPanel��5)      ��5*      �� $
 HeroeActual.Heroe� �� 	Converter# [  .+�5+   
   ]� ��.  $	��Top=�5,      .+�5-      �� $
��Left=�6   $��Bottom=�5.       $��40(�5/       
�������$��Segoe UI Black)�51       $��10,0,0,0q�52       ��53       �� $
 HeroeActual.Nombre� J� Effect 54      3  -System.Windows.Media.Effects.DropShadowEffect  55      6)   57      �� 58       �� Orientation$ 
Horizontal=�6   $��Right=�59   !   $��Bottom=�5:   !   .+�5;      �� $��assets/avengers.png��6   $��40��5=       $��0,0,10,0q�5>       y�5<       �� $
 HeroeActual.Vengador�# [ 5>   4   �� 5?      $��assets/xmen.png��6   $��60��5A       y�5@       �� $
 HeroeActual.Xmen�# [ 5A   -   5B      5C      �� 5E   
   $��Bottom=�6   $ 
Horizontal=�5F      $��Center=�5G      .+�5H      �� ��6   �� $
 AnteriorCommand�.��5I      �� -   5         ��Name$ 	leftImage��5I      #��[ 5J       6C   5K      �� 5L      -   5         ��Name$ actualTextBlock��5L      #��[ 5M       $��5,0,0,5q�5N       ��5O       �� $
 Actual�6?   �� 5P      #��[ 6   $��0,0,0,5q�5Q       /64   �� 5R      -   5        $ totalTextBlock��5R      #��[ 5S       $��0,0,5,5q�5T       ��5U       �� $
 Total�6>   �� 5V      ��6   �� *SiguienteCommand+.��5W      �� -   5        $ 
rightImage��5W      #��[ 5X        J� RenderTransformOrigin$ 0.5,0.5&�5Y       z�5Z      V� 5[      .~�5\      ��  �� ScaleY$ 1Q�6-    �� ScaleX$ -1Q�5]   %   �� 5^       �� AngleY$ 0Q�6,    �� AngleX$ 0Q�5_   $   �� 5`       �� Angle$ 0Q�6.   T� 5a      5b      5d      5e      5f      �� 5g   
   $��UniformToFill=�5h      $��10q�5i      ��5g      �� $
 HeroeActual.Imagen�5i   &   5j      5k      