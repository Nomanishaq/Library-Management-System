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
    public partial class Report : UserControl
    {
        
        private static Report _Report;
        public static Report rep
        {
            get
            {
                if (_Report == null)
                    _Report = new Report();
                return _Report;

            }

        }
        public Report()
        {
            InitializeComponent();
            Showbook();
            loadData();
            borowbookdetail();
        }

        public void showTables()
        {
            this.Showbook();
            this.loadData();
            this.borowbookdetail();
        }
        DataClasses1DataContext dba = new DataClasses1DataContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadData()
        {
           
            dataGridView2.DataSource = dba.select_member();
            
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();     
        }

        private void Report_Load(object sender, EventArgs e)
        {
            loadData();
            Showbook();
           borowbookdetail();
            
        }
        public void Showbook()
        {
            
            dataGridView3.DataSource = dba.bookshow();
        }

        public void borowbookdetail()
        {
            
            dataGridView1.DataSource = dba.isubookdetail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Showbook();
            loadData();
            borowbookdetail();
        }
    }
}
