   M S B A M L   `   `   `  ����  ProjectileMotion!    ProjectileMotion.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  Projectile Motion��5   	   $	��500��6#   $	��525��60   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��70px �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��5q�6)   .+�5      �� Initial Speed:6,   �� 5      -   5        $��InitialSpeedBox��5      �� 5      -   5        $��InitialSpeedHintTextBlock��5      
�������Greater or equal to 06f   5      �� 5      $��1��6   $��5q�6)   .+�5      �� Angle:6$   �� 5      -   5        $��AngleBox��5      �� 5      -   5        $��AngleHintTextBlock��5      
�������Between 0 and 906Z   5      �� 5      $��2��6   $��5q�6)   .+�5       �� 	Sampling:6'   �� 5!      -   5        $��SamplingBox��5!      .��6-   260   �� 5"      -   5        $��SamplingHintTextBlock��5"      
�������Greater than 06[   5#      �� 5$      -   5        $��3��5$   0   $��5q�6@   .��6K   Draw6Q   5%      � 5&   
   $��1��6   .+�5'      �� -	   5        $��Border��5'   =   $��1q�6   
���   �._�5(      � -
   5        $��ProjectileMotionPolyline��5(   <   
���  ��$��1��6(   6<   5)      5*      5+      5,      