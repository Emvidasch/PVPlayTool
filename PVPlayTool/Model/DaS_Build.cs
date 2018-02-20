using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVPlayTool.Model
{
    [Serializable]
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
}
