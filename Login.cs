using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powerloom_salary_management
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
           
        }
       

        private void Login_Load(object sender, EventArgs e)
        {

        }

       

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            
            
            if (User_TextBox1.Text !="")
            {
                if(Password_TextBox.Text!="")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) From Login_db where User_Name='" + User_TextBox1.Text + "' AND Password='" + Password_TextBox.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Welcome_page F1 = new Welcome_page();
                        F1.ShowDialog();
                    }
                    else
                    {                        
                        Invalid_msg m = new Invalid_msg("Invalid Username or Password");
                        m.Show();

                    }
                }
                else
                {
                    Invalid_msg m = new Invalid_msg("Enter Password");
                    m.Show();
                }
                
            }
            else
            {
                Invalid_msg m = new Invalid_msg("Enter Username");
                m.Show();
            }
           

        }

        private void minimized_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
