   M S B A M L   `   `   `  ����>  :Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfWpf  5   	       Wpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Wpf     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � -   5         �Name$ window��5
   "   ���	#FFD1D9DC � 	Resources 5   
      
stylButton �� 
TargetType �� Property �� Value �� 
StartPoint �� EndPoint	 � Color
 � Offset  styleDataGrid&   System.Windows.Controls.DataGrid  styleKsiazki �� Triggers P� Property P� Value �� ImageSource j� Stretch��%  &	        &	 0    &	 O    �� 5      " ��6'   .�5      ��  � ��$ 40��6+   �� 5       � ��$	 Top=�66   �� 5       � �� 5      �� 5      $ 0.5,0&�6.   $ 0.5,1&�6A   .��5      � $
	 Gray��6+   $
 0Q�68   � 5      $	 	LightBlue��6+   $
 1Q�6=   5      5      5      �� 5      "  6*   .�5      ��  �@ AutoGenerateColumns . 68   �� 5       � y�$ Hidden=�6/   �� 5       �@ CanUserAddRows .  63   �� 5       �@ CanUserDeleteRows .  66   �� 5       � �� 5       �� 5!      $ 0.5,0&�6.   $ 0.5,1&�6A   .��5"      � $
	 Gray��6+   $
 0Q�68   � 5#      $	 	LightBlue��6+   $
 1Q�6=   5$      5&      �� 5(       � ��$ 2q�64   �� 5)       � ��
 �   �60   �� 5*       � �� �	#FF3030CB6/   5,      �� 5.      " ��6)   .�5/      ��  � ��$  ��6,    50      P� 51       �@J�IsMouseOver . . �52      ��  � �� 53      �� 54   "   $ /img/wiedzmin.jpg��6-   $
 Fill=�6M   56      �� 57       �@J�Opacity$	 0.7Q�64   58      P� 59       �@J�IsMouseOver .  . �5:      ��  � ��
 ���� 67   �� 5;       �@J�Opacity$ 1Q�64   5<      5>      5?       � ColumnDefinitions 5A   
   �� 5B      $��* �6   �� 5C      $��* �6   �� 5D      $��* �6   �� 5E      $��* �6    � RowDefinitions 5H   
   �� 5I      $
��Auto �6   �� 5J      $��* �6   �� 5K      $��* �6   .+�5N   
   o� $��0��6   $��0��6   $��2��6-   .@�5O      m� ��5P      � 5Q      .+�5R      �� $��\img\gear.png��6    $��15��67   $��15��6E   $
��Left=�6T   �� 5S      $��Settings��6$   $��Right=�64   $��4q�6P   5T      .@�5V      m� $��
Background��6   .@�5W      m� -   5         m�Name$ default��5W      $��Default��60    m� 	IsChecked . 6[   �� 5X      m� 5Y      -   5        $ green��5Y      $��Green��6.   6=   m� 5Z      -   5        $
 blue��5Z      $
��Blue��6-   6;   5[      m� 5]      $��
Foreground��6   .@�5^      m� -   5        $ blackF��5^      $��Black��6/    . 6P   �� 5_      m� 5`      -   5        $
 redF��5`      $	��Red��6-   6:   m� 5a      -   5        $ blueF��5a      $
��Blue��6.   6<   5b      m� 5d      -   5        $
 bold��5d      $
��Bold��6)    .  6H   5e      m� 5f      -	   5        $��About the authors��5f      .@�5g        -
   5          Name$ authors��5g      #��[ 6,   $y�Visible=�6S   6h   5h      m� 5i      -   5        $��About the program��5i      62   5k      �� 5m   
   -   5        $��0��5m      $��2��6!   $�� ��6.   ��5n      �� 5o      $ /img/wiedzmin.jpg��6   $
 Fill=�6=   5s      �� 5u   
   -   5        $��1��5u      $��2��6!   $�� ��6.   ��5v      �� 5w      $ /img/stone.jpg��6   $
 Fill=�6:   5y      �� 5{   
   -   5        $��2��5{      $��2��6!   $�� ��6.   ��5|      �� 5}      $ /img/krol.jpg��6   $
 Fill=�69   5      �� 5�   
   $��3��6   $��1��6    $+��%Enter your info, and select the book ��6-   �� 5�   
   $��3��6   $��1��6    $��Name:��6-   $��0,50,0,0q�6=   �� 5�   
   $��3��6   $��1��6    $��Surname:��6-   $��	0,100,0,0q�6@   �� 5�   
   $��3��6   $��1��6    $��Phone:��6-   $��	0,150,0,0q�6>   �� 5�   
   -   5         ��Name$ 	firstname��5�      $��3��6%   $��1��65    �� TextWrapping$
 Wrap=�6B   $	��120��6V   $��15��6b   $��Right=�6n   $	��Top=�6�   $��0,55,0,0q�6�   6�   �� 5�   
   -   5        $ surname��5�      $��3��6#   $��1��63   $
 Wrap=�6@   $	��120��6T   $��15��6`   $��Right=�6l   $	��Top=�6�   $��	0,105,0,0q�6�   6�   �� 5�   
   -   5        $ phone��5�      .��6A   ��5�      �� 5�      " ��6   .�5�      ��  � ��$ 1��61   �� 5�       � ��$ 3��64   �� 5�       �@��TextWrapping$
 Wrap=�65   �� 5�       � ��$	 120��6/   �� 5�       � ��$ 15��60   �� 5�       � ��$ Right=�6<   �� 5�       � ��$	 Top=�6;   �� 5�       �@��	MaxLength$ 9��62   �� 5�       � ��$ 	0,155,0,0q�6/    5�      �� 5�       �� Binding 6&   ��  �� RelativeSource �� *Self+ �� Path$ Text.Length� �� Value 95�   0   .a�5�      ��  � ��
 � � �6;   5�      5�      .��5�      5�      �� 5�   
   $��2��6   $��3��6   $��Look for other books��6-   $��Center=�6L   $��20(�6i   $��Calibri)�6w   �� 5�   
   $��2��6   $��3��6   $��30q�6/   ��5�      �� 5�      $ 0.5,0&�6&   $ 0.5,1&�69   .��5�      � $	 	LightBlue��6#   $
 2Q�65   � 5�      $	 AntiqueWhite��6#   $
 0Q�68   5�      .@�5�      �� -   5         ��Name$ fantasy��5�      $��Fantasy��6+   $��10q�6=   6I   �� 5�      -   5        $ horrors��5�      $��Horror��6+   $��10q�6<   6H   �� 5�      -   5        $	 Sci��5�      $��Science fiction��6'   $��10q�6A   6M   5�      �� 5�   
   -   5        $��1��5�      $��1��6!   $��Rentals information��6.   #��[  5�      �� 5�   
   -   5        $��2��5�      $��1��6!   $��Readers information��6.   #��[  5�        5�   
   -   5        $ dataGridRentals��5�      #��[ 6,   $��1��5�      $��1��6#     5�   
   -   5        $ dataGridReaders��5�      #��[ 6,   $��2��5�      $��1��6#   60   �� 5�   
   -   5         ��Name$ reset��5�      $��Reset��6    $��1��60   #��[  6=   6a   �� 5�   
   $��0��6   $��1��6    $��Recommended books��6-   $��Bottom=�6I   $��Center=�5�      $
��Bold"�6-   $��17(�6?   $��Calibri)�6M   �� 5�   
   -   5         ��Name$ 
lblmessage��5�      $��3��6$   $��1��64   $��Bottom=�6A   $��Right=�6\   $0��*Phone number must be exactly 9 digits long��5�      $��7(�6E   
���  ��$��10q�5�      5�      5�      