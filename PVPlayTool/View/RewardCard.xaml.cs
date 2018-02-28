using PVPlayTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PVPlayTool.View
{
    /// <summary>
    /// Interaction logic for Shared_CommonCard.xaml
    /// </summary>
    public partial class RewardCard : UserControl
    {
        public ERarity.Rarity ItemRarity;
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemImagePath { get; set; }
        public string ItemRarityCardFront { get; set; }
        public string ItemRarityCardBack { get; set; }

        private string _baseImagePath = "/PVPlayTool;component/Assets/";

        public RewardCard()
        {
            InitializeComponent();
        }
        public RewardCard(DaS_Item item)
        {
            ItemRarity = item.Rarity;
            ItemName = item.ItemName;
            ItemDescription = "You have obtained " + item.Quantity + "X " + item.ItemName + ".";
            ItemImagePath = _baseImagePath + "DarkSouls/Items/" + item.ImagePath;

            SetCardArt();

            InitializeComponent();
        }
        public RewardCard(DaS_Spell spell)
        {
            ItemRarity = spell.Rarity;
            ItemName = spell.SpellName;
            ItemDescription = "You have learned to cast " + spell.SpellName + ".";
            ItemImagePath = _baseImagePath + "DarkSouls/Spells/" + spell.ImagePath;

            SetCardArt();
            //CreateImages();

            InitializeComponent();
        }
        public RewardCard(DaS_Weapon weapon)
        {
            ItemRarity = weapon.Rarity;
            ItemName = weapon.WeaponName;
            ItemDescription = "You have obtained " + weapon.WeaponName + ".";
            ItemImagePath = _baseImagePath + "DarkSouls/Weapons/" + weapon.ImagePath;

            SetCardArt();
            //CreateImages();

            InitializeComponent();
        }
        public RewardCard(DaS_Armour armour)
        {
            InitializeComponent();

            ItemRarity = armour.Rarity;
            ItemName = armour.ArmourName;
            ItemDescription = "You have obtained " + armour.ArmourName + ".";
            ItemImagePath = _baseImagePath + "DarkSouls/Armour/" + armour.ImagePath;

            SetCardArt();
            CreateImages();

            InitializeComponent();
        }
        public RewardCard(DaS_Ring ring)
        {
            ItemRarity = ring.Rarity;
            ItemName = ring.RingName;
            ItemDescription = "You have obtained " + ring.RingName + ".";
            ItemImagePath = _baseImagePath + "DarkSouls/Rings/" + ring.ImagePath;

            SetCardArt();
            //CreateImages();

            InitializeComponent();
        }

        public void SetCardArt()
        {
            switch(ItemRarity)
            {
                case ERarity.Rarity.COMMON:
                    ItemRarityCardFront = "/PVPlayTool;component/Assets/Shared/tex_CardFront_Common.png";
                    ItemRarityCardBack = "/PVPlayTool;component/Assets/Shared/tex_CardBack_Common.png";
                    break;
                case ERarity.Rarity.UNCOMMON:
                    ItemRarityCardFront = "/PVPlayTool;component/Assets/Shared/tex_CardFront_Uncommon.png";
                    ItemRarityCardBack = "/PVPlayTool;component/Assets/Shared/tex_CardBack_Uncommon.png";
                    break;
                case ERarity.Rarity.RARE:
                    ItemRarityCardFront = "/PVPlayTool;component/Assets/Shared/tex_CardFront_Rare.png";
                    ItemRarityCardBack = "/PVPlayTool;component/Assets/Shared/tex_CardBack_Rare.png";
                    break;
                case ERarity.Rarity.LEGENDARY:
                    ItemRarityCardFront = "/PVPlayTool;component/Assets/Shared/tex_CardFront_Legendary.png";
                    ItemRarityCardBack = "/PVPlayTool;component/Assets/Shared/tex_CardBack_Legendary.png";
                    break;
                default:
                    ItemRarityCardFront = "/PVPlayTool;component/Assets/Shared/tex_CardFront_Common.png";
                    ItemRarityCardBack = "/PVPlayTool;component/Assets/Shared/tex_CardBack_Common.png";
                    break;
            }
        }
        public void CreateImages()
        {
            Img_CardBack.Source = new BitmapImage(new Uri(ItemRarityCardBack));
            Img_CardFront.Source = new BitmapImage(new Uri(ItemRarityCardFront));
            Img_CardImage.Source = new BitmapImage(new Uri(ItemImagePath));
        }
    }
}
