   M S B A M L   `   `   `  ����A  =GinesX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GinesXGinesX  5   	       GinesX.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:GinesX     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$
 None=�5
   	    � AllowsTransparency . .��5      � -   5         �Name$ MainGrid��5      ��5   
   �� 5         MainFont �� ImageSource# [  6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $
��200* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $	��20* �6#   �� 5      $	��18* �6#   �� 5      $	��20* �6#   .+�5      � $��1��6    5      �� 5      $	��30* �6$   �� 5      $	��40* �6$   �� 5      $	��30* �6$   �� 5      $	��40* �6$   �� 5      $	��70* �6$   �� 5       $	��40* �6$   �� 5!      $	��70* �6$   .+�5#      �� -   5         ��Name$ TB_Login��5#      $��1��5$      $��22(�5%      	 � Cursor$	 No��5&      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 
Логин��5'      $��Center=�5(      $��Center=�5)      ��5+      �� *Login+G� 5,      -   5         G�Name$ TB_Password��5,      $��3��5-      $��22(�5.      $	 No��5/      $
 Пароль��50      $��Center=�51      $��Center=�52      53      � 55      $��5��6    56      �� 57      $��3* �6(   �� 58      $	��10* �6(   �� 59      $��3* �6(    5;      �� 5<      $	��80* �6+   �� 5=      $	��50* �6+   �� 5>      $	��80* �6+   .+�5@      �� -   5         ��Name$ B_Voiti��5@      $��1��5A      $��
Войти��5B      $
	 Hand��5C      
���������5E      �� *ShowToThirdWindow+��5F      ��  �� ElementName$ TB_Password���� 5G      -   5        $ B_Reg��5G      $��3��5H      $��1��5I      $��Регистрация��5J      $��10(�5K      $
	 Hand��5L      
���������5N      �� *ChangeToRegWindow+5O      5P      5Q      5R      5S      