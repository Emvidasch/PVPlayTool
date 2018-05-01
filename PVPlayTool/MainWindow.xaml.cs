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

namespace PVPlayTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;

            //Initialize DaS lists
            App.DaS_InitializeStartingClasses();

            App.DaS_LoadWeapons();
            App.DaS_LoadArmour();
            App.DaS_LoadRings();
            App.DaS_LoadSpells();
            App.DaS_LoadItems();
            App.DaS_LoadCurses();
        }

        private void btn_DarkSoulsClick(object sender, RoutedEventArgs e)
        {
            View.DarkSouls darkSouls = new View.DarkSouls();
            darkSouls.Show();
            this.Hide();
        }
    }
}
