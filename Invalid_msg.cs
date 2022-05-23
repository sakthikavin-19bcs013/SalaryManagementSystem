using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powerloom_salary_management
{
    public partial class Invalid_msg : Form
    {
        public Invalid_msg(String Value)
        {
            InitializeComponent();
            label1.Text = Value;

        }
        
        
        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Invalid_msg_Load(object sender, EventArgs e)
        {

        }
    }
}
