   M S B A M L   `   `   `  ����@  <prac4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:prac4prac4  5   	       prac4.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:prac4     5   	     � Title$  Engineering Calculator��5   	   $	��500��5	   	   $	��350��5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ TextBox��5      $��0��6#   $��0��60   $��5��6@   $��30(�5       $��Stretch=�6    $	��Top=�6>   $��10q�5!       �� TextAlignment$ Right=�6   $��0��64   �� 5#   
   -   5        $��1��5#      $��0��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5$      .��6<   sin6A   �� 5%   
   -   5        $��1��5%      $��1��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5&      .��6<   π6?   �� 5'   
   -   5        $��1��5'      $��2��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5(      .��6<   e6?   �� 5)   
   -   5        $��1��5)      $��3��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5*      .��6>   CE6B   �� 5+   
   -   5        $��1��5+      $��4��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5,      .��6:   DEL6?   �� 5-   
   -   5        $��2��5-      $��0��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5.      .��6<   x²6@   �� 5/   
   -   5        $��2��5/      $��1��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�50      .��6<   1/x6A   �� 51   
   -	   5        $��2��51      $��2��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�52      .��6<   |x|6A   �� 53   
   -
   5        $��2��53      $��3��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�54      .��6<   COS6A   �� 55   
   -   5        $��2��55      $��4��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�56      .��6<   tg6@   �� 58   
   -   5        $��3��58      $��0��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�59      .��6<   2√x6A   �� 5:   
   -   5        $��3��5:      $��1��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5;      .��6;   (6>   �� 5<   
   -   5        $��3��5<      $��2��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5=      .��6;   )6>   �� 5>   
   -   5        $��3��5>      $��3��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5?      .��6<   n!6@   �� 5@   
   -   5        $��3��5@      $��4��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5A      .��6=   /6@   �� 5C   
   -   5        $��4��5C      $��0��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5D      .��6=   x6@   �� 5E   
   -   5        $��4��5E      $��1��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5F      .��6:   76=   �� 5G   
   -   5        $��4��5G      $��2��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5H      .��6:   86=   �� 5I   
   -   5        $��4��5I      $��3��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5J      .��6:   96=   �� 5K   
   -   5        $��4��5K      $��4��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5L      .��6=   *6@   �� 5N   
   -   5        $��5��5N      $��0��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5O      .��6<   10^x6B   �� 5P   
   -   5        $��5��5P      $��1��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5Q      .��6:   46=   �� 5R   
   -   5        $��5��5R      $��2��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5S      .��6:   56=   �� 5T   
   -   5        $��5��5T      $��3��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5U      .��6:   66=   �� 5V   
   -   5        $��5��5V      $��4��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5W      .��6=   -6@   �� 5Y   
   -   5        $��6��5Y      $��0��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5Z      .��6<   log6A   �� 5[   
   -   5        $��6��5[      $��1��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5\      .��6:   16=   �� 5]   
   -   5        $��6��5]      $��2��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5^      .��6:   26=   �� 5_   
   -   5        $��6��5_      $��3��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5`      .��6:   36=   �� 5a   
   -   5        $��6��5a      $��4��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5b      .��6=   +6@   �� 5d   
   -    5        $��7��5d      $��0��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5e      .��6<   ln6@   �� 5f   
   -!   5        $��7��5f      $��1��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5g      .��68   +/-6=   �� 5h   
   -"   5        $��7��5h      $��2��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5i      .��6:   06=   �� 5j   
   -#   5        $��7��5j      $��3��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5k      .��6;   ,6>   �� 5l   
   -$   5        $��7��5l      $��4��6   $��Times New Roman)�6.   $
��Bold"�6K   $��20(�5m      .��6:   =6=   5n      5o      