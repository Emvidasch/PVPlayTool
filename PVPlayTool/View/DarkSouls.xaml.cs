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
    /// Interaction logic for DarkSouls.xaml
    /// </summary>
    public partial class DarkSouls : Window
    {
        public bool EditorOpen = false;
        public DarkSouls()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
        }

        private void OnDarkSoulsClose(object sender, EventArgs e)
        {
            App.Current.MainWindow.Show();
        }

        private void btn_BuildEditor_Click(object sender, RoutedEventArgs e)
        {
            if(!EditorOpen)
            {
                DarkSouls_BuildEditor editor = new DarkSouls_BuildEditor(this);
                EditorOpen = true;
                editor.Show();
            }
        }

        private void btn_RagsToRiches_Click(object sender, RoutedEventArgs e)
        {
            if(!EditorOpen)
            {
                DarkSouls_RagsToRiches_Intro intro = new DarkSouls_RagsToRiches_Intro(this);
                intro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please close the Build Editor before proceeding.");
            }
        }
    }
}
