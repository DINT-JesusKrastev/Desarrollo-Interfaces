   M S B A M L   `   `   `  ����C  ?Personas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PersonasPersonas  5   	   "    Personas.DialogoNacionalidad   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Personas     5   	     � Title$  Añadir nacionalidad��5   	   $	��127��6%   $	��308��62    � Icon$ ./Resources/añadir.ico��5	   	    � ShowInTaskbar$ False��5
   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%S   '��       �� 5   
   " ��6   .�5      ��  � ��$	 100��6&   5      5      .��5      ]� $
��True��6   $��10q�6%   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   $��Right=�6F   .+�5      �� -   5        $��Aceptar��5      $��0,0,10,0q�6'   	 �� 	IsDefault$
	 True��69   6J   �� 5      $��Cancelar��6   
 �� IsCancel$

 True��6(   5      �� 5   
   .+�5      �� $��Nacionalidad��6   �� 5      ��6   ��  �� Path$ Nacionalidad� �� UpdateSourceTrigger$ PropertyChanged=�5      5      5      