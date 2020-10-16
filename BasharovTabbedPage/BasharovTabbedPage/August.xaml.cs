using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasharovTabbedPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class August : ContentPage
    {
        public August()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "установленная Указом Президента РФ №549 от 31 мая 2006 года «Об установлении профессиональных праздников и памятных дней в Вооруженных Силах Российской Федерации» как памятный день, призванный способствовать возрождению и развитию отечественных воинских традиций";
        }
    }
}