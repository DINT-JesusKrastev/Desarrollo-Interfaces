   M S B A M L   `   `   `  ����F  BSuperheroes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperheroesSuperheroes  5   	       Superheroes.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Superheroes     5   	     � Title$  Superhéroes��5   	   $	��506��6   $	��694��6*   $	��500��66   $	��695��6F    � Icon$ ./Resources/shield.ico��5	   	    � 	Resources 5       �� 
TargetType �� Property �� Value 
  Flecha 
 Titulo3  -System.Windows.Media.Effects.DropShadowEffect  Liga)  #Superheroes.LigaBooleanToVisibility $  LigaBooleanToVisibilityConversor*  $Superheroes.HeroeBooleanToBackground % !HeroeBooleanToBackgroundConversor��%�  ']�       &	  J     &	 �     &	      &	 J    &	 ]    �� 5   
   " ]�6   .�5      ��  � ��$
 True��6.   5      �� 5   
   " ��6   .�5      ��  � ��$ 25��6&   �� 5       � ��$ 25��6'   �� 5       � ��$ ./Resources/arrow.png��6'   -   5        5      �� 5   
   " ��6   .�5      ��  � ��$ 40(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Segoe UI Black)�6+   �� 5       � ��
 �����6+   �� 5       �@J�Effect 5        5      5      5      �� 5    
   " ��6   .�5!      ��  � ��$
 Fill=�6(   5"        5#   
   6S     5$   
   6U   5%      .��5(      ]� -   5         ]�Name$ PanelPrincipal��5(      ��6(   ��  �� Path$ Heroe� �� 	Converter# [ .+�5)   
   ]� $	��Top=�6   .+�5*      �� $
��Left=�65   $��10,0,0,5q�6K   #��[ 6]   ��6   �� $ Nombre�	 J� Effect	 5+        5,      5.      �� 5/      
 �� Orientation$
 
Horizontal=�6   $��Right=�62   $��5q�6I   .+�50      �� $��./Resources/avengers.png��6   $��40��6:   $��45��6E   #��[ 6Q   $��0,0,5,0q�6o   y�6�   �� $ Vengador�# [ �� 51      $��./Resources/xmen.png��6   $��60��66   $��50��6A   #��[ 6M   y�6k   �� $
 Xmen�# [ 52      �� 53      6   54      �� 55   
   $
 
Horizontal=�6   $��Bottom=�6.   $��Center=�6F   .+�56      �� -   5         ��Name$ btnFlechaIzq��56      #��[  6*   �� 57      -   5         ��Name$ numeracionPersonaje��57      $	��1/3��65   $
��Bold"�6@   $��20(�6R   $��5q�6`   �� 58      -   5        $ btnFlechaDrch��58      #��[  6+    J� RenderTransformOrigin$ 0.5,0.5&�6K   z�59      V� 5:      .~�5;      �� �� 5<      �� 5=       �� Angle$	 180Q�6*   T� 5>      5?      5A      5B      �� 5C   
   $
��10,0q�6*   $��UniformToFill=�68   ��6   �� *Imagen+68   5D      5E      