   M S B A M L   `   `   `  ����D  @AutoParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AutoParts	AutoParts  5   	       AutoParts.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:AutoParts     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $��Center=�6   $��Center=�64   $��Автозапчасти��6V   $��Times New Roman)�6m   $��20(�6�   �� 5   
   -   5         ��Name$ 	CatalogBt��5      $��1��6$   $��5q�61   $��Каталог��6<   $��Times New Roman)�6N   $��16(�6k   
�������
�������6�   �� 5   
   -   5        $ KorzBt��5      $��2��6!   $��5q�6.   $��Корзина��69   $��Times New Roman)�6K   $��16(�6h   
�������
�������6�   �� 5   
   -   5         ��Name$ UserName��5      $��1��6"   $
��null��62   $��Right=�6A   $	��Top=�6]   $��0 5 5 0q�6u   $��Times New Roman)�6�   $��14(�6�   �� 5   
   -   5        $ InfoPage��5      $��1��6"   $%��Главная страница��62   $��Center=�6M   $��Center=�6j   $��Times New Roman)�6�   $��26(�6�   �� 5   
   $��1��6   $��1��6   $��4��6,   $
��Left=�6=   $��5��6X   $��5��6b   
���   �6m    � 5   
   -   5        $��FrmMain��5        � NavigationUIVisibility$ Hidden=�5      $��1��5       $��4��5!      $��1��5"      5#      5$      