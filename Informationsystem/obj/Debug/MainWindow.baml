   M S B A M L   `   `   `  ????L  HInformationsystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:InformationsystemInformationsystem  5   	   "    Informationsystem.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9i+http://schemas.microsoft.com/xaml/behaviors     5   	   1localclr-namespace:Informationsystem     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? Title$  Суши от души??5
   	   $	??500??6   $	??800??6,   $??14(?68   $??Swis721 Lt BT)?6F   ???	#FF3DE71A$
??Bold"?6x    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value??%?   '??       '?? H     ?? 5   
   " ??6   .?5      ??  ? ??$ 14(?6)   5      ?? 5   
   " ??6   .?5      ??  ? ??$ 14(?6)   5      5      .??5      ? ???#FFEFD5 ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??0.8* ?6   .+?5   
   ?? $??0??6   ??6"   ?? *Items+ ?? SelectedItem 5      ?? *SelectedItem+??5      ?? 5      .R?5      ?? $??5q?6!   .+?5      ??     MaterialDesignBody1TextBlock#??[  6%   $??14(?6[   $
??Bold"?6?   ??6i   ??  ?? Path$
 Name?6?   ?? 5      #??[  6%   $??14(?6w   $
??Bold"?6?   ??6[   ?? $ Price?6?   5       5!      5#      ?? 5%   
   $??1??6    ? DataContext 6%   ?? *SelectedItem+.+?5&      ?? $'??!Выбранный элемент??6   #??[  61   $??14(?6g   ???	#FF8321E8$
??Bold"?6?   ?? 5'      $??Сет??6   #??[  6#   $??14(?6Y   ???	#FF8321E8$
??Bold"?6~   ?? 5(      -   5        	 ??Name$	 textBlockset??5(      #??[  6.   ??6d   ?? *Name+
 ?? UpdateSourceTrigger$
 PropertyChanged=??? 5)      $??Цена??6   #??[  6%   $??14(?6[   ???	#FF8321E8$
??Bold"?6?   ?? 5*      -   5        $	 textBlockprice??5*      #??[  60   ??6f   ?? *Price+$
 PropertyChanged=??? 5+      $%??Кол-во соусов (50р)??6   #??[  63   $??14(?6i   ???	#FF8321E8$
??Bold"?6?   ?? 5,      -   5         ??Name$ textBlocksouce??5,        MaterialDesignTextBox#??[ 6.   ??6]   ?? *Sauce+$
 PropertyChanged=?6?   ?? 5-      $
??Wrap=?6   $2??,Кол-во порций васаби (30р)??6,   #??[  6N   $??14(?6?   ???	#FF8321E8$
??Bold"?6?   ?? 5.      -   5        $ textBlockwasabi??5.      #??[ 6/   ??6^   ?? *Wasabi+$
 PropertyChanged=?6?   ?? 5/      $
??Wrap=?6   $2??,Кол-во порций имбиря (20р)??6,   #??[  6N   $??14(?6?   ???	#FF8321E8$
??Bold"?6?   ?? 50      -   5        $ textBlockimbir??50      #??[ 6.   ??6]   ?? *Imbir+$
 PropertyChanged=?6?   ?? 51      -   5         ??Name$ buttonoreder??51        MaterialDesignFlatButton#??[ 6+   ???	#FF6BFF00$??Заказать??6v   $??30,0,227.8,0q?6?   ???	#FF671EEA??6?   ?? *OrderCommand+52      53      54      