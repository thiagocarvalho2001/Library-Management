using System.Linq.Expressions;
using System.Text.Json;

namespace LibraryManager
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();

            comboBoxSort.Items.AddRange(new string[] { "Title", "Author", "Year" });

            this.Load += new EventHandler(Form1_Load);

            UpdateBookCount();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        public class Book
        {
            public string? Title { get; set; }
            public string? Author { get; set; }
            public string? Year { get; set; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text;
            string author = textAuthor.Text;
            string year = textYear.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(year))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(year, out _))
            {
                MessageBox.Show("Year must be a number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book book = new Book();
            {
                book.Title = title; book.Author = author; book.Year = year;
            }

            books.Add(book);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;

            MessageBox.Show("Title: " + title + "\nAuthor: " + author + "\nYear: " + year);

            UpdateBookCount();
            SaveBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.CurrentRow.DataBoundItem is Book selectedBook)
            {
                textTitle.Text = selectedBook.Title;
                textAuthor.Text = selectedBook.Author;
                textYear.Text = selectedBook.Year;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem is Book selectedBook)
            {

                selectedBook.Title = textTitle.Text;
                selectedBook.Author = textAuthor.Text;
                selectedBook.Year = textYear.Text;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = books;

                MessageBox.Show("Title: " + selectedBook.Title + "\nAuthor: " + selectedBook.Author + "\nYear: " + selectedBook.Year);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem is Book selectedBook)
            {
                books.Remove(selectedBook);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = books;

                MessageBox.Show("Book Deleted");

                UpdateBookCount();
                SaveBooks();
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string search = textSearch.Text.ToLower();

            var filteredBooks = books
                .Where(b => (b.Title?.ToLower().Contains(search) ?? false)
                || (b.Author?.ToLower().Contains(search) ?? false)
                || (b.Year?.ToLower().Contains(search) ?? false)).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredBooks;
        }
        private void SaveBooks()
        {
            try
            {
                string json = JsonSerializer.Serialize(books);
                File.WriteAllText("books.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks()
        {
            try
            {
                if (File.Exists("books.json"))
                {
                    string json = File.ReadAllText("books.json");
                    books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = books;
                }
                else
                {
                    books = new List<Book>();
                }
            }
            catch
            {
                MessageBox.Show("Error loading books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortBy = comboBoxSort.SelectedItem.ToString();

            if (sortBy == "Title")
            {
                books = books.OrderBy(b => b.Title).ToList();
            }
            else if (sortBy == "Author")
            {
                books = books.OrderBy(b => b.Author).ToList();
            }
            else if (sortBy == "Year")
            {
                books = books.OrderBy(b => b.Year).ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;

        }

        private void textFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Export Books to CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var lines = books.Select(b => $"{b.Title},{b.Author},{b.Year}");
                    File.WriteAllLines(saveFileDialog.FileName, lines);
                    MessageBox.Show(text: "Books Exported to CSV", caption: "Export Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int CountTotalBooks()
        {
            return books.Count;
        }

        private void labelTotalBooks_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBookCount()
        {
            int totalBooks = CountTotalBooks();
            labelTotalBooks.Text = $"Total Books: {totalBooks}";
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
