namespace DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void generate(TextBox textBox, int Maxinum)
        {
            Random random = new Random();
            int num = (random.Next(1, Maxinum) + 1);
            textBox.Text = num.ToString();
        }
        private void DiceButton2_Click(object sender, EventArgs e)
        {
            // 10 Dice
            generate(DicetextBox2, 10);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 6 Dice
            generate(DiceTextBox1, 6);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Dice2Box_Enter(object sender, EventArgs e)
        {

        }

        private void DicetextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}