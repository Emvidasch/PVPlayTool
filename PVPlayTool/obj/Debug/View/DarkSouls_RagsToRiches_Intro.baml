   M S B A M L   `   `   `  ����E  APVPlayTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PVPlayTool.ViewPVPlayTool.View  5   	   2    ,PVPlayTool.View.DarkSouls_RagsToRiches_Intro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PVPlayTool.View     5   	   -   5        $	��720��5   	   $
��1280��5	   	   $	��720��5
   	   $
��1280��5   	     � Title$1  +PVPlayTool - DarkSouls - RagsToRiches Intro��5   	   $	��720��6=   $
��1280��6J   ���	#FF212121.��5      � .+�5   
   �� -   5         ��Name$ Txt_RagsToRiches��5      $
��Left=�6.   $��	10,10,0,0q�6I   $
��Wrap=�6\   $��Rags To Riches��6p   $	��Top=�6�   $��36(�6�   $��OptimusPrincepsSemiBold)�6�   ���	#FFDEDEDE$��	Underline{�6�   �� 5   
   -   5         ��Name$ ckb_UseBuild��5      $��
Use Build?��6)   $
��Left=�6>   $��	10,63,0,0q�6Y   $	��Top=�6l   ���	#FFDEDEDE$��20(�6�    � Cursor$
 Hand��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Center=�6�   $��27��6�   $	��123��6   � ToolTip$  ��6  $��OptimusPrincepsSemiBold)�6  �� 5   
   -   5        $ txt_BuildExplanation��5      $
��Left=�62   $��	10,95,0,0q�6M   $
��Wrap=�6`   $	��Top=�6t   ���	#FFDEDEDE$	��278��6�   $	��324��6�   $��OptimusPrinceps)�6�   $��16(�6�   �� 6�   $���When enabled, the possible rewards are limited based on your stats in the build editor. This will take 2-handing into account for Strength requirements, and will not give Sorcery, Miracles or Pyromancy if you do not have the Attunement for it.��6�   �� 6�  �� 6�  �� 6�  �� 6  $C�=NOTE: Does not take your covenant into account. Deal with it.��6  �� 6R  �� 6^  �� 6j  6q  �� 5   
   -   5        $ txt_StartingEquipment��5      $
��Left=�63   $��
450,63,0,0q�6N   $
��Wrap=�6b   $��Starting Equipment��6v   $	��Top=�6�   ���	#FFDEDEDE$��20(�6�   $	��216��6�   $��OptimusPrincepsSemiBold)�6�    �� TextAlignment$ Center=�6�   $��	Underline{�6  �� 5   
   -   5         ��Name$ 	Btn_Start��5      $
