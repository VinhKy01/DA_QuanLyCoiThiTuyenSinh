   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      E    ?QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_DoiMatKhau   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
������ .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 35Q�6"   
���OO/�$	��450��5   "   $	��650��5   "   $��0 0 0 0q�5   "   .��5      � $��Center=�6   $��Center=�5      $	��450��5      $	��650��5       � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5       � $��0��6    $��Center=�5!       $��Center=�5"       $��0 15 0 0q�5#       .+�5$      �� $��ĐỔI MẬT KHẨU��6$   $��35(�5%   $   
�������5&   $   5'      � 5(      $��1��6    $��Center=�5)      .+�5*      �� -   5         ��Name$ txtTenTruyCap��5+      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên truy cập��5,       %  !MaterialDesignFloatingHintTextBox#��[  5-      $��Center=�5.      $��Center=�5/      $��0 5 0 0q�50      $	��300��51      $��15(�52       �� 
IsReadOnly .    
Foreground
 �����.  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush
	 �����
�������56      57      � 59      $��2��6    $��Center=�5:      .+�5;      G� -   5        
 G�Name$
 txtMatKhauCu��5<   !   $ Mật khẩu cũ��5=   !   
 �����
	 ����� ) %MaterialDesignFloatingHintPasswordBox#��[ 5@   !   $��Center=�5A   !   $��Center=�5B   !   $��0 5 0 0q�5C   !   $	��300��5D   !   
�������$��15(�5F   !   5G      � 5I      $��3��6    $��Center=�5J      .+�5K      G� -   5        $
 txtMatKhauMoi��5L   !   $ Mật khẩu mới��5M   !   
 �����
	 �����#��[ 5P   !   $��Center=�5Q   !   $��Center=�5R   !   $��0 5 0 0q�5S   !   $	��300��5T   !   
�������$��15(�5V   !   5W      � 5Y      $��4��6    $��Center=�5Z      .+�5[      G� -   5        $
 txtXacNhanMK��5\   !   $* $Xác nhận lại mật khẩu mới��5]   !   
 �����
	 �����#��[ 5`   !   $��Center=�5a   !   $��Center=�5b   !   $��0 5 0 0q�5c   !   $	��300��5d   !   
�������$��15(�5f   !   5g      � 5i      $��5��6   $��Center=�5j      $��Center=�5k       � ColumnDefinitions 5l      �� 5m      �� 5n      .+�5r      �� -   5         ��Name$ btnCapNhatMK��5x      $��0��5r       " MaterialDesignFlatDarkBgButton#��[ 5s      $��Cập nhật��5t      $	��150��5u      $��50��5v      $��	30 0 0 20q�5w      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5z      $��Center=�5{      $��Center=�5|      
���"�"�5}      �� 5~      -   5        $ btnHuyCapNhatMK��5�      $��1��5~      #��[ 5      $��Hủy��5�      $	��150��5�      $��50��5�      $��
30 0 30 20q�5�      $ 15��5�      $��Center=�5�      $��Center=�5�      
��� E��5�      5�      5�      5�      5�      5�      5�      