   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      C    =QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_NganhHoc   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $
��Left=�5   !   $��10q�5   !   .+�5      #  MaterialDesignThemes.Wpf.Card  $	��200��6.   $��40��5   .   ���	#FE222222   UniformCornerRadius$ 15Q�5   .   .��5      �� -   5         ��Name$ txtTimTenNganh��5   '   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm tên ngành��5   '      HelperTextFontSize$ 15Q�5   '   $
��Left=�5    '   $��Center=�5!   '   
�������$��5 0 0 0q�5#   '   
������ 	   
Foreground	 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist
   UnderlineBrush

 ���� $	��160��5'   '   .��63   5(      5)      '  !MaterialDesignThemes.Wpf.PackIcon  5*         Kind$ Magnify=�62   
�������$��
-28 10 0 0q�5,   2   $��20��5-   2   $��20��5.   2   5/      50      � 52      $��1��6    � ColumnDefinitions 53      �� 54      �� 55      .+�57      �� -   5        $ 
txtMaNganh��59      $��0��57      $��10q�58      $��15(�5:      $
��Bold"�5;      $	��200��5<      {�.  
���   �$ 
Mã ngành��5?       %  !MaterialDesignFloatingHintTextBox#��[  5@      $��Center=�5A      �� 5C      -   5        $ txtTenNganh��5G      $��1��5C      $��10q�5D      $��15(�5E      $
��Bold"�5F      $	��200��5H      
���   �$ Tên ngành��5J      #��[  5K      $��Center=�5L      5M      � 5O      $��2��6   
������  5S      �� 5T      �� 5U      $	��150 �6+   �� 5V      .+�5Z      � $��0��6   $��Right=�5[      $��0 0 10 0q�5\       5]      �� 5^      $��40 �6/   �� 5_      $��80 �6/   .+�5b      �� $��0q�6!   
���2͚�$��2��5d   %    �� CornerRadius$ 15��5e   %   $��40��5f   %   5g      �� 5i      -   5         ��Name$ btnFlag��5r   %   $��0��5i   !   
������ 
������ $��15(�5l   %   $��40��5m   %   $��40��5n   %   $��+��5o   %   
���   �$
��Bold"�5q   %   $��Center=�5t   %   $��Center=�5u   %   $��Right=�5v   %   $��Center=�5w   %   $
��0,10q�6@   �� 5y      -   5        $ btnThemNganhHoc��5}   '   $��1��5y   #    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5z   '   $��80��5{   '   $��Thêm��5|   '   {�.  
���   �$
��Bold"�5�   '   
������ 
������ 5�   '   �� 5�      	 �� X1$ 40��6   	 �� Y1$ 10��6'   	 �� X2$ 40��5�   #   	 �� Y2$ 50��6+   
�������$��1��5�   #   5�      �� 5�      -   5        $ btnCapNhatNganhHoc��5�   !   $��1��5�      #��[ 5�   !   $	��120��5�   !   $��40��5�   !   $��Sửa��5�   !   $��10q�5�   !   
���2͚�
���   �$
��Bold"�5�   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�   !   $��0q�5�   !   �� 5�      -   5        $ btnXoaNganhHoc��5�   !   $��2��5�      $
��Left=�5�   !   #��[ 5�   !   $	��120��5�   !   $��40��5�   !   $
��Xóa��5�   !   $��10q�5�   !   
���2͚�
���   �$
��Bold"�5�   !   $ 15��5�   !   $��0q�5�   !   5�      � 5�      $��3��6   $��Stretch=�5�      .+�5�      �� $��Danh sách ngành thi��5�      $��15q�5�      $
��Bold"�5�        MaterialDesignGroupBox#���  5�      .	  (MaterialDesignThemes.Wpf.ColorZoneAssist 	  Mode$ SecondaryMid=�5�      
������ $��Stretch=�5�      .��5�      &
   System.Windows.Controls.DataGrid
  -	   5         
 Name$ dtgNganhHoc��5�   #   $��Stretch=�5�   #   
�������$
��Bold"�5�   #    
  
IsReadOnly .  
  AutoGenerateColumns .   
  SelectionMode$ Extended=�5�   #   
���   � �� SelectedItem 5�   #   �� *SelectedNganhHoc+ 
  Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã ngành��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   ��  �� Path$ Manganh�  5�   "   $ Tên ngành��65    6H   �� $ Tennganh�5�      5�      5�      5�      5�      5�      5�      