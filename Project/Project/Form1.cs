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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            DataClasses1DataContext dc = new DataClasses1DataContext();
                string N = txt1.Text;
                string P = txt2.Text;
                var res = dc.Loggins.Where(ex => ex.Name == N && ex.pasword == P).FirstOrDefault();
                try
                {
                    if ((res.Name == N) && (res.pasword == P))
                    {
                        f2.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please confirm User name or password");
                
                }
                txt1.Text = txt2.Text = "";
        }
 }
}
