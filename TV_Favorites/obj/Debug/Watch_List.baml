   M S B A M L   `   `   `  ����G  CTV_Favorites, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TV_FavoritesTV_Favorites  5   	       TV_Favorites.Watch_List   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TV_Favorites     5   	     � Title$  
Watch_List��5   	   $	��862��6   $
��1512��6*    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ CanMinimize=�5	   	    � WindowStyle$
 None=�6#   .��5
      � ��5   
   �� 5       �� ImageSource$L FC:\Users\stefa\OneDrive\Desktop\School\Final Project\background-6.jpeg��6   .+�5   
   �� $��Center=�6   $��91��61   $	��Top=�6=   $
��1512��6U   
�������6b   �� 5   
   -   5         ��Name$ logo_button��5      $
��Left=�6&   $	��Top=�6A   $��244.8��6Y   $��91��6g   $��10,0,0,0q�5      
�������   NoMouseOverButtonTemplate#��[  6Q   ��5      �� 5      $ logo.jpg��6   5      �� 5   
   -   5        $ mainPage_link��5      $��

Main Page��6(   $
��Left=�6A   $��	258,0,0,0q�6\   $	��Top=�6o   $	��170��6�   $��91��5      $��23(�6   
�������
�������$��Microsoft YaHei UI)�6N   #��[  6�   �� 5   
   $��667,151,690,584q�6   $��Image10.png��6)   $
��Fill=�6>   �� 5   
   $
��Left=�6   $��653,283,0,0q�6/   $
��Wrap=�6D   $��	Watchlist��6X   $	��Top=�6i   $��60��6�   $	��168��6�   $��Javanese Text)�6�   $��30(�6�    �� TextAlignment$ Center=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ watchListDataGrid��5      $
��Left=�6.   $
��Auto��6I   $��485,371,0,0q�6W   $	��Top=�6l   $	��530��6�      CanUserAddRows .  	   
IsReadOnly	 . 
   AutoGenerateColumns
 .  $��20(�6�      AlternatingRowBackground
 �����$��Javanese Text)�6     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	TV Series��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Title+6R   4  .System.Windows.Controls.DataGridTemplateColumn  5      $  ��6)      CellTemplate 5       �� 5!      .R�5"      �� -   5        $��Remove��5"   %   66   5#      5%      5'      �� 5)   
   -   5        $ previousPage_button��5)      $��Previous Page��6.   
���   �$
��Left=�6Z   $��681,774,0,0q�6u   $	��Top=�6�   $	��120��6�   $��34��6�   
������ $��15(�6�   $��0,0,0,1q�6  #��[  6  �� 5+   
   $��1224,10,41,67q�6   .+�5,      �� $��Select TV Shows:��6   $��15(�6/   �� 5-      -   5         ��Name$ 
myComboBox��5-      
�������$��15(�6>    J� RenderTransformOrigin$ 	0.5,0.519&�6L   .@�5/      �� $��Game of Thrones��6   �� 50      $��Gossip Girl��6   �� 51      $��Friends��6   52      53      55      56      