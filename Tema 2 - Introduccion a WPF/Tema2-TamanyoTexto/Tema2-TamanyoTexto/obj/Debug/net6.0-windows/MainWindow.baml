   M S B A M L   `   `   `  ����M  ITema2-TamanyoTexto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Tema2_TamanyoTextoTema2_TamanyoTexto  5   	   #    Tema2_TamanyoTexto.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Tema2_TamanyoTexto     5   	     � Title$  Tamaño del texto��5   	   $	��372��6"   $	��957��6/    � Icon$ /Resources/Logo.ico��6;   .��5	      � .+�5
   
   �� -   5         ��Name$ tituloTextBlock��5      $��Center=�5      $��0,36,0,0q�5      $
��Wrap=�5      $
��50px(�5      $
��Bold"�5      $��Desarrollo de interfaces��5      $	��Top=�5      ���	#FF6FA1DC J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      	� 5   
   -   5         	�Name$  tamanyoPequenyoRadioButton��5      
 � Tag$ pequenyo��5       	� 	GroupName$ tamanyoTexto��5      $��Pequeño��5      $
��Left=�5      $��128,262,0,0q�5      $	��Top=�5       J� RenderTransformOrigin$ 0.5,0.5&�6%   z�5       V� 5!      .~�5"      ��  �� ScaleX$ 3Q�6%   	 �� ScaleY$	 3Q�60   �� 5#      �� 5$      T� 5%      5&      5(      	� 5)   
   -   5        $ tamanyoMedioRadioButton��5*      $ medio��5+      $ tamanyoTexto��5,      
 d� 	IsChecked$

 TrueY�5-      $��Media��5.      $
��Left=�5/      $��456,262,0,0q�50      $	��Top=�51      $ 0.5,0.5&�6%   z�52      V� 53      .~�54      �� $ 3Q�6%   $	 3Q�60   �� 55      �� 56      T� 57      58      5:      	� 5;   
   -   5        $ tamanyoGrandeRadioButton��5<      $ grande��5=      $ tamanyoTexto��5>      $��Grande��5?      $
��Left=�5@      $��776,262,0,0q�5A      $	��Top=�5B      $ 0.5,0.5&�6%   z�5C      V� 5D      .~�5E      �� $ 3Q�6%   $	 3Q�60   �� 5F      �� 5G      T� 5H      5I      5K      5L      5M      