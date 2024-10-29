using BMIPokemon.ViewModels;

namespace BMIPokemon
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new BMIViewModel();
        }
    }

}
