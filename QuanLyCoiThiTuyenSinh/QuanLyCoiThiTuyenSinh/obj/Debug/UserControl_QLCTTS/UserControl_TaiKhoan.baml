   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      C    =QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_TaiKhoan   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      � 
�������.+�5   
   ��   �� CornerRadius$  35��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ White��6#    � Offset$	 0.2Q�61   6@   5      5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5   
   -   5          Name$ tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6&   
������ .��5      � 	 � ColumnDefinitions	 5       �� 5!      �� 5"      �� 5#      �� 5$      .+�5'      �� -   5        
 ��Name$
 txtTenDangNhap��5(   !   $��0��5'   &   $��10q�5)   !   $	��150��5*   !   $��12(�5+   !   $
��Bold"�5,   !   
���   �{�.  )  #MaterialDesignThemes.Wpf.HintAssist   
Foreground
 �"�"�.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �"�"�   Hint$ Tên đăng nhập��51   !    %  !MaterialDesignFloatingHintTextBox#��[  52   !   $��Center=�53   !   �� 54      -   5        $
 
txtMatKhau��55   !   $��1��54   "   {�.  $��10q�57   !   $	��150��58   !   $��12(�59   !   $
��Bold"�5:   !   
���   �
 �"�"�
 �"�"�$ Mật khẩu��5>   !   #��[  5?   !   $��Center=�5@   !   �� 5A      -   5        $
 txtTenNguoiDung��5B   !   $��2��5A   "   $��10q�5C   !   $	��150��5D   !   $��12(�5E   !   {�.  $
��Bold"�5G   !   
���   �
 �"�"�
 �"�"�   HelperTextFontSize$	 100Q�5K   !   $ Tên người dùng��5L   !   #��[  5M   !   $��Center=�5N   !   �� 5O      -   5         ��Name$ 	cbbLoaiTK��5P   !   $��3��5O   #   {�.  $��10q�5R   !   $	��150��5S   !   $��12(�5T   !   $
��Bold"�5U   !   
���   �
 �"�"�
 �"�"�$ Loại tài khoản��5Y   !    & "MaterialDesignFloatingHintComboBox#��[ 5Z   !   .@�5[      �� $��1��6+   �� 5\      $��2��6+   5]      5^      5`        5b      $��1��6&   $��Center=�5c   &   
������ .��5f      � 	 5g      �� 5h      �� 5i      �� 5j      .+�5m      �� -   5         ��Name$ 
btnResetMK��5s   !   $��0��5m   !    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5n   !   $	��140��5o   !   $��40��5p   !   $��Đặt lại mật khẩu��5q   !   $��10q�5r   !   
���2͚�
���   �$
��Bold"�5w   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5x   !   $��0q�5y   !   �� 5{      -   5        $ btnPhanQuyenTK��5�   !   $��1��5{   !   #��[ 5|   !   $	��140��5}   !   $��40��5~   !   $��Phân quyền��5   !   $��10q�5�   !   
���2͚�
���   �$
��Bold"�5�   !   $ 15��5�   !   $��0q�5�   !   �� 5�      -   5        $ btnXoaTaiKhoan��5�   !   $��2��5�   !   $
��Left=�5�   !   #��[ 5�   !   $	��140��5�   !   $��40��5�   !   $
��Xóa��5�   !   $��10q�5�   !   
���2͚�
���   �$
��Bold"�5�   !   $ 15��5�   !   $��0q�5�   !   5�      5�        5�      $��2��6&   
������ $��Stretch=�5�   &   .��5�      �� $��Danh sách tài khoản��5�      $
��Bold"�5�        MaterialDesignGroupBox#���  5�      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ SecondaryMid=�5�      
������ $��15q�5�      $��Stretch=�5�      .��5�      &	   System.Windows.Controls.DataGrid	  -	   5         	 Name$ dtgTaiKhoan��5�   #   $��Stretch=�5�   #   
���   �
������� 	  AutoGenerateColumns .   	  
IsReadOnly . $
��Bold"�5�   #    	  SelectionMode$ Extended=�5�   #    �� SelectedItem 5�   #   �� *SelectedTaiKhoan+ 	  Columns 5�      0
  *System.Windows.Controls.DataGridTextColumn
  5�   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Tên đăng nhập��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   ��  �� Path$ Taikhoan�
  5�   "   $ Mật khẩu��65    6G   �� $ Matkhau�
  5�   "   $ Loại tài khoản��65    6M   �� $ Loaitaikhoan�
  5�   "   $ Tên người dùng��65    6M   �� $ Manguoidung�5�      5�      5�      5�      5�      5�      5�      