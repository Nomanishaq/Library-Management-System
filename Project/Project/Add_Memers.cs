using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Project
{
    public partial class Add_Memers : UserControl
    {
        private static Add_Memers _AddMemers;
        
        public static Add_Memers memb
        {
            get {

                if (_AddMemers == null)
                {
                    _AddMemers = new Add_Memers();
                }
                return _AddMemers;
                
                }
        }

        public Add_Memers()
        {
            InitializeComponent();

        }

        DataClasses1DataContext dta = new DataClasses1DataContext();
       

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (add_member_Name_textBox.Text != "" && Ad_F_Name_textBox.Text != "" && Ad_Cnic_textBox.Text != "" && Ad_phpne_textBox.Text != "" && Ad_Adres_TextBox.Text != "" && Gender.Text != "")
            {
                string gender = Gender.SelectedItem.ToString();
                dta.ad_member(add_member_Name_textBox.Text, Ad_F_Name_textBox.Text, Ad_Cnic_textBox.Text, Ad_phpne_textBox.Text, Ad_Adres_TextBox.Text, gender);
                MessageBox.Show("Add Member Sucessfully");
                add_member_Name_textBox.Text = "";
                Ad_F_Name_textBox.Text = "";
                Ad_Cnic_textBox.Text = "";
                Ad_phpne_textBox.Text = "";
                Ad_Adres_TextBox.Text = "";
                Gender.Text = "";
                Report rp = new Report();
                rp.loadData(); 

            }
            else
            {
                MessageBox.Show("Error");
            }

            loadData();           

        }

        public void loadData() {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Recordgridview.DataSource = db.select_member();


        }

        private void Add_Memers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Ad_Cnic_textBox_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void Ad_Cnic_textBox_TextChanged(object sender, EventArgs e)
        {
    
            
            var match = Regex.IsMatch(Ad_Cnic_textBox.Text, @"\d{5}-\d{7}-\d");

           if (match)
            {
                lblValidateCNIC.Hide();
            }
            else
            {
                lblValidateCNIC.Visible = true;
                lblValidateCNIC.ForeColor = Color.Red;
            }
        }

        private void Ad_phpne_textBox_TextChanged(object sender, EventArgs e)
        {
            var match = Regex.IsMatch(Ad_phpne_textBox.Text, @"\d{4}-\d{7}");

            if (match)
            {
               phonerror.Hide();
            }
            else
            {
                phonerror.Visible = true;
                phonerror.ForeColor = Color.Red;
            }
        }

        private void Recordgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
