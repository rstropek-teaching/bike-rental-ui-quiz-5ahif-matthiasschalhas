   M S B A M L   `   `   `  ����D  @WPFRental, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFRental	WPFRental  5   	       WPFRental.BikeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFRental     5   	   -   5          � Title$  Fahrräder-Ausleih��5	   	   $
��1080��6#   $
��1920��61    � WindowState$ 	Maximized=�6>    � ShowInTaskbar .  � 	Resources 5         StyleButton �� 
TargetType �� Property �� Value  StyleUeberschrift �� Triggers P� Property	 P� Value
 �� 	Resources �� Color��%�  &	        &	      '�� �    �� 5   
   " ��6$   .�5      ��  � ��$ Calibri)�6+   6=   �� 5       � ��$ 30(�6)   66   �� 5       � ��$
 Bold"�6+   6:   �� 5       � ��
 �   �6;   �� 5       � �� �	#FF03B8A76?   �� 5       � ��$ 0q�60   6<   5      �� 5   
   " ��6*   .�5      ��  � ��$ Calibri)�6+   6=   �� 5       � ��$ 36(�6)   66   �� 5       � ��$
 Bold"�6+   6:   �� 5       � �� �	#FF0028936?   5      �� 5   
   " ��6   .�5      ��  � ��
 �   �6;   �� 5       � ��$
 Bold"�6+   6:    5       P� 5!       �@��AlternationIndex$	 0��6C   . �5"      ��  � �� �	#FFC9C9C96G   5#      P� 5$       �@��AlternationIndex$	 1��6C   . �5%      ��  � �� �	#FFA8A8A86G   5&      
 5(      ���� 5)      $ White��5*      (��       5)   "   * SystemColors.HighlightBrushKey+)5*      5+      5,      5-      .��5/      � ��50   
   �� 51       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��52      �  � Color$ 	#FFCFD6CD��6    � Offset$ 1Q�61   � 53      $ 	#FFFAFFFF��6   54       � ColumnDefinitions 57   
   �� 58      $��* �6   6+   �� 59      $��3* �6   6,   .+�5<   
   � $��0��6    � RowDefinitions 5=      �� 5>      $	��13* �6    6/   �� 5?      $��* �6    6-   �� 5@      $
��1.5* �6    60   �� 5A      $��* �6    6-    5D      �� 5E      $��* �6#   6/   �� 5F      $��5* �6#   60   �� 5G      $��* �6#   6/   .+�5J      �� -   5         ��Name$ listboxBike��5J      $��3��6+   
���   �$��30(�6j    �� AlternationCount$ 2��6x   ��6?   ��  �� SelectedItem 6�   �� *item+��5K      �� 5L      .R�5M      ��  �� Orientation$ 
Horizontal=�6%   .+�5N      �� $
��10,0q�6@   ��6$   ��  �� Path$ Id�6P   �� 5O      $��-��6$   $
��10,0q�60   6@   �� 5P      $
��10,0q�6L   ��6$   �� $ PriceFirstHour�6\   �� 5Q      $	��€��6$   $	��1,0q�60   6?   �� 5R      $��-��6$   $
��10,0q�60   6@   �� 5S      $
��10,0q�6C   ��6$   �� $ Brand�6S   5T      5U      5W      �� 5X      -   5        $��2��5X      $��1��6"   $��Fahrrad Löschen��62   #���   6L   6�   5Y      � 5[   
   $��1��6    5\      �� 5]      $
��3.7* �6    60   �� 5^      $��* �6    6-    5a      �� 5b      $��* �6#   6/   �� 5c      $��* �6#   6/   .+�5g      �� $��0,0,1,1q�6   
���   �._�5h      � $��0��6   $��0��6'    5j      �� 5k      $��* �6+   67   �� 5l      $��* �6+   67    5o      �� 5p      $��* �6(   65   �� 5q      $��8* �6(   66   �� 5r      $��2* �6(   66   .+�5u      �� $��Fahrrad Hinzufügen��6   $��2��69   $��0��6M   $��Center=�6Z   $��Center=�6x   #���  6�   6�   �� 5w      $��1��6!   $��0��6.   .+�5x      �� $��Brand: ��6    $��10,13q�62   $��28(�6A   $
��Bold"�6O   6c   �� 5y      $��Purchase Date:��6    $��10,13q�69   $��28(�6H   $
��Bold"�6V   6j   �� 5z      $��Notes: ��6    $��10,13q�62   $��28(�6A   $
��Bold"�6O   6c   �� 5{      $��Date of last Service:��6    $��10,13q�6@   $��28(�6O   $
��Bold"�6]   6q   �� 5|      $!��Rental price (First hour): ��6    $��10,13q�6F   $��28(�6U   $
��Bold"�6c   6w   �� 5}      $��Rental price (Add hour):��6    $��10,13q�6C   $��28(�6R   $
��Bold"�6`   6t   �� 5~      $��Bike category: ��6    $��10,13q�6:   $��28(�6I   $
��Bold"�6W   6k   5      �� 5�      $��1��6!   $��1��6.   .+�5�      �� $��10,14q�6"   $��28(�6U   $
��Bold"�6c   ��61   �� *Brand+ �� Mode$ TwoWay=�6w   (  "System.Windows.Controls.DatePicker  5�      $��10,19q�6%   $��28(�6   $
��Bold"�6�      DisplayDate 64   �� *DateTime.Now+   SelectedDate 6Y   �� *PurchaseDate+6�   �� 5�      $��10,16q�6"   $��28(�6H   $
��Bold"�6V   ��61   �� *Notes+6j     5�      $��10,14q�6%   $��28(�6~   $
��Bold"�6�    64   �� *DateTime.Now+ 6Y   �� *LastService+6�   �� 5�      $��10,14q�6"   $��28(�6Q   $
��Bold"�6_   ��61   �� *PriceFirstHour+6t   �� 5�      $��10,19q�6"   $��28(�6O   $
��Bold"�6]   ��61   �� *PriceAddHour+6r   �� 5�      $��10,14q�6#   $��28(�62   $
��Bold"�6@    �� Text 6R   �� *
Category+.@�5�      �� $��Standardbike��6+   6D   �� 5�      $��Mountainbike��6+   6D   �� 5�      $��Treckingbike��6+   6D   �� 5�      $��
Racingbike��6+   6B   5�      5�      �� 5�      -   5        $��3��5�      $��2��6*   $��Fahrrad Hinzufügen��6>   #���   6[   $��30q�6�   6�   5�      5�      �� 5�      $��1��6   
���   �$��0,0,0,1q�69   ._�5�      � $��1��6   $��0��6'    5�      �� 5�      $��* �6+   67   �� 5�      $��* �6+   67    5�      �� 5�      $��* �6(   65   �� 5�      $��8* �6(   66   �� 5�      $��2* �6(   66   .+�5�      �� $��Fahrrad Bearbeiten��6   $��2��69   $��0��6M   $��Center=�6Z   $��Center=�6x   #���  6�   6�   �� 5�      $��1��6!   $��0��6.   .+�5�      �� $��Brand: ��6    $��10,13q�62   $��28(�6A   $
��Bold"�6O   6c   �� 5�      $��Purchase Date:��6    $��10,13q�69   $��28(�6H   $
��Bold"�6V   6j   �� 5�      $��Notes: ��6    $��10,13q�62   $��28(�6A   $
��Bold"�6O   6c   �� 5�      $��Date of last Service:��6    $��10,13q�6@   $��28(�6O   $
��Bold"�6]   6q   �� 5�      $!��Rental price (First hour): ��6    $��10,13q�6F   $��28(�6U   $
��Bold"�6c   6w   �� 5�      $��Rental price (Add hour):��6    $��10,13q�6C   $��28(�6R   $
��Bold"�6`   6t   �� 5�      $��Bike category: ��6    $��10,13q�6:   $��28(�6I   $
��Bold"�6W   6k   5�      �� 5�      $��1��6!   $��1��6.   .+�5�      �� $��10,14q�6_   $��28(�6n   $
��Bold"�6|   ��6"   �� *SelectedItem.Brand+ �� ElementName$ listboxBike��6�     5�      $��10,19q�6q   $��28(�6�   $
��Bold"�6�    6%   �� *SelectedItem.PurchaseDate+$ listboxBike��6�   �� 5�      $��10,16q�6_   $��28(�6n   $
��Bold"�6|   ��6"   �� *SelectedItem.Notes+$ listboxBike��6�     5�      $��10,14q�6p   $��28(�6   $
��Bold"�6�    6%   �� *SelectedItem.LastService+$ listboxBike��6�   �� 5�      $��10,14q�6g   $��28(�6v   $
��Bold"�6�   ��6"   �� *SelectedItem.PriceFirstHour+$ listboxBike��6�   �� 5�      $��10,19q�6e   $��28(�6t   $
��Bold"�6�   ��6"   �� *SelectedItem.PriceAddHour+$ listboxBike��6�   �� 5�      $��10,14q�6c   $��28(�6r   $
��Bold"�6�    6#   �� *SelectedItem.Category+$ listboxBike��.@�5�      �� $��Standardbike��6+   6D   �� 5�      $��Mountainbike��6+   6D   �� 5�      $��Treckingbike��6+   6D   �� 5�      $��
Racingbike��6+   6B   5�      5�      �� 5�      -   5        $��3��5�      $��2��6*   $��Fahrrad Bearbeiten��6>   #���   6[   $��30q�6�   6�   5�      5�      � 5�      $��2��6   $��1��6'    5�      �� 5�      $��7* �6'   64   �� 5�      $��* �6'   63   .+�5�      �� $
��40,0q�6   $��0��6,   $��Center=�6<   .+�5�      �� $��40(�6   $
��Bold"�6*   .��6=   Sortier Optionen6O   �� 5�      -   5        $	��cb1��5�   L   $��28(�6   $
��Bold"�6-   $	��0,5q�6?   .��6n   Price First Hour6�   �� 5�      -   5        $	��cb2��5�   L   $��28(�6   $
��Bold"�6-   $	��0,5q�6?   .��6o   Price Additional Hour6�   �� 5�      -   5        $	��cb3��5�   L   $��28(�6   $
��Bold"�6-   $	��0,5q�6?   .��6o   Purchase Date6~   5�      �� 5�      -	   5        $��1��5�      
�������.��5�      �� $��back.jpg��6    J� OpacityMask
 �   �6D   5�      5�      5�      5�      5�      