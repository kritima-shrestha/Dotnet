namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.KeyPress += textBox1_keyPress;
            textBox2.KeyPress += textBox1_keyPress;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(textBox1.Text);
            int Number2 = int.Parse(textBox2.Text);
            int Result = Number1 + Number2;
            textBox3.Text = Result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(textBox1.Text);
            int Number2 = int.Parse(textBox2.Text);
            int Result = Number1 - Number2;
            textBox3.Text = Result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(textBox1.Text);
            int Number2 = int.Parse(textBox2.Text);
            int Result = Number1 * Number2;
            textBox3.Text = Result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try 
            {
                int Number1 = int.Parse(textBox1.Text);
                int Number2 = int.Parse(textBox2.Text);
                int Result = Number1 / Number2;
                textBox3.Text = Result.ToString();
            }

            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message+"The number cannot be divisble by 0.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
