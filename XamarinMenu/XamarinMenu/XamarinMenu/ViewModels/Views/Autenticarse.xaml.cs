using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinMenu.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Autenticarse : ContentPage
    {
        public Autenticarse()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProveedoresPage());

        }
      
    }
}