��Left=�6$   $��	15,0,0,50q�6?   $	��320��6R   $��OptimusPrincepsSemiBold)�6^   $��24(�6�   ���	#7FDDDDDD
�������$��3q�6�      ImageButton#���   6�   
�������$	��180��60  $��Bottom=�6=  $
 Hand��6X  .��5      �� -   5         ��Name$ 	img_Start��5      $
��Left=�6'   $	��Top=�6B   $D��>/PVPlayTool;component/Assets/DarkSouls/Icons/tex_DaS_Start.png��6Z   $��3,0,0,0q�6�   5      �� 5   
   -   5        $ img_HeadSlot��5      $
��Left=�6&   $	��100��6A   $��517,101,0,0q�6N   $	��Top=�6c   $��86��6{   $?��9/PVPlayTool;component/Assets/Shared/tex_EquipmentSlot.png��6�   �� 5   
   -	   5        $ img_BodySlot��5      $
��Left=�6&   $	��100��6A   $��517,218,0,0q�6N   $	��Top=�6c   $��86��6{   $?��9/PVPlayTool;component/Assets/Shared/tex_EquipmentSlot.png��6�   �� 5   
   -
   5        $ img_RightHandSlot��5      $
��Left=�6+   $	��100��6F   $��426,218,0,0q�6S   $	��Top=�6h   $��86��6�   $?��9/PVPlayTool;component/Assets/Shared/tex_EquipmentSlot.png��6�   �� 5   
   -   5        $ img_LeftHandSlot��5      $
��Left=�6*   $	��100��6E   $��608,218,0,0q�6R   $	��Top=�6g   $��86��6   $?��9/PVPlayTool;component/Assets/Shared/tex_EquipmentSlot.png��6�   �� 5   
   -   5        $ img_FeetSlot��5      $
��Left=�6&   $	��100��6A   $��517,365,0,0q�6N   $	��Top=�6c   $��86��6{   $?��9/PVPlayTool;component/Assets/Shared/tex_EquipmentSlot.png��6�   �� 5   
   -   5        $ image��5      $
��Left=�6   $	��100��6:   $	��Top=�6G   $	��100��6_   �� 5   
   -   5        $ 
img_Shield��5      $
��Left=�6$   $��80��6?   $��616,227,0,0q�6K   $	��Top=�6`   $��70��6x   $L��F/PVPlayTool;component/Assets/DarkSouls/Weapons/tex_DaS_PlankShield.png��6�   �� 5   
   -   5        $ 	img_Armor��5      $
��Left=�6#   $��80��6>   $��525,227,0,0q�6J   $	��Top=�6_   $��70��6w   $R��L/PVPlayTool;component/Assets/DarkSouls/Armour/tex_DaS_HollowWarriorArmor.png��6�   �� 5   
   -   5        $ img_Armor_Copy��5      $
��Left=�6(   $��80��6C   $��525,376,0,0q�6O   $	��Top=�6d   $��70��6|   $W��Q/PVPlayTool;component/Assets/DarkSouls/Armour/tex_DaS_HollowWarriorWaistcloth.png��6�   �� 5   
   -   5        $ 
txt_weapon��5      $
��Left=�6(   $��440,244,0,0q�6C   $
��Wrap=�6X   $��Class Starting Weapon��6l   $	��Top=�6�   $��41��6�   $��60��6�   $��OptimusPrincepsSemiBold)�6�   
�������6�   �� 5   
   -   5        $ 	txt_Armor��5      $
��Left=�6'   $��529,319,0,0q�6B   $
��Wrap=�6W   $��Hollow Warrior Armor��6k   $	��Top=�6�   $��41��6�   $��59��6�   $��OptimusPrincepsSemiBold)�6�   
�������$ Center=�6�   �� 5    
   -   5        $ txt_Legs��5       $
��Left=�6&   $��518,470,0,0q�6A   $
��Wrap=�6V   $��Hollow Warrior Waistcloth��6j   $	��Top=�6�   $��41��6�   $��84��6�   $��OptimusPrincepsSemiBold)�6�   
�������$ Center=�6�   �� 5!   
   -   5        $ 
txt_Shield��5!      $
��Left=�6(   $��622,320,0,0q�6C   $
��Wrap=�6X   $��Plank Shield��6l   $	��Top=�6�   $��29��6�   $��59��6�   $��OptimusPrincepsSemiBold)�6�   
�������$ Center=�6�   �� 5"   
   -   5        $ txt_StartingItems��5"      $
��Left=�6/   $��
894,62,0,0q�6J   $
��Wrap=�6^   $��Starting Items��6r   $	��Top=�6�   ���	#FFDEDEDE$��20(�6�   $	��216��6�   $��OptimusPrincepsSemiBold)�6�   $ Center=�6�   $��	Underline{�6  �� 5#   
   -   5        $ txt_Humanity��5#      $
��Left=�6*   $��1000,116,0,0q�6E   $
��Wrap=�6[   $	��Top=�6o   ���	#FFDEDEDE$��21��6�   $��97��6�   $��16(�6�   $��OptimusPrinceps)�6�   �� 6�   $�Humanity x5��6�   �� 6�   �� 6  �� 6  6  �� 5$   
   -   5        $ img_Humanity��5$      $
��Left=�6&   $��80��6A   $��
895,89,0,0q�6M   $	��Top=�6a   $��70��6y   $G��A/PVPlayTool;component/Assets/DarkSouls/Items/tex_DaS_Humanity.png��6�   �� 5%   
   -   5        $ txt_LloydsTalisman��5%      $
��Left=�60   $��1000,215,0,0q�6K   $
��Wrap=�6a   $	��Top=�6u   ���	#FFDEDEDE$��21��6�   $	��204��6�   $��16(�6�   $��Lloyd's Talisman x10��6�   $��OptimusPrinceps)�6�   �� 5&   
   -   5        $ img_LloydsTalisman��5&      $
��Left=�6,   $��80��6G   $��895,175,0,0q�6S   $	��Top=�6h   $��70��6�   $M��G/PVPlayTool;component/Assets/DarkSouls/Items/tex_DaS_LloydsTalisman.png��6�   �� 5'   
   -   5        $ 	img_Rings��5'      $
��Left=�6#   $��80��6>   $��895,278,0,0q�6J   $	��Top=�6_   $��70��6w   $Q��K/PVPlayTool;component/Assets/DarkSouls/Rings/tex_DaS_DarkmoonSeanceRing.png��6�   �� 5(   
   -   5        $ 	txt_Rings��5(      $
��Left=�6'   $��1000,316,0,0q�6B   $
��Wrap=�6X   $	��Top=�6l   ���	#FFDEDEDE$��21��6�   $	��204��6�   $��16(�6�   $��Two rings of your choice��6�   $��OptimusPrinceps)�6�   �� 5)   
   -   5        $ Btn_Help��5)      $��1159,0,0,50q�6#   $��OptimusPrincepsSemiBold)�68   $��24(�6]   
�������
�������$��3q�6�   #���   6�   $
 Hand��6�   $
��Left=�6�   $	��100��6  $	��100��6  $��Bottom=�6(  .��5*      �� -   5        $ img_Help��5*      $6��0/PVPlayTool;component/Assets/Shared/tex_Help.png��6&   $��-17,-19,-19,-18q�6`   $��85��6y   $��85��6�   5+      �� 5,   
   -   5        $ txt_Help��5,      $
��Left=�6&   $��1155,506,0,0q�6A   $
��Wrap=�6W   $
��Help��6k   $	��Top=�6w   ���	#FFDEDEDE$��20(�6�   $	��107��6�   $��OptimusPrincepsSemiBold)�6�   $ Center=�6�   $��	Underline{�6�   5.      5/      