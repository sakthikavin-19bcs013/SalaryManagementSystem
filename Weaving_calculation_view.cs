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
    public partial class Weaving_calculation_view : Form
    {
        
        public Weaving_calculation_view()
        {
            InitializeComponent();
           

        }
       

    private void Weaving_calculation_view_Load(object sender, EventArgs e)
    {
        panel6.Hide();
        //panel2.Hide();
        Back_btn.Hide();
        Print_btn.Hide();

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
        SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Emp_name_eng,Emp_id FROM Weaving_emp ORDER BY Emp_id ", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        CB_emp_name.DataSource = dt;
        CB_emp_name.DisplayMember = "Emp_name_eng";
        CB_emp_name.SelectedIndex = -1;     


    }
        
      
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void BT_sub_Click_1(object sender, EventArgs e)
        {

            if(CB_emp_name.Text!="")
            {
                panel5.Hide();
                panel6.Show();

                Back_btn.Show();
                Print_btn.Show();

                //  panel1.Hide();
                //panel2.Show();
                label9.Text = "NTS TEXTILES";

                label78.Visible = false;
                tx_s_78.Visible = false;
                label_amt_78.Visible = false;
                Tx_a_78.Visible = false;

                label85.Visible = false;
                Tx_s_85.Visible = false;
                labelamt_85.Visible = false;
                Tx_a_85.Visible = false;

                label90.Visible = false;
                Tx_s_90.Visible = false;
                label_amt_90.Visible = false;
                Tx_a_90.Visible = false;


                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGSB7TR\SQLEXPRESS;Initial Catalog=NTS_Textile;Integrated Security=True");
                string sqlQuery = "SELECT Emp_id,Emp_name_tam FROM Weaving_emp WHERE Emp_name_eng='" + CB_emp_name.Text + "'";
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

                SqlCommand cmd = new SqlCommand("SELECT Date,Day_tam,ISNULL([78],0)as [78],ISNULL([85],0) as[85],ISNULL([90],0) as[90] FROM(SELECT t3.Emp_name_tam, t1.Date, t2.Day_tam, t1.Size, t1.Total_piece FROM [NTS_Textile].[dbo].[Weaving_new_daily_entry] as t1  INNER JOIN [NTS_Textile].[dbo].[Week_days] as t2 on t1.Day = t2.Day_Eng INNER JOIN [NTS_Textile].[dbo].[Weaving_emp] as t3 on t1.Emp_name = t3.Emp_name_eng WHERE t1.Emp_name = '" + CB_emp_name.Text + "' AND t1.Date BETWEEN '" + fromdate + "' AND '" + todate + "') as SourceTable Pivot (SUM(Total_piece) for Size in([78],[85],[90]))as PivotTable ", con);
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                con.Close();
                kryptonDataGridView1.DataSource = dt1;

                kryptonDataGridView1.Rows[0].Cells[0].Selected = false;
                kryptonDataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
                Decimal sum = 0;
                Decimal sum2 = 0;
                Decimal sum3 = 0;


                for (int i = 0; i <= kryptonDataGridView1.Rows.Count - 1; i++)
                {
                    if (kryptonDataGridView1["78", i].Value != DBNull.Value)
                    {
                        sum += (Decimal)kryptonDataGridView1["78", i].Value;
                    }
                    if (kryptonDataGridView1["85", i].Value != DBNull.Value)
                    {
                        sum2 += (Decimal)kryptonDataGridView1["85", i].Value;
                    }
                    if (kryptonDataGridView1["90", i].Value != DBNull.Value)
                    {
                        sum3 += (Decimal)kryptonDataGridView1["90", i].Value;
                    }

                }
                dt1 = kryptonDataGridView1.DataSource as DataTable;
                DataRow row = dt1.NewRow();
                row[1] = "Total";
                row[2] = sum;
                row[3] = sum2;
                row[4] = sum3;
                dt1.Rows.Add(row);
                int lr = kryptonDataGridView1.Rows.Count - 1;

                kryptonDataGridView1.Rows[lr].DefaultCellStyle.BackColor = Color.OrangeRed;
                this.kryptonDataGridView1.Columns["78"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.kryptonDataGridView1.Columns["85"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.kryptonDataGridView1.Columns["90"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                Decimal total_78 = 0;
                Decimal total_85 = 0;
                Decimal total_90 = 0;

                if (sum != 0)
                {
                    label78.Visible = true;
                    tx_s_78.Visible = true;
                    label_amt_78.Visible = true;
                    Tx_a_78.Visible = true;

                    Decimal s78 = 0;

                    string sqlQuery78 = "SELECT Rate FROM [NTS_Textile].[dbo].[Price] Where Size='78'";
                    SqlCommand objCommand78 = new SqlCommand(sqlQuery78, con);
                    con.Open();
                    SqlDataReader dr78;
                    dr78 = objCommand78.ExecuteReader();
                    while (dr78.Read())
                    {
                        s78 = Convert.ToDecimal(dr78["Rate"]);
                    }
                    con.Close();
                    decimal dSum = Convert.ToDecimal(sum);

                    total_78 = Decimal.Multiply(dSum, s78);

                    total_78 = Math.Round(total_78, 2);
                    tx_s_78.Text = sum.ToString();
                    Tx_a_78.Text = total_78.ToString();

                }


                if (sum2 != 0)
                {
                    label85.Visible = true;
                    Tx_s_85.Visible = true;
                    labelamt_85.Visible = true;
                    Tx_a_85.Visible = true;

                    Decimal s85 = 0;

                    string sqlQuery85 = "SELECT Rate FROM [NTS_Textile].[dbo].[Price] Where Size='85'";
                    SqlCommand objCommand85 = new SqlCommand(sqlQuery85, con);
                    con.Open();
                    SqlDataReader dr85;
                    dr85 = objCommand85.ExecuteReader();
                    while (dr85.Read())
                    {
                        s85 = Convert.ToDecimal(dr85["Rate"]);
                    }
                    con.Close();
                    decimal dSum2 = Convert.ToDecimal(sum2);

                    total_85 = Decimal.Multiply(dSum2, s85);

                    total_85 = Math.Round(total_85, 2);
                    Tx_s_85.Text = sum2.ToString();
                    Tx_a_85.Text = total_85.ToString();

                }


                if (sum3 != 0)
                {
                    label90.Visible = true;
                    Tx_s_90.Visible = true;
                    label_amt_90.Visible = true;
                    Tx_a_90.Visible = true;

                    Decimal s90 = 0;

                    string sqlQuery90 = "SELECT Rate FROM [NTS_Textile].[dbo].[Price] Where Size='90'";
                    SqlCommand objCommand90 = new SqlCommand(sqlQuery90, con);
                    con.Open();
                    SqlDataReader dr90;
                    dr90 = objCommand90.ExecuteReader();
                    while (dr90.Read())
                    {
                        s90 = Convert.ToDecimal(dr90["Rate"]);
                    }
                    con.Close();
                    decimal dSum3 = Convert.ToDecimal(sum3);

                    total_90 = Decimal.Multiply(dSum3, s90);

                    total_90 = Math.Round(total_90, 2);
                    Tx_s_90.Text = sum3.ToString();
                    Tx_a_90.Text = total_90.ToString();

                }


                decimal full_total = 0;
                full_total = decimal.Add(total_78, total_85);
                full_total = decimal.Add(full_total, total_90);

                Total_amt.Text = full_total.ToString();


                string sqlQuery2 = "Select SUM(Total_piece) as total FROM [NTS_Textile].[dbo].[Weaving_new_daily_entry] where Emp_name='" + CB_emp_name.Text + "'";
                SqlCommand objCommand_tot = new SqlCommand(sqlQuery2, con);

                con.Open();
                SqlDataReader drtot;
                drtot = objCommand_tot.ExecuteReader();
                while (drtot.Read())
                {
                    Total_piece.Text = drtot["total"].ToString();
                }
            }
            else
            {
                Invalid_msg m = new Invalid_msg("Pick Employee Name");
                m.Show();
            }

        }

        private void Back_btn_Click_1(object sender, EventArgs e)
        {
            panel6.Hide();
            panel5.Show();
           
        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = panelPrint.CreateGraphics();
            Size s = panelPrint.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, panelPrint.ClientRectangle.Width, panelPrint.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }


        private void Print_btn_Click_1(object sender, EventArgs e)
        {
            Back_btn.Hide();
            Print_btn.Hide();

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



