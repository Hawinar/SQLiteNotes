   M S B A M L   `   `   `  ????F  BSQLiteNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SQLiteNotes.PagesSQLiteNotes.Pages  5           SQLiteNotes.Pages.MainMenu   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:SQLiteNotes.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        N? Title$  MainMenu??5
      .??5      ? .+?5   
   ?? -   5         ??Name$ lbTitles??5      $
??Left=?6$   $	??195??6?   $??0,90,0,0q?6c   ??6K   ?? ??5      ?? 5      .R?5      ? .+?5      ?? $
??Left=?6;   ??6$   ?? *Title+6;   5      5      5      ?? 5   
   -   5         ??Name$ tbText??5      $?? ??5      $	??320??5      $	??Top=?5      $
??Left=?5       ?? AcceptsReturn$
 True??5       !  MaterialDesignOutlinedTextBox#??[  5       ?? TextWrapping$
 Wrap=?5      " ?? VerticalScrollBarVisibility$
 Auto=?5      $??200,120,0,0q?60   $	??581??6E   {?5      ??  ?? Path$ 	IsChecked? ?? ElementName$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox??5   E   ?? 5!   
   -   5         ??Name$ 	btAddNote??5!      $??Добавить??5"      $??Right=?5#      $??
0,365,10,0q?5$      $	??Top=?5%      $	??165??5&      $??Bookman Old Style)?5'      ???	#FF0A550F5)      ?? 5*   
   -   5        $ 	btDelNote??5*      $??Удалить??5+      $??Right=?5,      $	??Top=?5-      $	??165??5.      $??Bookman Old Style)?5/      ???	#FF0A550F50   (   ?? 51   
   -   5        $ btSave??51      $??Сохранить??6!   $??Right=?65   $??
0,120,10,0q?6Q   $	??Top=?6e   $	??165??6}   $??Bookman Old Style)?6?   ???	#FF0A550F6?   ?? 52   
   -   5        $ 	tbNewNote??53      $??Right=?54      $	??400??55      $	??Top=?56      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$%	 Введите название??57      $
 True??58        MaterialDesignFilledTextBox#??[ 5:      $
 Wrap=?5;      $??
0,402,10,0q?6   $	??165??6-   {?59      ?? $ 	IsChecked?$0 *MaterialDesignFilledTextBoxEnabledComboBox??5;   -   ?? 5<   
   -   5        $ 
tbNewTitle??5=      $?? ??5>      $??Right=?5?      $	??400??5@      $	??Top=?5A      $!	 Смена названия??5B      $
 True??5C      #??[ 5E      $
 Wrap=?5F      $??
0,152,10,0q?6!   $	??165??65   {?5D      ?? *	IsChecked+$0 *MaterialDesignFilledTextBoxEnabledComboBox??5F   5   ?? 5G   
   -   5        
 ??Name$
 lbLastChangeDate??5G      $?? ??6*   $
??Left=?65   $??200,100,0,0q?6P   $	??Top=?6e   $??Bookman Old Style)?6}   $??14(?6?   ?? 5H   
   -	   5        $ tbFontFamily??5I      $??Right=?5J      $	??400??5K      $	??Top=?5L      $2	 ,Введите название шрифта??5M      $
 True??5N      #??[ 5P      $
 Wrap=?5Q      $??
0,202,10,0q?6!   $	??165??65   {?5O      ?? *	IsChecked+$0 *MaterialDesignFilledTextBoxEnabledComboBox??5Q   5   ?? 5R   
   -
   5        $ 
tbFontSize??5S      $??Right=?5T      $	??400??5U      $	??Top=?5V      $.	 (Введите размер шрифта??5W      $
 True??5X      #??[ 5Z      $
 Wrap=?5[      $??
0,252,10,0q?6!   $	??165??65   {?5Y      ?? *	IsChecked+$0 *MaterialDesignFilledTextBoxEnabledComboBox??5[   5   5\      5]      