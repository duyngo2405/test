   M S B A M L   `   `   `  ����Q  MThucHanhKiemThuPhanMem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ThucHanhKiemThuPhanMemThucHanhKiemThuPhanMem  5   	   $    ThucHanhKiemThuPhanMem.TimKiem   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ThucHanhKiemThuPhanMem     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ TimKiem��5	   	   $	��450��6   $	��800��6&   .��5
      � $��5q�6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��9* �6   .+�5   
   �� -   5        $��txtTenSV��5   L   $��30��6   $	��290��6   $��Center=�6*   6L   �� 5   
   -   5        $��	cbLuaChon��5   ;   $��1��6   $��30��6#   $	��140��6/   $��Center=�6L   .@�5      �� -   5        $��cbLuaChonSv��5   3   $��Tên sinh viên��6   63   �� 5      -   5        $��cbLuaChonDiem��5   5   $��Điểm (vd: 6>8)��6   65   �� 5      -   5        $��cbLuaChonMH��5   -   $��
Môn học��6   6-   5      �� 5   
   -   5        $��txtNoiDungTimKiem��5   \   $��2��6   $��30��6"   $	��140��6.   $��Center=�6:   6\   �� 5   
   -   5        $��
btnTimKiem��5   r   $��3��6   $��30��6!   $	��100��6-   $��16(�69   $��Times New Roman)�6G   $
��Tìm��6d   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGridKetQua��5     $��1��6   $��4��6       ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 64   $��Stretch=�6D   $��Stretch=�6`      AutoGenerateColumns .  !   EnableColumnVirtualization .     EnableRowVirtualization .     CanUserAddRows .  	   
IsReadOnly	 . 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 MSSV��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *
MaSinhVien+  5       $ 	Họ tên��6%    65   �� *TenSinhVien+  5!      $ 
Ngày sinh��6%    68   �� *
NgaySinh+  5"      $ Giới tính��6%    68   �� *
GioiTinh+  5#      $
 THPT��6%    63   �� *
TruongTHPT+  5$      $ 
Mã Ngành��6%    67   �� *	MaNganh+  5%      $ Điểm chuẩn��6%    69   �� *	DiemChuan+  5&      $ Điểm thi��6%    67   �� *	DiemThi+5(      5*      5+      