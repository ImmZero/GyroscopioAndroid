namespace Gyroscopio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void bt1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagAcel());
        }
    }
}