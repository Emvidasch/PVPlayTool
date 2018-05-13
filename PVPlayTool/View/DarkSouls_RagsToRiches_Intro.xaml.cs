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

namespace PVPlayTool.View
{
    /// <summary>
    /// Interaction logic for DarkSouls_RagsToRiches.xaml
    /// </summary>
    public partial class DarkSouls_RagsToRiches_Intro : Window
    {
        private DarkSouls _parent;
        public DarkSouls_RagsToRiches_Intro(DarkSouls parent)
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            _parent = parent;
        }

        private void Btn_StartRagsToRiches_Click(object sender, RoutedEventArgs e)
        {
            if((bool)ckb_UseBuild.IsChecked && App.DaS_CurrentBuild == null)
            {
                //Trying to use a build when none is set.
                MessageBox.Show("No build has been set. Please return to the Dark Souls build editor to create or load a build to use.");
            }
            else
            {
                DarkSouls_RagsToRiches r2r = new DarkSouls_RagsToRiches(this, (bool)ckb_UseBuild.IsChecked);
                r2r.WindowState = WindowState.Maximized;
                r2r.Show();
                this.Hide();
            }

        }

        private void OnRagsToRichesIntroClose(object sender, EventArgs e)
        {
            _parent.Show();
        }

        private void Btn_Help_Click(object sender, RoutedEventArgs e)
        {
            DarkSouls_RagsToRiches_Help help = new DarkSouls_RagsToRiches_Help();
            help.Show();
        }
    }
}
