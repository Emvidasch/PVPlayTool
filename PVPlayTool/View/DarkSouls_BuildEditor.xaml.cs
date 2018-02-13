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
using System.Text.RegularExpressions;
namespace PVPlayTool.View
{
    /// <summary>
    /// Interaction logic for DarkSouls_BuildEditor.xaml
    /// </summary>
    public partial class DarkSouls_BuildEditor : Window
    {
        //Variables
        public DaS_StartingClass SelectedStartingClass;
        private int _vitalityPoints = 0;
        private int _attunementPoints = 0;
        private int _endurancePoints = 0;
        private int _strengthPoints = 0;
        private int _dexterityPoints = 0;
        private int _resistancePoints = 0;
        private int _intelligencePoints = 0;
        private int _faithPoints = 0;

        private DarkSouls _parent;

        //Methods

        //Constructor
        public DarkSouls_BuildEditor(DarkSouls parent)
        {
            //Initialize
            InitializeComponent();

            //Save parent window for opening/closing
            _parent = parent;

            //Load Current build
            LoadCurrentBuild();
        }

        //Load current build if one exists in App
        private void LoadCurrentBuild()
        {
            if(App.DaS_CurrentBuild != null)
            {
                SelectedStartingClass = App.DaS_CurrentBuild.StartingClass;
            }
        }
        //DropDownMenu
        private void Cbx_StartingClass_DropDownClosed(object sender, EventArgs e)
        {
            switch (Cbx_StartingClass.Text)
            {
                case "Warrior":
                    SelectedStartingClass = new DaS_StartingClass("Warrior");
                    break;
                case "Knight":
                    SelectedStartingClass = new DaS_StartingClass("Knight");
                    break;
                case "Wanderer":
                    SelectedStartingClass = new DaS_StartingClass("Wanderer");
                    break;
                case "Thief":
                    SelectedStartingClass = new DaS_StartingClass("Thief");
                    break;
                case "Bandit":
                    SelectedStartingClass = new DaS_StartingClass("Bandit");
                    break;
                case "Hunter":
                    SelectedStartingClass = new DaS_StartingClass("Hunter");
                    break;
                case "Sorcerer":
                    SelectedStartingClass = new DaS_StartingClass("Sorcerer");
                    break;
                case "Pyromancer":
                    SelectedStartingClass = new DaS_StartingClass("Pyromancer");
                    break;
                case "Cleric":
                    SelectedStartingClass = new DaS_StartingClass("Cleric");
                    break;
                case "Deprived":
                    SelectedStartingClass = new DaS_StartingClass("Deprived");
                    break;
                default:
                    break;
            }
            UpdateBaseStats();
            UpdateStats();
            UpdateSoulLevel();
        }

        //Update
        private void UpdateBaseStats()
        {
            Txb_StartingSoulLevel.Text = SelectedStartingClass.StartingLevel.ToString();
            Txb_StartingVitality.Text = SelectedStartingClass.Vitality.ToString();
            Txb_StartingAttunement.Text = SelectedStartingClass.Attunement.ToString();
            Txb_StartingEndurance.Text = SelectedStartingClass.Endurance.ToString();
            Txb_StartingStrength.Text = SelectedStartingClass.Strength.ToString();
            Txb_StartingDexterity.Text = SelectedStartingClass.Dexterity.ToString();
            Txb_StartingResistance.Text = SelectedStartingClass.Resistance.ToString();
            Txb_StartingIntelligence.Text = SelectedStartingClass.Intelligence.ToString();
            Txb_StartingFaith.Text = SelectedStartingClass.Faith.ToString();
        }
        private void UpdateSoulLevel()
        {
            int totalSoulLevel = SelectedStartingClass.StartingLevel + _vitalityPoints + _attunementPoints + _endurancePoints + _strengthPoints + 
                _dexterityPoints + _resistancePoints + _intelligencePoints + _faithPoints;

            Txb_CurrentSoulLevel.Text = totalSoulLevel.ToString();

        }
        private void UpdateStats()
        {
            Txb_CurrentVitality.Text = (SelectedStartingClass.Vitality + _vitalityPoints).ToString();
            Txb_CurrentAttunement.Text = (SelectedStartingClass.Attunement + _attunementPoints).ToString();
            Txb_CurrentEndurance.Text = (SelectedStartingClass.Endurance + _endurancePoints).ToString();
            Txb_CurrentStrength.Text = (SelectedStartingClass.Strength + _strengthPoints).ToString();
            Txb_CurrentDexterity.Text = (SelectedStartingClass.Dexterity + _dexterityPoints).ToString();
            Txb_CurrentResistance.Text = (SelectedStartingClass.Resistance + _resistancePoints).ToString();
            Txb_CurrentIntelligence.Text = (SelectedStartingClass.Intelligence + _intelligencePoints).ToString();
            Txb_CurrentFaith.Text = (SelectedStartingClass.Faith + _faithPoints).ToString();

            UpdateSoulLevel();
        }

