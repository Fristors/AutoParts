   M S B A M L   `   `   `  ����D  @AutoParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AutoParts	AutoParts  5          AutoParts.KorzPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:AutoParts     5        N� 
Background
  ����� N� Title$ KorzPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��170 �6   �� 5      $��50 �6   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��3��6    $$��Товары в корзине��64   $��Center=�6O   $��Center=�6l   $��Times New Roman)�6�   $��20(�6�   �� 5   
   -   5         ��Name$ Parts��5      $��2��6!   $��1��65   $��5q�6B   $��Stretch=�6M   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property �@�Cursor �� Value$
 Hand��6/   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   �� 5       5"      5#      ��5%      �� 5&      .R�5'      �� 
�������	 �� CornerRadius$	 15��64   $��5q�6F   
 �� Padding$
 5q�6Q   ._�5(      � $��Center=�6   $��Stretch=�6:   .+�5)      ��  �� Orientation$ 
Horizontal=�6)   $
��10 0q�6B   .+�5*   "   �� $	��100��6?   $
��Left=�6K   $��5 0 5 0q�6f   ��6(   �� *url+6f   � 5+   "   $��Center=�6'   .+�5,   &   �� $	��Top=�6F   $��20(�6^   $��Times New Roman)�6l   $
��Bold"�6�   $��0 15 0 0q�6�   ��60   �� *name+6�   �� 5-   &   $ 
Horizontal=�61   $��Bottom=�6J   $��	 0 0 0 15q�6e   .+�5.   *   �� $��16(�6a   $��Times New Roman)�6o   ��64   �� *Car.ModelCar.BrandCar.brand+6o   �� 5/   *   $�� ��64   $��16(�6=   $��Times New Roman)�6K   �� 50   *   $��16(�6X   $��Times New Roman)�6f   ��64   �� *Car.ModelCar.model+6f   51   '   52   #   53      �� 54      $��Right=�6?   $	��Top=�6[   $��0 5 0 0q�6s   $��14(�6�   $��Times New Roman)�6�   ��6(   �� *price+6�   �� 55      -   5        $��Удалить��55   %   $��Right=�67   $��Bottom=�6S   $��0 0 0 5q�6n   $��14(�6   $��Times New Roman)�6�   
�������
���  ��
�������$��0q�6�      BtnStyle#��[  6  6$  56      57      58      5:      �� 5;   
   -   5         ��Name$ CostLb��5;      $��2��6    $��2��6-   $��Right=�6=   $��Center=�6Y   $��Итого - ��6t   $��Times New Roman)�6�   $��18(�6�   $��0 0 5 0q�6�   �� 5<   
   -   5         ��Name$ wordBtn��5<      $��3��6"   $��1��6/   $	��150��6?   $	��5 7q�6L   $'��!Создать накладную��6Y   $��Right=�6u   6�   5=      5>      