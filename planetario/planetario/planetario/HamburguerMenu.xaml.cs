using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace planetario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HamburguerMenu : MasterDetailPage
    {
        public HamburguerMenu()
        {
            InitializeComponent();
            MyMenu();
        }
        public void MyMenu()
        {
            Detail = new NavigationPage(new MainPage());
            List<Menu> menu = new List<Menu>
            {
                new Menu{MenuTitle="Sala 1", MenuDetail ="Origen del Universo", icon="teoria.png"},
                new Menu{ MenuTitle="Sala 2", MenuDetail ="Meteoritos y Astrometricca", icon="meteoro.png"},
                new Menu{ MenuTitle="Sala 3", MenuDetail ="Extremofilos y formas de vida", icon="monstruo.png"},
                new Menu{ MenuTitle="Sala 4", MenuDetail ="Austriobiologica", icon="transbordador.png"},
                new Menu{ MenuTitle = "Sala 5", MenuDetail ="Exposicion Espacial", icon="shuttle.png"},
                new Menu{ MenuTitle = "Sala 6", MenuDetail ="Casa de la Tierra", icon="planeta.png"},

            };
            ListMenu.ItemsSource = menu;
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                if (menu.MenuTitle.Equals("Sala 1"))
                {
                    Detail = new NavigationPage(new MainPage());
                }
                else if (menu.MenuTitle.Equals("Sala 2"))
                {
                    Detail = new NavigationPage(new Feed());
                }
                else if (menu.MenuTitle.Equals("Sala 3"))
                {
                    Detail = new NavigationPage(new Sala3());
                }
                else if (menu.MenuTitle.Equals("Sala 4"))
                {
                    Detail = new NavigationPage(new Sala4());
                }
                else if (menu.MenuTitle.Equals("Sala 5"))
                {
                    Detail = new NavigationPage(new Sala5());
                }
                else if(menu.MenuTitle.Equals("Sala 6"))
                {
                    Detail = new NavigationPage(new Sala6());
                }
            }
        }
        public class Menu
        {
            public string MenuTitle
            {
                get;
                set;
            }
            public string MenuDetail
            {
                get;
                set;
            }
            public ImageSource icon
            {
                get;
                set;
            }
            public Page Page
            {
                get;
                set;

            }
        }


    }
}

  