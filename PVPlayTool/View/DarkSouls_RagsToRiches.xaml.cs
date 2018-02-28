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
using PVPlayTool.Model;

namespace PVPlayTool.View
{
    /// <summary>
    /// Interaction logic for DarkSouls_RagsToRiches.xaml
    /// </summary>
    public partial class DarkSouls_RagsToRiches : Window
    {
        public DaS_Item TestItem;
        private DarkSouls_RagsToRiches_Intro _parent;
        public DarkSouls_RagsToRiches(DarkSouls_RagsToRiches_Intro parent)
        {
            InitializeComponent();
            _parent = parent;
            TestItem = new DaS_Item();
            TestItem.ItemName = "Humanity";
            TestItem.Quantity = 5;
            TestItem.Rarity = ERarity.Rarity.LEGENDARY;
            TestItem.ImagePath = "tex_DaS_Humanity.png";
        }

        private void Btn_CreateRewardCard_Click(object sender, RoutedEventArgs e)
        {
            if(TestItem != null)
            {
                RewardCard card = new RewardCard(TestItem);
                Grd_MainGrid.Children.Add(card);
            }
        }

        private void OnRagsToRichesClosed(object sender, EventArgs e)
        {
            _parent.Show();
        }
    }
}
