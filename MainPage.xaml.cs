using CartaoVisitaDigitalMAUI.Models;

namespace CartaoVisitaDigitalMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Pessoa();
        }

        private async void WhatsappBtn_Clicked(object sender, EventArgs e)
        {
            if (BindingContext is Models.Pessoa pessoa)
                await Launcher.Default.OpenAsync(pessoa.WhatsApp);
        }

        private async void YoutubeBtn_Clicked(object sender, EventArgs e)
        {
            if (BindingContext is Pessoa pessoa)
                await Launcher.Default.OpenAsync(pessoa.YouTube);
        }

        private async void InstagramBtn_Clicked(object sender, EventArgs e)
        {
            if (BindingContext is Pessoa pessoa)
                await Launcher.Default.OpenAsync(pessoa.Instagram);
        }
    }

}
