   M S B A M L   `   `   `  ����O  KMathCAD_Trainer_0.01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MathCAD_Trainer_0._01MathCAD_Trainer_0._01  5   	   [2clr-namespace:MathCAD_Trainer_0._01.MVVM.ViewModel$MathCAD_Trainer_0._01.MVVM.ViewModel  5   	   Q-clr-namespace:MathCAD_Trainer_0._01.MVVM.ViewMathCAD_Trainer_0._01.MVVM.View  5   	   &     MathCAD_Trainer_0._01.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MathCAD_Trainer_0._01     5   	   H	viewModel2clr-namespace:MathCAD_Trainer_0._01.MVVM.ViewModel     5   	   >view-clr-namespace:MathCAD_Trainer_0._01.MVVM.View     5   	   -   5        $
��home��5
   	     � Title$  
MainWindow��5   	   $	��650��5   	   $
��1000��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�5   	    � DataContext 5      8  2MathCAD_Trainer_0._01.MVVM.ViewModel.MainViewModel  5   
   .��5      ��  �� CornerRadius$ 8��6      PrimaryBackgroundColor#���   5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5#      �� $ 8 0 0 8��6     SecundaryBackgroundColor#���  5$      ._�5%      � -   5        	 �Name$	 gridMenu��5%      $��60��5&      
 � RowDefinitions
 5'      �� 5(      $��60 �6(   �� 5)      $��80 �6(   �� 5*      $
��Auto �6(   �� 5+      .+�5/      �� $��1��6!    �� Orientation$ 
Horizontal=�50   !   $	��Top=�51   !   .+�52      F�   logo#���  6   $��16 0 0 0q�53       �� Stretch$
 Fill=�54        PrimaryBlueColor#���  55      $��25��56      $��25��57      $
��Left=�6+   �� 59      $��MathCAD
Trainer��6    #���  5:       $
��Bold"�5;       $��20(�62   $��Center=�5<       $
��Left=�5=       $
��Left=�5>       $��14 0 0 0q�5?       5@      d� 5C      -   5         d�Name$ btnMenu��5C   #   $��Right=�5D   #   $��0q�5E   #   
������ $��Center=�5G   #     MenuIconStyle#��[ 5H   #   $��0 0 15 0q�5I   #    � Triggers 5J      :� 5K       :� RoutedEvent$ ToggleButton.Unchecked��6+   .[�5L   "   �� .��5M   &   �� -   5         ��Name$ HideStackPanel��5M   1   .��5N   *   W�  �� 
TargetName$ gridMenu��6:    �� TargetProperty$ Width�5O   :    g� 	BeginTime$ 0:0:0X�5P   :    W� From$	 200X�6L   	 W� To$ 60X�6W    g� Duration$ 0:0:0.3D�5Q   :   5R   +   5S   '   5T   #   5U      :� 5V      $ ToggleButton.Checked��6+   .[�5W   "   �� .��5X   &   �� -   5        $ ShowStackPanel��5X   1   .��5Y   *   W� $ gridMenu��6:   $ Width�5Z   :   $ 0:0:0X�5[   :   $ 60X�5\   :   $	 200X�5]   :   $ 0:0:0.3D�5^   :   5_   +   5`   '   5a   #   5b      5d      �� 5f      $��3��6!   .+�5h      	� -   5         	�Name$ rdHome��5h   &    d� 	IsChecked$
 TrueY�5i   &   $�� Главная��5j   &     MenuRadioButtonStyle#���  5k   &     home
 � Tag# �  5l   &   ��5m   &   �� *HomeViewCommand+	� 5o      -   5        $ rdReference��5o   &   $�� Методичка��5p   &   #���  5q   &     bookWithText# �  5r   &   $��0 5 0 5q�5s   &   ��5t   &   �� *ReferenceViewCommand+	� 5v      -   5        $ 	rdTesting��5v   &   $�� Тесты��5w   &   #���  5x   &    	 check# �  5y   &   ��5z   &   �� *TestingViewCommand+	� 5|      -	   5        $ 	rdProfile��5|   &   $�� Профиль��5}   &   #���  5~   &    	 profile# � 	 5   &   $��0 5 0 5q�5�   &   ��5�   &   �� *SettingViewCommand+	� 5�      -
   5        $ rdExit��5�   &   $�� Выход��5�   &   #���  5�   &    
 exit# � 
 5�   &   ��5�   &   �� *ExitViewCommand+5�      5�      5�      � 5�      $��1��6   
 5�      �� 5�      $��60 �6$   �� 5�      .+�5�      �� $��1��6   $��10q�6&   ._�5�      �� ��6'   �� *CurrentView+5�      5�      5�      5�      5�      