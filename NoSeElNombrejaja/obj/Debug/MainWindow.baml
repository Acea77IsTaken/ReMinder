   M S B A M L   `   `   `  ����K  GNoSeElNombrejaja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:NoSeElNombrejajaNoSeElNombrejaja  5   	   !    NoSeElNombrejaja.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:NoSeElNombrejaja     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��850��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$ /site_bg.png��6    j� Stretch$
 None=�64    j� TileMode$
 Tile=�6C    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��2 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   ���	#FFE2A02B6   � 5   
   -   5        $��MenuSuperior��5      $��50��5      ���	#FF3E0F0F � 	Resources 5       �� 
TargetType �� Property �� Value	 �� Triggers
 P� Property P� Value��%�  '��       '�� �     �� 5      " ��6   .�5      ��  � �� �	#FFE2A02B63   	 5      P� 5      
 �@J�IsMouseOver . . �5      ��  � ��
 �����6;   5      5      �� 5      " ��6   .�5       ��  � �� �	#FF21212163   	 5!      P� 5"      
 �@J�IsMouseOver . . �5#      ��  � �� �	#FF7171716;   5$      5&      5'       � Triggers 5(      :� 5)       :� RoutedEvent$ Grid.Loaded��6   .[�5*      �� .��5+      �� .��5,      W�  �� 
TargetName$ MenuSuperior��6.    �� TargetProperty$ Opacity�5-   .    W� From$	 0.0X�5.   .   	 W� To$	 1.0X�69    g� Duration$ 0:0:02D�6B   5/      50      51       � ColumnDefinitions 53      �� 54      �� 55      �� 56      �� 57      �� 58      .+�5:      �� -   5        $��BotonTareas��5:   %   $��0��6   $��40��5;      $	��130��6!   $	��Top=�5<      ._�5=      �� $��Tareas��6   $��Cambria)�6)   $
��Bold"�6>   $��Center=�5>      $��Center=�65   $��20(�5?      $	��130��6&   $��Center=�62   5A      5B      �� 5C      -   5        $��BotonAnuncios��5C   %   $��1��6   $��40��5D      $	��130��6!   $	��Top=�5E      ._�5F      �� $��Anuncios��6   $��Cambria)�6+   $
��Bold"�6@   $��Center=�5G      $��Center=�65   $��20(�5H      $	��130��6&   $��Center=�62   5J      5K      �� 5L      -   5        $��BotonTrabajadores��5L   %   $��3��6   $��40��5M      $	��130��6!   $	��Top=�5N      ._�5O      �� $��Trabajadores��6   $��Cambria)�6/   $
��Bold"�6D   $��Center=�5P      $��Center=�65   $��20(�5Q      $	��130��6&   $��Center=�62   5S      5T      �� 5U      -   5        $��BotonSoporte��5U   %   $��4��6   $��40��5V      $	��130��6!   $	��Top=�5W      ._�5X      �� $��Soporte��6   $��Cambria)�6*   $
��Bold"�6?   $��Center=�5Y      $��Center=�65   $��20(�5Z      $	��130��6&   $��Center=�62   5\      5]      �� 5^      -   5        $��2��5^      $��/ReMinder logo.png��6$   $��50��6@   6k   5_      �� 5`   
   -   5        $��AreaContenido��5a      $��2��5`      ��5b      �� 5c      $ /site_bg.png��6   $
 Tile=�68   5f      5g      5h      