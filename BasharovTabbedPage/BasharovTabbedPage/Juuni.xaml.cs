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
    public partial class Juuni : ContentPage
    {
        public Juuni()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Решение о праздновании было принято в 2010 году. Государства-члены Международной морской организации, ИМО (англ. International Maritime Organization, IMO), входящие в ООН, подписали на конференции в Маниле резолюцию №19, послужившую основанием учреждения этой международной даты.";
        }
        private void batn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Дата праздника", "25 июня", "OK  ");
        }
    }
}