   M S B A M L   `   `   `  ����E  APeExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PeExplorer.ViewsPeExplorer.Views  5      %    PeExplorer.Views.HeadersControl   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PeExplorer.Views     5      ���#192231$	��540��5   4   $
��1010��6A   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��20q�6!   ���#24344D �� CornerRadius$ 10��6C   ._�5      �� ���#24344D �� Orientation$ Vertical=�6.   .+�5      �� $��10q�6   ���#D3D6DBOPTINAL HEADER6M   &   System.Windows.Controls.DataGrid  5      $��10q�5      ���#24344D   DataGridRowStyle   RowStyle# [  5        DataGridCellStyle   	CellStyle# [ 5        DataGridColumnHeaderStyle   ColumnHeaderStyle# [ 5      "   VerticalScrollBarVisibility$ Hidden=�5         SelectionMode$ Single=�5         AutoGenerateColumns$ False��5      $��Center=�5      ���#919DAE
������ $��0 0 0 0q�5      	 J� IsManipulationEnabled$	 False��5      
   
IsReadOnly$

 True��5      $	��400��5      $	��400��6*   ��5       �� *!Headers.OptinalHeaderProperties+   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��5#   %      
IsReadOnly$
 True��5$   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5"   /   �� *Name+5$   %     5%         
FontFamily$ Consolas)�6H      
FontWeight$
 Bold"�5&   %   $ Value��5'   %    5%   .   �� *Value+5'   %     5(      $ 	More Info��6K    6.   �� *
MoreInfo+6K   5+      5.      5/      �� 50   
   $��1��6    �� Padding$ 20q�6!   ._�51      �  � RowDefinitions 52      �� 53      $��* �6$   �� 54      $��* �6$   .+�56      �� $��0��6   $��0 0 0 20q�6&   ���#24344D$ 10��6M   ._�57      �� ���#24344D$ Vertical=�66   .+�58      �� $��10q�6$   ���#D3D6DB
DOS HEADER6Q     59      $��10q�6$   ���#24344D# [  5:      # [ 5;      # [ 5<      $ Hidden=�5>      $��Center=�5?      ���#919DAE
������ $��0 0 0 0q�5B      $ Single=�5C      $ False��5D      $	 False��5E      $

 True��5F      $	��400��5G      $	��160��6*   ��5H      �� *Headers.DosHeaderProperties+ 5I        5J   "   $
 Name��5K   %   $
 True��5L   %    5J   6   �� *Name+5L   %     5M   "   $ Consolas)�6P   $
 Bold"�5N   %   $ Value��5O   %    5M   6   �� *Value+5O   %     5P   "   $ 	More Info��6S    66   �� *
MoreInfo+6S   5S      5W      5X      �� 5Y      $��1��6   $��0 0 0 20q�6&   ���#24344D$ 10��6N   ._�5Z      �� ���#24344D$ Vertical=�66   .+�5[      �� $��10q�6$   ���#D3D6DBFILE HEADER6R     5\      -   5          Name$ _OptionalHeaderContent��5a      $��10q�5]      ���#24344D# [  5^      # [ 5_      # [ 5`      $��Center=�5b      ���#919DAE
������ $��0 0 0 0q�5e      $	 False��5f      $

 True��5g      $ Single=�5h      $ False��5i      $ Hidden=�5j      $	��400��5k      $	��160��6(   ��5l      �� *Headers.FileHeaderProperties+ 5m        5n   "   $
 Name��5o   %   $
 True��5p   %    5n   6   �� *Name+5p   %     5q   "   $ Consolas)�6P   $
 Bold"�5r   %   $ Value��5s   %    5q   6   �� *Value+5s   %     5t   "   $ 	More Info��6S    66   �� *
MoreInfo+6S   5w      5z      5{      5|      5}      5�      5�      