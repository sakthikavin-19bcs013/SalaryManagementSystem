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
    public partial class Welcome_page : Form
    {
        public Welcome_page()
        {
            InitializeComponent();
            customizeddesign();
        }
        
        private void minimized_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void customizeddesign()
        {
            panel_winding.Visible = false;
            panel_weaving.Visible = false;
            panel_new_emp.Visible = false;
            panel_salary_rate.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panel_winding.Visible == true)
                panel_winding.Visible = false;
            if (panel_weaving.Visible == true)
                panel_weaving.Visible = false;
            if (panel_new_emp.Visible == true)
                panel_new_emp.Visible = false;
            if (panel_salary_rate.Visible == true)
                panel_salary_rate.Visible = false;
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void weaving_main_button_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_weaving);

        }

        private void Weaving_entry_btn_Click(object sender, EventArgs e)
        {
            openchildform(new Weaving_Entry());
            hidesubmenu();
        }

        private void Weaving_cal_btn_Click(object sender, EventArgs e)
        {
            openchildform(new Weaving_calculation_view());
            hidesubmenu();
        }
        private void weavingview_bt_Click(object sender, EventArgs e)
        {
            openchildform(new Weaving_calculation());
            hidesubmenu();
        }
        private void Winding_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_winding);
        }

        private void Winding_entry_btn_Click(object sender, EventArgs e)
        {
            openchildform(new Winding_Entry());
            hidesubmenu();
        }

        private void Winding_cal_btn_Click(object sender, EventArgs e)
        {
            openchildform(new Winding_calculation_view());
            hidesubmenu();
        }
  
        private void stock_btn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void stock_view_btn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void new_emp_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_new_emp);
        }

        private void Weaving_new_emp_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void Winding_new_emp_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
        private Form activeForm = null;
        private void openchildform(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.None;
            panelchild.Controls.Add(childform);
            panelchild.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void salary_bt_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_salary_rate);
        }

        private void weaving_salary_bt_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void Winding_salary_bt_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

       
    }
}
