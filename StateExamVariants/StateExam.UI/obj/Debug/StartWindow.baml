   M S B A M L   `   `   `  ����G  CStateExam.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:StateExam.UIStateExam.UI  5   	       StateExam.UI.StartWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:StateExam.UI     5   	     � Title$"  State Exam Variant Generator��5   	   $	��100��6.   $	��600��6;    � 
ResizeMode$ CanResizeWithGrip=�6G    � SizeToContent$ WidthAndHeight=�6f    � WindowStartupLocation$ CenterScreen=�6�   .��5	      � $��69��6   $	��Top=�6    � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ BaseGenerator��5      $��0��6)   $��Generate base variant��69   $��5,6,0,5q�6Y   $��Center=�6j   $��Center=�6�   $��40��6�   $	��150��6�   
���2͚�6�   �� 5   
   -   5        $ AdvancedGenerator��5      $��1��6-   $��Generate advanced variant��6=   $��5,6,0,5q�6a   $��Center=�6r   $��Center=�6�   $��40��6�   $	��150��6�   
��� ���6�   �� 5   
   -   5        $ ManualGenerator��5      $��2��6+   $��Generate variant manually��6;   $��5,6,0,5q�6_   $��Center=�6p   $��Center=�6�   $��40��6�   $	��150��6�   
����ح�6�   5      5      