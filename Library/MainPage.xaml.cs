using Library.ViewModel;

namespace Library
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainViewModel();
        }

       
    }
}