
using ClassLibrary1;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using static System.Windows.Forms.DataFormats;

namespace Translator_v1._0
{
    public partial class Form1 : Form
    {
        static string localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        static string pathToLabb3Folder = Path.Combine(localAppDataFolder, "Labb3");

        public WordList currentFile = null;

        string xc = string.Empty;

        public Word practice = null;

        private int guesses;

        private int correctGuesses;

        private float percentage;

        private int langCount = 0;

        public Form1()
        {
            InitializeComponent();
            FillListBox();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (filesListBox.SelectedItems.Count > 0)
            {
                Viewbutton.Enabled = true;
                practiceButton.Enabled = true;
                string xc = filesListBox.Items[filesListBox.SelectedIndex].ToString();
                currentFile = WordList.LoadList(xc);
            }

        }

        private void FillListBox()
        {
            filesListBox.Items.AddRange(WordList.GetLists());
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            addTextBox.Enabled = true;
            label3.Visible = true;

            for (int i = 0; i < currentFile.Languages.Length; i++)
            {
                dataGridView1.Columns.Add(currentFile.Languages[i].ToString(), currentFile.Languages[i]);

            }

            currentFile.List(0, translations);
            label3.Text = currentFile.Languages[0];

            void translations(string[] translations)
            {
                int rowindex = dataGridView1.Rows.Add();
                for (int i = 0; i < currentFile.Languages.Length; i++)
                {
                    dataGridView1.Rows[rowindex].Cells[currentFile.Languages[i]].Value = translations[i];
                }

            }


        }

        private void Removebutton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }

            string hea = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[currentFile.Languages[dataGridView1.SelectedCells[0].ColumnIndex]].FormattedValue.ToString();
            currentFile.Remove(0, hea);


        }

        private void Savebutton_Click(object sender, EventArgs e)
        {

            string[] row = wordsAddedTextBox.Text.Split(";", StringSplitOptions.RemoveEmptyEntries);
            langCount = 0;
            label3.Text = currentFile.Languages[0];

            if (row.Length != currentFile.Languages.Length)
            {
                MessageBox.Show("Number of added words must match languages!");
                wordsAddedTextBox.Text = string.Empty;
            }
            else
            {
                dataGridView1.Rows.Add(row);
                currentFile.Add(row);
                currentFile.Save();

                MessageBox.Show("Your list have been saved", "Save file");

                wordsAddedTextBox.Text = string.Empty;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                Removebutton.Enabled = true;
            }
            else
            {
                Removebutton.Enabled = false;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            langCount++;

            if (langCount == currentFile.Languages.Length)
            {
                langCount = 0;
            }

            label3.Text = currentFile.Languages[langCount];

            wordsAddedTextBox.AppendText(addTextBox.Text + ";");

            addTextBox.Text = string.Empty;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0, 1);
        }

        private void practiceButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            nextButton.Enabled = false;

            label6.Visible = false;

            doneButton.Enabled = false;
            toTextBox.Text = string.Empty;

            Practice();

        }
        private void toTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            Image img = Image.FromFile("C:\\Users\\pontus lann\\Downloads\\borat.jpg");

            if (e.KeyCode == Keys.Enter)
            {
                doneButton.Enabled = true;
                nextButton.Enabled = true;
                if (toTextBox.Text == practice.Translations[1])
                {
                    tabPage2.BackgroundImage = img;
                    guesses++;
                    correctGuesses++;
                }
                else
                {
                    label6.Text = "Wrong!";
                    label6.Visible = true;
                    guesses++;
                }

            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            toTextBox.Text = String.Empty;
            label6.Visible = false;
            nextButton.Enabled = false;
            Practice();
            tabPage2.BackgroundImage = default;
        }

        void Practice()
        {
            practice = currentFile.GetWordToPractice();

            fromTextBox.Text = $"{practice}";

            translateLabel.Text = $"To {currentFile.Languages[practice.ToLanguage]}";
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            percentage = correctGuesses / guesses;

            MessageBox.Show($"You had {percentage * 100:f0}% correct answers", "Exit practice mode");

            tabControl1.SelectedIndex = 0;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();


            if (form2.DialogResult == DialogResult.Yes)
            {
                if (form2.fileName == string.Empty || form2.lang1 == string.Empty || form2.lang2 == string.Empty)
                {
                    MessageBox.Show("You need to enter file name and atleast two languages", "Error");
                }
                else
                {
                    CreateNewFiles(form2.fileName, form2.lang1, form2.lang2, form2.lang3, form2.lang4);
                }
            }
            else
            {
                MessageBox.Show("No new file was created!", "errror");
            }
            filesListBox.Items.Clear();
            filesListBox.Items.AddRange(WordList.GetLists());


        }

        public void CreateNewFiles(string fileName, params string[] languages)
        {
            string currentFile = Path.Combine(pathToLabb3Folder, fileName + ".dat");

            if (!File.Exists(currentFile))
            {
                using (FileStream fs = File.Create(currentFile))
                {
                    byte[] buffer = new UTF8Encoding(true).GetBytes($"{string.Join(";", languages)}");
                    fs.Write(buffer, 0, buffer.Length);
                }
            }
        }

        private void emptyButton_Click(object sender, EventArgs e)
        {
            wordsAddedTextBox.Text = string.Empty;
        }

        private void addTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addTextBox.Text != string.Empty)
            {
                filesListBox.Enabled = false;
                addButton.Enabled = true;
                label3.Visible = true;
            }
            else
            {
            }
        }

        private void wordsAddedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (wordsAddedTextBox.Text != string.Empty)
            {
                filesListBox.Enabled = false;
                emptyButton.Enabled = true;
                Savebutton.Enabled = true;
                label5.Visible = true;
            }
            else
            {
                Savebutton.Enabled = false;
                filesListBox.Enabled = true;
                emptyButton.Enabled = false;
                label5.Visible = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var msgBox = MessageBox.Show($"Do you want to save before exit? Press Yes!", "Exit", MessageBoxButtons.YesNoCancel);

            if (msgBox == DialogResult.Yes)
            {
                if (filesListBox.SelectedItems.Count > 0)
                {
                    currentFile.Save();
                    MessageBox.Show("Current file have been saved", "See you later!", MessageBoxButtons.OK);
                }
                else
                {
                    e.Cancel = false;
                }
            }
            else if (msgBox == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }
    }

}