   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User&QuanLyCoiThiTuyenSinh.UserControl_User  5      F    @QuanLyCoiThiTuyenSinh.UserControl_User.UserControl_User_PhongThi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_User     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffect  6*   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 15Q�5      
�������.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      .+�5        $��0��6&   $ 15Q�5   &   .��5      � $
��Left=�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6%   $��0��5   %   $
��Left=�5    %   $��10q�5!   %   .+�5"        $	��200��62   $��40��5#   .   ���	#FE222222$ 15Q�5%   .   .��5&   "   �� -   5         ��Name$ txtFindID_Phong��5&   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm mã phòng��5(   +      HelperTextFontSize$ 15Q�5)   +   $
��Left=�5*   +   $��Center=�5+   +   
�������$��5 0 0 0q�5-   +   
������ 	   
Foreground	 �	#FE222222.  (MaterialDesignThemes.Wpf.TextFieldAssist
   UnderlineBrush

 ���� $	��160��51   +   .��67   52   #   53      '  !MaterialDesignThemes.Wpf.PackIcon  54         Kind$ Magnify=�66   
�������$��
-28 10 0 0q�56   2   $��20��57   2   $��20��58   2   59      �� 5;      $ 
Horizontal=�6%   $��1��5<   %   $
��Left=�5=   !   $��10q�5>   !   .+�5?        $	��200��62   $��40��5@   .   ���	#FE222222$ 15Q�5B   .   .��5C   "   �� -   5        $ txtTimDiaChi��5C   *   $ Tìm địa chỉ��5E   '   $ 15Q�5F   '   $
��Left=�5G   '   $��Center=�5H   '   
�������$��5 0 0 0q�5J   '   
������ 	 �	#FE222222

 ���� $	��160��5N   '   .��63   5O   #   5P        5Q      $ Magnify=�66   
�������$��
-28 10 0 0q�5S   2   $��20��5T   2   $��20��5U   2   5V      5X      5[      � 5]      $��1��6   .+�5^      �� $��Danh sách phòng thi��5_   !      MaterialDesignGroupBox#���   5`   !   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�5a   !   
������ $��15q�5c   !   $
��Bold"�5d   !   $��Stretch=�5e   !   .��5f      &	   System.Windows.Controls.DataGrid	  -   5         	 Name$ dtgPhongThi��5f   #   $��Stretch=�5g   #   
������� 	  AutoGenerateColumns .   	  
IsReadOnly .  	  SelectionMode$ Extended=�5k   #   $
��Bold"�5l   #   
���   � �� SelectedItem 5m   #   �� *SelectedPhongHoc+ 	  Columns 5o      0
  *System.Windows.Controls.DataGridTextColumn
  5p   "   ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã phòng��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   ��  �� Path$ Maphong�
  5q   "   $ Địa chỉ điểm thi��65    6O   �� $ Diachidiemthi�
  5r   "   $ Ghi chú��65    6F   �� $ Ghichu�5t      5u      5v      5x      5y      5z      5{      