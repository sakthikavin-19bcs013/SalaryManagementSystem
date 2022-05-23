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
    public partial class Weaving_calculation : Form
    {
        public Weaving_calculation()
        {
            InitializeComponent();           

        }

        private void Weaving_calculation_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Emp_name_eng FROM Weaving_emp ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //CB_emp_name.DataSource = dt;
            CB_emp_name.DisplayMember = "Emp_name_eng";
            //CB_emp_name.SelectedIndex = -1;

            DataRow topItem = dt.NewRow();
            //topItem[0] = 0;
            topItem[0] = "Select";
            dt.Rows.InsertAt(topItem, 0);
            CB_emp_name.DataSource = dt;
        }


        private void BT_sub_Click(object sender, EventArgs e)
        {

            string fromdate = TB_frm_date.Value.ToString("yyyy-MM-dd");
            string todate = TB_to_date.Value.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select Date,Day,Loom_Number,Size,Total_piece,'Edit/Delete' as Command FROM [NTS_Textile].[dbo].[Weaving_new_daily_entry] where Emp_name='" + CB_emp_name.Text + "' AND Date BETWEEN '" + fromdate + "' AND '" + todate + "' ORDER BY Date ASC,Loom_Number", con);
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            con.Close();
            kryptonDataGridView1.DataSource = dt1;


         //   this.kryptonDataGridView1.Columns["Size"].DefaultCellStyle.ForeColor = Color.Green;

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                string a;
                a = kryptonDataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                MessageBox.Show(a);
            }
        }
    }
}
