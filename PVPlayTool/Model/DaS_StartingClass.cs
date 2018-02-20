using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVPlayTool.Model
{
    [Serializable]
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
}
