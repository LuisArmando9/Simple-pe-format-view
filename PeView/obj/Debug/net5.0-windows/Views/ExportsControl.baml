   M S B A M L   `   `   `  ����E  APeExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PeExplorer.ViewsPeExplorer.Views  5      %    PeExplorer.Views.ExportsControl   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PeExplorer.Views     5      ���#192231$	��540��5      $
��1010��6%   .��5
      � .+�5   
   �� $��0��6   $��20q�6!   ���#24344D  �� CornerRadius$  10��6C   ._�5      �� ���#24344D �� Orientation$ Vertical=�6.   .+�5      �� $��10q�6   ���#D3D6DB	EXPORTS6F   &   System.Windows.Controls.DataGrid  5      $��10q�5      ���#24344D   DataGridRowStyle   RowStyle# [  5        DataGridCellStyle   	CellStyle# [ 5        DataGridColumnHeaderStyle   ColumnHeaderStyle# [ 5      $
��Left=�5      ���#919DAE
������ $��0 0 0 0q�5         SelectionMode$ Single=�5         AutoGenerateColumns$ False��5       J� IsManipulationEnabled$ False��5         
IsReadOnly$
 True��5      $	��700��5      $	��400��6)   ��5      �� *Exports.ExportProperties+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6F      
IsReadOnly$
 True��6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *Name+6T     5       $
 Forward Name��6M   $
 True��6c    6-   �� *ForwardName+6c     5!      $
 Virtual Address��6I   $
 True��6b    6-   �� *	Address+6b     5"      $
 Ordinal��6I   $
 True��6Z    6-   �� *	Ordinal+6Z   5'      5*      5+      5,      5-      