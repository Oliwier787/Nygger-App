namespace Nygger_App
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random r = new Random();

            int diceRoll = r.Next(1,  7);

            RollValueLabel.Text = "Wylosowany rzut " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
