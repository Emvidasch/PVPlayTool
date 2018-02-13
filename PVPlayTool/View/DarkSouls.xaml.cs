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
    }
}
