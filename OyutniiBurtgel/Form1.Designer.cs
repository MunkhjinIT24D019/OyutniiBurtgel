namespace OyutniiBurtgel
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
            TreeNode treeNode6 = new TreeNode("Компьютерын ухаан");
            TreeNode treeNode7 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode8 = new TreeNode("Програм хангамж");
            TreeNode treeNode9 = new TreeNode("Node4");
            TreeNode treeNode10 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode6, treeNode7, treeNode8, treeNode9 });
            ListViewItem listViewItem2 = new ListViewItem("munkhjin");
            ColumnHeader columnHeader1;
            label1 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            Утас = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            checkedListBox1 = new CheckedListBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label7 = new Label();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            label9 = new Label();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            treeView1 = new TreeView();
            linkLabel1 = new LinkLabel();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            progressBar1 = new ProgressBar();
            columnHeader1 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "M.IT24D019";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(0, 363);
            maskedTextBox1.Mask = "0000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(151, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // Утас
            // 
            Утас.AutoSize = true;
            Утас.Location = new Point(50, 56);
            Утас.Name = "Утас";
            Утас.Size = new Size(0, 20);
            Утас.TabIndex = 3;
          
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1, 250);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 93);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(1, 407);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 131);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-- Тэнхим сонгох --", "Мэдээллийн технологи", "Компьютерын ухаан", "Програм хангамж" });
            comboBox1.Location = new Point(0, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 167);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 204);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 11;
            label5.Click += label5_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн сан", "Компьютерын сүлжээ", "Мэдээллийн технологи", "Вэб программчлал", "Алгоритм ба өгөгдлийн бүтэц" });
            checkedListBox1.Location = new Point(1, 110);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(224, 114);
            checkedListBox1.TabIndex = 12;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 325);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.moiloo_zurag;
            pictureBox1.Location = new Point(321, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(72, 468);
            button1.Name = "button1";
            button1.Size = new Size(143, 51);
            button1.TabIndex = 15;
            button1.Text = "Бүртгэх";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 499);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 16;
            label7.Click += label7_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(20, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 78);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 24);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(321, 19);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 21;
            label9.Text = "Нийт: 0";
            label9.Click += label9_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Монгол        ", " Англи         ", " Орос          ", " Хятад         ", " Япон          ", " Солонгос " });
            listBox1.Location = new Point(321, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 22;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(321, 376);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(564, 184);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "ОЮУТНЫ БҮРТГЭЛ \n\nКод: M.IT24D019\nУтас: 9999-9999\nНас: 21\nТөрсөн огноо: 2006-08-05\nСургалт: Өдрийн сургалт\nТэнхим: Мэдээллийн технологи\nТэтгэлэг: Тийм\nХичээл: Програмчлал, Өгөгдлийн бүтэц\nХэл: Англи\n\n";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(590, 185);
            treeView1.Name = "treeView1";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Компьютерын ухаан";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Мэдээллийн технологи";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Програм хангамж";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Node4";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Байгалийн ухааны сургууль";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode10 });
            treeView1.Size = new Size(235, 172);
            treeView1.TabIndex = 24;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(682, 15);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 20);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(591, 49);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(264, 121);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Овог нэр ";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Утас";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Нас";
            columnHeader3.Width = 50;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-66, 557);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(960, 38);
            progressBar1.TabIndex = 27;
            progressBar1.Value = 100;
            progressBar1.Click += progressBar1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 599);
            Controls.Add(progressBar1);
            Controls.Add(listView1);
            Controls.Add(linkLabel1);
            Controls.Add(treeView1);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(label9);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(checkedListBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(Утас);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label Утас;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private CheckedListBox checkedListBox1;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label7;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private Label label9;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private TreeView treeView1;
        private LinkLabel linkLabel1;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ProgressBar progressBar1;
    }
}
