   M S B A M L   `   `   `  ����N  JHalı Saha Yönetim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Halı_Saha_Yönetim.PageScreensHalı_Saha_Yönetim.PageScreens  5      .    (Halı_Saha_Yönetim.PageScreens.Settings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Halı_Saha_Yönetim.PageScreens     5        N� Title$  Settings��5	       N� 
Background
 �����.��5      � #��� ��6   $��2,0,-2,0q�6X   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGridSaha��5      $
��Left=�6'      AutoGenerateColumns .  $	��264��6^   $��
33,102,0,0q�6k   $	��Top=�6   $	��371��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ SAHA ID��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID+6<     5      $ SAHA ADI��6A    6%   �� *	Saha_Ad+6A     5      $ FİYAT��6?    6%   �� *Fiyat+6?     5      $ 	KAPASİTE��6B    6%   �� *
Kapasite+6B   5      �� 5   
   -   5        $��	txtSahaAd��5      $
��Left=�6#   $��23��6>   $��
520,37,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $��txtFiyat��5      $
��Left=�6"   $��23��6=   $
 Wrap=�6I   $�� ��6]   $	��Top=�6e   $	��120��6}   $��
520,80,0,0q�6�   �� 5   
   -   5        $��txtSahaKapasite��5      $
��Left=�6)   $��23��6D   $
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��120��6�   $��520,124,0,0q�6�   �� 5   
   -   5        $��Kaydet��5      $
��Left=�6"   $��520,163,0,0q�6=   $	��Top=�6R   $	��120��6j   $��36��6v   ���	#FFDE9B9B6�   �� 5   
   -   5        $	��Sil��5      $
��Left=�6   $��36��6:   $��520,219,0,0q�6F   $	��Top=�6[   $	��120��6s   ���	#FFD3A0A06�   �� 5   
   -   5         ��Name$ txtSecim��5      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $�� ��6_   $	��Top=�6g   $	��120��6   $��520,278,0,0q�6�   �� 5   
   $��
Saha Adı:��6   $��15(�6$   $
��Left=�62   $��
450,33,0,0q�6M   $	��Top=�6a   �� 5   
   $��Fiyat:��6   $��15(�6!   $
��Left=�6/   $��
473,76,0,0q�6J   $	��Top=�6^   �� 5   
   $��	Kapasite:��6   $��15(�6$   $
��Left=�62   $��452,120,0,0q�6M   $	��Top=�6b   �� 5   
   $��SAHA EKLEME EKRANI��6   $��23(�6-   $
��Left=�6;   $��	33,37,0,0q�6V   $	��Top=�6i   $��40��6�   $	��371��6�   ���	#FFFD51516�   5       5!      