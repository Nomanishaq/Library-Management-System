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
    public partial class catalog : UserControl
    {
        private static catalog _catalog;
        public static catalog cata
        {
            get
            {
                if (_catalog == null)
                    _catalog = new catalog();
                return _catalog;

            }

        }

        public catalog()
        {
            InitializeComponent();
            Shw();
        }
        DataClasses1DataContext dta = new DataClasses1DataContext();
        public void Shw() 
        {
            dataGridView1.DataSource = dta.bookshow();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Book_Name LIKE ={0}%", textBox5.Text);
        }
    }
}
