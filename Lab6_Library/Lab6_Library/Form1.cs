using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Library
{
    public partial class Form1 : Form
    {
        Dictionary<string, Book> books = new Dictionary<string, Book>();
        Book b1 = new Book("035728497", "Trainspotting");
        Book b2 = new Book("037408831", "The Lord Of The Rings");
        

        public Form1()
        {
            InitializeComponent();
            books.Add(b1.ISBN, b1);
            books.Add(b2.ISBN, b2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            books.Add(ISBN.Text, new Book(ISBN.Text, bookTitle.Text));
            booksList.Text += ISBN.Text + " " +"'"+ bookTitle.Text +"'"+ "\t added to the list" + Environment.NewLine;

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            booksList.Text = ISBN.Text + " removed from the list";
            books.Remove(ISBN.Text);            
        }

        private void ChangeLoanButton_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<String, Book> i in books)
            {
                if (ISBN.Text == i.Key)
                {
                    i.Value.Onloan = true;
                    booksList.Text ="on loan status changed !! \t" + i.Key + " " + i.Value.Title + " " + i.Value.Onloan;
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool bookFound = false;
            foreach (KeyValuePair<String, Book> i in books)
            {
                if (ISBN.Text == i.Key)
                {
                    booksList.Text = i.Key + " " + i.Value.Title + " " + i.Value.Onloan;
                    bookFound = true;
                }
            }
            if (bookFound == false)
            { booksList.Text = "Sorry book not found !";}           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookTitle_TextChanged(object sender, EventArgs e)
        {
            booksList.Text = "";
            foreach (KeyValuePair<String, Book> i in books)
            {
                Book book = i.Value;
                if (book.Title.ToLower().Contains(bookTitle.Text.ToLower()))
                {
                    booksList.Text += book.ISBN + " " + book.Title + " " + book.Onloan + Environment.NewLine;
                }
            }
        }

        private void booksList_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void titleSearchButton_Click(object sender, EventArgs e)
        {
            booksList.Text = "";
            foreach (KeyValuePair<String, Book> i in books)
            {
                Book book = i.Value;
                if (book.Title.ToLower().Contains(bookTitle.Text.ToLower()))
                {
                    booksList.Text +=book.ISBN + " " + book.Title + " " + book.Onloan + Environment.NewLine;
                }
            }
        }
    }
}
