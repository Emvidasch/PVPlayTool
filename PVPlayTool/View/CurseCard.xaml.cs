using PVPlayTool.Model;
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

namespace PVPlayTool.View
{
    /// <summary>
    /// Interaction logic for Shared_CommonCard.xaml
    /// </summary>
    public partial class CurseCard : UserControl
    {
        public string CurseName { get; set; }
        public string CurseDescription { get; set; }
        public string CurseImagePath { get; set; }
        public string CurseCardFront { get; set; }
        public string CurseCardBack { get; set; }

        private string _baseImagePath = "/PVPlayTool;component/Assets/";

        public CurseCard()
        {
            InitializeComponent();
        }
        public CurseCard(DaS_Curse curse)
        {
            CurseName = curse.CurseName;
            CurseDescription = curse.Description;

            CurseImagePath = _baseImagePath + "Shared/tex_Curse.png";
            CurseCardFront = _baseImagePath + "Shared/tex_CardFront_Curse.png";
            CurseCardBack = _baseImagePath + "Shared/tex_CardBack_Curse.png";

            InitializeComponent();
        }
        public void CreateImages()
        {
            Img_CardBack.Source = new BitmapImage(new Uri(CurseCardBack));
            Img_CardFront.Source = new BitmapImage(new Uri(CurseCardFront));
            Img_CardImage.Source = new BitmapImage(new Uri(CurseImagePath));
        }
    }
}
