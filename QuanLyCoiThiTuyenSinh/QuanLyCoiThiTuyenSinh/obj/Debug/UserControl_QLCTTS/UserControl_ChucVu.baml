   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      A    ;QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_ChucVu   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      � 
������� � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6&   
������ .��5      � $��0��6   .+�5      � $��20q�6$   $��Center=�60   .+�5      �� -   5         ��Name$ txtMaChucVu��5   %   $��10q�5   %   $��15(�5   %   $
��Bold"�5   %   $	��200��5   %   
���   �{�.  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã chức vụ��5!   %    %  !MaterialDesignFloatingHintTextBox#��[  5"   %   $��Center=�5#   %   �� 5$      -   5        $ txtTenChucVu��5'   %   $��10q�5%   %   $��15(�5&   %   $
��Bold"�5(   %   $	��200��5)   %   
���   �$ Tên chức vụ��5+   %   #��[  5,   %   $��Center=�5-   %   5.      5/      51        53      $��1��6&   $��0 5 0 0q�63   
������ .��56      �  � ColumnDefinitions 57      �� 58      �� 59      $	��150 �6/   �� 5:      .+�5>      � $��0��6   $��Right=�5?      $��0 0 10 0q�5@       5A      �� 5B   "   $��40 �63   �� 5C   "   $��80 �63   .+�5F      �� $��0q�6%   
���2͚�$��2��5H   %    �� CornerRadius$ 15��5I   %   $��40��5J   %   5K      �� 5M      -   5         ��Name$ btnFlag��5T   %   $��0��5M   %   
������ 
������ $��15(�5P   %   $��40��5Q   %   $��40��5R   %   $��+��5S   %   $��Center=�5V   %   $��Center=�5W   %   $
��Left=�5X   %   
���   �$
��Bold"�5Z   %   $��Center=�5[   %   $
��0,10q�6@   �� 5]      -   5        $ btnThemChucVu��5a   '   $��1��5]   '    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5^   '   $��80��5_   '   $��Thêm��5`   '   
������ 
������ 
���   �$
��Bold"�5f   '   {�.  5g   '   �� 5h      		 �� X1$	 40��6#   	
 �� Y1$
 10��6+   	 �� X2$ 40��5i   #   	 �� Y2$ 50��6+   
�������$��1��5k   #   5l      �� 5o      -   5        $ btnCapNhatChucVu��5s   !   $��1��5o   !   $	��120��5p   !   $��40��5q   !   $��Sửa��5r   !   $��10q�5u   !   
���2͚�
���   �$
��Bold"�5x   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5y   !   $��0q�5z   !   �� 5|      -   5        $ btnXoaChucVu��5�   !   $��2��5|   !   $
��Left=�61   $	��120��5}   !   $��40��5~   !    � ToolTip$< 6Resource name: MaterialDesignRaisedSecondaryDarkButton��5   !   $
��Xóa��5�   !   $��10q�5�   !   
���2͚�
���   �$
��Bold"�5�   !   $ 15��5�   !   $��0q�5�   !   5�      5�        5�      $��2��6&   
������ $��Stretch=�5�   &   .��5�      �� $��Danh sách chức vụ��5�        MaterialDesignGroupBox#���  5�      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ SecondaryMid=�5�      
������ $��15q�5�      $
��Bold"�5�      $��Stretch=�5�      .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dtgChucVu��5�   #   $��Stretch=�5�   #   
������    
IsReadOnly . $
��Bold"�5�   #      AutoGenerateColumns .     SelectionMode$ Extended=�5�   #   
���   � �� SelectedItem 5�   #   �� *SelectedChucVu+   Columns 5�      0	  *System.Windows.Controls.DataGridTextColumn	  5�   "   ,
  &System.Windows.Controls.DataGridColumn 
  Header$ Mã chức vụ��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   ��  �� Path$ Machucvu�	  5�   "   $ Tên chức vụ��65    6J   �� $ 	Tenchucvu�5�      5�      5�      5�      5�      5�      5�      