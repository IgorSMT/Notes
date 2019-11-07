using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.ViewModel;
using Xamarin.Forms;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<LabelViewModel> LabelVievModelCollection;

        public MainPage(ObservableCollection<LabelViewModel> viewModel)
        {
            InitializeComponent();
            this.LabelVievModelCollection = viewModel;
        }

        private async void OnPage2ButtonCliked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page2(LabelVievModelCollection));
        }

        private async void OnPage3ButtonCliked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3(LabelVievModelCollection));
        }
    }
}
