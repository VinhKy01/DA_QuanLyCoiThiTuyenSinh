   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      C    =QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_PhongThi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      � $��0��6   $
��Left=�5      .+�5      � $
��Left=�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6%   $��0��5   %   $
��Left=�5   %   $��10q�5    %   .+�5!      #  MaterialDesignThemes.Wpf.Card  $	��200��62   $��40��5"   .   ���	#FE222222   UniformCornerRadius$ 15Q�5$   .   .��5%   "   �� -   5         ��Name$ txtFindID_Phong��5%   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm mã phòng��5'   +   	   HelperTextFontSize$	 15Q�5(   +   $
��Left=�5)   +   $��Center=�5*   +   
�������$��5 0 0 0q�5,   +   
������ 
   
Foreground
 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 ���� $	��160��50   +   .��67   51   #   52      '  !MaterialDesignThemes.Wpf.PackIcon  53         Kind$ Magnify=�66   
�������$��
-28 10 0 0q�55   2   $��20��56   2   $��20��57   2   58      �� 5:      $ 
Horizontal=�6%   $��1��5;   %   $
��Left=�5<   %   $��10q�5=   %   .+�5>        $	��200��62   $��40��5?   .   ���	#FE222222$ 15Q�5A   .   .��5B   "   �� -   5        $ txtTimDiaChi��5B   *   $ Tìm địa chỉ��5D   '   $	 15Q�5E   '   $
��Left=�5F   '   $��Center=�5G   '   
�������$��5 0 0 0q�5I   '   
������ 
 �	#FE222222
 ���� $	��160��5M   '   .��63   5N   #   5O        5P      $ Magnify=�66   
�������$��
-28 10 0 0q�5R   2   $��20��5S   2   $��20��5T   2   5U      5W      5Z      � 5\      $��1��6   
������  5^      �� 5_      6.   �� 5`      6.   .+�5c      � $��0��6    5d      �� 5e   "   �� 5f   "   .+�5i      �� -   5        $ 
txtMaPhong��5l   %   $��0��5i   &   $��Center=�5j   %   $��Center=�5k   %   {�.  $��0 -4 0 0q�5n   %   $��15(�5o   %   $
��Bold"�5p   %   $	��200��5q   %   
���   �$ 
Mã phòng��5s   %    %  !MaterialDesignFloatingHintTextBox#��[  5t   %   �� 5v      -   5         ��Name$ cbbDiaDiemThi��5z   %   $��1��5v   '   $ Địa chỉ điểm thi��5w   %   $
��Bold"�5x   %   $��0 3 0 0q�5y   %   $	��200��5{   %   $��Center=�5|   %   $��Center=�5}   %      
FontFamily$ Verdana)�5~   %    & "MaterialDesignFloatingHintComboBox#��[ 5   %   5�      5�      �� 5�      -   5        $ 	txtGhiChu��5�   !   $��1��5�   "   $��15(�5�   !   $��0 0 0 10q�5�   !   $��Center=�5�   !   $
��Bold"�5�   !   $	��410��5�   !   
���   �$ Ghi chú��5�   !   #��[  5�   !   $��Center=�5�   !   5�      � 5�      $��2��6   $��0 5 0 0q�6$   
������  5�      �� 5�      �� 5�      $	��150 �6+   �� 5�      .+�5�      � $��0��6   $��Right=�5�      $��0 0 10 0q�5�       5�      �� 5�      $��40 �6/   �� 5�      $��80 �6/   .+�5�      �� $��0q�6!   
���2͚�$��2��5�   %    �� CornerRadius$ 15��5�   %   $��40��5�   %   5�      �� 5�      -   5         ��Name$ btnFlag��5�   %   $��0��5�   !   
������ 
������ $��15(�5�   %   $��40��5�   %   $��40��5�   %   $��+��5�   %   
���   �$
��Bold"�5�   %   $��Center=�5�   %   $��Center=�5�   %   $��Center=�5�   %   $��Center=�5�   %   �� 5�      -   5        $ btnThemPhongThi��5�   %   $��1��5�   !    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5�   %   $��80��5�   %   $��Thêm��5�   %   {�.  
���   �$
��Bold"�5�   %   
������ 
������ 5�   %   �� 5�      	 �� X1$ 40��6   	 �� Y1$ 10��6'   	 �� X2$ 40��5�   #   	 �� Y2$ 50��6+   
���   �$��1��5�   #   5�      �� 5�      -	   5        $ btnCapNhatPhongThi��5�   !   $��1��5�      #��[ 5�   !   $	��120��5�   !   $��40��5�   !   $��Sửa��5�   !   $��10q�5�   !   
���   �$
��Bold"�5�   !   
���2͚�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�   !   $��0q�5�   !   �� 5�      -
   5        $ btnXoaPhongThi��5�   !   $��2��5�      $
��Left=�5�   !   #��[ 5�   !   $	��120��5�   !   $��40��5�   !   $
��Xóa��5�   !   $��10q�5�   !   
���   �$
��Bold"�5�   !   
���2͚�$ 15��5�   !   $��0q�5�   !   5�      � 5�      $��3��6   $��Stretch=�5�      .+�5�      �� $��Danh sách phòng thi��5�   !     MaterialDesignGroupBox#���  5�   !   .	  (MaterialDesignThemes.Wpf.ColorZoneAssist 	  Mode$ SecondaryMid=�5�   !   
������ $��15q�5�   !   $
��Bold"�5�   !   $��Stretch=�5�   !   .��5�      &
   System.Windows.Controls.DataGrid
  -   5         
 Name$ dtgPhongThi��5�   #   $��Stretch=�5�   #   
������� 
  AutoGenerateColumns .   
  
IsReadOnly .  
  SelectionMode$ Extended=�5�   #   $
��Bold"�5�   #   
���   � �� SelectedItem 5�   #   �� *SelectedPhongHoc+ 
  Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã phòng��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   ��  �� Path$ Maphong�  5�   "   $ Địa chỉ điểm thi��65    6O   �� $ Diachidiemthi�  5�   "   $ Ghi chú��65    6F   �� $ Ghichu�5     5     5     5     5     5     5     