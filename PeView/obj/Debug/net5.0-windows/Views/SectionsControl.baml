   M S B A M L   `   `   `  ����E  APeExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PeExplorer.ViewsPeExplorer.Views  5      &     PeExplorer.Views.SectionsControl   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PeExplorer.Views     5      ���#192231$	��540��5   #   $
��1010��60   .��5
      � .+�5   
   �� $��0��6   $��20q�6!   ���#24344D  �� CornerRadius$  10��6C   ._�5      �� ���#24344D �� Orientation$ Vertical=�6.   .+�5      �� $��10q�6   ���#D3D6DB
SECTIONS6H   &   System.Windows.Controls.DataGrid  5      $��10q�5      ���#24344D   DataGridRowStyle   RowStyle# [  5        DataGridCellStyle   	CellStyle# [ 5        DataGridColumnHeaderStyle   ColumnHeaderStyle# [ 5      $
��Left=�5      ���#919DAE
������ $��0 0 0 0q�5       J� IsManipulationEnabled$ False��5         
IsReadOnly$
 True��5         SelectionMode$ Single=�5         AutoGenerateColumns$ False��5      $	��910��5      $	��400��6(   ��5      �� *#!Sections.SectionHeadersProperties+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5        ColumnElementStyle1  +System.Windows.Controls.DataGridBoundColumn
   ElementStyle#
 [ 6.   ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6{      
IsReadOnly$
 True��6�      Binding 6b   �� *Name+6�     5       #
 [ 6-   $ Base address��6�   $
 True��6�    6a   �� *ImageBaseAddress+6�     5!      #
 [ 6-   $ virtual size��6�   $
 True��6�    6a   �� *VirtualSize+6�     5"      #
 [ 6-   $ virtual address��6�   $
 True��6�    6a   �� *VirtualAddress+6�     5#      #
 [ 6-   $ Size Of Raw Data��6�   $
 True��6�    6a   �� *SizeOfRawData+6�     5$      #
 [ 6.   $ Pointer to Raw Data��6�   $
 True��6�    6b   �� *PointerToRawData+6�     5%      #
 [ 6-   $ Pointer to Relocations��6�   $
 True��6�    6a   �� *PointerToRelocations+6�     5&      #
 [ 6-   $ Pointer to Line numbers��6�   $
 True��6�    6a   �� *PointerToLinenumbers+6�     5'      #
 [ 6-   $ Number Of Relocations��6�   $
 True��6�    6a   �� *NumberOfRelocations+6�     5(      #
 [ 6-   $ Number Of Line numbers��6�   $
 True��6�    6a   �� *NumberOfLinenumbers+6�     5)      #
 [ 6-   $ Characteristics��6�   $
 True��6�    6a   �� *Characteristics+6�   5,      5/      50      51      52      