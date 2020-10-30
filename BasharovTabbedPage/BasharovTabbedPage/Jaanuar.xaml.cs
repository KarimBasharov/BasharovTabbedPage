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
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "3 января 1888 года Марвин Стоун запатентовал свое изобретение — соломинку — он получил в Вашингтонском патентном бюро документы на изобретение бумажной соломки для питья коктейлей и прочих жидкостей за № 375962. А уже в 1890 году их изготовление стало его основным бизнесом";
            
        }
        private void batn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Дата праздника", "3 января", "OK  ");
        }
    }
}