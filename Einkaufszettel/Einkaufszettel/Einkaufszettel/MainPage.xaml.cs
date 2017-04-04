using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Einkaufszettel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //listView.ItemsSource = App.Zettel;
            ((App)App.Current).ResumeAtEinkaufszettelId = -1;
            listView.ItemsSource = await App.Datenbank.GetItemsAsync();
        }

        private async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EinkaufszettelItemSeite
            {
                BindingContext = new EinkaufszettelItem()
            });
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((App)App.Current).ResumeAtEinkaufszettelId = (e.SelectedItem as EinkaufszettelItem).ID;

            await Navigation.PushAsync(new EinkaufszettelItemSeite
            {
                BindingContext = e.SelectedItem as EinkaufszettelItem
            });
        }
    }
}
