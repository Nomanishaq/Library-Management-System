using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Form1 b = new Form1();
            this.Close();
            b.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Home.Hom))
            {
                HomeP.Controls.Add(Home.Hom);
                Home.Hom.Dock = DockStyle.Fill;
                Home.Hom.BringToFront();
            }
            else
            {
                Home.Hom.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!HomeP.Controls.Contains(Add_Memers.memb))
            {
                HomeP.Controls.Add(Add_Memers.memb);
                Add_Memers.memb.Dock = DockStyle.Fill;
                Add_Memers.memb.BringToFront();

            }
            else
            {
                Add_Memers.memb.BringToFront();
            }

        }

        private void HomeP_Paint(object sender, PaintEventArgs e)
        {
            if (!HomeP.Controls.Contains(Home.Hom))
            {
                HomeP.Controls.Add(Home.Hom);
                Home.Hom.Dock = DockStyle.Fill;
                Home.Hom.BringToFront();
            }
            else
            {
                Home.Hom.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(catalog.cata))
            {
                HomeP.Controls.Add(catalog.cata);
                catalog.cata.Dock = DockStyle.Fill;
                catalog.cata.BringToFront();
            }
            else
            {

                catalog.cata.Show();
                catalog.cata.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Issue.isu))
            {
                HomeP.Controls.Add(Issue.isu);
                Issue.isu.Dock = DockStyle.Fill;
                Issue.isu.BringToFront();
            }
            else
            {
                Issue.isu.BringToFront();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Return.Ret))
            {
                HomeP.Controls.Add(Return.Ret);
                Return.Ret.Dock = DockStyle.Fill;
                Return.Ret.BringToFront();
            }
            else
            {
                Return.Ret.BringToFront();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Add_book.book))
            {
                HomeP.Controls.Add(Add_book.book);
                Add_book.book.Dock = DockStyle.Fill;
                Add_book.book.BringToFront();
            }
            else
            {
                Add_book.book.BringToFront();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Report.rep))
            {
                HomeP.Controls.Add(Report.rep);
                Report.rep.Dock = DockStyle.Fill;
                Report.rep.BringToFront();
            }
            else
            {
                Report.rep.BringToFront();
            }
            Report rp = new Report();
            rp.showTables();
            rp.loadData();
            rp.Showbook();
            rp.borowbookdetail();
          

        }



    }

}

