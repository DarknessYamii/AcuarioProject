   M S B A M L   `   `   `  ����B  >Acuario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AcuarioAcuario  5          Acuario.ControlPiscinas   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Acuario     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  ControlPiscinas��5      $	��820��5	      $	��500��5
      ��5      �� 5   
    �� ImageSource$ /mar.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��403* �6   �� 5      $
��397* �6    � RowDefinitions 5   
   �� 5      $
��221* �6   �� 5      $
��213* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagridAcuario��5      $��2��5      $��2��5      $��66,111,39,142q�5         AutoGenerateColumns$ False��5       
�������$��2q�5"         
IsReadOnly$
 True��5#      ��5$      ��  �� Path$ listGestion�   Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 140 5'      
   Header$
 Nombre Sala��5)      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5(      �� $ roomName�5)        5*      $		 140 5+      $
 Temperatura��5-       5,      �� $ temperature�5-        5.      $		 140 5/      $
 Especie��51       50      �� $ species�51        52      $		 140 53      $
 Fecha de Revision��55       54      �� $ revisionDate�55        56      $		 140 57      $
 Tratamiento ��59       58      �� $ 	treatment�59      5;      �� 5=   
   -   5        $��1��5>      $��0��5?      $��75��5@      $��38��5A      $��66,0,262,83q�5B      $��Bottom=�5C      
�������
������$��Agregar��5G      
������5H      �� 5I   
   -   5        $��1��5J      $��0��5K      $��2��5L      $��76��5M      $��38��5N      $��362,0,362,83q�5O      $��Bottom=�5P      
�������
������$��	Modificar��5T      
������5U      �� 5V   
   -   5        $��1��5W      $��1��5X      $��76��5Y      $��38��5Z      $��282,0,39,83q�5[      $��Bottom=�5\      
�������
������$��Eliminar��5`      
������5a      �� 5b   
   -   5        $��1��5c      $��2��5d      $��60��5e      $��56��5f      $��
0,0,380,10q�5g      $��Right=�5h      $��Bottom=�5i      
������ ��5l      �� 5m      $ 	/home.png��6   5p      5q      5r      