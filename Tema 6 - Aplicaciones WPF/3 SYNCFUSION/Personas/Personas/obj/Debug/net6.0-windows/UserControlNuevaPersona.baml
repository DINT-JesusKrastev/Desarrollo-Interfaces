   M S B A M L   `   `   `  ����C  ?Personas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PersonasPersonas  5      i eSyncfusion.SfTextInputLayout.WPF, Version=24.1.47.0, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89�Zclr-namespace:Syncfusion.UI.Xaml.TextInputLayout;assembly=Syncfusion.SfTextInputLayout.WPF"Syncfusion.UI.Xaml.TextInputLayout 5	      &     Personas.UserControlNuevaPersona   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Personas     5      rinputLayoutZclr-namespace:Syncfusion.UI.Xaml.TextInputLayout;assembly=Syncfusion.SfTextInputLayout.WPF     5	        � 	Resources  5
       �� 
TargetType �� Property �� Value��%�   '��       '�� N     �� 5   
   " ��6   .�5      ��  � ��$ 0,10,0,0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 0,0,5,0q�6'   5      5      .��5      �� $��10q�6   .+�5   
   :  4Syncfusion.UI.Xaml.TextInputLayout.SfTextInputLayout     Hint$ Nombre��5         HintFloatMode$ Float=�5         
HelperText$% Escribe el nombre de la persona��5         	InputView. 5      �� ��6   ��  �� Path$ NuevaPersona.Nombre�	 �� UpdateSourceTrigger$	 PropertyChanged=�
   LeadingView
 5      �� 5      $��./Resources/person.png��6   5        5   
   $
 Edad��5       $ Float=�5!      $# Escribe la edad de la persona��5"      . 5#      �� ��6   �� $ NuevaPersona.Edad�$	 PropertyChanged=�
 5$      �� 5%      $��./Resources/cake.png��6   5'      �� 5)   
    �� Orientation$ 
Horizontal=�6   .+�5*        $ Nacionalidad��5+      $ Float=�5,      $+ %Escribe la nacionalidad de la persona��5-      $
��Left=�5.      $	��200��5/      . 50      �� ��6   �� $ Nacionalidades� �� SelectedItem 6G   �� $ NuevaPersona.Nacionalidad�$	 PropertyChanged=�
 51      �� 52      $��./Resources/world.png��6   54      �� 55      $��+��6   $��25��6!   $��25��6,   ��68   �� $% AbrirDialogoNacionalidadCommand�56      �� 57   
   $��Aceptar��6   $��Center=�6#   $	��150��6@   ��6L   �� $ AnyadirPersonaCommand�58      59      