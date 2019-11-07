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
	public partial class Page3 : ContentPage
	{
        public Page3 (ObservableCollection<LabelViewModel> viewModel)
		{
            InitializeComponent();

            MyListView.ItemsSource = viewModel;
        }
	}
}