   M S B A M L   `   `   `  ����M  IMH_SocialnoOmrezje, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MH_SocialnoOmrezjeMH_SocialnoOmrezje  5   	   7 clr-namespace:MH_SocialnoOmrezjeMH_SocialnoOmrezje  5   	   #    MH_SocialnoOmrezje.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /uc clr-namespace:MH_SocialnoOmrezje     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MH_SocialnoOmrezje     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   6-   �� 5      $��2* �6   6,   �� 5      $��* �6   6+   �� 5      $
��Auto �6   6.    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $	��100 �6   6+   �� 5      $
��Auto �6   6,   .+�5   
   o� $��3��6   .@�5      m� $
��File��6   .@�5      m� $��Objave��6   .@�5      m� -   5        $��Dodaj��5      6I   m� 5      -   5        $��Odstrani��5      6L   m� 5       -   5        $��Uredi��5       6I   5!      m� 5"      $��Datoteka��6   .@�5#      m� -   5        $��
Prijatelji��5#      6O   m� 5$      -   5        $��Izhod��5$      6G   m� 5%      -   5        $
��Uvoz��5%      6H   m� 5&      -   5        $��Izvoz��5&      6I   5'      5(      5)      �� 5-   
   $��2��6   $��0��6"   $��3��62   .@�5.      �� $	��Zid��6   .��5/      �� .+�50      �� -   5        $
��list��50      51      �� 52      -	   5        $��30��52      $��10q�6(   $
��Left=�64    J� RenderTransformOrigin$ 0.698,0.597&�6d   .��53      �� $��res/dodaj.png��6    69   54      55      56      �� 58      $��O meni��6   $��22��6&   $��Bottom=�62   .��5D         MH_SocialnoOmrezje.Userr  5E      �� 5F      $��
Prijatelji��6   .��5G      �� .+�5H      �� -
   5        $	��txt��5H      $��Isci prijatelja: ��6)   6f   �� 5L      $��70��6   $��70��6*   $
��Left=�65   .@�6P   
Miha Hirtl6\   �� 5M      $��70��6   $��70��6*   $
��Left=�65   .@�6P   
Bill Gates6\   5N      5O      �� 5P      $��Slike��6   .��5Q      �� .+�5R      �� $��5q�6   $��	res/1.jpg��6'   $	��100��6:   $
��Auto��6F   $
��Left=�6T   6r   �� 5S      $��5q�6   $��
res/2.jpeg��6'   $	��100��6;   $
��Auto��6G   $
��Left=�6U   $	��Top=�6p   6�   �� 5T      $��5q�6   $��	res/3.jpg��6'   $	��100��6:   $
��Auto��6F   $
��Left=�6T   $	��Top=�6o   6�   5U      5V      5W      �� 5Y   
   $��2��6   $��3��6   $��
res/mz.jpg��6-   6C   5[      5]      