   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5      B    <QuanLyCoiThiTuyenSinh.UserControl_QLCTTS.UserControl_BuoiThi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  tranisitionContenSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromBottom+   Duration$ 0:0:0.5X�.��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $
��auto �6$   64   �� 5      6&   .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ txtMaBuoiThi��5      $��0��5      $��10q�5      $��15(�5      $
��Bold"�5      $��Center=�5      $	��200��5      {�.  
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã buổi thi��5        %  !MaterialDesignFloatingHintTextBox#��[  5!      $��Center=�5"      �� 5#      -   5        $ 
txtBuoiThi��5)      $��1��5#      $��10q�5$      $��15(�5%      $
��Bold"�5&      $��Center=�5'      $	��200��5(      
���   �$ 
Buổi thi��5+      #��[  5,      $��Center=�5-      5.      � 50      $��1��6    51      �� 52      �� 53      $	��150 �6+   �� 54      .+�58      � $��0��6   $��Right=�59      $��0 0 10 0q�5:       5;      �� 5<      $��40 �6/   �� 5=      $��80 �6/   .+�5@      �� $��0q�6!   
���2͚�$��2��5B   %    �� CornerRadius$ 15��5C   %   $��40��5D   %   5E      �� 5G      -   5         ��Name$ btnFlag��5P   %   $��0��5G   !   
������ 
������ $��15(�5J   %   $��40��5K   %   $��40��5L   %   $��+��5M   %   
���   �$
��Bold"�5O   %   $��Center=�5R   %   $��Center=�5S   %   $��Center=�5T   %   $��Center=�5U   %   �� 5W      -   5        $ btnThemBuoiThi��5[   !   $��1��5W   !    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5X   !   $��80��5Y   !   $��Thêm��5Z   !   {�.  
���   �$
��Bold"�5_   !   
������ 
������ 5a   !   �� 5b      		 �� X1$	 40��6   	
 �� Y1$
 10��6'   	 �� X2$ 40��5c   #   	 �� Y2$ 50��6+   
���   �$��1��5e   #   5f      �� 5h      -   5        $ btnCapNhatBuoiThi��5m      $��1��5h      #��[ 5i      $	��120��5j      $��40��5k      $��Sửa��5l      $��10q�5o      
���2͚�
���   �$
��Bold"�5r      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5s      $��0q�5t      �� 5v      -   5        $ btnXoaBuoiThi��5|   !   $��2��5v      $
��Left=�5w   !   #��[ 5x   !   $	��120��5y   !   $��40��5z   !   $
��Xóa��5{   !   $��10q�5~   !   
���2͚�
���   �$
��Bold"�5�   !   $ 15��5�   !   $��0q�5�   !   5�      � 5�      $��2��6   $��Stretch=�5�      .+�5�      �� $ ��Danh sách các buổi thi��6     MaterialDesignGroupBox#���  5�      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ SecondaryMid=�5�      
������ $��15q�5�      $
��Bold"�5�      $��Stretch=�5�      .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtgBuoiThi��5�   #   $��Stretch=�5�   #   
�������   AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Extended=�5�   #   
���   �$
��Bold"�5�   #    �� SelectedItem 5�   #   �� *SelectedBuoiThi+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Mã buổi thi��65   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6J   ��  �� Path$
 Mabt�  5�   "   $ 
Buổi thi��65    6G   �� $ Tenbt�5�      5�      5�      5�      5�      5�      5�      