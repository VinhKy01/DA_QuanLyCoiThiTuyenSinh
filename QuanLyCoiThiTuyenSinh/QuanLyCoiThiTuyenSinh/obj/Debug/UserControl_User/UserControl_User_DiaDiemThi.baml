   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User&QuanLyCoiThiTuyenSinh.UserControl_User  5      H    BQuanLyCoiThiTuyenSinh.UserControl_User.UserControl_User_DiaDiemThi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffect  6*   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 15Q�5      
�������.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      .+�5        $��0��6&   $ 15Q�5   &   .��5      ��  �� Orientation$ 
Horizontal=�6!   $
��Left=�5   !   $��10q�5   !   .+�5        $	��200��6.   $��40��5   .   ���	#FE222222$ 15Q�5   .   .��5      �� -   5         ��Name$ txtTimDiaChiDiemThi��5   '   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Tìm địa chỉ điểm thi��5    '      HelperTextFontSize$ 15Q�5!   '   $
��Left=�5"   '   $��Center=�5#   '   
�������$��5 0 0 0q�5%   '   
������    
Foreground �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush
	 ���� $	��160��5)   '   .��63   5*      5+      '  !MaterialDesignThemes.Wpf.PackIcon  5,      
   Kind$
 Magnify=�62   
�������$��
-28 10 0 0q�5.   2   $��20��5/   2   $��20��50   2   51      52      � 54      $��1��6   .+�55      �� $#��Danh sách địa điểm thi��56         MaterialDesignGroupBox#���   57      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�58      $��15q�59      $
��Bold"�5:      $��0q�5;      $��Stretch=�5<      .��5=      &	   System.Windows.Controls.DataGrid	  -   5         	 Name$ dtgDiemThiSo��5=   #   $��Stretch=�5>   #   
������� 	  
IsReadOnly .  	  AutoGenerateColumns .   	  SelectionMode$ Extended=�5B   #   
���   �$
��Bold"�5D   #    �� SelectedItem 5E   #   �� *SelectedDiaDiemThi+ 	  Columns 5F      0
  *System.Windows.Controls.DataGridTextColumn
  5G   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Điểm thi số��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   ��  �� Path$ 	Diemthiso�
  5H   "   $ Địa chỉ điểm thi��65    6O   �� $ Diachidiemthi�5J      5K      5L      5N      5O      5P      5Q      