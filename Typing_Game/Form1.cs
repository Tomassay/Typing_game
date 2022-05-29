namespace Typing_Game
{
    public partial class Form1 : Form
    {
        String[] words = { "horse", "cat", "dog", "monkey", "tiger", "panda", "lion", "zebra" };
        int num = 0;
        int wordl;
        int errors = 0;
        public Form1()
        {

            InitializeComponent();
            txt.Text = words[0];
            label2.Text = "" + words.Length;
            wordl = words.Length;
            errorsLabel.Text = "" + errors;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playGame(object sender, EventArgs e)
        {
            if(txt.Text == textBox1.Text)
            {
                win();
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void win()
        {
            if (num < wordl - 1)
            {
                num++;
                txt.Text = words[num];
                textBox1.Text = "";
            }
            else
            {
                num = 0;
                txt.Text = words[num];
                textBox1.Text = "";
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}