   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:QuanLyCoiThiTuyenSinhQuanLyCoiThiTuyenSinh  5   	   &     QuanLyCoiThiTuyenSinh.fNguoiDung   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:QuanLyCoiThiTuyenSinh     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
fNguoiDung��5   	   $	��600��6   $
��1080��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��3��6    �� CornerRadius$ 20��5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � 	 � Color$	 	#FE222222��6#   
 � Offset$	
 0.2Q�65   6D   5      5      � 5    
   $��0��6   $��10q�5!      .+�5"      � $
��Left=�6    5#      �� 5$      �� 5%      .+�5(      �� -   5         ��Name$ txtTimeLogin��5*      $��0��5(      $��day/month/year��5)      $��8(�5+      $��15 0 0 0q�5,      $
��Bold"�5-      ���	#FFA2A2A2��5.      Z� 5/      �� 51      -   5        $ txtTenHienThi��53      $��1��51      $��Tên hiển thị��52      $��12(�54      $��15 0 0 0q�55      $
��Bold"�56      ���	#FFA2A2A2��57      Z� 58      59      �� 5:       �� Orientation$ 
Horizontal=�6   $��Right=�5;      .+�5<      �� -   5         ��Name$ btnDoiMK_User��5>      $��Đổi mật khẩu��5<      $��15(�5=      $��Center=�5@      $��Center=�5A      $
��Bold"�5B      $��0q�5C      ���	#FFA2A2A2��5D      Z� ��5E      Z� 5F      �� 5H      -   5        $ btnExit��5L      $��15(�5H      $��Center=�5I      $��Center=�5J      $
��Bold"�5K      $��0q�5N      ���	#FFA2A2A2��5O      Z� ��5P      Z� .��5R      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�6.   $��25��6;   $��25��6F   5S      5T      5U      � 5W   
   $��1��6   $��Center=�5X      .+�5Y      �� $ 
Horizontal=�6   $��Center=�5Z      $	��Top=�5[      $
��10 0q�5\      .+�5]      �� -   5        $ tab_Menu��5`      $	��150��5]      $��50��5^      
 J� Uid$ 0��5_      $��
THÔNG TIN��5b      $��Black"�5c      ���	#FF2196F3��5d      Z� ��5e      Z� 5f      �� 5h      -   5        $	��150��5h      $��50��5i      $ 1��5j      $��	THÍ SINH��5l      $��Black"�5m      ���	#FF2196F3��5n      Z� ��5o      Z� 5p      �� 5r      -   5        $	��150��5r      $��50��5s      $ 2��5t      $��PHÒNG��5v      $��Black"�5w      ���	#FF2196F3��5x      Z� ��5y      Z� 5z      �� 5|      -   5        $	��150��5|      $��50��5}      $ 3��5~      $��NGÀNH��5�      $��Black"�5�      ���	#FF2196F3��5�      Z� ��5�      Z� 5�      �� 5�      -	   5        $	��150��5�      $��50��5�      $ 4��5�      $
��MÔN��5�      $��Black"�5�      ���	#FF2196F3��5�      Z� ��5�      Z� 5�      �� 5�      -
   5        $	��150��5�      $��50��5�      $ 5��5�      $��ĐỊA ĐIỂM THI��5�      $��Black"�5�      ���	#FF2196F3��5�      Z� ��5�      Z� 5�      �� 5�      -   5        $	��150��5�      $��50��5�      $ 6��5�      $��GIÁM THỊ��5�      $��Black"�5�      ���	#FF2196F3��5�      Z� ��5�      Z� 5�      5�      � 5�      -   5         �Name$ 
GridCursor��5�      $	��150��5�      $��5��6   ���	#FF2196F3$��Bottom=�5�      $
��Left=�5�      $��	160 0 0 0q�5�      5�      � 5�   
   -   5        $ GridMain��5�      $��2��5�      
������ 5�      5�      5�      