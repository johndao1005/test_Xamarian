namespace WinFormsApp
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            SearchInput = new TextBox();
            comboBox1 = new ComboBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Staff Contacts";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(31, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(739, 434);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(SearchInput);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(731, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Staff List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(731, 401);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Staff Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(620, 511);
            button1.Name = "button1";
            button1.Size = new Size(146, 27);
            button1.TabIndex = 3;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 361);
            dataGridView1.TabIndex = 0;
            // 
            // SearchInput
            // 
            SearchInput.Location = new Point(62, 5);
            SearchInput.Name = "SearchInput";
            SearchInput.Size = new Size(189, 27);
            SearchInput.TabIndex = 3;
            SearchInput.TextChanged += SearchInput_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(305, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 16);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Staff Contacts";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Search";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 8);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Sort";
            // 
            // button2
            // 
            button2.Location = new Point(462, 4);
            button2.Name = "button2";
            button2.Size = new Size(78, 29);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(638, 5);
            button3.Name = "button3";
            button3.Size = new Size(90, 28);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(546, 5);
            button4.Name = "button4";
            button4.Size = new Size(86, 28);
            button4.TabIndex = 8;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox SearchInput;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label4;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
