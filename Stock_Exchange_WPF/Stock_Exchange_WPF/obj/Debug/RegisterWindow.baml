   M S B A M L   `   `   `  ����M  IStock_Exchange_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Stock_Exchange_WPFStock_Exchange_WPF  5   	   '    !Stock_Exchange_WPF.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Stock_Exchange_WPF     5   	     � Title$  Окно Входа��5   	   $	��350��6   $	��350��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   .+�5   
   �� -   5         ��Name$ Entry_Button��5      $��
Войти��6'   $��Center=�67   $��3��6T   $��Center=�6a   $��35��6|   $	��135��6�   6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $��14(�6E   $��5,15,0,0q�6S   $/��)Введите логин и пароль��6e   $��Center=�6�   $��30��6�   $	��160��6�   �� 5   
   -   5         ��Name$ Login_TextBox��5      $��Center=�6)   $��1��6F    �� TextWrapping$
 Wrap=�6S   $��Center=�6g   $��35��6�   $	��135��6�   �� 5   
   -   5         ��Name$ Login_Mistake_TextBlock��5      $
��Left=�65   $��1��6P   $
��Wrap=�6]   $��15,0,0,0q�6q   $��Center=�6�   $��35��6�   $��70��6�   G� 5   
   -   5         G�Name$ Password_TextBox��5       G� PasswordChar$ *��60   $��Center=�6A   $��2��6^   $��Center=�6k   $��35��6�   $	��135��6�   �� 5   
   -   5        $  Password_Mistake_TextBlock��5      $
��Left=�68   $��2��6T   $
��Wrap=�6a   $��15,0,0,0q�6u   $��Center=�6�   $��35��6�   $��70��6�   �� 5   
   $��Center=�6   $��0,0,0,0q�61   $��1��6B   $
��Wrap=�6O   $��
Логин��6c   $	��Top=�6p   �� 5   
   $��Center=�6   $��0,0,0,0q�61   $��2��6B   $
��Wrap=�6O   $��Пароль��6c   $	��Top=�6q   5      5      