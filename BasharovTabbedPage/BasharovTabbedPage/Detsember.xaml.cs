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
    public partial class Detsember : ContentPage
    {
        public Detsember()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Впервые День борьбы со СПИДом отмечался 1 декабря 1988 года после того, как на встрече министров здравоохранения всех стран прозвучал призыв к социальной терпимости и расширению обмена информацией по ВИЧ/СПИДу.";
        }
        private void batn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Дата праздника", "1 декабря", "OK  ");
        }
    }
}