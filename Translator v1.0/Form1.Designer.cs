namespace Translator_v1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Viewbutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.Languagelabel = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.emptyButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.practiceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.wordsAddedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nextButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.translateLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 25;
            this.filesListBox.Location = new System.Drawing.Point(8, 27);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(264, 404);
            this.filesListBox.TabIndex = 0;
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Existing files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Options:";
            // 
            // Viewbutton
            // 
            this.Viewbutton.Enabled = false;
            this.Viewbutton.Location = new System.Drawing.Point(307, 60);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(112, 34);
            this.Viewbutton.TabIndex = 5;
            this.Viewbutton.Text = "View ";
            this.Viewbutton.UseVisualStyleBackColor = true;
            this.Viewbutton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.Enabled = false;
            this.Removebutton.Location = new System.Drawing.Point(307, 120);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(112, 34);
            this.Removebutton.TabIndex = 6;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Enabled = false;
            this.Savebutton.Location = new System.Drawing.Point(307, 176);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(112, 34);
            this.Savebutton.TabIndex = 7;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(456, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(549, 354);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(480, 406);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Languagelabel
            // 
            this.Languagelabel.AutoSize = true;
            this.Languagelabel.Location = new System.Drawing.Point(73, 0);
            this.Languagelabel.Name = "Languagelabel";
            this.Languagelabel.Size = new System.Drawing.Size(108, 25);
            this.Languagelabel.TabIndex = 10;
            this.Languagelabel.Text = "Existing files";
            // 
            // addTextBox
            // 
            this.addTextBox.Enabled = false;
            this.addTextBox.Location = new System.Drawing.Point(598, 406);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(150, 31);
            this.addTextBox.TabIndex = 11;
            this.addTextBox.TextChanged += new System.EventHandler(this.addTextBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(35, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 514);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.emptyButton);
            this.tabPage1.Controls.Add(this.newButton);
            this.tabPage1.Controls.Add(this.practiceButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.wordsAddedTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Languagelabel);
            this.tabPage1.Controls.Add(this.addTextBox);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.filesListBox);
            this.tabPage1.Controls.Add(this.Savebutton);
            this.tabPage1.Controls.Add(this.Viewbutton);
            this.tabPage1.Controls.Add(this.Removebutton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Press save too save words too current list";
            this.label5.Visible = false;
            // 
            // emptyButton
            // 
            this.emptyButton.Enabled = false;
            this.emptyButton.Location = new System.Drawing.Point(853, 441);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(112, 34);
            this.emptyButton.TabIndex = 17;
            this.emptyButton.Text = "Empty";
            this.emptyButton.UseVisualStyleBackColor = true;
            this.emptyButton.Click += new System.EventHandler(this.emptyButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(307, 285);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(112, 34);
            this.newButton.TabIndex = 16;
            this.newButton.Text = "New file";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // practiceButton
            // 
            this.practiceButton.Enabled = false;
            this.practiceButton.Location = new System.Drawing.Point(307, 231);
            this.practiceButton.Name = "practiceButton";
            this.practiceButton.Size = new System.Drawing.Size(112, 34);
            this.practiceButton.TabIndex = 15;
            this.practiceButton.Text = "Practice";
            this.practiceButton.UseVisualStyleBackColor = true;
            this.practiceButton.Click += new System.EventHandler(this.practiceButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(790, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Waiting to be added";
            // 
            // wordsAddedTextBox
            // 
            this.wordsAddedTextBox.Enabled = false;
            this.wordsAddedTextBox.Location = new System.Drawing.Point(754, 406);
            this.wordsAddedTextBox.Name = "wordsAddedTextBox";
            this.wordsAddedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wordsAddedTextBox.Size = new System.Drawing.Size(251, 31);
            this.wordsAddedTextBox.TabIndex = 13;
            this.wordsAddedTextBox.TextChanged += new System.EventHandler(this.wordsAddedTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Language";
            this.label3.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nextButton);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.doneButton);
            this.tabPage2.Controls.Add(this.translateLabel);
            this.tabPage2.Controls.Add(this.toTextBox);
            this.tabPage2.Controls.Add(this.fromTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(904, 416);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(112, 34);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(142, -21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(680, 239);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correct";
            this.label6.Visible = false;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(6, 416);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(112, 34);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Exit";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // translateLabel
            // 
            this.translateLabel.AutoSize = true;
            this.translateLabel.Location = new System.Drawing.Point(408, 221);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(108, 25);
            this.translateLabel.TabIndex = 2;
            this.translateLabel.Text = "To language";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(586, 218);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(150, 31);
            this.toTextBox.TabIndex = 1;
            this.toTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toTextBox_KeyDown);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Enabled = false;
            this.fromTextBox.Location = new System.Drawing.Point(190, 221);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(150, 31);
            this.fromTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 514);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1052, 570);
            this.MinimumSize = new System.Drawing.Size(1052, 570);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox filesListBox;
        private Label label1;
        private Label label2;
        private Button Viewbutton;
        private Button Removebutton;
        private Button Savebutton;
        private DataGridView dataGridView1;
        private Button addButton;
        private Label Languagelabel;
        private TextBox addTextBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private TabPage tabPage2;
        private Label label4;
        private TextBox wordsAddedTextBox;
        private Button practiceButton;
        private Label translateLabel;
        private TextBox toTextBox;
        private TextBox fromTextBox;
        private Label label6;
        private Button doneButton;
        private Button nextButton;
        private Button newButton;
        private Button emptyButton;
        private Label label5;
    }
}