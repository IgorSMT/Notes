using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
	{
        public ObservableCollection<LabelViewModel> LabelVievModelCollection;

        public Page2 (ObservableCollection<LabelViewModel> item )
		{
			InitializeComponent ();
            LabelVievModelCollection = item;
		}

        private async void OnSaveTitleButtonCliked(object sender, EventArgs e)
        {
            var title_data = new LabelViewModel
            {
                Label = editor.Text,
                Date = DateTime.Now
            };

            LabelVievModelCollection.Add(title_data);
            var mainpage = new MainPage(LabelVievModelCollection);
            mainpage.BindingContext = title_data;
            await Navigation.PushModalAsync(mainpage);
        }

    }
}