   M S B A M L   `   `   `  ����D  @AutoParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AutoParts	AutoParts  5          AutoParts.PartPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:AutoParts     5        N� 
Background
  ����� N� Title$ PartPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ PartName��5      $��3��6"   $��Center=�66   $��Center=�6S   $��Деталь - ��6n   $��Times New Roman)�6�   $��20(�6�   �� 5   
   -   5         ��Name$ PartImg��5      $��1��6!   $��5��6.   $��5q�6?   �� 5   
   $��1��6   $��1��6    $��Автомобиль��6-   $��Center=�6B   $��Times New Roman)�6]   $��16(�6z   �� 5   
   -   5        $ CarBrand��5      $��1��6"   $��2��62   $��Марка - ��6?      	LabelFont#��[  6R   �� 5   
   -   5        $ CarModel��5      $��1��6"   $��3��62   $��Модель - ��6?   #��[  6S   �� 5   
   -   5        $ CarYear��5      $��1��6!   $��4��61   $��	Год - ��6>   #��[  6O   �� 5    
   $��2��6   $��1��6    $*��$Информация о детале��6-   $��Center=�6K   $��Times New Roman)�6f   $��16(�6�   �� 5!   
   -   5        $ 	PartBrand��5!      $��2��6#   $��2��63   $#��Производитель - ��6@   #��[  6[   �� 5"   
   -   5        $ 	PartPrice��5"      $��2��6#   $��3��63   $��Цена - ��6@   #��[  6R   �� 5#   
   -   5        $��5��5#      $��2��6   $��	15 0 15 0q�6.   $(��"Добавать в корзину��6A   $��Times New Roman)�6^   $��14(�6{   6�   5$      5%      