   M S B A M L   `   `   `  ����F  BInternships, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InternshipsInternships  5   	       Internships.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Internships     5   	     � Title$  Login��5   	   $	��200��6   $	��350��6$   .��5	      � ���	#FF72ACCA � RowDefinitions 5
   
   �� 5      $��25 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��25 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Username��6   $��1��6#   $��1��60   �� 5   
   $��Password��6   $��2��6#   $��1��60   �� 5   
   -   5        $��UserEnteredLogin��5      $��1��6*   $��2��67   $	��100��6G   G� 5   
   -   5        $��UserEnteredPassword��5      $��2��61   $��2��6>   $	��100��6N   �� 5    
   $��Submit��6    �� 	IsDefault . $��25��63   $��85��6?   $��3��6J   $��1��6W   $��5q�6g   ��6r   �� *LoginCommand+�� 5!   
   $��Cancel��6   $��25��6"   $��85��6.   $��3��69   $��2��6F   $��5q�6V   ��6a   �� *CancelCommand+�� 5"   
   $��Create Account��6   $��25��6*   $��85��66   $��3��6A   $��3��6N   $��5q�6^   ��6i   �� *CreateCommand+5#      5$      