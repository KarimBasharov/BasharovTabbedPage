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
    public partial class Veebruar : ContentPage
    {
        public Veebruar()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Именно дата 24 февраля 1918 года, когда Комитетом Спасения была провозглашена независимость страны, и считается сегодня датой образования Эстонской республики.";
        }
    }
}