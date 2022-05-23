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
    public partial class Start_Up : Form
    {
        //int move = 2;
        public Start_Up()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if(panel2.Width >=360)
            {
                timer1.Stop();
                Login f2 = new Login();
                f2.Show();
                this.Hide();
            }
           
        }

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void Start_Up_Load(object sender, EventArgs e)
        //{
        //    timer1.Start();
        //}
    }
}
