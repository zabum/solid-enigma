using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Einkaufszettel
{
    public partial class App : Application
    {
        static EinkaufszettelItemDB datenbank;
        public static EinkaufszettelItemDB Datenbank
        {
            get
            {
                if (datenbank == null)
                {
                    datenbank = new EinkaufszettelItemDB(DependencyService.Get<IFileHelper>().GetLocalFilePath("EinkaufszettelSQLite.db3"));
                }
                return datenbank;
            }
        }
        
        public int ResumeAtEinkaufszettelId { get; set; }

        public App()
        {
            Resources = new ResourceDictionary();
            Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new MainPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;
            MainPage = nav;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
