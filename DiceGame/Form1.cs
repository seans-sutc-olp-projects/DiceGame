namespace DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate(DiceTextBox1, 6);
        }
        private void generate(TextBox textBox, int Maxinum)
        {
            Random random = new Random();
            int num = random.Next(1, Maxinum) +1;
            textBox.Text = num.ToString();
        }
    }
}