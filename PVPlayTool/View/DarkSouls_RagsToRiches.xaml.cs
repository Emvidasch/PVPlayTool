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
    public enum ERewardType
    {
        RING,
        WEAPON,
        ARMOUR,
        ITEM,
        SPELL
    }
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
        public Random RNG;

        public DarkSouls_RagsToRiches(DarkSouls_RagsToRiches_Intro parent, bool useBuild)
        {
            //Initialize
            InitializeComponent();

            //Set Parent
            _parent = parent;

            //Load Rewards
            LoadRewards(useBuild);

            //Load RNG
            RNG = new Random();
        }

        private void OnRagsToRichesClosed(object sender, EventArgs e)
        {
            _parent.Show();
        }

        private void Img_CreateRewardCard_Click(object sender, MouseButtonEventArgs e)
        {
            // Clear previous cards
            ResetLoot();

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
            //Select random type of reward.
            ERewardType type;
            if(SpellRewardList.Count > 0)
            {
                type = (ERewardType)(RNG.Next() % 5);
            }
            else
            {
                type = (ERewardType)(RNG.Next() % 4);
            }
            
            switch (type)
            {
                case ERewardType.RING:
                    //Create a list to hold all eligible rewards
                    List<DaS_Ring> rings = new List<DaS_Ring>();

                    //Select the reward that has the rarity and add it to a list
                    var ringsRarity = from r in RingRewardList where r.Rarity == rarity select r;
                    foreach (var r in ringsRarity)
                    {
                        rings.Add(r);
                    }
                    //Pick a random item from that list.
                    int i = (RNG.Next()) % rings.Count();

                    DaS_Ring ring = rings[i];
                    return new RewardCard(ring);

                case ERewardType.WEAPON:
                    //Create a list to hold all eligible rewards
                    List<DaS_Weapon> weapons = new List<DaS_Weapon>();

                    //Select the reward that has the rarity and add it to a list
                    var weaponsRarity = from w in WeaponRewardList where w.Rarity == rarity select w;
                    foreach (var w in weaponsRarity)
                    {
                        weapons.Add(w);
                    }
                    //Pick a random item from that list.
                    int j = (RNG.Next()) % weapons.Count();

                    DaS_Weapon weapon = weapons[j];
                    return new RewardCard(weapon);
                case ERewardType.ARMOUR:
                    //Create a list to hold all eligible rewards
                    List<DaS_Armour> armours = new List<DaS_Armour>();

                    //Select the reward that has the rarity and add it to a list
                    var armourRarity = from a in ArmourRewardList where a.Rarity == rarity select a;
                    foreach (var a in armourRarity)
                    {
                        armours.Add(a);
                    }
                    //Pick a random item from that list.
                    int k = (RNG.Next()) % armours.Count();

                    DaS_Armour armour = armours[k];
                    return new RewardCard(armour);
                case ERewardType.ITEM:
                    //Create a list to hold all eligible rewards
                    List<DaS_Item> items = new List<DaS_Item>();

                    //Select the reward that has the rarity and add it to a list
                    var itemsRarity = from it in ItemRewardList where it.Rarity == rarity select it;
                    foreach (var it in itemsRarity)
                    {
                        items.Add(it);
                    }
                    //Pick a random item from that list.
                    int l = (RNG.Next()) % items.Count();

                    DaS_Item item = items[l];
                    return new RewardCard(item);
                case ERewardType.SPELL:
                    //Create a list to hold all eligible rewards
                    List<DaS_Spell> spells = new List<DaS_Spell>();

                    //Select the reward that has the rarity and add it to a list
                    var spellsRarity = from s in SpellRewardList where s.Rarity == rarity select s;
                    foreach (var s in spellsRarity)
                    {
                        spells.Add(s);
                    }
                    //Pick a random item from that list.
                    int m = (RNG.Next()) % spells.Count();

                    DaS_Spell spell = spells[m];
                    return new RewardCard(spell);

                default:
                    //Create a list to hold all eligible rewards
                    List<DaS_Item> defaultItems = new List<DaS_Item>();

                    //Select the reward that has the rarity and add it to a list
                    var defaultItemsRarity = from it in ItemRewardList where it.Rarity == rarity select it;
                    foreach (var it in defaultItemsRarity)
                    {
                        defaultItems.Add(it);
                    }
                    //Pick a random item from that list.
                    int n = (RNG.Next()) % defaultItems.Count();

                    DaS_Item defaultItem = defaultItems[n];
                    return new RewardCard(defaultItem);
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

            //Roll dice and check result
            dice = RNG.NextDouble() * (chanceLimit + 1);

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

            grb_Curse.Content = null;
        }
        private void ResetLoot()
        {
            grb_Common.Content = null;
            grb_Uncommon.Content = null;
            grb_Rare.Content = null;
            grb_Legendary.Content = null;

            grb_Curse.Content = null;
        }

        private void Img_CreateCurseCard_Click(object sender, MouseButtonEventArgs e)
        {
            ResetLoot();

            //Roll for rarity of the draw.
            // Legendary = 10%
            // Rare = 25%
            // Uncommon = 60%
            // Common = 100%

            bool legendary = false;

            legendary = DiceRoll(10, 512);
            if(legendary)
            {
                grb_Curse.Content = DrawCurse(ERarity.Rarity.LEGENDARY);
                return;
            }

            bool rare = false;
            rare = DiceRoll(25, 512);
            if(rare)
            {
                grb_Curse.Content = DrawCurse(ERarity.Rarity.RARE);
                return;
            }

            bool uncommon = false;
            uncommon = DiceRoll(60, 512);
            if(uncommon)
            {
                grb_Curse.Content = DrawCurse(ERarity.Rarity.UNCOMMON);
                return;
            }

            grb_Curse.Content = DrawCurse(ERarity.Rarity.COMMON);

        }
        private CurseCard DrawCurse(ERarity.Rarity rarity)
        {
            //Create an empty Curse List
            List<DaS_Curse> curses = new List<DaS_Curse>();
            //Get a list of all curses meeting criteria
            var cursesRarity = from c in CurseList where c.Rarity == rarity select c;

            foreach(var c in cursesRarity)
            {
                curses.Add(c);
            }

            //Select a curse from the list
            int i = RNG.Next() % curses.Count;
            DaS_Curse curse = curses[i];

            return new CurseCard(curse);
        }
    }
}
