   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      H    BQuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_GiamThiCoiThi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      � $��0��6   .+�5      � $
��Left=�6   $��Center=�5       � ColumnDefinitions 5      �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6%   $
��Left=�5   %   $��0��5   %   $��10q�5   %   .+�5       #  MaterialDesignThemes.Wpf.Card  $	��200��62   $��40��5!   .   ���	#FE222222   UniformCornerRadius$ 15Q�5#   .   .��5$   "   �� -   5         ��Name$ txtFindName_GiamThi��5$   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm tên giám thị��5&   '   	   HelperTextFontSize$	 15Q�5'   '   $
��Left=�5(   '   $��Center=�5)   '   
�������$��5 0 0 0q�5+   '   
������ 
   
Foreground
 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 ���� $	��160��5/   '   .��63   50   #   51      '  !MaterialDesignThemes.Wpf.PackIcon  52         Kind$ Magnify=�66   
�������$��
-28 10 0 0q�54   2   $��20��55   2   $��20��56   2   57      �� 59      $ 
Horizontal=�6%   $
��Left=�5:   %   $��1��5;   %   $��10q�5<   %   .+�5=        $	��200��62   $��40��5>   .   ���	#FE222222$ 15Q�5@   .   .��5A   "   �� -   5        $ txtTimDiaChiDiemThi��5A   +   $# Tìm địa chỉ điểm thi��5C   +   $	 15Q�5D   +   $
��Left=�5E   +   $��Center=�5F   +   
�������$��5 0 0 0q�5H   +   
������ 
 �	#FE222222
 ���� $	��160��5L   +   .��67   5M   #   5N        5O      $ Magnify=�66   
�������$��
-28 10 0 0q�5Q   2   $��20��5R   2   $��20��5S   2   5T      5V      5X        5Z      $��1��6&   
������ .��5]      � $��0��6    5_      �� 5`      6.   �� 5a      6.   .+�5d      � $��0��6    5e      �� 5f   "   �� 5g   "   �� 5h   "   .+�5j      �� -   5        $ txtMaGiamThi��5l   %   $��0��5j   &   $
��Bold"�5k   %   $	��200��5m   %   {�.  $��Center=�5o   %   
���   �$ Mã giám thị��5q   %    %  !MaterialDesignFloatingHintTextBox#��[  5r   %   $��Center=�5s   %   �� 5t      -   5        $ txtTenGiamThi��5v   %   $��1��5t   &   $
��Bold"�5u   %   $	��200��5w   %   $��Center=�5x   %   
���   �$ Tên giám thị��5z   %   #��[  5{   %   $��Center=�5|   %   �� 5~      -   5         ��Name$ cbbDonVi��5�   '   $��2��5~   '   $ Tên đơn vị��5   '   $
��Bold"�5�   '   $	��200��5�   '   $��Center=�5�   '      
FontFamily$ Verdana)�5�   '   $��72��5�   '    & "MaterialDesignFloatingHintComboBox#��[ 5�   '   5�      5�      � 5�      $��1��6   $��0 0 0 15q�5�       5�      �� 5�   "   �� 5�   "   �� 5�   "   .+�5�      �� -   5        $ 	cbbChucVu��5�   '   $��0��5�   '   $ Tên chức vụ��5�   '   $
��Bold"�5�   '   $	��200��5�   '   $��Center=�5�   '   $ Verdana)�5�   '   $��72��5�   '   #��[ 5�   '   5�      � 5�      $��1��6#   $��Center=�63   $��Center=�5�   2   $	��200��5�   2   $��0 10 0 0q�5�   #   
������  5�   "   �� 5�   &   �� 5�   &   �� 5�   &   .+�5�   "   �� $��0��6,   $��Giới Tính��5�   %   
���   �$
��Bold"�5�   %   $��15��5�   %   	� 5�   "   -   5         	�Name$ rbNam��5�   �    d� 	IsChecked$
 TrueY�6.   
���2͚�$��1��6X   
���   �$
��Bold"�6{   $	��Nam��6�   	� 5�   "   -	   5        $
 rbNu��5�   }   
���2͚�$��2��6G   
���   �$
��Bold"�6j   $
��Nữ��6�   5�      �� 5�      -
   5        $ cbbDiaDiemThi��5�   '   $��2��5�   '   $ Địa chỉ điểm thi��5�   '   $
��Bold"�5�   '   $	��200��5�   '   $��Center=�5�   '   $ Verdana)�5�   '   $��72��5�   '   #��[ 5�   '   5�      5�      5�      5�      � 5�      $��2��6    5�      �� 5�      �� 5�      $	��150 �6+   �� 5�      .+�5�      � $��0��6   $��Right=�5�      $��0 0 10 0q�5�       5�      �� 5�      $��40 �6/   �� 5�      $��80 �6/   .+�5�      �� $��0q�6!   
���2͚�$��2��5�   %    �� CornerRadius$ 15��5�   %   $��40��5�   %   5�      �� 5�      -   5         ��Name$ btnFlag��5�   %   $��0��5�   !   
������ 
������ $��15(�5�   %   $��40��5�   %   $��40��5�   %   $��+��5�   %   
���   �$
��Bold"�5�   %   $��Center=�5�   %   $��Center=�5�   %   $��Center=�5�   %   $��Center=�5�   %   �� 5�      -   5        $ btnThemGiamThi��5�   %   $��1��5�   !    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5�   %   $��80��5�   %   $��Thêm��5�   %   {�.  
���   �$
��Bold"�5�   %   
������ 
������ 5�   %   �� 5�      	 �� X1$ 40��6   	 �� Y1$ 10��6'   	 �� X2$ 40��5�   #   	 �� Y2$ 50��6+   
���   �$��1��5�   #   5�      �� 5�      -   5        $ btnCapNhatGiamThi��5   !   $��1��5�      #��[ 5�   !   $	��120��5�   !   $��40��5�   !   $��Sửa��5�   !   $��10q�5  !   
���2͚�
���   �$
��Bold"�5  !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5  !   $��0q�5  !   �� 5	     -   5        $ btnXoaGiamThi��5  !   $��2��5	     $
��Left=�5
  !   #��[ 5  !   $	��120��5  !   $��40��5  !   $
��Xóa��5  !   $��10q�5  !   
���2͚�
���   �$
��Bold"�5  !   $ 15��5  !   $��0q�5  !   5     � 5     $��3��6   $��Stretch=�5     .+�5     �� $��Danh sách giám thị��5     $
��Bold"�5       MaterialDesignGroupBox#���  5     .	  (MaterialDesignThemes.Wpf.ColorZoneAssist 	  Mode$ SecondaryMid=�5     
������ $��15q�5!     $��Stretch=�5"     .��5#     &
   System.Windows.Controls.DataGrid
  -   5         
 Name$ 
dtgGiamThi��5#  #   $��Stretch=�5$  #   
������� 
  
IsReadOnly .  
  SelectionMode$ Extended=�5'  #    
  AutoGenerateColumns .  $
��Bold"�5)  #   
���   � �� SelectedItem 5*  #   �� *SelectedGiamThi+ 
  Columns 5,     0  *System.Windows.Controls.DataGridTextColumn  5-  "   ,  &System.Windows.Controls.DataGridColumn   Header$ Mã giám thị��65   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6J   �� ! �� Path$! 	Magiamthi�  5.  "   $ Tên giám thị��65     6K   �� $! 
Tengiamthi�  5/  "   $ Tên đơn vị��65     6I   �� $! Tendonvi�  50  "   $ Giới tính��65     6H   �� $! Gioitinh�  51  "   $ Tên chức vụ��65     6J   �� $! 	Tenchucvu�  52  "   $ Địa chỉ điểm thi��65     6O   �� $! Diachidiemthi�54     55     57     58     59     5:     5;     