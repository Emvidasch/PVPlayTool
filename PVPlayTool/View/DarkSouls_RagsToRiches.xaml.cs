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

        public DarkSouls_RagsToRiches(DarkSouls_RagsToRiches_Intro parent, bool useBuild)
        {
            //Initialize
            InitializeComponent();

            //Set Parent
            _parent = parent;

            //Load Rewards
            LoadRewards(useBuild);
        }

        private void OnRagsToRichesClosed(object sender, EventArgs e)
        {
            _parent.Show();
        }

        private void Img_CreateRewardCard_Click(object sender, MouseButtonEventArgs e)
        {
            //Roll for rarity of the draw.
            // Legendary = 10%
            // Rare = 25%
            // Uncommon = 60%
            // Common = 80% (100%)

            bool legendary = false;
            bool rare = false;
            bool uncommon = false;
            bool common = false;

            //Roll for Legendary
            legendary = DiceRoll(10, 512);
            //Roll for Rare
            rare = DiceRoll(25, 512);
            //Roll for Uncommon
            uncommon = DiceRoll(60, 512);

            // If no cards were previously drawn succesfully, guarantee a Common card, else Roll for Common
            if(legendary || rare || uncommon)
            {
                common = DiceRoll(80, 512);
            }
            else
            {
                common = true;
            }

            //Check rolls and draw cards
            if(legendary)
            {
                grb_Legendary.Content = DrawReward(ERarity.Rarity.LEGENDARY);
            }
            if (rare)
            {
                grb_Rare.Content = DrawReward(ERarity.Rarity.RARE);
            }
            if (uncommon)
            {
                grb_Uncommon.Content = DrawReward(ERarity.Rarity.UNCOMMON);
            }
            if (common)
            {
                grb_Common.Content = DrawReward(ERarity.Rarity.COMMON);
            }

        }
        private RewardCard DrawReward(ERarity.Rarity rarity)
        {
            //Roll for type of reward.
            //Ring = 25%
            //Spell = 50%
            //Weapon = 50%
            //Armour = 75%
            //Item = 100% (if all else fails)

            //Roll for Ring
            if(DiceRoll(25,512))
            {
                //Create a list to hold all eligible rewards
                List<DaS_Ring> rings = new List<DaS_Ring>();

                //Select the reward that has the rarity and add it to a list
                var ringsRarity = from r in RingRewardList where r.Rarity == rarity select r;
                foreach(var r in ringsRarity)
                {
                    rings.Add(r);
                }
                //Pick a random item from that list.
                Random rand = new Random();
                int i = (rand.Next()) % rings.Count();

                DaS_Ring ring = rings[i];
                return new RewardCard(ring);
            }
            //Roll for Spell
            else if(DiceRoll(50,512) && SpellRewardList.Count > 0)
            {
                //Create a list to hold all eligible rewards
                List<DaS_Spell> spells = new List<DaS_Spell>();

                //Select the reward that has the rarity and add it to a list
                var spellsRarity = from s in SpellRewardList where s.Rarity == rarity select s;
                foreach (var s in spellsRarity)
                {
                    spells.Add(s);
                }
                //Pick a random item from that list.
                Random rand = new Random();
                int i = (rand.Next()) % spells.Count();

                DaS_Spell spell = spells[i];
                return new RewardCard(spell);
            }
            //Roll for Weapon
            else if(DiceRoll(50,512))
            {
                //Create a list to hold all eligible rewards
                List<DaS_Weapon> weapons = new List<DaS_Weapon>();

                //Select the reward that has the rarity and add it to a list
                var weaponsRarity = from w in WeaponRewardList where w.Rarity == rarity select w;
                foreach (var w in weaponsRarity)
                {
                    weapons.Add(w);
                }
                //Pick a random item from that list.
                Random rand = new Random();
                int i = (rand.Next()) % weapons.Count();

                DaS_Weapon weapon = weapons[i];
                return new RewardCard(weapon);
            }
            //Roll for Armour
            else if(DiceRoll(75,512))
            {
                //Create a list to hold all eligible rewards
                List<DaS_Armour> armours = new List<DaS_Armour>();

                //Select the reward that has the rarity and add it to a list
                var armourRarity = from a in ArmourRewardList where a.Rarity == rarity select a;
                foreach (var a in armourRarity)
                {
                    armours.Add(a);
                }
                //Pick a random item from that list.
                Random rand = new Random();
                int i = (rand.Next()) % armours.Count();

                DaS_Armour armour = armours[i];
                return new RewardCard(armour);
            }
            //Pick an item
            else
            {
                //Create a list to hold all eligible rewards
                List<DaS_Item> items = new List<DaS_Item>();

                //Select the reward that has the rarity and add it to a list
                var itemsRarity = from i in ItemRewardList where i.Rarity == rarity select i;
                foreach (var i in itemsRarity)
                {
                    items.Add(i);
                }
                //Pick a random item from that list.
                Random rand = new Random();
                int j = (rand.Next()) % items.Count();

                DaS_Item item = items[j];
                return new RewardCard(item);
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
        private void LoadRewards(bool useBuild)
        {
            if(!useBuild)
            {
                WeaponRewardList = App.DaS_WeaponList;
                ArmourRewardList = App.DaS_ArmourList;
                RingRewardList = App.DaS_RingList;
                ItemRewardList = App.DaS_ItemList;
                SpellRewardList = App.DaS_SpellList;
                CurseList = App.DaS_CurseList;
            }
            else
            {
                // Get current stats from saved build
                DaS_Build b = App.DaS_CurrentBuild;

                //Weapons
                WeaponRewardList = new List<DaS_Weapon>();
                var weapons = from w in App.DaS_WeaponList where 
                              w.StrReq <= (b.Strength * 1.5f) &&
                              w.DexReq <= b.Dexterity &&
                              w.IntReq <= b.Intelligence &&
                              w.FthReq <= b.Faith
                              select w;

                foreach(var w in weapons)
                {
                    WeaponRewardList.Add(w);
                }

                //Armour
                ArmourRewardList = App.DaS_ArmourList;

                //Rings
                RingRewardList = App.DaS_RingList;

                //Items
                ItemRewardList = App.DaS_ItemList;

                //Spells
                SpellRewardList = new List<DaS_Spell>();
                var spells = from s in App.DaS_SpellList where
                             s.AttReq <= b.Attunement &&
                             s.IntReq <= b.Intelligence &&
                             s.FthReq <= b.Faith
                             select s;
                foreach(var s in spells)
                {
                    SpellRewardList.Add(s);
                }

                //Curses
                CurseList = App.DaS_CurseList;
            }
        }

        private void ResetLoot(object sender, RoutedEventArgs e)
        {
            grb_Common.Content = null;
            grb_Uncommon.Content = null;
            grb_Rare.Content = null;
            grb_Legendary.Content = null;
        }
    }
}
