   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      D    >QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_DiemThiSo   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      � 
������� � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6&   $��0q�5   &   
���   �.��5      ��  �� Orientation$ 
Horizontal=�6!   $
��Left=�5   !   $��10q�5   !   .+�5        $	��200��6.   $��40��5   .   ���	#FE222222   UniformCornerRadius$ 15Q�5   .   .��5      �� -   5         ��Name$ txtTimDiaChiDiemThi��5   '   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Tìm địa chỉ điểm thi��5    '      HelperTextFontSize$ 15Q�5!   '   $
��Left=�5"   '   $��Center=�5#   '   
�������$��5 0 0 0q�5%   '   
������ 	   
Foreground	 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist
   UnderlineBrush

 ���� $	��160��5)   '   .��63   5*      5+      '  !MaterialDesignThemes.Wpf.PackIcon  5,         Kind$ Magnify=�62   
�������$��
-28 10 0 0q�5.   2   $��20��5/   2   $��20��50   2   51      52      � 54      $��1��6   
������� � ColumnDefinitions 56      �� 57      �� 58      .+�5;      �� -   5        $ txtDiemThiSo��5<      $��0��5;      $��10q�5=      $��15(�5>      $
��Bold"�5?      $	��200��5@      {�.  
���   �$ Điểm thi số��5D       %  !MaterialDesignFloatingHintTextBox#��[  5E      $��Center=�5F      �� 5H      -   5        $ txtDiaChiDiemThi��5I      $��1��5H      $��10q�5J      $��15(�5K      $
��Bold"�5L      $	��200��5M      
���   �$ Địa chỉ điểm thi��5O      #��[  5P      $��Center=�5Q      5R      � 5T      $��2��6   
������� 5V      �� 5W      �� 5X      $	��150 �6+   �� 5Y      .+�5]      � $��0��6   $��Right=�5^      $��0 0 10 0q�5_       5`      �� 5a      $��40 �6/   �� 5b      $��80 �6/   .+�5e      �� $��0q�6!   
���2͚�$��2��5g   !    �� CornerRadius$ 15��5h   !   $��40��5i   !   5k      �� 5m      -   5         ��Name$ btnFlag��5v   %   $��0��5m   !   
������ 
������ $��15(�5p   %   $��40��5q   %   $��40��5r   %   $��+��5s   %   
���   �$
��Bold"�5u   %   $��Center=�5x   %   $��Center=�5y   %   $��Center=�5z   %   $��Center=�5{   %   �� 5}      -   5        $ btnThemDiaDiemThi��5�   %   $��1��5}   !    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5~   %   $��80��5   %   $��Thêm��5�   %   {�.  
���   �$
��Bold"�5�   %   
������ 
������ 5�   %   �� 5�      	 �� X1$ 40��6   	 �� Y1$ 10��6'   	 �� X2$ 40��5�   #   	 �� Y2$ 50��6+   
�������$��1��5�   #   5�      �� 5�      -   5        $ btnCapNhatDiaDiemThi��5�   !   $��1��5�      $	��120��5�   !   $��40��5�   !   $��Sửa��5�   !   $��10q�5�   !   $
��Bold"�5�   !   
���2͚�
���   �+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�   !   $��0q�5�   !   �� 5�      -   5        $ btnXoaDiaDiemThi��5�   !   $��2��5�      $
��Left=�6-   $	��120��5�   !   $��40��5�   !    � ToolTip$< 6Resource name: MaterialDesignRaisedSecondaryDarkButton��5�   !   $
��Xóa��5�   !   $��10q�5�   !   $
��Bold"�5�   !   
���2͚�
���   �$ 15��5�   !   $��0q�5�   !   5�      � 5�      $��3��6   $��0 5 0 5q�6$   $��Stretch=�5�   &   .+�5�      �� $#��Danh sách địa điểm thi��5�        MaterialDesignGroupBox#���  5�      .	  (MaterialDesignThemes.Wpf.ColorZoneAssist 	  Mode$ SecondaryMid=�5�      $��15q�5�      $
��Bold"�5�      $��0q�5�      $��Stretch=�5�      .��5�      &
   System.Windows.Controls.DataGrid
  -	   5         
 Name$ dtgDiemThiSo��5�   #   $��Stretch=�5�   #   
������� 
  
IsReadOnly .  
  AutoGenerateColumns .   
  SelectionMode$ Extended=�5�   #   
���   �$
��Bold"�5�   #    �� SelectedItem 5�   #   �� *SelectedDiaDiemThi+ 
  Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Điểm thi số��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   ��  �� Path$ 	Diemthiso�  5�   "   $ Địa chỉ điểm thi��65    6O   �� $ Diachidiemthi�5�      5�      5�      5�      5�      5�      5�      