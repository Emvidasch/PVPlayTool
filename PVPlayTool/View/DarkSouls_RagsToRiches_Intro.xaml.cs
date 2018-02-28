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
            DarkSouls_RagsToRiches r2r = new DarkSouls_RagsToRiches(this);
            r2r.WindowState = WindowState.Maximized;
            r2r.Show();
            this.Hide();
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
