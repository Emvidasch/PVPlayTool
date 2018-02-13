using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

public class DaS_Build
{
    //Constructors
    public DaS_Build()
    {

    }
    public DaS_Build(DaS_StartingClass startClass, int vit, int att, int end, int str, int dex, int res, int intl, int fth)
    {
        StartingClass = startClass;
        Vitality = vit;
        Attunement = att;
        Endurance = end;
        Strength = str;
        Dexterity = dex;
        Resistance = res;
        Intelligence = intl;
        Faith = fth;
    }
    //Parameters
    public DaS_StartingClass StartingClass;
    public int Vitality;
    public int Attunement;
    public int Endurance;
    public int Strength;
    public int Dexterity;
    public int Resistance;
    public int Intelligence;
    public int Faith;
}
public class DaS_StartingClass
{
    //Constructor
    public DaS_StartingClass(string name)
    {
        //Initlize Parameters
        Name = name;

        switch (name)
        {
            case "Warrior":
                StartingLevel = 4;
                Vitality = 11;
                Attunement = 8;
                Endurance = 12;
                Strength = 13;
                Dexterity = 13;
                Resistance = 11;
                Intelligence = 9;
                Faith = 9;
                break;
            case "Knight":
                StartingLevel = 5;
                Vitality = 14;
                Attunement = 10;
                Endurance = 10;
                Strength = 11;
                Dexterity = 11;
                Resistance = 10;
                Intelligence = 9;
                Faith = 11;
                break;
            case "Wanderer":
                StartingLevel = 3;
                Vitality = 10;
                Attunement = 11;
                Endurance = 10;
                Strength = 10;
                Dexterity = 14;
                Resistance = 12;
                Intelligence = 11;
                Faith = 8;
                break;
            case "Thief":
                StartingLevel = 5;
                Vitality = 9;
                Attunement = 11;
                Endurance = 9;
                Strength = 9;
                Dexterity = 15;
                Resistance = 10;
                Intelligence = 12;
                Faith = 11;
                break;
            case "Bandit":
                StartingLevel = 4;
                Vitality = 12;
                Attunement = 8;
                Endurance = 14;
                Strength = 14;
                Dexterity = 9;
                Resistance = 11;
                Intelligence = 8;
                Faith = 10;
                break;
            case "Hunter":
                StartingLevel = 4;
                Vitality = 11;
                Attunement = 9;
                Endurance = 11;
                Strength = 12;
                Dexterity = 14;
                Resistance = 11;
                Intelligence = 9;
                Faith = 9;
                break;
            case "Sorcerer":
                StartingLevel = 3;
                Vitality = 8;
                Attunement = 15;
                Endurance = 8;
                Strength = 9;
                Dexterity = 11;
                Resistance = 8;
                Intelligence = 15;
                Faith = 8;
                break;
            case "Pyromancer":
                StartingLevel = 1;
                Vitality = 10;
                Attunement = 12;
                Endurance = 11;
                Strength = 12;
                Dexterity = 9;
                Resistance = 12;
                Intelligence = 10;
                Faith = 8;
                break;
            case "Cleric":
                StartingLevel = 2;
                Vitality = 11;
                Attunement = 11;
                Endurance = 9;
                Strength = 12;
                Dexterity = 8;
                Resistance = 11;
                Intelligence = 8;
                Faith = 14;
                break;
            case "Deprived":
                StartingLevel = 6;
                Vitality = 11;
                Attunement = 11;
                Endurance = 11;
                Strength = 11;
                Dexterity = 11;
                Resistance = 11;
                Intelligence = 11;
                Faith = 11;
                break;

        }
    }
    //Starting Name and Level
    public string Name;
    public int StartingLevel;

    //Stat Parameters

    public int Vitality;
    public int Attunement;
    public int Endurance;
    public int Strength;
    public int Dexterity;
    public int Resistance;
    public int Intelligence;
    public int Faith;
}

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

        //Dark Souls II
        //Variables
        //Methods

        //Dark Souls III
        //Variables
        //Methods
    }
}
