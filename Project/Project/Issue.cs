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
    public partial class Issue : UserControl
    {
        private static Issue _Issue;
        public static Issue isu
        {
            get
            {
                if (_Issue == null)
                    _Issue = new Issue();
                return _Issue;

            }

        }

        public Issue()
        {
            InitializeComponent();
            Report r = new Report();
           
        }
        
        private void Issue_Load(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var members = db.Member_adds.ToList();

            txt2.DataSource = members;
            txt2.DisplayMember = "Name";
            txt2.ValueMember = "Member_Id";

            var book = db.bookadds.ToList();
            txt1.DataSource = book;
            txt1.DisplayMember = "ID";
            txt1.ValueMember = "Book_Name";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.borowbookdetail();
            if (txt1.Text != "" && txt2.Text != "" && txt5.Text != "")
            {
                var isdate = txt3.Value;
                var rtndate = txt4.Value;
                DateTime startDate = txt3.Value;
                DateTime endDate = txt4.Value;
                TimeSpan calculateDays = endDate - startDate;
                double Total = calculateDays.Days;
                txt5.Text = Total.ToString();

 
                DataClasses1DataContext dbab = new DataClasses1DataContext();
                dbab.isubook(txt1.Text, txt2.Text, isdate, rtndate,Convert.ToInt32( txt5.Text) );
                MessageBox.Show("Sucess");
                txt1.Text = "";
                txt2.Text = "";
                txt5.Text = "";
               
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        DataClasses1DataContext da = new DataClasses1DataContext();
        

        private void txt4_ValueChanged(object sender, EventArgs e)
        {
            txt5.Text = (txt3.Value - txt4.Value).ToString();
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
