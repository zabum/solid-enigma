using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Einkaufszettel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EinkaufszettelItemSeite : ContentPage
	{
		public EinkaufszettelItemSeite ()
		{
			InitializeComponent ();
		}

        private async void OnSpeichernClicked(object sender, EventArgs e)
        {
            var item = (EinkaufszettelItem)BindingContext;
            await App.Datenbank.SaveItemAsync(item);
            await Navigation.PopAsync();
        }

        private async void OnLöschenClicked(object sender, EventArgs e)
        {
            var item = (EinkaufszettelItem)BindingContext;
            await App.Datenbank.DeleteItemAsync(item);
            await Navigation.PopAsync();
        }

        private async  void OnAbbrechenClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void OnSprechenClicked(object sender, EventArgs e)
        {
            var item = (EinkaufszettelItem)BindingContext;
            DependencyService.Get<ITextToSpeech>().Speak(item.Name);
        }
    }
}
