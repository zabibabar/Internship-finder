   M S B A M L   `   `   `  ����F  BInternships, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InternshipsInternships  5   	       Internships.Education   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Internships     5   	     � Title$  	Education��5   	   $	��300��6   $	��470��6(   .��5	      � ���	#FF72ACCA � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��College/University��6   $��1��6-   $��1��6:   $��5q�6J   �� 5   
   -   5        $��
UserSchool��5      $��1��6H   $��2��6U   $	��150��6e   $��5q�6q   ��6$   �� *CurrentUser.School+6|   �� 5   
   $��Major��6   $��2��6    $��1��6-   $��5q�6=   �� 5   
   -   5        $��	UserMajor��5      $��2��6F   $��2��6S   $	��150��6c   $��5q�6o   ��6#   �� *CurrentUser.Major+6z   �� 5!   
   $	��GPA��6   $��3��6   $��1��6+   $��5q�6;   �� 5"   
   -   5        $	��GPA��5"   S   |�.  $��3��6_   $��2��6l   $	��150��6|   $��30��6�   $��Center=�6�   $��Center=�6�   ��6$   ��  �� ElementName$ Ticker�� �� Path$ Value�6�   �� 5#   
   -   5        $��Ticker��5#      $��3��6   $��3��6,   $	��150��6<   $��30��6H   $��Center=�6T   $��Center=�6o    �� TickPlacement$ BottomRight=�5$   3    �� TickFrequency$	 0.1Q�6O    � Minimum$	 2.0Q�6c    � Maximum$	 4.0Q�6q   	 �� IsSnapToTickEnabled	 . 
 � Value
 6   �� *CurrentUser.GPA+6   �� 5&   
   $��Enrollment Date��6   $��4��6*   $��1��67   $��5q�6G   (  "System.Windows.Controls.DatePicker  5'   
   -   5        $��UserEnrollment��5'      |�.  $��4��6=   $��2��6J   $	��150��6[   $��30��6g   $��Center=�5(      $��Center=�60   6M   �� 5*   
   $��Expected Graduation��6   $��5��6.   $��1��6;   $��5q�6K     5+   
   -   5        $��UserGraduation��5+      |�.  $��5��6=   $��2��6J   $	��150��6Z   $��30��6f   $��Center=�5,      $��Center=�60   6M   �� 5.   
   $��College Standing��6   $��6��6+   $��1��68   $��5q�6H   �� 5/   
   -   5        $��UserCollegeStanding��5/      $��6��6.   $��2��6;   $	��150��6K   $��30��6W   $��Center=�6c   $��Center=�6~   .@�50      �� $ ��--Select an option below--��6   �� 51      $��Freshman��6   �� 52      $��	Sophomore��6   �� 53      $��Junior��6   �� 54      $��Senior��6   55      �� 57   
   $��Save and Submit��6   $��25��6+   $	��150��67   $��7��6C   $��2��6P   $��5q�6`   ��6k   �� *SubmitCommand+59      5:      