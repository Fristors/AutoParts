   M S B A M L   `   `   `  ����D  @AutoParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AutoParts	AutoParts  5          AutoParts.AddPartPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:AutoParts     5        N� 
Background
  ����� N� Title$ AddPartPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��60 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��2��6   $1��+Добавить производителя��6$   $��Center=�6E   $��Center=�6b   $��Times New Roman)�6}   $��20(�6�   �� 5   
   $��4��6   $��4��6   $#��Добавить деталь��61   $��Center=�6K   $��Center=�6h   $��Times New Roman)�6�   $��20(�6�   �� 5    
   $��1��6   $��Название��6   $��Center=�60   $��Center=�6M      	LabelFont#��[  6h   �� 5!   
   -   5         ��Name$ PartBrandTB��5!      $��1��6'   $��1��64   $��Times New Roman)�6D   $��14(�6a   �� 5"   
   -   5        $��2��5"      $��2��6   $��Добавить��62   $
��70,0q�6E   $��Times New Roman)�6S   $��16(�6p   $��25��6�   $��Bottom=�6�   &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$
 Grid��5#   /      AutoGenerateColumns .  $��4��6>   $��5��6R   $��4��6_   $��5 0 5 5q�6p      Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер детали��6<   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6R   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *id+6R     5&      $ 
Марка��6U   $		 100 6d   
 6%   �� *Car.ModelCar.BrandCar.brand+6d     5'      $ Модель��6L   $		 100 6\   
 6%   �� *Car.ModelCar.model+6\     5(      $ Год��6J   $	 80 6W   
 6%   �� *Car.YearCar.year+6W     5)      $  Производитель��6K   $		 110 6b   
 6%   �� *Manufacturer.name+6b     5*      $ Цена��6?   $	 75 6M   
 6%   �� *price+6M   5,      �� 5-   
   -   5         ��Name$ updateButton��5-   J   $��9��6   $��1��6   $��Right=�6.   $��30��6`   $��Обновить��6l   $��70��6   6�   �� 5.   
   -   5        $ deleteButton��5.   I   $��9��6   $��2��6   $
��Left=�6.   $��30��6_   $��Удалить��6k   $��70��6}   6�   5/      50      