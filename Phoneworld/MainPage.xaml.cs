namespace Phoneworld
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnHello_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "Welcome to MAUI", "OK");
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            string username = entryUsername.Text;
            DisplayAlert("Welcome", $"Hello {username}", "OK");
        }
    }

}
