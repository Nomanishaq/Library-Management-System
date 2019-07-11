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
    public partial class Return : UserControl
    {
        private static Return _Return;
        public static Return Ret
        {
            get
            {
                if (_Return == null)
                    _Return = new Return();
                return _Return;

            }

        }
        public Return()
        {
            InitializeComponent();
            borowbookdetail();
        }
        DataClasses1DataContext dta = new DataClasses1DataContext();
        
        public void borowbookdetail()
        {

            dataGridView1.DataSource = dta.isubookdetail();
        }

    }
}
