   M S B A M L   `   `   `  ����A  =GinesX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GinesX.ViewGinesX.View  5   	       GinesX.View.RegWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GinesX.View     5   	     � Title$  	RegWindow��5	   	   $	��450��6   $	��800��6(    � WindowStyle$
 None=�64    � 
ResizeMode$ NoResize=�6G   .��5
      � -   5         �Name$ MainGrid��5
      ��5   
   �� 5         RegFont �� ImageSource# [  6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $
��200* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $	��20* �6#   �� 5      $	��18* �6#   �� 5      $	��20* �6#   .+�5      � $��1��6    5      �� 5      $	��30* �6$   �� 5      $	��40* �6$   �� 5      $	��30* �6$   �� 5      $	��40* �6$   �� 5      $	��30* �6$   �� 5      $	��40* �6$   �� 5       $	��60* �6$   �� 5!      $	��30* �6$   �� 5"      $	��60* �6$   .+�5$      �� -   5         ��Name$ TB_Email��5%      $��1��5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$' !Електронный адрес��5&      $��Center=�5'      $��Center=�5(      $��22(�5)      ��5*      �� *
NewEmail+��5+      �� *
EmailColor+�� 5-      -   5        $ TB_Login��5.      $��3��5-      $ 
Логин��5/      $��Center=�50      $��Center=�51      $��22(�52      ��53      �� *
Newlogin+��54      �� *
LoginColor+G� 56      -   5        	 G�Name$	 PB_Password��57      $��5��56      $ Пароль��58      $��Center=�59      $��Center=�5:      $��22(�5;      ��5<      �� *PasswordColor+� 5>      $��7��6    5?      �� 5@      $
��100* �6+   �� 5A      $	��40* �6+   �� 5B      $
��100* �6+   .+�5D      �� -   5        
 ��Name$
 B_Back��5D      $��
Назад��5E      
������� � Cursor$
 Hand��5G      ��5H      �� *ChangeToMainWindow+�� 5I      -   5        $
 B_RegOn��5K      $��2��5I      $��Регистрация��5J      $��12(�5L      
�������$
 Hand��5N      $��0,2,0,0q�6+   $	��Top=�6<   ��5O      �� *Reg+��5P      ��  �� ElementName$ PB_Password��5Q      5R      5S      5T      5U      