   M S B A M L   `   `   `  ????G  CWPF-Practica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF_PracticaWPF_Practica  5   	       WPF_Practica.ex2_window   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF_Practica     5   	     ? Title$  
ex2_window??5   	   $	??322??6   $	??661??6)   .??5	      ? .+?5
   
   ?? $
??Left=?6   $??	32,24,0,0q?6/   $????Дана строка. Если она представляет собой запись целого числа, то вывести 1; если вещественного (с дробной частью), то вывести 2; если строку нельзя преобразовать в число, то вывести 0.??6B   $
??Wrap=?6  $	??Top=?6  $??14(?6.  ?? 5   
   $??Строка:??6   $
??Left=?6"   $??
32,107,0,0q?6=   $	??Top=?6Q   $??16(?6i   ?? 5   
   -   5         ??Name$ tb_numb??5      $
??Left=?6#   $??114,114,0,0q?6>   $?? ??6S    ?? TextWrapping$
 Wrap=?6[   $	??Top=?6o   $	??272??6?   $??24??6?   ?? 5   
   -   5         ??Name$ 	btn_start??5      $??Рассчет??6$   $
??Left=?66   $??
84,209,0,0q?6Q   $	??Top=?6e   $??33??6}   $??97??6?   6?   ?? 5   
   -   5        $ btn_back??5      $??
Назад??6#   $
??Left=?63   $??214,209,0,0q?6N   $	??Top=?6c   $??33??6{   $??97??6?   6?   ?? 5   
   -   5         ??Name$ lbl_info??5      $?? ??6"   $
??Left=?6-   $??220,153,0,0q?6H   $	??Top=?6]   5      5      