   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:QuanLyCoiThiTuyenSinhQuanLyCoiThiTuyenSinh  5   	   (    "QuanLyCoiThiTuyenSinh.ThemTaiKhoan   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:QuanLyCoiThiTuyenSinh     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � 
ResizeMode$  NoResize=�5   	    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � Title$ ThemTaiKhoan��5   	   $	��600��6   $	��500��6+   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 20��6   $��5��6'   ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,1&�6;   .��5      � 	 � Color$	 	#FE222222��6'   
 � Offset$	
 0.2Q�69   6H   � 5      $	 	#FE224222��6'   $	
 0.5Q�69   6H   � 5      $	 	#FE225222��6'   $
 1Q�69   6F   5       5"      �� 5%      $��TẠO TÀI KHOẢN��6   $��0��5&      $��Black"�5'      $��40(�5(      
�������$��Center=�5*      $��Center=�5+      �� 5-      -   5         ��Name$ txtTenDangNhap��5/      $��1��5-      $��24(�5.      $
��Bold"�50      
�������$	��400��52      $��Center=�53      )  #MaterialDesignThemes.Wpf.HintAssist   
Foreground
 �����.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �����   Hint$ Tên đăng nhập��56       %  !MaterialDesignFloatingHintTextBox#��[  57      $��Center=�58      G� 5:      -   5         G�Name$ 
txtMatKhau��5:      $	��400��5;      $��24(�5<      $��2��5=      $
��Bold"�5>      $��Center=�5?      $��Center=�5@      
�������$ Mật khẩu��5B      
 �����
 ����� ) %MaterialDesignFloatingHintPasswordBox#��[ 5E      G� 5G      -   5        $ txtXacNhanMK��5G      $	��400��5H      $��24(�5I      $��3��5J      $
��Bold"�5K      $��Center=�5L      $��Center=�5M      
�������$ Nhập lại mật khẩu��5O      
 �   �
 �   �#��[ 5R      � 5T      $��4��6   $	��400��5U       � ColumnDefinitions 5V      �� 5W      �� 5X      .+�5[      �� -   5         ��Name$ btnTaoTaiKhoan��5a      $��0��5[       + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5\      $	��180��5]      $��50��5^      $��Tạo��5_      $��10q�5`      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5c      $��20(�5d      $
��Bold"�5e      
���"�"�$��0q�5g      �� 5i      -   5        $ btnHuy��5q      $��1��5i      #��[ 5j      $	��180��5k      $��50��5l      $��Hủy��5m      $��10q�5n      $��20(�5o      $
��Bold"�5p      
��� E��$ 20��5t      $��0q�5u      5w      5y      5z      5{      