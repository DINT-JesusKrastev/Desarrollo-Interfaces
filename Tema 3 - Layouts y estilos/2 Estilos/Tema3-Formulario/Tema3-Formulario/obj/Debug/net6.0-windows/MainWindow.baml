   M S B A M L   `   `   `  ����K  GTema3-Formulario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Tema3_FormularioTema3_Formulario  5   	   !    Tema3_Formulario.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Tema3_Formulario     5   	     � Title$  
Formulario��5   	   $	��559��6   $	��865��6)   $	��559��5	   	   $	��865��6    � Icon$ ./Resources/Logo.ico��5
   	   .��5      ]� $
��True��6   .+�5   
   �� $
��Wrap=�6   $��
Formulario��6(   $	��Top=�6:   $
��40px(�6O   $
��Bold"�6_   $��0,20,0,0q�6q   $
��Auto��6�    �� TextAlignment$ Center=�6�   ]� 5   
   $��Bottom=�6   $
��True��6,   $��Center=�6A   .+�5      �� $
��Wrap=�6   $��Jesús Krastev��6,   $
��20px(�6A   $
��Auto��6Q   $��Italic$�6^   $ Center=�6q   $
��Left=�6�   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� $��5q�6   $��Aceptar��6%   $
��90px��67   $
��25px��6D   6T   �� 5      $��5q�6   $��Cancelar��6$   $
��90px��67   $
��25px��6D   6T   5      �� 5      6   5      ]� 5   
   $
��True��6   .+�5      �� $��10q�6   $��./Resources/foto.jpg��6    $��Right=�6>   6W   �� 5      .+�5      �� $��3q�6    �� CornerRadius$ 3��6-   
���   �$��10q�6R    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      ._�5      �� 
����ح�.+�5      ]� $
��True��6    .+�5      �� $
��Wrap=�6$   $��Nombre��68   $��10q�6F   $��50��6R   $
��Left=�6]   �� 5      $��20��6$   $��20��6/   $��0,0,10,0q�6;   $��Right=�6N    � ToolTip$ Máximo 100 caracteres��6e   ��5       �� 5!   "    �� ImageSource$ /Resources/info.png��6-   5#      �� 5$       �� TextWrapping$
 Wrap=�6"   $�� ��66   $
��Auto��6>   $��10q�6K   5%      ]� 5&      $
��True��6    .+�5'      �� $
��Wrap=�6$   $
��Edad��68   $��10q�6D   $��50��6P   $
��Left=�6[   �� 5(      $��20��6$   $��20��6/   $��0,0,10,0q�6;   $��Right=�6N   $" Número entero entre 0 y 100��6e   ��5)      �� 5*   "   $ /Resources/info.png��6-   5,      �� 5-      $
 Wrap=�6"   $�� ��66   $
��Auto��6>   $��10q�6K   5.      ]� 5/      $
��True��6    .+�50      �� $
��Wrap=�6$   $��
Dirección��68   $��10q�6I   $��50��6U   $
��Left=�6`   �� 51      $��20��6$   $��20��6/   $��0,0,10,0q�6;   $��Right=�6M   $ Incluir el código postal��6d   ��52      �� 53   "   $ /Resources/info.png��6-   55      �� 56      $
 Wrap=�6"   $�� ��66   $
��Auto��6>   $��10q�6K   57      58      59      �� 5;      $��3q�6   $ 3��6-   
���   �$��10q�6R    5<        5=      ._�5?      �� 
�������$ 
Horizontal=�6C   .+�5@      �� $��	Aficiones��6#   $	��200��66   $	��100��6B   $��10,20,20,20q�6O   .��5A      �� $
��Left=�6)   $��Center=�6D   $��10,0,0,0q�6`   .+�5B   "   �� $��Hacer deporte��6+   �� 5C   "   $��Viajar��6+   �� 5D   "   $��
Ver series��6+   �� 5E   "   $��Leer comics��6+   5F      5G      �� 5H      $��Estado civil��6#   $	��200��69   $	��100��6E   .��5I      �� $
��Left=�6)   $��Center=�6D   $��10,0,0,0q�6`   .+�5J   "   	� $��Soltero��6.   	 d� 	IsChecked$
	 TrueY�6@   
 	� 	GroupName$
 estadoCivil��6Q   	� 5K   "   $��Casado��6.   $
 estadoCivil��6?   	� 5L   "   $��
Divorciado��6.   $
 estadoCivil��6C   	� 5M   "   $��Viudo��6.   $
 estadoCivil��6>   5N      5O      5P      5Q      5R      5S      5T      5U      