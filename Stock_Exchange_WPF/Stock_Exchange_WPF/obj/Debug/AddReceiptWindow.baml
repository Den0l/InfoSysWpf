   M S B A M L   `   `   `  ����M  IStock_Exchange_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Stock_Exchange_WPFStock_Exchange_WPF  5   	   )    #Stock_Exchange_WPF.AddReceiptWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Stock_Exchange_WPF     5   	     � Title$  AddReceiptWindow��5   	   $	��200��6"   $	��400��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ AddRecep_Button��5      $��1��6*   $'��!Создать квитанцию��6:   $��Center=�6V   $��1��6s   $��Center=�6�   6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $"��Итоговая сумма:��6E    �� Padding$ 10q�6\   $	��Top=�6i   �� 5   
   -   5         ��Name$ AddRecep_Amount��5      $��0��6+   $��Center=�6;    �� TextWrapping$
 Wrap=�6X   $��Center=�6l   $	��120��6�   �� 5   
   $��Center=�6   $��1��61   $
��Wrap=�6>   $$��Внесенная сумма:��6R   $ 10q�6j   $	��Top=�6w   �� 5   
   -   5        $ AddRecep_User��5      $��0��6)   $��Center=�69   $��1��6V   $
 Wrap=�6c   $��Center=�6w   $	��120��6�   �� 5   
   $��1��6   $��Center=�6$   $
��Wrap=�6A   $��
Сдача��6U   $ 10q�6b   $	��Top=�6o   �� 5   
   -   5        $ AddRecep_Surren��5      $��1��6+   $��Center=�6;   $
 Wrap=�6X   $��Center=�6l   $	��120��6�   5      5      