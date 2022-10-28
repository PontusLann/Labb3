namespace Translator_v1._0
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Addbutton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lang1TextBox = new System.Windows.Forms.TextBox();
            this.lang2TextBox = new System.Windows.Forms.TextBox();
            this.lang3TextBox = new System.Windows.Forms.TextBox();
            this.lang4TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(182, 338);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(112, 34);
            this.Addbutton.TabIndex = 1;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(47, 37);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(204, 31);
            this.fileTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name your file";
            // 
            // lang1TextBox
            // 
            this.lang1TextBox.Location = new System.Drawing.Point(47, 98);
            this.lang1TextBox.Name = "lang1TextBox";
            this.lang1TextBox.Size = new System.Drawing.Size(204, 31);
            this.lang1TextBox.TabIndex = 6;
            // 
            // lang2TextBox
            // 
            this.lang2TextBox.Location = new System.Drawing.Point(47, 161);
            this.lang2TextBox.Name = "lang2TextBox";
            this.lang2TextBox.Size = new System.Drawing.Size(204, 31);
            this.lang2TextBox.TabIndex = 7;
            this.lang2TextBox.TextChanged += new System.EventHandler(this.lang2TextBox_TextChanged);
            // 
            // lang3TextBox
            // 
            this.lang3TextBox.Enabled = false;
            this.lang3TextBox.Location = new System.Drawing.Point(47, 223);
            this.lang3TextBox.Name = "lang3TextBox";
            this.lang3TextBox.Size = new System.Drawing.Size(204, 31);
            this.lang3TextBox.TabIndex = 8;
            this.lang3TextBox.TextChanged += new System.EventHandler(this.lang3TextBox_TextChanged);
            // 
            // lang4TextBox
            // 
            this.lang4TextBox.Enabled = false;
            this.lang4TextBox.Location = new System.Drawing.Point(47, 283);
            this.lang4TextBox.Name = "lang4TextBox";
            this.lang4TextBox.Size = new System.Drawing.Size(204, 31);
            this.lang4TextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Language: 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Language: 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Language: 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Language: 4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lang4TextBox);
            this.Controls.Add(this.lang3TextBox);
            this.Controls.Add(this.lang2TextBox);
            this.Controls.Add(this.lang1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.Addbutton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Addbutton;
        private TextBox fileTextBox;
        private Label label1;
        private TextBox lang1TextBox;
        private TextBox lang2TextBox;
        private TextBox lang3TextBox;
        private TextBox lang4TextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}