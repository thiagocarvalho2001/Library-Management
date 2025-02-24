namespace LibraryManager
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
            label2 = new Label();
            label3 = new Label();
            textTitle = new TextBox();
            textAuthor = new TextBox();
            textYear = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Update = new Button();
            Delete = new Button();
            textSearch = new TextBox();
            Search = new Button();
            comboBoxSort = new ComboBox();
            textFilter = new TextBox();
            buttonExport = new Button();
            labelTotalBooks = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Title:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 44);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Author:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 88);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Year:";
            // 
            // textTitle
            // 
            textTitle.Location = new Point(0, 18);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(156, 23);
            textTitle.TabIndex = 3;
            textTitle.TextChanged += textBox1_TextChanged;
            // 
            // textAuthor
            // 
            textAuthor.Location = new Point(0, 62);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(156, 23);
            textAuthor.TabIndex = 4;
            textAuthor.TextChanged += textBox2_TextChanged;
            // 
            // textYear
            // 
            textYear.Location = new Point(0, 106);
            textYear.Name = "textYear";
            textYear.Size = new Size(156, 23);
            textYear.TabIndex = 5;
            textYear.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 135);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(162, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(313, 158);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Update
            // 
            Update.Location = new Point(81, 135);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 8;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += button2_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(0, 164);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 9;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(481, 4);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(100, 23);
            textSearch.TabIndex = 10;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // Search
            // 
            Search.Location = new Point(481, 33);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 11;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(587, 4);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(121, 23);
            comboBoxSort.TabIndex = 13;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // textFilter
            // 
            textFilter.Location = new Point(587, 36);
            textFilter.Name = "textFilter";
            textFilter.Size = new Size(121, 23);
            textFilter.TabIndex = 14;
            textFilter.TextChanged += textFilter_TextChanged;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(613, 65);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(75, 23);
            buttonExport.TabIndex = 16;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // labelTotalBooks
            // 
            labelTotalBooks.AutoSize = true;
            labelTotalBooks.Location = new Point(162, 168);
            labelTotalBooks.Name = "labelTotalBooks";
            labelTotalBooks.Size = new Size(71, 15);
            labelTotalBooks.TabIndex = 17;
            labelTotalBooks.Text = "Total Books:";
            labelTotalBooks.Click += labelTotalBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTotalBooks);
            Controls.Add(buttonExport);
            Controls.Add(textFilter);
            Controls.Add(comboBoxSort);
            Controls.Add(Search);
            Controls.Add(textSearch);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textYear);
            Controls.Add(textAuthor);
            Controls.Add(textTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Window";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textTitle;
        private TextBox textAuthor;
        private TextBox textYear;
        private Button button1;
        private DataGridView dataGridView1;
        private Button Update;
        private Button Delete;
        private TextBox textSearch;
        private Button Search;
        private ComboBox comboBoxSort;
        private TextBox textFilter;
        private Button buttonExport;
        private Label labelTotalBooks;
    }
}
