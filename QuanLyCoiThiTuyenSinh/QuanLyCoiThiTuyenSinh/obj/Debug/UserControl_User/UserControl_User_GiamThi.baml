   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User&QuanLyCoiThiTuyenSinh.UserControl_User  5      E    ?QuanLyCoiThiTuyenSinh.UserControl_User.UserControl_User_GiamThi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffect  6*   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 15Q�5      
�������.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      .+�5        $��0��6&   $ 15Q�5   &   .��5      � $
��Left=�6   $��Center=�5       � ColumnDefinitions 5      �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6%   $
��Left=�5   %   $��0��5    %   $��10q�5!   %   .+�5"        $	��200��62   $��40��5#   .   ���	#FE222222$ 15Q�5%   .   .��5&   "   �� -   5         ��Name$ txtFindName_GiamThi��5&   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm tên giám thị��5(   '      HelperTextFontSize$ 15Q�5)   '   $
��Left=�5*   '   $��Center=�5+   '   
�������$��5 0 0 0q�5-   '   
������ 	   
Foreground	 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist
   UnderlineBrush

 ���� $	��160��51   '   .��63   52   #   53      '  !MaterialDesignThemes.Wpf.PackIcon  54         Kind$ Magnify=�66   
�������$��
-28 10 0 0q�56   2   $��20��57   2   $��20��58   2   59      �� 5;      $ 
Horizontal=�6%   $
��Left=�5<   %   $��1��5=   %   $��10q�5>   %   .+�5?        $	��200��62   $��40��5@   .   ���	#FE222222$ 15Q�5B   .   .��5C   "   �� -   5        $ txtTimDiaChiDiemThi��5C   +   $# Tìm địa chỉ điểm thi��5E   +   $ 15Q�5F   +   $
��Left=�5G   +   $��Center=�5H   +   
�������$��5 0 0 0q�5J   +   
������ 	 �	#FE222222

 ���� $	��160��5N   +   .��67   5O   #   5P        5Q      $ Magnify=�66   
�������$��
-28 10 0 0q�5S   2   $��20��5T   2   $��20��5U   2   5V      5X      5Z      � 5\      $��1��6   .+�5]      �� $��Danh sách giám thị��5^      $
��Bold"�5_         MaterialDesignGroupBox#���   5`      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�5a      
������ $��15q�5c      $��Stretch=�5d      .��5e      &	   System.Windows.Controls.DataGrid	  -   5         	 Name$ 
dtgGiamThi��5e   #   $��Stretch=�5f   #   
������� 	  
IsReadOnly .  	  SelectionMode$ Extended=�5i   #    	  AutoGenerateColumns .  $
��Bold"�5k   #   
���   � �� SelectedItem 5l   #   �� *SelectedGiamThi+ 	  Columns 5n      0
  *System.Windows.Controls.DataGridTextColumn
  5o   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Mã giám thị��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   ��  �� Path$ 	Magiamthi�
  5p   "   $ Tên giám thị��65    6K   �� $ 
Tengiamthi�
  5q   "   $ Tên đơn vị��65    6I   �� $ Tendonvi�
  5r   "   $ Giới tính��65    6H   �� $ Gioitinh�
  5s   "   $ Tên chức vụ��65    6J   �� $ 	Tenchucvu�
  5t   "   $ Địa chỉ điểm thi��65    6O   �� $ Diachidiemthi�5v      5w      5x      5z      5{      5|      5}      