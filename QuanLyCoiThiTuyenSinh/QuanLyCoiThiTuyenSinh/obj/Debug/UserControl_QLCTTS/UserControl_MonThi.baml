   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      A    ;QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_MonThi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6&   $��0q�5   &   
���   �.��5      � $
��Left=�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6%   $
��Left=�5   %   $��0��5   %   $��10q�5    %   .+�5!        $	��200��62   $��40��5"   .   ���	#FE222222   UniformCornerRadius$ 15Q�5$   .   .��5%   "   �� -   5         ��Name$ txtTimTenMon��5%   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Tìm tên��5'   '   	   HelperTextFontSize$	 15Q�5(   '   $
��Left=�5)   '   $��Center=�5*   '   
�������$��5 0 0 0q�5,   '   
������ 
   
Foreground
 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 ���� $	��160��50   '   .��63   51   #   52      '  !MaterialDesignThemes.Wpf.PackIcon  53         Kind$ Magnify=�66   
�������$��
-28 10 0 0q�55   2   $��20��56   2   $��20��57   2   58      �� 5:      -   5         ��Name$ cbbTimNganhHoc��5@   #   $��Center=�5:   #   $��Center=�5;   #   $	��150��5<   #   $��Black"�5=   #   $��2��5>   #   $��15 0 0 0q�5?   #   $ Tìm kiếm theo ngành��5B   #    &  "MaterialDesignFloatingHintComboBox#��[  5D   #   ��5C   #   �� *#!LongListToTestComboVirtualization+5E      5F      5H      � 5J      $��1��6   
������� 5L      �� 5M      6*   �� 5N      6*   .+�5Q      � $��0��6    5R      �� 5S      61   �� 5T      61   �� 5U      61   .+�5Y      �� -   5        $ txtMaMonHoc��5[   %   $��0��5Y   "   $	��200��5Z   %   $
��Bold"�5\   %   
���   �{�.  $ Mã môn��5_   %    % !MaterialDesignFloatingHintTextBox#��[ 5`   %   $��Center=�5a   %   (  "System.Windows.Controls.DatePicker  5d      -   5          Name$ dtpkNgayThi��5f   '   $��1��5d   %   $	��200��5e   '   $
��Bold"�5g   '   
���   �$ 	Ngày thi��5i   '      HasClearButton .  ( $MaterialDesignFloatingHintDatePicker#��[ 5k   '   �� 5n      -   5        $ cbbThoiGianThi��5q   '   $��2��5n   #   $ Thời gian thi��5o   '   $
��Bold"�5p   '   $	��200��5r   '   $��Center=�5s   '      
FontFamily$ Verdana)�5t   '   #��[  5u   '   5v      5w      � 5y      $��1��6   $��0 0 0 10q�5z       5{      �� 5|      62   �� 5}      62   �� 5~      62   .+�5�      �� -   5        $ txtTenMonHoc��5�   %   $��0��5�   "   $	��200��5�   %   $
��Bold"�5�   %   
���   �$ 	Tên môn��5�   %   #��[ 5�   %   $��Center=�5�   %   �� 5�      -   5        $ 
cbbBuoiThi��5�   '   $��1��5�   #   $ 
Buổi thi��5�   '   $
��Bold"�5�   '   $	��200��5�   '   $��Center=�5�   '   $ Verdana)�5�   '   #��[  5�   '   5�      �� 5�      -	   5        $ cbbNganhHoc��5�   '   $��2��5�   #   $ Tên ngành��5�   '   $
��Bold"�5�   '   $	��200��5�   '   $��Center=�5�   '   $��Center=�5�   '   $ Verdana)�5�   '   #��[  5�   '   5�      5�      5�      � 5�      $��2��6    5�      �� 5�      �� 5�      $	��150 �6+   �� 5�      .+�5�      � $��0��6   $��Right=�5�      $��0 0 10 0q�5�       5�      �� 5�      $��40 �6/   �� 5�      $��80 �6/   .+�5�      �� $��0q�6!   
���2͚�$��2��5�   %    �� CornerRadius$ 15��5�   %   $��40��5�   %   5�      �� 5�      -
   5         ��Name$ btnFlag��5�   %   $��0��5�   !   
������ 
������ $��15(�5�   %   $��40��5�   %   $��40��5�   %   
���   �$
��Bold"�5�   %   $��+��5�   %   $��Center=�5�   %   $��Center=�5�   %   $��Center=�5�   %   $��Center=�5�   %   �� 5�      -   5        $ btnThemMonHoc��5�   %   $��1��5�   !    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5�   %   $��80��5�   %   $��Thêm��5�   %   {�.  
���   �$
��Bold"�5�   %   
������ 
������ 5�   %   �� 5�      	 �� X1$ 40��6   	 �� Y1$ 10��6'   	 �� X2$ 40��5�   #   	 �� Y2$ 50��6+   
���   �$��1��5�   #   5�      �� 5�      -   5        $ btnCapNhatMonHoc��5�   !   $��1��5�      #��[ 5�   !   $	��120��5�   !   $��40��5�   !   $��Sửa��5�   !   $��10q�5�   !   
���2͚�
���   �$
��Bold"�5�   !   +	  %MaterialDesignThemes.Wpf.ButtonAssist 	  CornerRadius$ 15��5�   !   $��0q�5�   !   �� 5�      -   5        $ btnXoaMonHoc��5�   !   $��2��5�      $
��Left=�5�   !   #��[ 5�   !   $	��120��5�   !   $��40��5�   !   $
��Xóa��5�   !   $��10q�5�   !   
���2͚�
���   �$
��Bold"�5�   !   $ 15��5�   !   $��0q�5�   !   5�      � 5�      $��3��6   $��Stretch=�5�      .+�5�      �� $��Danh sách môn thi��5�      $
��Bold"�5�        MaterialDesignGroupBox#���  5�      .
  (MaterialDesignThemes.Wpf.ColorZoneAssist 
  Mode$ SecondaryMid=�5�      $��15q�5      
������ $��Stretch=�5     .��5     &   System.Windows.Controls.DataGrid  -   5          Name$ 	dtgMonThi��5  #   $��Stretch=�5  #      AutoGenerateColumns .  
�������   
IsReadOnly . $
��Bold"�5  #      SelectionMode$ Extended=�5	  #   
���   � �� SelectedItem 5
  #   �� *SelectedMonThi+   Columns 5     0  *System.Windows.Controls.DataGridTextColumn  5  "   ,  &System.Windows.Controls.DataGridColumn   Header$ Mã môn��65   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6E   �� ! �� Path$! Mamon�  5  "   $ 	Tên môn��65     6F   �� $! Tenmon�  5  "   $ 	Ngày thi��65     6G   �� $! Ngaythi�  5  "   $ 
Buổi thi��65     6G   �� $! Buoithi�  5  "   $ Thời gian��65     6H   �� $! Thoigian�  5  "   $ Tên ngành��65     6H   �� $! Tennganh�5     5     5     5     5     5     5     