using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinMenu.MenuItems;
using XamarinMenu.Views;

namespace XamarinMenu
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> MenuList { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MenuList = new List<MasterPageItem>();


            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "Autenticarse", Icon = "itemIcon1.png", TargetType = typeof(Autenticarse) };
            var page2 = new MasterPageItem() { Title = "Acerca de", Icon = "itemIcon2.png", TargetType = typeof(AcerdaDe) };
            var page3 = new MasterPageItem() { Title = "Contacto", Icon = "itemIcon3.png", TargetType = typeof(Contacto) };
            var page4 = new MasterPageItem() { Title = "Salir", Icon = "itemIcon4.png", TargetType = typeof(Salir) };

            // Adding menu items to menuList
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);


            navigationDrawerList.ItemsSource = MenuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Autenticarse)));

        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
