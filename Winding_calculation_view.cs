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
using System.Drawing.Printing;
using System.Collections;

namespace Powerloom_salary_management
{
    public partial class Winding_calculation_view : Form
    {
        public Winding_calculation_view()
        {
            InitializeComponent();
            panel2.Hide();
            Back_btn.Hide();
            kryptonButton1.Hide();
        }

        private void Winding_calculation_view_Click(object sender, EventArgs e)
        {
            


        }

        private void BT_sub_Click(object sender, EventArgs e)
        {

            panel5.Hide();
            panel2.Show();

            Back_btn.Show();
            kryptonButton1.Show();

            label9.Text = "NTS TEXTILES";
            


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
            string sqlQuery = "SELECT Emp_id,Emp_name_tam FROM Winding_emp WHERE Emp_name_eng='"+CB_emp_name_winding.Text+"'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                label_emp_id.Text = (string)dr["Emp_id"].ToString();

                label_name_txt.Text = (string)dr["Emp_name_tam"].ToString();
            }
            con.Close();

            label_frm_txt.Text = TB_frm_date.Text;
            label_to_date.Text = TB_to_date.Text;


            string fromdate = TB_frm_date.Value.ToString("yyyy-MM-dd");
            string todate = TB_to_date.Value.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("SELECT t1.Date_field, t2.Day_tam, t1.Count FROM[NTS_Textile].[dbo].[Winding_daily_entry] as t1 INNER JOIN[NTS_Textile].[dbo].[Week_days] as t2 on t1.Day = t2.Day_Eng INNER JOIN[NTS_Textile].[dbo].[Winding_emp] as t3 on t1.Emp_name = t3.Emp_name_eng WHERE t1.Emp_name = '"+CB_emp_name_winding.Text+"' AND t1.Date_field BETWEEN '" + fromdate + "' AND '" + todate + "' ", con);
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            con.Close();
            kryptonDataGridView1.DataSource = dt1;

            kryptonDataGridView1.Rows[0].Cells[0].Selected = false;
            kryptonDataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            Decimal sum = 0;


            for (int i = 0; i <= kryptonDataGridView1.Rows.Count - 1; i++)
            {
                if (kryptonDataGridView1["Column3", i].Value != DBNull.Value)
                {
                    sum += (Decimal)kryptonDataGridView1["Column3", i].Value;
                }

            }
            dt1 = kryptonDataGridView1.DataSource as DataTable;
            DataRow row = dt1.NewRow();
            row[1] = "Total";
            row[2] = sum;

            dt1.Rows.Add(row);
            int lr = kryptonDataGridView1.Rows.Count - 1;

            kryptonDataGridView1.Rows[lr].DefaultCellStyle.BackColor = Color.OrangeRed;
            this.kryptonDataGridView1.Columns["Column3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Decimal total_count = 0;


            if (sum != 0)
            {

                Decimal s78 = 0;

                string sqlQuery78 = "SELECT Price FROM [NTS_Textile].[dbo].[Winding_Price] ";
                SqlCommand objCommand78 = new SqlCommand(sqlQuery78, con);
                con.Open();
                SqlDataReader dr78;
                dr78 = objCommand78.ExecuteReader();
                while (dr78.Read())
                {
                    s78 = Convert.ToDecimal(dr78["Price"]);
                }
                con.Close();
                decimal dSum = Convert.ToDecimal(sum);

                total_count = Decimal.Multiply(dSum, s78);

                total_count = Math.Round(total_count, 2);

                //tx_s_78.Text = sum.ToString();
                //Tx_a_78.Text = total_count.ToString();

            }


            Total_amt.Text = total_count.ToString();


            string sqlQuery2 = "Select SUM(Count) as total FROM [NTS_Textile].[dbo].[Winding_daily_entry] where Emp_name='" + CB_emp_name_winding.Text + "'";
            SqlCommand objCommand_tot = new SqlCommand(sqlQuery2, con);

            con.Open();
            SqlDataReader drtot;
            drtot = objCommand_tot.ExecuteReader();
            while (drtot.Read())
            {
                Total_piece.Text = drtot["total"].ToString();
            }

        }

        private void Winding_calculation_view_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            Back_btn.Hide();
            kryptonButton1.Hide();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Emp_name_eng,Emp_id FROM [NTS_Textile].[dbo].[Winding_emp] ORDER BY Emp_id ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            CB_emp_name_winding.DataSource = dt;
            CB_emp_name_winding.DisplayMember = "Emp_name_eng";
            CB_emp_name_winding.SelectedIndex = -1;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
//this.Show();
            panel5.Show();
            panel2.Hide();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = panelprint1.CreateGraphics();
            Size s = panelprint1.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, panelprint1.ClientRectangle.Width, panelprint1.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Back_btn.Hide();
            kryptonButton1.Hide();

            CaptureScreen();
            PrinterSettings ps = new PrinterSettings();
            ps.Copies = 2;
            IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
            PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4);
            printDocument1.DefaultPageSettings.PaperSize = sizeA4;
            printPreviewDialog1.ShowDialog();

            Close();
        }
    }
}
