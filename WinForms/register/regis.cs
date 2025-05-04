using System.Xml.Linq;

namespace register
{
    public partial class regis : Form
    {
        public regis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            // Validate Gender
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select your gender.");
                return;
            }

            // Validate Age
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please enter a valid age greater than 0.");
                return;
            }

            // Validate Province
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your province.");
                return;
            }

            // Validate District
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your district.");
                return;
            }

            // Optional: Skills validation
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Please select at least one skill.");
                return;
            }

            // If all validations pass
            MessageBox.Show("Registration successful!");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return; // Prevents null exception

            var province = comboBox1.SelectedItem.ToString();
            List<string> bagmatiDistricts = new List<string> { "Kathmandu", "Bhaktapur", "Lalitpur" };
            List<string> gandakiDistricts = new List<string> { "Kaski", "Lamjung", "Manang" };

            comboBox2.Items.Clear();
            switch (province)
            {
                case "Bagmati":
                    comboBox2.Items.AddRange(bagmatiDistricts.ToArray());
                    break;
                case "Gandaki":
                    comboBox2.Items.AddRange(gandakiDistricts.ToArray());
                    break;
                default:
                    comboBox2.Items.Clear();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Clear TextBox
            textBox1.Text = "";

            // Clear RadioButtons
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // Reset NumericUpDown
            numericUpDown1.Value = 17;

            // Reset ComboBoxes
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            // Uncheck CheckBoxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }


    }
}




