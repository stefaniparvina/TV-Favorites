   M S B A M L   `   `   `  ����G  CTV_Favorites, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TV_FavoritesTV_Favorites  5   	       TV_Favorites.Main_Page   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TV_Favorites     5   	     � Title$  	Main_Page��5   	   $	��862��6   $
��1512��6(    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ CanMinimize=�5	   	    � WindowStyle$
 None=�6#   .��5
      � ���	#FFFDFFB2 � RowDefinitions 5   
   �� 5      $
��254* �6   �� 5      $
��177* �6   .+�5   
   �� $��Center=�6   $��91��61   $	��Top=�6=   $
��1512��6U   
�������6b   �� 5   
   -   5         ��Name$ profile_button��5      $��
Your Profile��6)   $
��Left=�6E   $��	255,0,0,0q�6`   $	��Top=�6s   $	��170��6�   $��91��5      $��23(�6   
�������
�������$��Microsoft YaHei UI)�6N      NoMouseOverButtonTemplate#��[  6�   �� 5   
   $
��Left=�6   $��404,177,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��69��6p   $	��641��6|    �� TextAlignment$ Center=�6�    �� 
LineHeight$ 9��6�   $��Sitka Heading)�6�   $
��Bold"�6�   $��30(�6�   �� 6�   $%�Do you like watching TV shows? ��6�   �� 6  �� 6#  $(�"If yes, this is the place for you!��6'  6T  �� 5   
   $
��Left=�6   $��195,326,0,0q�6/   $
��Wrap=�6D   $	��Top=�5      $	��427��6%   $��Javanese Text)�61   $ 1��6L   $��25(�6[   $,��&This is our selection of TV favorites:��6i   $��57��6�   �� 5   
   -   5        $ 	gg_button��5      $��1024,388,198,298q�6$   
���   �$��0q�6R   $��2��6~   #��[  6�   ��5      �� 5       �� ImageSource$ /Image7.png��6   	 j� Stretch$
	 Fill=�67   ��5      �� 5      
 �� 
TargetType"
 ��6    �� Triggers 5       P� 5!       P� Property �@J�IsMouseOver P� Value . . �5"      ��  �� Property � �� �� Value 5#   "   �� 5$   &   $��
Image7.png��6,   6B   5&      �� 5'       �@J�Effect 5(   "   3  -System.Windows.Media.Effects.DropShadowEffect  5)   &      Color$ 	#FF888888��67      
BlurRadius$ 6Q�6I      	Direction$	 320Q�6X      ShadowDepth$ 1Q�6h   5+      5,      5.      50      �� 52   
   -   5        $ friends_button��52      $��608,388,614,298q�6)   
���   �$��0q�6V   $��2��6�   #��[  6�   ��53      �� 54      $ /Image8.png��6   $
	 Fill=�67   ��56      �� 57      "
 ��6    58      P� 59       �@J�IsMouseOver . . �5:      ��  � �� 5;   "   �� 5<   &   $��
Image8.png��6,   6B   5>      �� 5?       �@J�Effect 5@   "     5A   &   $ 	#FF888888��67   $ 6Q�6I   $	 320Q�6X   $ 1Q�6h   5C      5D      5F      5H      �� 5J   
   -   5        $ 
got_button��5J      $��195,388,1027,298q�6%   
���   �$��0q�6S   $��2��6�   #��[  6�   ��5K      �� 5L      $ /got screenshot.png��6   $
	 Fill=�6?   ��5N      �� 5O      "
 ��6    5P      P� 5Q       �@J�IsMouseOver . . �5R      ��  � �� 5S   "   �� 5T   &   $��
Image6.png��6,   6B   5V      �� 5W       �@J�Effect 5X   "     5Y   &   $ 	#FF888888��67   $ 6Q�6I   $	 320Q�6X   $ 1Q�6h   5[      5\      5^      5`      �� 5c   
   $��1224,10,41,67q�6   .+�5d      �� $��Select TV Shows:��6   $��15(�6/   �� 5e      -   5         ��Name$ 
myComboBox��5e      
�������$��15(�6>    J� RenderTransformOrigin$ 	0.5,0.519&�6L   .@�5g      �� $��Game of Thrones��6   �� 5h      $��Gossip Girl��6   �� 5i      $��Friends��6   5j      5k      �� 5m   
   -   5         ��Name$
 logo��5m      $C��=C:\Users\stefa\OneDrive\Desktop\School\Final Project\logo.jpg��6   $
��Left=�5n      $��91��6(   $	��Top=�64   $��10,0,0,0q�6L   5o      5p      