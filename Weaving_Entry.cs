using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powerloom_salary_management
{
    public partial class Weaving_Entry : Form
    {
        public Weaving_Entry()
        {
            InitializeComponent();
            TB_day.Text = TB_date.Value.DayOfWeek.ToString();
            TB_emp_id.Text = "";
         //   CB_emp_name.SelectedIndex = -1;
            TB_loom_num.Text = "";
            CB_size.SelectedIndex = -1;
            TB_tl_piece.Text = "";

        }

        private void Weaving_Entry_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Emp_name_eng,Emp_id FROM Weaving_emp ORDER BY Emp_id", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            CB_emp_name.DataSource = dt;
            CB_emp_name.DisplayMember = "Emp_name_eng";
            CB_emp_name.SelectedIndex = -1;            
            TB_emp_id.Text = "";


            
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT DISTINCT Size FROM Price ", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            CB_size.DataSource = dt1;
            CB_size.DisplayMember = "Size";
            CB_size.SelectedIndex = -1;

            TB_loom_num.Text = "";
           // CB_size.SelectedIndex = -1;
            TB_tl_piece.Text = "";

        }

       
        private void TB_date_ValueChanged(object sender, EventArgs e)
        {
            TB_day.Text = TB_date.Value.DayOfWeek.ToString();
        }

       

        private void CB_emp_name_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
            string sqlQuery = "SELECT Emp_id FROM Weaving_emp WHERE Emp_name_eng='" + CB_emp_name.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                string name = (string)dr["Emp_id"].ToString();
                TB_emp_id.Text = name;
            }
        }
        private void BT_sub_Click(object sender, EventArgs e)
        {
            if(CB_emp_name.Text != "")
            {
                if(TB_emp_id.Text != "")
                {
                    if(TB_date.Text !="")
                    {
                        if (TB_day.Text !="")
                            {
                            if (TB_loom_num.Text !="")
                                {
                                    if(CB_size.Text !="")
                                    {
                                        if(TB_tl_piece.Text!="")
                                        {
                                            try
                                            {

                                                string fromdate = TB_date.Value.ToString("yyyy-MM-dd");
                                                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
                                                con.Open();
                                                SqlCommand cmd = new SqlCommand("INSERT INTO [NTS_Textile].[dbo].[Weaving_new_daily_entry]  (Emp_id,Emp_name,Date,Day,Loom_number,Size,Total_piece) Values('" + TB_emp_id.Text + "','" + CB_emp_name.Text + "','" + fromdate.ToString()+ "','" + TB_day.Text + "','" + TB_loom_num.Text + "','" + CB_size.Text + "','" + TB_tl_piece.Text + "')", con);
                                                cmd.ExecuteNonQuery();
                                                con.Close();

                                                Invalid_msg m = new Invalid_msg("Data Inserted Successfully");
                                                m.Show();

                                                CB_emp_name.SelectedItem = CB_emp_name.SelectedValue;
                                                    TB_loom_num.Text = "";
                                                    CB_size.SelectedItem = CB_size.SelectedValue;
                                                    TB_tl_piece.Text = "";

                                             }
                                            catch(Exception ex)
                                            {
                                                Invalid_msg m = new Invalid_msg("Error");
                                                m.Show();
                                                
                                            }
                                        }
                                        else
                                        {
                                            Invalid_msg m = new Invalid_msg("Enter Total piece");
                                            m.Show();
                                        }
                                    }
                                    else
                                    {
                                        Invalid_msg m = new Invalid_msg("Select Size");
                                        m.Show();
                                    }
                                }
                                else
                                {
                                    Invalid_msg m = new Invalid_msg("Enter Loom Number");
                                    m.Show();
                                }
                            }                          
                        
                        else
                        {
                            Invalid_msg m = new Invalid_msg("Select Day");
                            m.Show();
                        }
                    }
                    else
                    {
                        Invalid_msg m = new Invalid_msg("Select Date");
                        m.Show();
                    }
                }
                else
                {
                    Invalid_msg m = new Invalid_msg("Select Employee Name");
                    m.Show();
                }
            }
            else
            {
                Invalid_msg m = new Invalid_msg("Enter Employee Name");
                m.Show();
            }

        }

        private void TB_loom_num_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                CB_size.Focus();
            }
        }

        private void CB_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TB_tl_piece.Focus();
            }
        }

        private void TB_tl_piece_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                BT_sub.Focus();
            }
        }
    }
}
