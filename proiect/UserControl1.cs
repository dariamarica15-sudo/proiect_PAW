using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public Button Btnsalveaza
        {
            get => btnSalveaza;
            set => btnSalveaza = value;
        }
        public TextBox TbId
        {
            get => tbId;
            set => tbId = value;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
