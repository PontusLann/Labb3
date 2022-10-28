namespace Translator_v1._0
{
    public partial class Form2 : Form
    {
        public string fileName
        {
            get
            {
                return fileTextBox.Text;
            }

            set
            {
                fileTextBox.Text = value;
            }
        }

        public string lang1
        {
            get
            {
                return lang1TextBox.Text;
            }

            set
            {
                lang1TextBox.Text = value;
            }
        }

        public string lang2
        {
            get
            {
                return lang2TextBox.Text;
            }

            set
            {
                lang2TextBox.Text = value;
            }
        }

        public string lang3
        {
            get
            {
                return lang3TextBox.Text;
            }

            set
            {
                lang3TextBox.Text = value;
            }
        }

        public string lang4
        {
            get
            {
                return lang4TextBox.Text;
            }

            set
            {
                lang4TextBox.Text = value;
            }
        }

        public Form2()
        {
            InitializeComponent();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void lang2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (lang2TextBox.Text == string.Empty)
            {
                lang3TextBox.Enabled = false;
            }
            else
            {
                lang3TextBox.Enabled = true;
            }
        }

        private void lang3TextBox_TextChanged(object sender, EventArgs e)
        {
            if (lang3TextBox.Text == string.Empty)
            {
                lang4TextBox.Enabled = false;
            }
            else
            {
                lang4TextBox.Enabled = true;
            }
        }
    }
}

