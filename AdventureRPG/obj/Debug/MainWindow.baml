   M S B A M L   `   `   `  ����  AdventureRPG    AdventureRPG.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  AdventureRPG��5   	   $	��475��6   $	��650��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��0 �6   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   � $��1��6   $��0��6   
������$��2��6D    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6     5#      �� 5$      $
��Auto �6#   �� 5%      $
��Auto �6#   .+�5*      �� $��0��6   $��0��6!   $��Name:��61   �� 5+      $��0��6   $��1��6!   ��61   �� *CurrentPlayer.Name+�� 5,      $��1��6   $��0��6!   $��Class:��61   �� 5-      $��1��6   $��1��6!   ��61   �� *CurrentPlayer.CharacterClass+�� 5.      $��2��6   $��0��6!   $��Level:��61   �� 5/      $��2��6   $��1��6!   ��61   �� *CurrentPlayer.Level+�� 50      $��3��6   $��0��6!   $��Hit points:��61   �� 51      $��3��6   $��1��6!   ��61   �� *CurrentPlayer.HitPoints+�� 52      $��4��6   $��0��6!   $��Armor:��61   �� 53      $��4��6   $��1��6!   ��61   �� *CurrentPlayer.Armor+�� 54      $��5��6   $��0��6!   $��Gold:��61   �� 55      $��5��6   $��1��6!   ��61   �� *CurrentPlayer.Gold+�� 56      $��6��6   $��0��6!   $	��XP:��61   �� 57      $��6��6   $��1��6!   ��61   �� * CurrentPlayer.ExperiencePoints+5:      � 5=   
   $��2��6   $��0��6   
�������$��2��6C   .+�5>      ��  �� TabStripPlacement$	 Top=�6   $��0,0,0,0q�61   .@�5?      �� -   5        $��tabItemInventory��5?      $��	Inventory��62   .��5@      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     HeadersVisibility$ Column=�6k   ��6   �� *CurrentPlayer.Inventory+   Columns 5A      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$ #��61      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   �� *Name+6U     5D      $ Description��61   $ * 6_   	 6F   �� *Name+6_     5E      $ Value��61   $
 Auto 6Z   	 6@   �� *Value+6Z   5G      5H      �� 5I      -   5        $��tabItemEquipment��5I      $��	Equipment��62   .��5J        5K      5L      5M      5N      � 5P   
   $��1��6   $��2��6   
�������.+�5Q      �� $��	Game Data��6   5R      � 5S   
   $��2��6   $��2��6   
�������.+�5T      �� $��Combat/Movement Controls��6   5U      � 5X   
   $��0��6   $��0��6   $��3��6,   
�������.+�5Y      o� -   5        $��menu1��5Y      $��50��6    $��22��6,   $
��Left=�68   $	��Top=�6S   
�������.@�5Z      m� $
��Menu��6   $��22��6)   .@�5[      m� -   5        $��SaveGameMenu��5[      $��	Save Game��63   6F   m� 5\      -   5        $��LoadGameMenu��5\      $��	Load Game��63   6F   m� 5]      -   5        $��NewGameMenu��5]      $��New Game��62   6D   5^      5_      5`      5m      5n      