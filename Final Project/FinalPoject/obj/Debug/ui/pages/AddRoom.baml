   M S B A M L   `   `   `  ����F  BFinalPoject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FinalPoject.ui.controlsFinalPoject.ui.controls  5      "    FinalPoject.ui.pages.AddRoom   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :controls%clr-namespace:FinalPoject.ui.controls     5        N� Title$  AddRoom��5      $	��262��6   $	��364��6   .��5
      � ���	#FF17181C.+�5   
   �� -   5         ��Name$ lblTitle��5      $
��Left=�6&   $
��Wrap=�6A   $	��Top=�6U   ���	#FFECECEC$��37��6�   $	��262��6�   $��16(�6�    �� TextAlignment$ Center=�6�    �� Padding$ 0,7,0,0q�6�   �� 6�    � Language$ en-gb�6�   $�Add Room��6�   6�   �� 5   
   -   5        $ lblSingleBedrooms��5      $��
10,199,0,0q�6/   $
��Wrap=�6C   ���	#FFB0B0B0$
��Left=�6n   $	��Top=�6�   $	��204��6�   $��14.667(�6�   �� 6�   $ en-gb�6�   $�Single Bedrooms: 0��6�   6�   �� 5   
   -   5        $ lblDoubleBedrooms��5      $��
10,224,0,0q�6/   $
��Wrap=�6C   ���	#FFB0B0B0$
��Left=�6n   $	��Top=�6�   $	��204��6�   $��14.667(�6�   �� 6�   $ en-gb�6�   $�Double Bedrooms: 0��6�   6�   �� 5   
   -   5        $ lblTrebleBedrooms��5      $��
10,249,0,0q�6/   $
��Wrap=�6C   ���	#FFB0B0B0$
��Left=�6n   $	��Top=�6�   $	��204��6�   $��14.667(�6�   �� 6�   $ en-gb�6�   $�Treble Bedrooms: 0��6�   6�   �� 5   
   -   5        $ lblFamilyBedrooms��5      $��
10,274,0,0q�6/   $
��Wrap=�6C   ���	#FFB0B0B0$
��Left=�6n   $	��Top=�6�   $	��204��6�   $��14.667(�6�   �� 6�   $ en-gb�6�   $�Family Bedrooms: 0��6�   6�   �� 5   
   -   5        $ lblStats��5      $
��Left=�6&   $
��Wrap=�6A   $	��Top=�6U   ���	#FFECECEC$��37��6�   $	��262��6�   $��16(�6�   $ Center=�6�   $ 0,7,0,0q�6�   $��	0,158,0,0q�6�   �� 6�   $ en-gb�6�   $�Hotel Statistics��6�   6  )   #FinalPoject.ui.controls.HotelButton  5   
   -   5          Name$ 
btnAddRoom��5      )   #FinalPoject.ui.controls.HotelButton   MouseUp$ btnAddRoom_MouseUp��6�   $
��Left=�63   $��
57,122,0,0q�6N   $	��Top=�6b   $	��147��6z      
ButtonText$ Add Room��6�   $��30��6�      Filled . 6�   �� 5   
   -   5        $ 	lblAmount��5      $��	10,42,0,0q�6'   $
��Wrap=�6:   ���	#FFB0B0B0$
��Left=�6e   $	��Top=�6�   $��95��6�   $��14.667(�6�   �� 6�   $ en-gb�6�   $�Amount:��6�   6�   �� 5   
   -	   5        	 ��Name$	 txtRoom��5      $
��Left=�6#   $��23��6>   $��
110,42,0,0q�6J   
 �� TextWrapping$

 Wrap=�6^   $	��Top=�6r   $	��137��6�   �� 5   
   -
   5        $ lblType��5      $��	10,73,0,0q�6%   $
��Wrap=�68   ���	#FFB0B0B0$
��Left=�6c   $	��Top=�6~   $	��115��6�   $��14.667(�6�   �� 6�   $ en-gb�6�   $�Type:��6�   6�   �� 5   
   -   5         ��Name$ 
cmbBedroom��5      $
��Left=�6'   $��
110,73,0,0q�6B   $	��Top=�6V   $	��137��6n    �� SelectedIndex$ 0��6z   .@�5      �� $��Single Bedroom��6   �� 5      $��Double Bedroom��6   �� 5      $��Treble Bedroom��6   �� 5      $��Family Bedroom��6   5        5   
   -   5        $ 	btnGoBack��5      $ btnGoBack_MouseUp��6�   $
��Left=�62   $��
57,324,0,0q�6M   $	��Top=�6a   $	��147��6y   $ Return to Main Menu��6�   $��30��6�    .    	BaseColor$ #B1241E��6�   6�   �� 5   
   -   5        $ 
lblMessage��5      $
��Left=�6(   $��	10,98,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $	��242��6�   ���	#FFF10404$ Center=�6�   $y�Hidden=�6�   �� 6�   $ en-gb�6�   $�Added Room Successfully��6�   6  5      5       