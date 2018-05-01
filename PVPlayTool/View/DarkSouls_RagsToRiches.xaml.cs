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
using System.Windows.Shapes;
using PVPlayTool.Model;

namespace PVPlayTool.View
{
    /// <summary>
    /// Interaction logic for DarkSouls_RagsToRiches.xaml
    /// </summary>
    public partial class DarkSouls_RagsToRiches : Window
    {
        private DarkSouls_RagsToRiches_Intro _parent;

        public List<DaS_Weapon> WeaponRewardList;
        public List<DaS_Armour> ArmourRewardList;
        public List<DaS_Item> ItemRewardList;
        public List<DaS_Ring> RingRewardList;
        public List<DaS_Spell> SpellRewardList;

        public List<DaS_Curse> CurseList;

        public DarkSouls_RagsToRiches(DarkSouls_RagsToRiches_Intro parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void OnRagsToRichesClosed(object sender, EventArgs e)
        {
            _parent.Show();
        }

        private void Img_CreateRewardCard_Click(object sender, MouseButtonEventArgs e)
        {
            //Roll for rarity of the draw.
            // Legendary = 5%
            // Rare = 15%
            // Uncommon = 30%
            // Common = 80% (100%)

            bool legendary = false;
            bool rare = false;
            bool uncommon = false;
            bool common = false;

            //Roll for Legendary
            legendary = DiceRoll(5, 512);
            //Roll for Rare
            rare = DiceRoll(15, 512);
            //Roll for Uncommon
            uncommon = DiceRoll(30, 512);
            // If no cards were previously drawn succesfully, guarantee a Common card, else Roll for Common
            if(legendary || rare || uncommon)
            {
                common = true;
            }
            else
            {
                common = DiceRoll(80, 512);
            }


        }
        private void Btn_Help_Click(object sender, RoutedEventArgs e)
        {
            DarkSouls_RagsToRiches_Help help = new DarkSouls_RagsToRiches_Help();
            help.Show();
        }
        private bool DiceRoll(int chancePercentage, int chanceLimit)
        {
            //Create Dice, Random factor and required roll chance
            double dice = 0.0;
            double chance = chanceLimit / 100 * chancePercentage;
            Random rand = new Random();


            //Roll dice and check result
            dice = rand.NextDouble() * (chanceLimit + 1);

            return (dice <= chance);
        }
    }
}
