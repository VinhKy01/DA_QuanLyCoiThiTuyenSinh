   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User&QuanLyCoiThiTuyenSinh.UserControl_User  5      D    >QuanLyCoiThiTuyenSinh.UserControl_User.UserControl_User_MonThi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffect  6*   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 15Q�5      
�������.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      .+�5        $��0��6&   $ 15Q�5   &   .��5      � $
��Left=�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6%   $
��Left=�5   %   $��0��5   %   $��10q�5    %   .+�5!        $	��200��62   $��40��5"   .   ���	#FE222222$ 15Q�5$   .   .��5%   "   �� -   5         ��Name$ txtTimTenMon��5%   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Tìm tên��5'   '      HelperTextFontSize$ 15Q�5(   '   $
��Left=�5)   '   $��Center=�5*   '   
�������$��5 0 0 0q�5,   '   
������ 	   
Foreground	 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist
   UnderlineBrush

 ���� $	��160��50   '   .��63   51   #   52      '  !MaterialDesignThemes.Wpf.PackIcon  53         Kind$ Magnify=�66   
�������$��
-28 10 0 0q�55   2   $��20��56   2   $��20��57   2   58      �� 5:      -   5         ��Name$ cbbNganhHoc��5@   #   $��Center=�5:   #   $��Center=�5;   #   $	��150��5<   #   $��Black"�5=   #   $��2��5>   #   $��15 0 0 0q�5?   #   $ Tìm kiếm theo ngành��5B   #    &  "MaterialDesignFloatingHintComboBox#��[  5D   #   ��5C   #   �� *#!LongListToTestComboVirtualization+5E      5F      5H      � 5J      $��1��6   .+�5K      �� $��Danh sách môn thi��5L      $
��Bold"�5M        MaterialDesignGroupBox#���  5N      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�5O      $��15q�5P      
������ $��Stretch=�5R      .��5S      &	   System.Windows.Controls.DataGrid	  -   5         	 Name$ 	dtgMonThi��5S   #   $��Stretch=�5T   #    	  AutoGenerateColumns .  
������� 	  
IsReadOnly . $
��Bold"�5X   #    	  SelectionMode$ Extended=�5Y   #   
���   � �� SelectedItem 5Z   #   �� *SelectedMonThi+ 	  Columns 5\      0
  *System.Windows.Controls.DataGridTextColumn
  5]   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Mã môn��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   ��  �� Path$ Mamon�
  5^   "   $ 	Tên môn��65    6F   �� $ Tenmon�
  5_   "   $ 	Ngày thi��65    6G   �� $ Ngaythi�
  5`   "   $ 
Buổi thi��65    6G   �� $ Buoithi�
  5a   "   $ Thời gian��65    6H   �� $ Thoigian�
  5b   "   $ Tên ngành��65    6H   �� $ Tennganh�5d      5e      5f      5h      5i      5j      5k      