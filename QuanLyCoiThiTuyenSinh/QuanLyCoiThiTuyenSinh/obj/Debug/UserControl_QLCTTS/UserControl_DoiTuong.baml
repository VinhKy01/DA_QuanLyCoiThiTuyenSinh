   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      C    =QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_DoiTuong   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      � 
������  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      � $��0��6   
������  5      �� 5      �� 5      .+�5      �� -   5         ��Name$ txtMaDoiTuong��5      $��0��5      $��10q�5      $��15(�5      $
��Bold"�5      $	��400��5       
���   �{�.  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã đối tượng��5#       %  !MaterialDesignFloatingHintTextBox#��[  5$      $��Center=�5%      �� 5&      -   5        $ txtTenDoiTuong��5)      $��1��5&      $��10q�5'      $��15(�5(      $
��Bold"�5*      $	��400��5+       �� TextWrapping$
 Wrap=�5,      
���   �$ Mô tả��5.      #��[  5/      $��Center=�50      52      � 54      $��1��6    � ColumnDefinitions 55      �� 56      �� 57      $	��150 �6+   �� 58      .+�5<      � $��0��6   $��Right=�5=      $��0 0 10 0q�5>       5?      �� 5@      $��40 �6/   �� 5A      $��80 �6/   .+�5D      �� $��0q�6!   
���2͚�$��2��5F   %    �� CornerRadius$ 15��5G   %   $��40��5H   %   5J      �� 5L      -   5        	 ��Name$	 btnFlag��5U   %   $��0��5L   !   
������ 
������ $��15(�5O   %   $��40��5P   %   $��40��5Q   %   $��+��5R   %   
���   �$
��Bold"�5T   %   $��Center=�5W   %   $��Center=�5X   %   $
��Left=�5Y   %   $��Center=�5Z   %   $
��0,10q�6@   �� 5\      -   5        $	 btnThemDoiTuong��5`   '   $��1��5\   #    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5]   '   $��80��5^   '   $��Thêm��5_   '   
������ 
������ 
���   �$
��Bold"�5e   '   {�.  5f   '   �� 5g      	
 �� X1$
 40��6   	 �� Y1$ 10��6'   	 �� X2$ 40��5h   #   	 �� Y2$ 50��6+   
�������$��1��5j   #   5k      �� 5n      -   5        $	 btnCapNhatDoiTuong��5r   !   $��1��5n      $	��120��5o   !   $��40��5p   !   $��Sửa��5q   !   $��10q�5t   !   
���   �$
��Bold"�5v   !   
���2͚�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5x   !   $��0q�5y   !   �� 5{      -   5        $	 btnXoaDoiTuong��5�   !   $��2��5{      $
��Left=�6-   $	��120��5|   !   $��40��5}   !    � ToolTip$< 6Resource name: MaterialDesignRaisedSecondaryDarkButton��5~   !   $
��Xóa��5   !   $��10q�5�   !   
���2͚�
���   �$
��Bold"�5�   !   $ 15��5�   !   $��0q�5�   !   5�      � 5�      $��2��6   $��Stretch=�5�      .+�5�      �� $��Danh sách khu vực��5�      $
��Bold"�5�        MaterialDesignGroupBox#���  5�      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ SecondaryMid=�5�      
������ $��15q�5�      $��Stretch=�5�      .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ dtgDoiTuong��5�   #   $��Stretch=�5�   #   
�������   
IsReadOnly .    AutoGenerateColumns .     SelectionMode$ Extended=�5�   #   
���   � �� SelectedItem 5�   #   �� *SelectedDoiTuong+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Mã đối tượng��65   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6K   ��  �� Path$ 
Madoituong�  5�   "   $ Mô tả đối tượng��65    6N   �� $ Tendoituong�5�      5�      5�      5�      5�      5�      5�      