using System;
using System.IO;
using System.Windows.Forms;

namespace AddressBookForm
{
    public partial class Form1 : Form
    {
        private const string FilePath = "address.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

     
            string entry = $"{name}, {email}, {phone}{Environment.NewLine}";
            File.AppendAllText(FilePath, entry);

            MessageBox.Show("Data saved successfully.", "Information");

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);
                string allData = string.Join(Environment.NewLine, lines);
                MessageBox.Show(allData, "Saved Data");
            }
            else
            {
                MessageBox.Show("No such data found.", "Information");
            }
        }
    }
}