   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   a ]DevExpress.Xpf.Core.v23.1, Version=23.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   c _DevExpress.Xpf.Charts.v23.1, Version=23.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aTCustomGhttp://schemas.devexpress.com/winfx/2008/xaml/charts/rangecontrolclient  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��25* �6   �� 5      $��5* �6   �� 5      $	��25* �6   �� 5      $��2* �6   �� 5      $��8* �6   �� 5      $��5* �6    � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��5* �6   �� 5      $��2* �6   �� 5      $	��20* �6   �� 5      $��2* �6   �� 5      $��3* �6   �� 5      $	��10* �6   �� 5      $��2* �6   �� 5      $��3* �6   �� 5       $��5* �6   �� 5!      $��5* �6   .+�5$   
   �� $��20(�6   $��5��6   $��1��62   $��1��6B   $��PDF Concat Tool��6O   $��Center=�6i   �� 5%   
   -   5         ��Name$ btnOpenFileFirst��5%      $��20(�6+   $��1��6U   $��3��6e   $��4��6r   $��Select main PDF file��6�   �� 5&   
   -   5        $ btnOpenFileSecond��5&      $��20(�6,   $��3��6W   $��3��6g   $��3��6{   $ ��Select additional PDF file��6�   �� 5'   
   -   5        $ AddPageButton��5'      $��20(�6(   $��3��6F   $��6��6V   $��Insert Page��6c   �� 5(   
   $��5��6   $��5��6$   $
��Wrap=�61   $��Page number��6E   �� 5)   
   -   5        $��NumberTextBox��5)      $��5��6R   $��6��6b   $��20(�6o   $��Center=�6~   $��Center=�6�   �� 5*   
   -   5        $��newFileName��5*      $��1��6%   $��9��66    �� TextWrapping$
 Wrap=�6C   $��Concated_File.pdf ��6W   $��Center=�6r   $��Center=�6�   �� 5+   
   $��1��6   $��8��6$   $
��Wrap=�61   $��Name after concatenation:��6E   �� 5-   
   -   5        $ GoConvertButton��5-      $��20(�6*   $��3��6J   $��3��6Z   $��9��6n   $��
Concat Now��6{   50      52      