        //Buttons
        private void Btn_IncreaseStat_Click(object sender, RoutedEventArgs e)
        {
            if (sender == Btn_UpVit)
            {
                IncreaseStat(ref _vitalityPoints);
            }
            if (sender == Btn_UpAtt)
            {
                IncreaseStat(ref _attunementPoints);
            }
            if (sender == Btn_UpEnd)
            {
                IncreaseStat(ref _endurancePoints);
            }
            if (sender == Btn_UpStr)
            {
                IncreaseStat(ref _strengthPoints);
            }
            if(sender == Btn_UpDex)
            {
                IncreaseStat(ref _dexterityPoints);
            }
            if(sender == Btn_UpRes)
            {
                IncreaseStat(ref _resistancePoints);
            }
            if(sender == Btn_UpInt)
            {
                IncreaseStat(ref _intelligencePoints);
            }
            if(sender == Btn_UpFth)
            {
                IncreaseStat(ref _faithPoints);
            }
        }
        private void Btn_DecreaseStat_Click(object sender, RoutedEventArgs e)
        {
            if (sender == Btn_DownVit)
            {
                DecreaseStat(ref _vitalityPoints);
            }
            if (sender == Btn_DownAtt)
            {
                DecreaseStat(ref _attunementPoints);
            }
            if (sender == Btn_DownEnd)
            {
                DecreaseStat(ref _endurancePoints);
            }
            if (sender == Btn_DownStr)
            {
                DecreaseStat(ref _strengthPoints);
            }
            if (sender == Btn_DownDex)
            {
                DecreaseStat(ref _dexterityPoints);
            }
            if (sender == Btn_DownRes)
            {
                DecreaseStat(ref _resistancePoints);
            }
            if (sender == Btn_DownInt)
            {
                DecreaseStat(ref _intelligencePoints);
            }
            if (sender == Btn_DownFth)
            {
                DecreaseStat(ref _faithPoints);
            }
        }

        // In/Decrement
        private void IncreaseStat(ref int stat)
        {
            if(stat < 99)
            {
                ++stat;
                UpdateStats();
                UpdateSoulLevel();
            }
        }
        private void DecreaseStat(ref int stat)
        {
            if(stat > 0)
            {
                --stat;
                UpdateStats();
                UpdateSoulLevel();
            }
        }

        //Allow only numeric values
        private static bool IsTextAllowed(string text)
        {
            Regex reg = new Regex("[^0-9]");
            return !reg.IsMatch(text);
        }

