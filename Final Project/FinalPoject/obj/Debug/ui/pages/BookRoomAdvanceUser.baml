   M S B A M L   `   `   `  ����F  BFinalPoject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FinalPoject.ui.pagesFinalPoject.ui.pages  5      A%clr-namespace:FinalPoject.ui.controlsFinalPoject.ui.controls  5      .    (FinalPoject.ui.pages.BookRoomAdvanceUser   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:FinalPoject.ui.pages     5      :controls%clr-namespace:FinalPoject.ui.controls     5        N� Title$  BookRoomAdvanceUser��5	       N� 
Background �	#FF17181C$��301.715��6:   $��Center=�6J   $��Center=�6g   $��343.573��6�   .��5      � -   5         �Name$ grdMain��5      .+�5   
   �� -   5         ��Name$ lblTitle��5      $
��Left=�6&   $
��Wrap=�6A   $	��Top=�6U   ���	#FFECECEC$��37��6�   $	��293��6�   $��16(�6�    �� TextAlignment$ Center=�6�    �� Padding$ 0,7,0,0q�6�   $��	Book Room��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateEnd��5      $
��Left=�6&   $��
135,40,0,0q�6A   $	��Top=�6U   $	��159��6m   $��13.333(�6y   ��5      �� 5       �� EndPoint$ 0.5,0&�6&    �� 
StartPoint$ 0.5,1&�67   .��5      � 	 � Color$	 	#FFA3AEB9��6#   
 � Offset$
 0Q�65   � 5      $	 	#FF8399A9��6#   $
 0.375Q�65   � 5      $	 	#FF718597��6#   $
 0.375Q�65   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   -   5        $ textBlock_Copy��5      $
��Left=�6,   $��	11,43,0,0q�6G   $
��Wrap=�6Z   $	��Top=�6n   $��14.667(�6�   ���	#FFC7C7C7$��93��6�   �� 6�   $	�End��6�   �� 6�   $� Date��6�   6�   �� 5   
   -   5        $ lblTitle_Copy��5      $
��Left=�6+   $
��Wrap=�6F   $	��Top=�6Z   ���	#FFECECEC$��37��6�   $	��293��6�   $��16(�6�   $ Center=�6�   $ 0,7,0,0q�6�   $��Price��6�   $��	1,146,0,0q�6�   �� 5   
   -   5        $ lblUsername��5      $
��Left=�6)   $��
10,185,0,0q�6D   $
��Wrap=�6X   $	��Top=�6l   $��14.667(�6�   ���	#FFC7C7C7$	��221��6�    J� RenderTransformOrigin$ 0.584,0.498&�6�   �� 6�   $
�Name��6�   �� 6�   $�: ��6�   �� 6   $�Zack Davidson��6  6  �� 5   
   -   5        $ lblID��5      $
��Left=�6#   $��231,185,0,0q�6>   $
��Wrap=�6S   $	��Top=�6g   $��14.667(�6   ���	#FFC7C7C7$��62��6�   $ 0.584,0.498&�6�   $	��ID:��6�   �� 5   
   -   5        $ lblDiscount��5      $
��Left=�6)   $��
10,210,0,0q�6D   $
��Wrap=�6X   $	��Top=�6l   $��14.667(�6�   ���	#FFC7C7C7$	��221��6�   $ 0.584,0.498&�6�   $��
Discount: ��6�   �� 5   
   -	   5        $ lblOriginal��5      $
��Left=�6)   $��
10,235,0,0q�6D   $
��Wrap=�6X   $	��Top=�6l   $��14.667(�6�   ���	#FFC7C7C7$	��221��6�   $ 0.584,0.498&�6�   $��Original Price: ��6�   �� 5   
   -
   5        $ lblFinalPrice��5      $
��Left=�6+   $��
10,260,0,0q�6F   $
��Wrap=�6Z   $	��Top=�6n   $��14.667(�6�   ���	#FFC7C7C7$	��221��6�   $ 0.584,0.498&�6�   $��Final Price: ��6�   )   #FinalPoject.ui.controls.HotelButton  5   
   -   5          Name$ 	btnCancel��5      )   #FinalPoject.ui.controls.HotelButton   MouseUp$ btnCancel_MouseUp��6�      	BaseColor$ #B1241E��62   $
��Left=�6F   $��
10,295,0,0q�6a   $	��Top=�6u   $	��108��6�   $��28��6�      Filled .    
ButtonText$ Cancel��6�   6�     5    
   -   5        $ 
btnConfirm��5       $ btnConfirm_MouseUp��6�   $
��Left=�63   $��185,295,0,0q�6N   $	��Top=�6c   $	��108��6{   $��28��6�    . $ Confirm��6�   6�   �� 5!   
   -   5        $ textBlock_Copy1��5!      $
��Left=�6-   $��	11,72,0,0q�6H   $
��Wrap=�6[   $	��Top=�6o   $��14.667(�6�   ���	#FFC7C7C7$	��124��6�   $��Guests��6�   �� 5"   
   -   5         ��Name$ 	txtGuests��5"      $
��Left=�6%   $��23��6@   $��
135,71,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��158��6�   $��14.667(�6�   $��0��6�   �� 5#   
   -   5         ��Name$ rdbMeals��5#      $��Evening Meals Required��6%   $
��Left=�6F   $��
11,106,0,0q�6a   $	��Top=�6u   $	��282��6�   $��26��6�   $��14.667(�6�   ���	#FFC7C7C7
�������6�   5%      5&      