   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User&QuanLyCoiThiTuyenSinh.UserControl_User  5      E    ?QuanLyCoiThiTuyenSinh.UserControl_User.UserControl_User_ThiSinh   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffect  6*   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 15Q�5      
�������.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      .+�5        $��0��6&   $ 15Q�5   &   .��5      � $
��Left=�6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5       ��  �� Orientation$ 
Horizontal=�6%   $��0��5!   %   $
��Left=�5"   !   $��10q�5#   !   .+�5$        $	��200��62   $��40��5%   .   ���	#FE222222$ 15Q�5'   .   .��5(   "   �� -   5         ��Name$ txtFindName��5(   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Tìm tên��5*   '      HelperTextFontSize$ 15Q�5+   '   $
��Left=�5,   '   $��Center=�5-   '   
�������$��5 0 0 0q�5/   '   
������ 	   
Foreground	 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist
   UnderlineBrush

 ���� $	��160��53   '   .��63   54   #   55      '  !MaterialDesignThemes.Wpf.PackIcon  57         Kind$ Magnify=�66   
�������$��
-28 10 0 0q�59   2   $��20��5:   2   $��20��5;   2   5<      �� 5>      $ 
Horizontal=�6%   $��1��5?   %   $��Center=�5@   %   .+�5A        $	��200��62   $��40��5B   .   ���	#FE222222$ 15Q�5D   .   .��5E   "   �� -   5        $ txtFindMaPhong��5E   *   $ Tìm mã phòng��5G   +   $ 15Q�5H   +   $
��Left=�5I   +   $��Center=�5J   +   
�������$��5 0 0 0q�5L   +   
������ 	 �	#FE222222

 ���� $	��160��5P   +   .��67   5Q   #   5R        5T      $ Magnify=�66   
�������$��
-28 20 0 0q�5V   2   $��20��5W   2   $��20��5X   2   5Y      �� 5[      -   5         ��Name$ cbbNganhHoc��5b   #   $��Center=�5[   #   $��Center=�5\   #   $	��150��5]   #   $��Black"�5^   #   $��2��5_   #   $��15 0 0 0q�5`   #   $ Tìm kiếm theo ngành��5c   #    &  "MaterialDesignFloatingHintComboBox#��[  5e   #   ��5d   #   �� *#!LongListToTestComboVirtualization+5f      5h      5k      � 5m      $��1��6   .+�5n      �� $��Danh sách thí sinh��5o   !     MaterialDesignGroupBox#���  5p   !   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�5q   !   $��15q�5r   !   $
��Bold"�5s   !    � UseLayoutRounding . .��5u      &	   System.Windows.Controls.DataGrid	  -   5         	 Name$ 
dtgThiSinh��5u   #   $��Stretch=�5v   #   
���   � 	  AutoGenerateColumns .   	  
IsReadOnly .  	  SelectionMode$ Extended=�5z   #   $
��Bold"�5{   #    �� SelectedItem 5|   #   �� *SelectedThiSinh+ 	  Columns 5}      0
  *System.Windows.Controls.DataGridTextColumn
  5~   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Số báo danh��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   ��  �� Path$	 Sbd�
  5   "   $ 	Họ tên��65    6E   �� $ Hoten�
  5�   "   $ 
Ngày sinh��65    6H   �� $ Ngaysinh�
  5�   "   $ Giới tính��65    6H   �� $ Gioitinh�
  5�   "   $ Hộ khẩu��65    6F   �� $ Hokhau�
  5�   "   $ Đối tượng��65    6H   �� $ Doituong�
  5�   "   $ Ngành��65    6D   �� $ Manganh�
  5�   "   $ 	Khu vực��65    6F   �� $ Khuvuc�
  5�   "   $ 
Mã phòng��65    6G   �� $ Maphong�5�      5�      5�      5�      5�      5�      5�      