        //Check if textbox receives numerical input
        private void Txb_NumericalOnly_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        //Commit text in textbox
        private void Txb_Commit(object sender, RoutedEventArgs e)
        {
            if (_isInitialized && SelectedStartingClass != null)
            {
                if (sender == Txb_CurrentVitality)
                {
                    int x = 0;
                    if(Int32.TryParse(Txb_CurrentVitality.Text, out x))
                    {
                        if(x > 99)
                        {
                            x = 99;
                        }
                        else if(x < SelectedStartingClass.Vitality)
                        {
                            x = SelectedStartingClass.Vitality;
                        }

                        _vitalityPoints = x - SelectedStartingClass.Vitality;
                        UpdateSoulLevel();
                        UpdateStats();
                    }
                }
                else if (sender == Txb_CurrentAttunement)
                {
                    int x = 0;
                    if (Int32.TryParse(Txb_CurrentAttunement.Text, out x))
                    {
                        if (x > 99)
                        {
                            x = 99;
                        }
                        else if (x < SelectedStartingClass.Attunement)
                        {
                            x = SelectedStartingClass.Attunement;
                        }

                        _attunementPoints = x - SelectedStartingClass.Attunement;
                        UpdateSoulLevel();
                        UpdateStats();
                    }
                }
                else if (sender == Txb_CurrentEndurance)
                {
                    int x = 0;
                    if (Int32.TryParse(Txb_CurrentEndurance.Text, out x))
                    {
                        if (x > 99)
                        {
                            x = 99;
                        }
                        else if (x < SelectedStartingClass.Endurance)
                        {
                            x = SelectedStartingClass.Endurance;
                        }

                        _endurancePoints = x - SelectedStartingClass.Endurance;
                        UpdateSoulLevel();
                        UpdateStats();
                    }
                }
                else if (sender == Txb_CurrentStrength)
                {
                    int x = 0;
                    if (Int32.TryParse(Txb_CurrentStrength.Text, out x))
                    {
                        if (x > 99)
                        {
                            x = 99;
                        }
                        else if (x < SelectedStartingClass.Strength)
                        {
                            x = SelectedStartingClass.Strength;
                        }

                        _strengthPoints = x - SelectedStartingClass.Strength;
                        UpdateSoulLevel();
                        UpdateStats();
                    }
                }
                else if (sender == Txb_CurrentDexterity)
                {
                    int x = 0;
                    if (Int32.TryParse(Txb_CurrentDexterity.Text, out x))
                    {
                        if (x > 99)
                        {
                            x = 99;
                        }
                        else if (x < SelectedStartingClass.Dexterity)
                        {
                            x = SelectedStartingClass.Dexterity;
                        }

                        _dexterityPoints = x - SelectedStartingClass.Dexterity;
                        UpdateSoulLevel();
                        UpdateStats();
                    }
                }
                else if (sender == Txb_CurrentResistance)
                {
                    int x = 0;
                    if (Int32.TryParse(Txb_CurrentResistance.Text, out x))
                    {
                        if (x > 99)
                        {
                            x = 99;
                        }
                        else if (x < SelectedStartingClass.Resistance)
                        {
                            x = SelectedStartingClass.Resistance;
                        }

                        _resistancePoints = x - SelectedStartingClass.Resistance;
                        UpdateSoulLevel();
                        UpdateStats();
                    }
                }
                else if (sender == Txb_CurrentIntelligence)
                {
                    int x = 0;
                    if (Int32.TryParse(Txb_CurrentIntelligence.Text, out x))
                    {
                        if (x > 99)
                        {
                            x = 99;
                        }
                        else if (x < SelectedStartingClass.Intelligence)
                        {
                            x = SelectedStartingClass.Intelligence;
                        }

                        _intelligencePoints = x - SelectedStartingClass.Intelligence;
                        UpdateSoulLevel();
                        UpdateStats();
                    }
                }
                else if (sender == Txb_CurrentFaith)
                {
                    int x = 0;
                    if (Int32.TryParse(Txb_CurrentFaith.Text, out x))
                    {
                        if (x > 99)
                        {
                            x = 99;
                        }
                        else if (x < SelectedStartingClass.Faith)
                        {
                            x = SelectedStartingClass.Faith;
                        }

                        _faithPoints = x - SelectedStartingClass.Faith;
                        UpdateSoulLevel();
                        UpdateStats();
                    }
                }
            }
        }

        //Commit text on ENTER when texbox is in focus
        private void Txb_Commit_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Txb_Commit(sender, e);
            }
        }

        // Save build when editor closes
        private void Editor_Closed(object sender, EventArgs e)
        {
            if(SelectedStartingClass != null)
            {
                int vit = SelectedStartingClass.Vitality + _vitalityPoints;
                int att = SelectedStartingClass.Attunement + _attunementPoints;
                int end = SelectedStartingClass.Endurance + _endurancePoints;
                int str = SelectedStartingClass.Strength + _strengthPoints;
                int dex = SelectedStartingClass.Dexterity + _dexterityPoints;
                int res = SelectedStartingClass.Resistance + _resistancePoints;
                int intl = SelectedStartingClass.Intelligence + _intelligencePoints;
                int fth = SelectedStartingClass.Faith + _faithPoints;

                App.DaS_CurrentBuild = new DaS_Build(SelectedStartingClass, vit, att, end, str, dex, res, intl, fth);
            }
            _parent.EditorOpen = false;

        }
    }
}
