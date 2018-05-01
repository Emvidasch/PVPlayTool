using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PVPlayTool.Model;
using System.Xml.Linq;




namespace PVPlayTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Dark Souls I
        //Variables
        public static DaS_Build DaS_CurrentBuild;

        public static List<DaS_StartingClass> DaS_StartingClasses;

        public static List<DaS_Weapon> DaS_WeaponList;
        public static List<DaS_Armour> DaS_ArmourList;
        public static List<DaS_Ring> DaS_RingList;
        public static List<DaS_Spell> DaS_SpellList;
        public static List<DaS_Item> DaS_ItemList;
        public static List<DaS_Curse> DaS_CurseList;

        //Methods
        public static void DaS_InitializeStartingClasses()
        {
            //Create List
            DaS_StartingClasses = new List<DaS_StartingClass>();
            //Warrior
            DaS_StartingClass Warrior = new DaS_StartingClass("Warrior");
            DaS_StartingClasses.Add(Warrior);

            //Knight
            DaS_StartingClass Knight = new DaS_StartingClass("Knight");
            DaS_StartingClasses.Add(Knight);

            //Wanderer
            DaS_StartingClass Wanderer = new DaS_StartingClass("Wanderer");
            DaS_StartingClasses.Add(Wanderer);

            //Thief
            DaS_StartingClass Thief = new DaS_StartingClass("Thief");
            DaS_StartingClasses.Add(Thief);

            //Bandit
            DaS_StartingClass Bandit = new DaS_StartingClass("Bandit");
            DaS_StartingClasses.Add(Bandit);

            //Hunter
            DaS_StartingClass Hunter = new DaS_StartingClass("Hunter");
            DaS_StartingClasses.Add(Hunter);

            //Sorcerer
            DaS_StartingClass Sorcerer = new DaS_StartingClass("Sorcerer");
            DaS_StartingClasses.Add(Sorcerer);

            //Pyromancer
            DaS_StartingClass Pyromancer = new DaS_StartingClass("Pyromancer");
            DaS_StartingClasses.Add(Pyromancer);

            //Cleric
            DaS_StartingClass Cleric = new DaS_StartingClass("Cleric");
            DaS_StartingClasses.Add(Cleric);

            //Deprived
            DaS_StartingClass Deprived = new DaS_StartingClass("Deprived");
            DaS_StartingClasses.Add(Deprived);
        }
        public static void DaS_LoadWeapons()
        {
            //Init list
            DaS_WeaponList = new List<DaS_Weapon>();

            //Load XML
            var weapons = XElement.Load(@"..\..\Data\DarkSouls\DaS_Weapons.xml");

            //Read XML and add to list.
            foreach(var weapon in weapons.Elements("Weapon"))
            {
                DaS_Weapon w = new DaS_Weapon();
                w.WeaponName = weapon.Element("EquipmentName").Value;
                w.ImagePath = weapon.Element("ImagePath").Value;
                w.StrReq = Int32.Parse(weapon.Element("StrReq").Value);
                w.DexReq = Int32.Parse(weapon.Element("DexReq").Value);
                w.IntReq = Int32.Parse(weapon.Element("IntReq").Value);
                w.FthReq = Int32.Parse(weapon.Element("FthReq").Value);
                w.Rarity = (ERarity.Rarity)Int32.Parse(weapon.Element("Rarity").Value);
                DaS_WeaponList.Add(w);
            }
        }
        public static void DaS_LoadArmour()
        {
            //Init list
            DaS_ArmourList = new List<DaS_Armour>();

            //Load XML
            var armours = XElement.Load(@"..\..\Data\DarkSouls\DaS_Armour.xml");

            //Read XML and add to list.
            foreach (var armour in armours.Elements("Armour"))
            {
                DaS_Armour a = new DaS_Armour();
                a.ArmourName = armour.Element("EquipmentName").Value;
                a.ImagePath = armour.Element("ImagePath").Value;
                a.Rarity = (ERarity.Rarity)Int32.Parse(armour.Element("Rarity").Value);

                DaS_ArmourList.Add(a);
            }
        }
        public static void DaS_LoadRings()
        {
            //init list
            DaS_RingList = new List<DaS_Ring>();

            //Load XML
            var rings = XElement.Load(@"..\..\Data\DarkSouls\DaS_Rings.xml");

            //Read XML and add to list.
            foreach(var ring in rings.Elements("Ring"))
            {
                DaS_Ring r = new DaS_Ring();
                r.RingName = ring.Element("EquipmentName").Value;
                r.ImagePath = ring.Element("ImagePath").Value;
                r.Rarity = (ERarity.Rarity)Int32.Parse(ring.Element("Rarity").Value);

                DaS_RingList.Add(r);
            }
        }
        public static void DaS_LoadSpells()
        {
            //Init list
            DaS_SpellList = new List<DaS_Spell>();

            //Load XML
            var spells = XElement.Load(@"..\..\Data\DarkSouls\DaS_Spells.xml");

            //Read XML and add to list.
            foreach (var spell in spells.Elements("Spell"))
            {
                DaS_Spell s = new DaS_Spell();
                s.SpellName = spell.Element("SpellName").Value;
                s.ImagePath = spell.Element("ImagePath").Value;
                s.AttReq = Int32.Parse(spell.Element("AttReq").Value);
                s.IntReq = Int32.Parse(spell.Element("IntReq").Value);
                s.FthReq = Int32.Parse(spell.Element("FthReq").Value);
                s.Rarity = (ERarity.Rarity)Int32.Parse(spell.Element("Rarity").Value);

                DaS_SpellList.Add(s);
            }
        }
        public static void DaS_LoadItems()
        {
            //Init list
            DaS_ItemList = new List<DaS_Item>();

            //Load XML
            var items = XElement.Load(@"..\..\Data\DarkSouls\DaS_Items.xml");

            //Read XML and add to list.
            foreach(var item in items.Elements("Item"))
            {
                DaS_Item i = new DaS_Item();

                i.ItemName = item.Element("ItemName").Value;
                i.Quantity = Int32.Parse(item.Element("Quantity").Value);
                i.Rarity = (ERarity.Rarity)Int32.Parse(item.Element("Rarity").Value);
                i.ImagePath = item.Element("ImagePath").Value;

                DaS_ItemList.Add(i);
            }
        }
        public static void DaS_LoadCurses()
        {
            //Init list
            DaS_CurseList = new List<DaS_Curse>();

            //Load XML
            var curses = XElement.Load(@"..\..\Data\DarkSouls\DaS_Curses.xml");

            //Read XML and add to list.
            foreach (var curse in curses.Elements("Curse"))
            {
                DaS_Curse c = new DaS_Curse();

                c.CurseName = curse.Element("CurseName").Value;
                c.Description = curse.Element("Description").Value;
                c.Rarity = (ERarity.Rarity)Int32.Parse(curse.Element("Rarity").Value);

                DaS_CurseList.Add(c);
            }
        }

        //Dark Souls II
        //Variables
        //Methods

        //Dark Souls III
        //Variables
        //Methods
    }
}
