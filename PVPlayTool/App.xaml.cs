using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PVPlayTool.Model;




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
