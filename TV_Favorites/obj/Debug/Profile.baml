   M S B A M L   `   `   `  ����G  CTV_Favorites, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TV_FavoritesTV_Favorites  5   	       TV_Favorites.Profile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TV_Favorites     5   	     � Title$  Profile��5   	   $	��862��6   $
��1512��6'    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ CanMinimize=�5	   	    � WindowStyle$
 None=�6#   .��5
      � ��5   
   �� 5       �� ImageSource$L FC:\Users\stefa\OneDrive\Desktop\School\Final Project\background-6.jpeg��6   .+�5   
   �� $��Center=�6   $��91��61   $	��Top=�6=   $
��1512��6U   
�������6b   �� 5   
   -   5         ��Name$ logo_button��5      $
��Left=�6&   $	��Top=�6A   $��244.8��6Y   $��91��6g   $��10,0,0,0q�6s   
�������   NoMouseOverButtonTemplate#��[  5   ?   ��5      �� 5      $ logo.jpg��6   5      �� 5   
   -   5        $ mainPage_link��5      $��

Main Page��6(   $
��Left=�6A   $��	258,0,0,0q�6\   $	��Top=�6o   $	��170��6�   $��91��5      $��23(�6   
�������
�������$��Microsoft YaHei UI)�6N   #��[  6�   �� 5   
   -   5        $ watchList_button��5      $��Your Watchlist��6+   $
��Left=�6D   $��643,738,0,0q�5      $	��Top=�6&   $	��210��6>   $��34��6J   $��15(�6V   ���	#FFFDFFB2$��Javanese Text)�5   (   $
��Bold"�6b   �� 5   
   $��666,151,682,588q�6   $��
Image9.png��6)   $
��Fill=�6=   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ profile��5       $��290,431,298,341q�6$      AutoGenerateColumns .    CanUserAddRows .  $��20(�6o   $��Javanese Text)�6}   6�   �� 5"   
   -   5        $ saveChanges��5"      
�������$��Update��69   $
��Left=�6J   $��695,573,0,244q�6   $	��115��6�   $��Javanese Text)�6�   $��15(�6�   
���   �6�   �� 5$   
   $��1224,10,41,67q�6   .+�5%      �� $��Select TV Shows:��6   $��15(�6/   �� 5&      -   5        	 ��Name$	 
myComboBox��5&      
�������$��15(�6>   
 J� RenderTransformOrigin$
 	0.5,0.519&�6L   .@�5(      �� $��Game of Thrones��6   �� 5)      $��Gossip Girl��6   �� 5*      $��Friends��6   5+      5,      �� 5-   
   $
��Left=�6   $��639,291,0,0q�6/   $
��Wrap=�6D   $��Update your information:��6X   $	��Top=�6x   $��Javanese Text)�6�   $��20(�6�   $
��Bold"�6�   5/      50      