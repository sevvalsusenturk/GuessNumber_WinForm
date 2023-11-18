namespace GuessingsNumbersGame
{
    public partial class Form1 : Form
    {
        private int _CreatedNumber = 0;
        private int _TryCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int.TryParse(txtGuessNumber1.Text, out int number1);
            int.TryParse(txtGuessNumber2.Text, out int number2);

            _CreatedNumber = randomNumber.Next(number1, number2);

            // lblCreatedNumber.Text = _CreatedNumber.ToString();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            _TryCount = _TryCount + 1;
            lblTryNumber.Text = _TryCount.ToString();

            int.TryParse(txtGuess.Text, out int guessNumber);

            if (guessNumber == _CreatedNumber)
            {
                lblResult.Text = "Tebrikler! Doðru Tahmin";
            }
            else
            {
                lblResult.Text = "Maalesef Yanlýþ Tahmin";
            }
        }
    }
}