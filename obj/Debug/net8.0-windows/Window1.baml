   M S B A M L   `   `   `  ����?  ;QLPB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QLPBQLPB  5   	       QLPB.Window1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:QLPB     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgwd2��5
         AutoGenerateColumns$ False��6"   $��Center=�6>   $	��150��6b   $	��600��6o    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%V   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Ma CTV��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 65   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *MaCtv+  5      $ Ho Ten��6%   $		 100 65   
 6A   �� *HoTen+  5      $ So bai viet��6%   $		 100 6:   
 6F   �� *SoBv+  5      $ Ma Phong��6%   $		 100 67   
 6C   �� *	MaPhong+  5      $ 	Ten phong��6%   $		 100 68   
 6D   �� *
TenPhong+  5      $ Tien nhuan but��6%   $		 100 6=   
 6I   �� *tien+5      5      5      