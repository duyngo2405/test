   M S B A M L   `   `   `  ����Q  MThucHanhKiemThuPhanMem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ThucHanhKiemThuPhanMemThucHanhKiemThuPhanMem  5   	   '    !ThucHanhKiemThuPhanMem.CapNhatLop   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ThucHanhKiemThuPhanMem     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
CapNhatLop��5	   	   $	��450��6   $	��800��6)   .��5
      � $
��10pxq�6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��8* �6   .+�5   
   �� -   5        $��	txtTenLop��5   :   $��0��6   $��30��6"   $	��200��6.   $��Center=�6L   $��Nhập tên lớp��6n   6�   �� 5   
   -   5        $��txtMaGiangVien��5   J   $��1��6   $��0��6#   $	��200��60   $
��30px��6<    �� SelectedValuePath$ MaGiangVien��5       �� SelectedIndex$ 0��5      $��Center=�5       �� DisplayMemberPath$ TenGiangVien��5      �� 5   
   -   5        $��btnLuu��5   G   $��2��6   $��30��6!   $	��100��6-   $
��Lưu��69   6U   � 5   
   $��1��6   $��3��6   $��10q�60    5      �� 5      $��4* �6#   �� 5      �� 5       $��4* �6#   .+�5"      &   System.Windows.Controls.DataGrid  -   5        $��dataGridDanhSachSV��5%      $��0��5"      $��Stretch=�5#      $��Stretch=�5$         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5'      	   
IsReadOnly	 . 
   CanUserAddRows
 .     EnableRowVirtualization .  !   EnableColumnVirtualization .  $	��5pxq�5,         Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$
 MSSV��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
MaSinhVien+  5/      $ 	Họ tên��6)    69   �� *TenSinhVien+  50      $ 
Mã ngành��6)    6;   �� *	MaNganh+52      � 54      $��0��6   $��1��6    $��5q�60    55      �� 56      �� 57      �� 58      .+�5:      �� -   5        $��btnChuyenToi��5:   M   $��0��6   $��30��6&   $
��auto��62   $��	►►►��6?   6a   �� 5;      -   5        $��txtSiSo��5;   ]   $��1��6   $��Center=�6%   $��Center=�6@   $
��?/40��6l   �� 5<      -   5        $��btnChuyenLui��5<   M   $��2��6   $��30��6&   $
��auto��62   $��	◄◄◄��6?   6a   5=        5@      -   5        $ ��dataGridDanhSachSVDuocchon��5C      $��0��5@      $��2��6%   $��Stretch=�5A      $��Stretch=�5B       .  $ * 5E      	 . 
 .   .   .  $	��5pxq�5J       5K        5L      $	 STT��6)      Width$
 0.4* 66    6C   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL� �� 	Converter 0   *ThucHanhKiemThuPhanMem.RowToIndexConvertor    5M      $
 MSSV��6)    67   �� *
MaSinhVien+  5N      $ 	Họ tên��6)    69   �� *TenSinhVien+  5O      $ 
Mã ngành��6)    6;   �� *	MaNganh+5Q      5R      5S      5T      