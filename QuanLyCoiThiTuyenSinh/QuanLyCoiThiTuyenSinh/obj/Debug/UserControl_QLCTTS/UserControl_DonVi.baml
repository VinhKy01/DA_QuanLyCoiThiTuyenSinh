   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      @    :QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_DonVi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      � $��0��6   .+�5      � $��20q�6    $��Center=�6,   .+�5      �� -   5         ��Name$ 
txtMaDonVi��5   %   $��10q�5   %   $��15(�5   %   $
��Bold"�5   %   $	��200��5   %   {�.  
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã đơn vị��5   %    %  !MaterialDesignFloatingHintTextBox#��[  5   %   $��Center=�5   %   �� 5      -   5        $ txtTenDonVi��5$   %   $��10q�5    %   $��15(�5!   %   $
��Bold"�5"   %   $	��200��5#   %   
���   �$ Tên đơn vị��5&   %   #��[  5'   %   $��Center=�5(   %   5)      5*      � 5,      $��1��6    � ColumnDefinitions 5-      �� 5.      �� 5/      $	��150 �6+   �� 50      .+�54      � $��0��6   $��Right=�55      $��0 0 10 0q�56       57      �� 58      $��40 �6/   �� 59      $��80 �6/   .+�5<      �� $��0q�6!   
���2͚�$��2��5>   %    �� CornerRadius$ 15��5?   %   $��40��5@   %   5A      �� 5C      -   5         ��Name$ btnFlag��5J   %   $��0��5C   !   
������ 
������ $��15(�5F   %   $��40��5G   %   $��40��5H   %   $��+��5I   %   
���   �$
��Bold"�5M   %   $��Center=�5N   %   $��Center=�5O   %   $��Center=�5P   %   $��Center=�5Q   %   �� 5S      -   5        $ btnThemDonVi��5W   %   $��1��5S   !    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5T   %   $��80��5U   %   $��Thêm��5V   %   {�.  
���   �$
��Bold"�5[   %   
������ 
������ 5]   %   �� 5^      		 �� X1$	 40��6   	
 �� Y1$
 10��6'   	 �� X2$ 40��5_   #   	 �� Y2$ 50��6+   
���   �$��1��5a   #   5b      �� 5d      -   5        $ btnCapNhatDonVi��5i   !   $��1��5d      #��[ 5e   !   $	��120��5f   !   $��40��5g   !   $��Sửa��5h   !   $��10q�5k   !   
���2͚�
���   �$
��Bold"�5n   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5o   !   $��0q�5p   !   �� 5r      -   5        $ btnXoaDonVi��5x   !   $��2��5r      $
��Left=�5s   !   #��[ 5t   !   $	��120��5u   !   $��40��5v   !   $
��Xóa��5w   !   $��10q�5z   !   
���2͚�
���   �$
��Bold"�5}   !   $ 15��5~   !   $��0q�5   !   5�      � 5�      $��2��6   $��Stretch=�5�      .+�5�      �� $��Danh sách đơn vị��6   $
��Bold"�5�        MaterialDesignGroupBox#���  5�      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ SecondaryMid=�5�      
������ $��15q�5�      $��Stretch=�5�      .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ dtgDonVi��5�   #   $��Stretch=�5�   #   
�������   AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Extended=�5�   #   
���   � �� SelectedItem 5�   #   �� *SelectedDonVi+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Mã đơn vị��65   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6H   ��  �� Path$ Madonvi�  5�   "   $ Tên đơn vị��65    6I   �� $ Tendonvi�5�      5�      5�      5�      5�      5�      5�      