using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Notes.ViewModel;
using System.Collections.ObjectModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Notes
{
    public partial class App : Application
    {
        public ObservableCollection<LabelViewModel> LabelVievModelCollection = new ObservableCollection<LabelViewModel>();
        public App()
        {
            InitializeComponent();
           

            MainPage = new NavigationPage(new MainPage(LabelVievModelCollection));
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
