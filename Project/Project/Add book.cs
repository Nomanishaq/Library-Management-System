using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Project
{
    public partial class Add_book : UserControl
    {
        private static Add_book _Books;
        public static Add_book book
        {
            get
            {
                if (_Books == null)
                    _Books = new Add_book();
                return _Books;

            }

        }
 
        public Add_book()
        {
            InitializeComponent();
            shwdata();
        }
        DataClasses1DataContext dta = new DataClasses1DataContext();
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string a = category.SelectedItem.ToString();
                if (Book_Name_text.Text != "" && isbn_textBox.Text != "" && title_textBox.Text != "" && auther_textBox.Text != "" && a != "")
                {
                    dta.bokad(Book_Name_text.Text, isbn_textBox.Text, title_textBox.Text, auther_textBox.Text,a);
                    MessageBox.Show("Add Book Sucessfully");
                    Book_Name_text.Text = "";
                    isbn_textBox.Text = "";
                    title_textBox.Text = "";
                    auther_textBox.Text = "";
                    Report rp = new Report();
                    rp.Showbook();
                    shwdata();
                    
                    
                }
                else
                {
                    MessageBox.Show("Error");
                    Book_Name_text.Text = "";
                    isbn_textBox.Text = "";
                    title_textBox.Text = "";
                    auther_textBox.Text = "";
                    a = "";
               
                }

            }
            catch {
                MessageBox.Show("error");
            }

            

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void Add_book_Load(object sender, EventArgs e)
        {
           //category.ValueMember = 
        }

        private void Book_Name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void auther_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void title_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbn_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                dta.deleteBok(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            Book_Name_text.Text = "";
            isbn_textBox.Text = "";
            title_textBox.Text = "";
            auther_textBox.Text = "";
            MessageBox.Show("Deleted Successfully");
            shwdata();
            
        }
        public void shwdata() 
        {
            dataGridView1.DataSource = dta.bookshow();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            var con = dataGridView1.CurrentRow.Cells;
            Book_Name_text.Text=con[0].Value.ToString();

            isbn_textBox.Text=con[1].Value.ToString();
             title_textBox.Text=con[2].Value.ToString();
 
            auther_textBox.Text=con[3].Value.ToString();
            category.SelectedItem = con[4].Value.ToString();

            shwdata();

        }


      
           }
}
