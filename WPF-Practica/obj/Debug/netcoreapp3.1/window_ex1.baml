   M S B A M L   `   `   `  ????G  CWPF-Practica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF_PracticaWPF_Practica  5   	       WPF_Practica.window_ex1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF_Practica     5   	     ? Title$  
window_ex1??5   	   $	??378??6   $	??791??6)   .??5	      ? $??0,0,0,-6q?6    ? ColumnDefinitions 5
   
   ?? 5      $	??33* ?6   ?? 5      $
??367* ?6   .+?5   
   ?? $??15(?6   $
??Left=?6"   $??
15,15,0,15q?6=   $??2??6Q   ??Число вводится своим двоичным представлением (длина числа не превышает 10000 двоичных разрядов).?? 5   o   TRНеобходимо определить, делится ли число на 15.5      ?? 5   
   -   5         ??Name$ tb_numb??5      $
??Left=?6#   $??
31,110,0,0q?6>   $?? ??6R    ?? TextWrapping$
 Wrap=?6Z   $	??Top=?6n   $	??234??6?   $??30??6?   $??2??6?   ?? 5   
   -   5         ??Name$ 	btn_start??5      $??Рассчет??6$   $
??Left=?66   $??
32,217,0,0q?6Q   $	??Top=?6e   $??41??6}   $	??116??6?   $??2??6?   6?   ?? 5   
   -   5        $ btn_back??5      $??
Назад??6#   $
??Left=?63   $??181,217,0,0q?6N   $	??Top=?6c   $??41??6{   $	??116??6?   $??1??6?   6?   ?? 5   
   -   5         ??Name$ lbl_info??5      $?? ??6"   $??1??6-   $
??Left=?6=   $??
64,158,0,0q?6X   $	??Top=?6l   5      5      