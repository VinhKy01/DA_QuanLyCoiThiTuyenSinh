   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:QuanLyCoiThiTuyenSinhQuanLyCoiThiTuyenSinh  5   	   ,    &QuanLyCoiThiTuyenSinh.fDoiMatKhau_User   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:QuanLyCoiThiTuyenSinh     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � Title$ fDoiMatKhau_User��5   	   $	��500��6"   $	��400��6/   .��5      � $��5q�6   
������ .+�5   
   ��  �� CornerRadius$ 15��6   $��20q�6#   ��5      �� 5       �� 
StartPoint$
 0, 0&�6&    �� EndPoint$
 1, 1&�68   .��5      �  � Color$ Black��6#   	 � Offset$		 0.0Q�61   � 5      $ 
DarkViolet��6#   $		 0.5Q�66   � 5      $ DarkCyan��6#   $		 1.0Q�64   5      ._�5      � ��5      �� 5      $
 0, 0&�6*   $
 1, 1&�6<   .��5      � $ Black��6'   $		 0.0Q�65   � 5      $ 
DarkViolet��6'   $		 0.5Q�6:   � 5       $ DarkCyan��6'   $		 1.0Q�68   5!      
 � RowDefinitions
 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      .+�5-      �� $��0��6   $��Center=�5.      $��Center=�5/      $��ĐỔI MẬT KHẨU��50      $��Black"�51      
�������$��40(�53      �� 55      -   5         ��Name$ txtTenTruyCap��56      $��1��55      $��Black"�57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên truy cập��58       %  !MaterialDesignFloatingHintTextBox#��[  59      $��Center=�5:      $��Center=�5;      $��0 5 0 0q�5<      $	��300��5=      $��15(�5>       �� 
IsReadOnly .    
Foreground
 �����.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �����
�������5B      G� 5D      -   5         G�Name$ txtMatKhauCu��5F   !   $��2��5D   !   $��Black"�5E   !   $ Mật khẩu cũ��5G   !   
 �����
 ����� ) %MaterialDesignFloatingHintPasswordBox#��[ 5J   !   $��Center=�5K   !   $��Center=�5L   !   $��0 5 0 0q�5M   !   $	��300��5N   !   
�������$��15(�5P   !   G� 5R      -   5        $ txtMatKhauMoi��5T   !   $��3��5R   !   $��Black"�5S   !   $ Mật khẩu mới��5U   !   
 �����
 �����#��[ 5X   !   $��Center=�5Y   !   $��Center=�5Z   !   $��0 5 0 0q�5[   !   $	��300��5\   !   
�������$��15(�5^   !   G� 5`      -   5        $ txtXacNhanMK��5b   !   $��4��5`   !   $��Black"�5a   !   $* $Xác nhận lại mật khẩu mới��5c   !   
 �����
 �����#��[ 5f   !   $��Center=�5g   !   $��Center=�5h   !   $��0 5 0 0q�5i   !   $	��300��5j   !   
�������$��15(�5l   !   � 5n      $��5��6    � ColumnDefinitions 5o      �� 5p      �� 5q      .+�5u      �� -   5         ��Name$ btnCapNhatMK��5z      $��0��5u       " MaterialDesignFlatDarkBgButton#��[ 5v      $��Cập nhật��5w      $	��130��5x      $��50��5y      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5|      $��Center=�5}      $��Center=�5~      $��Black"�5      
���   �
���2͚�5�      �� 5�      -   5        $ btnHuyCapNhatMK��5�      $��1��5�      #��[ 5�      $��Hủy��5�      $	��130��5�      $��50��5�      $��Black"�5�      
���   �$ 20��5�      $��Center=�5�      $��Center=�5�      
��� E��5�      5�      5�      5�      5�      5�      