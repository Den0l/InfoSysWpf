   M S B A M L   `   `   `  ����M  IStock_Exchange_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Stock_Exchange_WPFStock_Exchange_WPF  5   	   %    Stock_Exchange_WPF.ClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Stock_Exchange_WPF     5   	     � Title$!  Личный кабинет��5   	   $	��450��6    $	��800��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��0.4* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��0.15* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ Exit_Client_Button��5      $��
Выйти��6-   6=   �� 5   
   -   5        $ Buy_Client_Button��5      $,��&Купить ценную бумагу��6,   $��1��6K   6[   �� 5   
   -   5        $ Receipt_Client_Button��5      $��Квитанции��60   $��2��6D   6T    � 5   
   -   5          �Name$ ClientPageFrame��5      $��1��6)   $��3��66     � NavigationUIVisibility$ Hidden=�6J   5      5      