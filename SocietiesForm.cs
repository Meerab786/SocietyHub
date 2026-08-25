using DB_Final.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Final
{
    public partial class SocietiesForm : UserControl
    {
        public SocietiesForm()
        {
            InitializeComponent();
        }

        private void btnAddSociety_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();
            main.LoadPage(new AddSociety());
        }
    }
}
