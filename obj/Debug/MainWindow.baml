   M S B A M L   `   `   `  ����C  ?Vigenere, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:VigenereVigenere  5   	   9!clr-namespace:Vigenere.ConvertersVigenere.Converters  5   	       Vigenere.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Vigenere     5   	   8
converters!clr-namespace:Vigenere.Converters     5   	     � Title$  Vigenere��5	   	   $	��400��6   $	��600��6'      DefaultFont#��[  5
   	    � 	Resources 5      6   0Vigenere.Converters.VigenereClearToCodeConverter  ClearToCode6   0Vigenere.Converters.VigenereCodeToClearConverter  CodeToClear �� 
TargetType �� BasedOn  MultiBoundCode �� Property �� Value `� 	Converter �� Path  MultiBoundClear��%�  &	       &	      &	 &     7��7  &	 �     7��7    5   
   62     5   
   62   �� 5   
   " ��6   8   .�5      ��  � �� 5      `� 5      8  .1�5      �� $ Clear�6"   �� 5      $ Password�6"   5      5      5      �� 5   
   " ��6   8   .�5      ��  � �� 5      `� 5      8  .1�5      �� $
 Code�6"   �� 5       $ Password�6"   5!      5#      5$      5&      .��5)      �  � RowDefinitions 5+   
   �� 5,      $	��50* �6   �� 5-      $
��100* �6   �� 5.      $	��50* �6   �� 5/      $
��100* �6   �� 50      $	��50* �6   	 � ColumnDefinitions	 53   
   �� 54      $	��50* �6   �� 55      $	��40* �6   .+�58   
   � $��2��6   $��0��6   $��15q�6,   	 59      �� 5:      �� 5;      .+�5>      �� -   5        
 ��Name$
 button_mode��5>      $��0��6*   $��Right=�6:   $��20��6V   $��50��6b   $��0,0,20,0q�6m   .��6�   MODE6�   5A      �� 5D   
   -   5         ��Name$ headline��5D      $��0��6"   $��0��6/   $��2��6?   $��Center=�6S   $��10q�6p   $��20(�6|   $
��Bold"�6�   .��6�   Vigenere Encode6�   �� 5G   
   $��1��6   $��0��6   $��Center=�6-   $	��Top=�6J   $��10q�6b   .��6n   
Klartext6x   �� 5I   
   -   5         ��Name$ 	clear_inp��5I      $��1��6%   $��0��62   $��Center=�6B   $��Bottom=�6_   $��50��6z   $
��auto��6�   $	��200��6�   $
��auto��6�   $��50,40,50,10q�6�    �� TextWrapping$
 Wrap=�6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   ��6�   �� $ Clear� �� UpdateSourceTrigger$ PropertyChanged=�6B  �� 5K   
   -   5        $ 	clear_out��5K      $��1��6%   $��0��62   $��Center=�6B   $��Bottom=�6_   $
��auto��6z   $	��200��6�   $
��auto��6�   $��50,40,50,10q�6�   $y�	Collapsed=�6�    �� 
IsReadOnly . $
 Wrap=�6�   $
 Auto=�6�   #��[ 6  
�������6[  �� 5N   
   -   5        $ password��5N      $��2��6$   $��1��61   $
��Left=�6A   $��Center=�6\   $	��130��6w   $��10q�6�   ��6�   �� $ Password�$ PropertyChanged=�6�   �� 5O   
   $��2��6   $��1��6   $��Right=�6-   $��Center=�6I   $��10,10,30,10q�6d   .��6y   
Passwort6�   �� 5R   
   -   5        $ code_out��5R      $��3��6$   $��0��61   $��Center=�6A   $	��Top=�6^   $
��auto��6v   $	��200��6�   $
��auto��6�   $��50,10,50,40q�6�    . $
 Wrap=�6�   $
 Auto=�6�   #��[ 6�   
�������6?  �� 5T   
   -   5        $ code_inp��5T      $��3��6$   $��0��61   $��Center=�6A   $	��Top=�6^   $��50��6v   $
��auto��6�   $	��200��6�   $
��auto��6�   $��50,10,50,40q�6�   $y�	Collapsed=�6�   $
 Wrap=�6�   $
 Auto=�6�   ��6  �� $
 Code�$ PropertyChanged=�6T  �� 5V   
   $��3��6   $��0��6   $��Center=�6-   $��Bottom=�6J   $��10q�6e   .��6q   
Geheimtext6}   �� 5Y   
   -   5        $��4��5Y      $��1��6   $
��Left=�6.   $��Center=�6I   $��20��6d   $��50��6p   $��20,0,0,0q�6{   .��6�   QUIT6�   �� 5Z   
   -	   5        $ 
Info_Label��5Z      $��4��6$   $��1��61   $
��Left=�6A   $��Center=�6\   $��	120,0,0,0q�6w   .��6�   Info:6�   5]      5_      