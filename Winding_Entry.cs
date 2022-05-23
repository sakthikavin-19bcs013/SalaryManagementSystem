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
    public partial class Winding_Entry : Form
    {
        public Winding_Entry()
        {
            InitializeComponent();

            TB_day.Text = TB_date.Value.DayOfWeek.ToString();

        }

        private void Winding_Entry_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Emp_name_eng,Emp_id FROM Winding_emp ORDER BY Emp_id", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            CB_emp_name.DataSource = dt;
            CB_emp_name.DisplayMember = "Emp_name_eng";
            CB_emp_name.SelectedIndex = -1;
            TB_emp_id.Text = "";
        }

       
        private void TB_date_ValueChanged_1(object sender, EventArgs e)
        {
            TB_day.Text = TB_date.Value.DayOfWeek.ToString();
        }

        private void CB_emp_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
            string sqlQuery = "SELECT Emp_id FROM Winding_emp WHERE Emp_name_eng='" + CB_emp_name.Text + "'";
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
            if (CB_emp_name.Text != "")
            {
                if (TB_emp_id.Text != "")
                {
                    if (TB_date.Text != "")
                    {
                        if (TB_day.Text != "")
                        {
                            
                            if (TB_Tl_count.Text != "")
                            {
                                try
                                {

                                    string fromdate = TB_date.Value.ToString("yyyy-MM-dd");
                                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("INSERT INTO [NTS_Textile].[dbo].[Winding_daily_entry]  (Emp_id,Emp_name,Date_field,Day,Count) Values('" + TB_emp_id.Text + "','" + CB_emp_name.Text + "','" + fromdate.ToString() + "','" + TB_day.Text + "','" + TB_Tl_count.Text + "')", con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    //TB_emp_id.Text = "";
                                    // CB_emp_name.SelectedIndex = -1;
                                    CB_emp_name.SelectedItem = CB_emp_name.SelectedValue;
                                    TB_Tl_count.Text = "";
                                    

                                    Invalid_msg m = new Invalid_msg("Data Inserted Successfully");
                                    m.Show();
                                }
                                catch (Exception ex)
                                {
                                    Invalid_msg m = new Invalid_msg("Error");
                                    m.Show();
                                }
                            }
                            else
                            {
                                Invalid_msg m = new Invalid_msg("Enter Total Count");
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

        private void TB_date_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                TB_Tl_count.Focus();
            }
        }

        private void TB_Tl_count_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_sub.Focus();
            }
        }
    }
}
