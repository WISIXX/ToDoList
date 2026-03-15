using Microsoft.VisualBasic.Devices;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;

                string test = textBox1.Text;

                if (!string.IsNullOrEmpty(test))
                {



                    textBox1.Clear();

                    checkedListBox1.Items.Add(test);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.Items.Count != 0)
            {

                checkedListBox1.Items.RemoveAt(checkedListBox1.Items.Count - 1);
            }


        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.BackColor = Color.FromArgb(6, 19, 20);
                textBox1.BackColor = Color.FromArgb(6, 19, 20);
                checkedListBox1.BackColor = Color.FromArgb(6, 19, 20);

                checkBox1.ForeColor = Color.FromArgb(252, 252, 252);
                textBox1.ForeColor = Color.White;
                checkedListBox1.ForeColor = Color.White;
                label1.ForeColor = Color.White;

            }
            else if (!checkBox1.Checked)
            {
                this.BackColor = Color.FromArgb(200, 237, 239);
                textBox1.BackColor = Color.White;
                checkedListBox1.BackColor = Color.White;

                checkBox1.ForeColor = Color.Black;
                textBox1.ForeColor = Color.Black;
                checkedListBox1.ForeColor = Color.Black;
                label1.ForeColor = Color.White;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(200, 237, 239);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
