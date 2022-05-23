namespace Powerloom_salary_management
{
    partial class Welcome_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.minimized_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_side_Menu = new System.Windows.Forms.Panel();
            this.panel_salary_rate = new System.Windows.Forms.Panel();
            this.Winding_salary_bt = new System.Windows.Forms.Button();
            this.weaving_salary_bt = new System.Windows.Forms.Button();
            this.salary_bt = new System.Windows.Forms.Button();
            this.panel_new_emp = new System.Windows.Forms.Panel();
            this.Winding_new_emp = new System.Windows.Forms.Button();
            this.Weaving_new_emp = new System.Windows.Forms.Button();
            this.new_emp_btn = new System.Windows.Forms.Button();
            this.panel_winding = new System.Windows.Forms.Panel();
            this.stock_view_btn = new System.Windows.Forms.Button();
            this.stock_btn = new System.Windows.Forms.Button();
            this.Winding_cal_btn = new System.Windows.Forms.Button();
            this.Winding_entry_btn = new System.Windows.Forms.Button();
            this.Winding_btn = new System.Windows.Forms.Button();
            this.panel_weaving = new System.Windows.Forms.Panel();
            this.weavingview_bt = new System.Windows.Forms.Button();
            this.Weaving_cal_btn = new System.Windows.Forms.Button();
            this.Weaving_entry_btn = new System.Windows.Forms.Button();
            this.weaving_main_button = new System.Windows.Forms.Button();
            this.panelchild = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimized_btn)).BeginInit();
            this.panel_side_Menu.SuspendLayout();
            this.panel_salary_rate.SuspendLayout();
            this.panel_new_emp.SuspendLayout();
            this.panel_winding.SuspendLayout();
            this.panel_weaving.SuspendLayout();
            this.panelchild.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.minimized_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 29);
            this.panel1.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.Image = global::Powerloom_salary_management.Properties.Resources.icons8_close_96;
            this.close_btn.Location = new System.Drawing.Point(968, 5);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(20, 18);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 3;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // minimized_btn
            // 
            this.minimized_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimized_btn.Image = global::Powerloom_salary_management.Properties.Resources.icons8_subtract_96;
            this.minimized_btn.Location = new System.Drawing.Point(935, 5);
            this.minimized_btn.Name = "minimized_btn";
            this.minimized_btn.Size = new System.Drawing.Size(20, 18);
            this.minimized_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimized_btn.TabIndex = 1;
            this.minimized_btn.TabStop = false;
            this.minimized_btn.Click += new System.EventHandler(this.minimized_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "NTS Textile";
            // 
            // panel_side_Menu
            // 
            this.panel_side_Menu.AutoScroll = true;
            this.panel_side_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(22)))));
            this.panel_side_Menu.Controls.Add(this.panel_salary_rate);
            this.panel_side_Menu.Controls.Add(this.salary_bt);
            this.panel_side_Menu.Controls.Add(this.panel_new_emp);
            this.panel_side_Menu.Controls.Add(this.new_emp_btn);
            this.panel_side_Menu.Controls.Add(this.panel_winding);
            this.panel_side_Menu.Controls.Add(this.Winding_btn);
            this.panel_side_Menu.Controls.Add(this.panel_weaving);
            this.panel_side_Menu.Controls.Add(this.weaving_main_button);
            this.panel_side_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side_Menu.Location = new System.Drawing.Point(0, 29);
            this.panel_side_Menu.Name = "panel_side_Menu";
            this.panel_side_Menu.Size = new System.Drawing.Size(200, 601);
            this.panel_side_Menu.TabIndex = 1;
            // 
            // panel_salary_rate
            // 
            this.panel_salary_rate.Controls.Add(this.Winding_salary_bt);
            this.panel_salary_rate.Controls.Add(this.weaving_salary_bt);
            this.panel_salary_rate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_salary_rate.Location = new System.Drawing.Point(0, 472);
            this.panel_salary_rate.Name = "panel_salary_rate";
            this.panel_salary_rate.Size = new System.Drawing.Size(200, 79);
            this.panel_salary_rate.TabIndex = 8;
            // 
            // Winding_salary_bt
            // 
            this.Winding_salary_bt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Winding_salary_bt.FlatAppearance.BorderSize = 0;
            this.Winding_salary_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.Winding_salary_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Winding_salary_bt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winding_salary_bt.ForeColor = System.Drawing.Color.White;
            this.Winding_salary_bt.Location = new System.Drawing.Point(0, 35);
            this.Winding_salary_bt.Name = "Winding_salary_bt";
            this.Winding_salary_bt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Winding_salary_bt.Size = new System.Drawing.Size(200, 35);
            this.Winding_salary_bt.TabIndex = 1;
            this.Winding_salary_bt.Text = "Winding";
            this.Winding_salary_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Winding_salary_bt.UseVisualStyleBackColor = true;
            this.Winding_salary_bt.Visible = false;
            this.Winding_salary_bt.Click += new System.EventHandler(this.Winding_salary_bt_Click);
            // 
            // weaving_salary_bt
            // 
            this.weaving_salary_bt.Dock = System.Windows.Forms.DockStyle.Top;
            this.weaving_salary_bt.FlatAppearance.BorderSize = 0;
            this.weaving_salary_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.weaving_salary_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weaving_salary_bt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaving_salary_bt.ForeColor = System.Drawing.Color.White;
            this.weaving_salary_bt.Location = new System.Drawing.Point(0, 0);
            this.weaving_salary_bt.Name = "weaving_salary_bt";
            this.weaving_salary_bt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.weaving_salary_bt.Size = new System.Drawing.Size(200, 35);
            this.weaving_salary_bt.TabIndex = 0;
            this.weaving_salary_bt.Text = "Weaving";
            this.weaving_salary_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weaving_salary_bt.UseVisualStyleBackColor = true;
            this.weaving_salary_bt.Visible = false;
            this.weaving_salary_bt.Click += new System.EventHandler(this.weaving_salary_bt_Click);
            // 
            // salary_bt
            // 
            this.salary_bt.Dock = System.Windows.Forms.DockStyle.Top;
            this.salary_bt.FlatAppearance.BorderSize = 0;
            this.salary_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.salary_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_bt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_bt.ForeColor = System.Drawing.Color.White;
            this.salary_bt.Location = new System.Drawing.Point(0, 437);
            this.salary_bt.Name = "salary_bt";
            this.salary_bt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.salary_bt.Size = new System.Drawing.Size(200, 35);
            this.salary_bt.TabIndex = 7;
            this.salary_bt.Text = "Salary Rate";
            this.salary_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salary_bt.UseVisualStyleBackColor = true;
            this.salary_bt.Visible = false;
            this.salary_bt.Click += new System.EventHandler(this.salary_bt_Click);
            // 
            // panel_new_emp
            // 
            this.panel_new_emp.Controls.Add(this.Winding_new_emp);
            this.panel_new_emp.Controls.Add(this.Weaving_new_emp);
            this.panel_new_emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_new_emp.Location = new System.Drawing.Point(0, 358);
            this.panel_new_emp.Name = "panel_new_emp";
            this.panel_new_emp.Size = new System.Drawing.Size(200, 79);
            this.panel_new_emp.TabIndex = 6;
            // 
            // Winding_new_emp
            // 
            this.Winding_new_emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Winding_new_emp.FlatAppearance.BorderSize = 0;
            this.Winding_new_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.Winding_new_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Winding_new_emp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winding_new_emp.ForeColor = System.Drawing.Color.White;
            this.Winding_new_emp.Location = new System.Drawing.Point(0, 35);
            this.Winding_new_emp.Name = "Winding_new_emp";
            this.Winding_new_emp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Winding_new_emp.Size = new System.Drawing.Size(200, 35);
            this.Winding_new_emp.TabIndex = 1;
            this.Winding_new_emp.Text = "Winding";
            this.Winding_new_emp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Winding_new_emp.UseVisualStyleBackColor = true;
            this.Winding_new_emp.Visible = false;
            this.Winding_new_emp.Click += new System.EventHandler(this.Winding_new_emp_Click);
            // 
            // Weaving_new_emp
            // 
            this.Weaving_new_emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Weaving_new_emp.FlatAppearance.BorderSize = 0;
            this.Weaving_new_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.Weaving_new_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Weaving_new_emp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weaving_new_emp.ForeColor = System.Drawing.Color.White;
            this.Weaving_new_emp.Location = new System.Drawing.Point(0, 0);
            this.Weaving_new_emp.Name = "Weaving_new_emp";
            this.Weaving_new_emp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Weaving_new_emp.Size = new System.Drawing.Size(200, 35);
            this.Weaving_new_emp.TabIndex = 0;
            this.Weaving_new_emp.Text = "Weaving";
            this.Weaving_new_emp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Weaving_new_emp.UseVisualStyleBackColor = true;
            this.Weaving_new_emp.Visible = false;
            this.Weaving_new_emp.Click += new System.EventHandler(this.Weaving_new_emp_Click);
            // 
            // new_emp_btn
            // 
            this.new_emp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.new_emp_btn.FlatAppearance.BorderSize = 0;
            this.new_emp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.new_emp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_emp_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_emp_btn.ForeColor = System.Drawing.Color.White;
            this.new_emp_btn.Location = new System.Drawing.Point(0, 323);
            this.new_emp_btn.Name = "new_emp_btn";
            this.new_emp_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.new_emp_btn.Size = new System.Drawing.Size(200, 35);
            this.new_emp_btn.TabIndex = 5;
            this.new_emp_btn.Text = "New Employee";
            this.new_emp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_emp_btn.UseVisualStyleBackColor = true;
            this.new_emp_btn.Visible = false;
            this.new_emp_btn.Click += new System.EventHandler(this.new_emp_btn_Click);
            // 
            // panel_winding
            // 
            this.panel_winding.Controls.Add(this.stock_view_btn);
            this.panel_winding.Controls.Add(this.stock_btn);
            this.panel_winding.Controls.Add(this.Winding_cal_btn);
            this.panel_winding.Controls.Add(this.Winding_entry_btn);
            this.panel_winding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_winding.Location = new System.Drawing.Point(0, 178);
            this.panel_winding.Name = "panel_winding";
            this.panel_winding.Size = new System.Drawing.Size(200, 145);
            this.panel_winding.TabIndex = 4;
            // 
            // stock_view_btn
            // 
            this.stock_view_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stock_view_btn.FlatAppearance.BorderSize = 0;
            this.stock_view_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.stock_view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_view_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_view_btn.ForeColor = System.Drawing.Color.White;
            this.stock_view_btn.Location = new System.Drawing.Point(0, 105);
            this.stock_view_btn.Name = "stock_view_btn";
            this.stock_view_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.stock_view_btn.Size = new System.Drawing.Size(200, 35);
            this.stock_view_btn.TabIndex = 3;
            this.stock_view_btn.Text = "Stock View";
            this.stock_view_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stock_view_btn.UseVisualStyleBackColor = true;
            this.stock_view_btn.Visible = false;
            this.stock_view_btn.Click += new System.EventHandler(this.stock_view_btn_Click);
            // 
            // stock_btn
            // 
            this.stock_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stock_btn.FlatAppearance.BorderSize = 0;
            this.stock_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.stock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_btn.ForeColor = System.Drawing.Color.White;
            this.stock_btn.Location = new System.Drawing.Point(0, 70);
            this.stock_btn.Name = "stock_btn";
            this.stock_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.stock_btn.Size = new System.Drawing.Size(200, 35);
            this.stock_btn.TabIndex = 2;
            this.stock_btn.Text = "Stock Entry";
            this.stock_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stock_btn.UseVisualStyleBackColor = true;
            this.stock_btn.Visible = false;
            this.stock_btn.Click += new System.EventHandler(this.stock_btn_Click);
            // 
            // Winding_cal_btn
            // 
            this.Winding_cal_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Winding_cal_btn.FlatAppearance.BorderSize = 0;
            this.Winding_cal_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.Winding_cal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Winding_cal_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winding_cal_btn.ForeColor = System.Drawing.Color.White;
            this.Winding_cal_btn.Location = new System.Drawing.Point(0, 35);
            this.Winding_cal_btn.Name = "Winding_cal_btn";
            this.Winding_cal_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Winding_cal_btn.Size = new System.Drawing.Size(200, 35);
            this.Winding_cal_btn.TabIndex = 1;
            this.Winding_cal_btn.Text = "Winding Calculation";
            this.Winding_cal_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Winding_cal_btn.UseVisualStyleBackColor = true;
            this.Winding_cal_btn.Click += new System.EventHandler(this.Winding_cal_btn_Click);
            // 
            // Winding_entry_btn
            // 
            this.Winding_entry_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Winding_entry_btn.FlatAppearance.BorderSize = 0;
            this.Winding_entry_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.Winding_entry_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Winding_entry_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winding_entry_btn.ForeColor = System.Drawing.Color.White;
            this.Winding_entry_btn.Location = new System.Drawing.Point(0, 0);
            this.Winding_entry_btn.Name = "Winding_entry_btn";
            this.Winding_entry_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Winding_entry_btn.Size = new System.Drawing.Size(200, 35);
            this.Winding_entry_btn.TabIndex = 0;
            this.Winding_entry_btn.Text = "Winding Entry";
            this.Winding_entry_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Winding_entry_btn.UseVisualStyleBackColor = true;
            this.Winding_entry_btn.Click += new System.EventHandler(this.Winding_entry_btn_Click);
            // 
            // Winding_btn
            // 
            this.Winding_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Winding_btn.FlatAppearance.BorderSize = 0;
            this.Winding_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.Winding_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Winding_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winding_btn.ForeColor = System.Drawing.Color.White;
            this.Winding_btn.Location = new System.Drawing.Point(0, 143);
            this.Winding_btn.Name = "Winding_btn";
            this.Winding_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Winding_btn.Size = new System.Drawing.Size(200, 35);
            this.Winding_btn.TabIndex = 3;
            this.Winding_btn.Text = "Winding";
            this.Winding_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Winding_btn.UseVisualStyleBackColor = true;
            this.Winding_btn.Click += new System.EventHandler(this.Winding_btn_Click);
            // 
            // panel_weaving
            // 
            this.panel_weaving.Controls.Add(this.weavingview_bt);
            this.panel_weaving.Controls.Add(this.Weaving_cal_btn);
            this.panel_weaving.Controls.Add(this.Weaving_entry_btn);
            this.panel_weaving.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_weaving.Location = new System.Drawing.Point(0, 35);
            this.panel_weaving.Name = "panel_weaving";
            this.panel_weaving.Size = new System.Drawing.Size(200, 108);
            this.panel_weaving.TabIndex = 2;
            // 
            // weavingview_bt
            // 
            this.weavingview_bt.Dock = System.Windows.Forms.DockStyle.Top;
            this.weavingview_bt.FlatAppearance.BorderSize = 0;
            this.weavingview_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.weavingview_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weavingview_bt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weavingview_bt.ForeColor = System.Drawing.Color.White;
            this.weavingview_bt.Location = new System.Drawing.Point(0, 70);
            this.weavingview_bt.Name = "weavingview_bt";
            this.weavingview_bt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.weavingview_bt.Size = new System.Drawing.Size(200, 35);
            this.weavingview_bt.TabIndex = 2;
            this.weavingview_bt.Text = "Weaving View";
            this.weavingview_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weavingview_bt.UseVisualStyleBackColor = true;
            this.weavingview_bt.Click += new System.EventHandler(this.weavingview_bt_Click);
            // 
            // Weaving_cal_btn
            // 
            this.Weaving_cal_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Weaving_cal_btn.FlatAppearance.BorderSize = 0;
            this.Weaving_cal_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.Weaving_cal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Weaving_cal_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weaving_cal_btn.ForeColor = System.Drawing.Color.White;
            this.Weaving_cal_btn.Location = new System.Drawing.Point(0, 35);
            this.Weaving_cal_btn.Name = "Weaving_cal_btn";
            this.Weaving_cal_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Weaving_cal_btn.Size = new System.Drawing.Size(200, 35);
            this.Weaving_cal_btn.TabIndex = 1;
            this.Weaving_cal_btn.Text = "Weaving Calculation";
            this.Weaving_cal_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Weaving_cal_btn.UseVisualStyleBackColor = true;
            this.Weaving_cal_btn.Click += new System.EventHandler(this.Weaving_cal_btn_Click);
            // 
            // Weaving_entry_btn
            // 
            this.Weaving_entry_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Weaving_entry_btn.FlatAppearance.BorderSize = 0;
            this.Weaving_entry_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.Weaving_entry_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Weaving_entry_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weaving_entry_btn.ForeColor = System.Drawing.Color.White;
            this.Weaving_entry_btn.Location = new System.Drawing.Point(0, 0);
            this.Weaving_entry_btn.Name = "Weaving_entry_btn";
            this.Weaving_entry_btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Weaving_entry_btn.Size = new System.Drawing.Size(200, 35);
            this.Weaving_entry_btn.TabIndex = 0;
            this.Weaving_entry_btn.Text = "Weaving Entry";
            this.Weaving_entry_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Weaving_entry_btn.UseVisualStyleBackColor = true;
            this.Weaving_entry_btn.Click += new System.EventHandler(this.Weaving_entry_btn_Click);
            // 
            // weaving_main_button
            // 
            this.weaving_main_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.weaving_main_button.FlatAppearance.BorderSize = 0;
            this.weaving_main_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.weaving_main_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weaving_main_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaving_main_button.ForeColor = System.Drawing.Color.White;
            this.weaving_main_button.Location = new System.Drawing.Point(0, 0);
            this.weaving_main_button.Name = "weaving_main_button";
            this.weaving_main_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.weaving_main_button.Size = new System.Drawing.Size(200, 35);
            this.weaving_main_button.TabIndex = 0;
            this.weaving_main_button.Text = "Weaving";
            this.weaving_main_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weaving_main_button.UseVisualStyleBackColor = true;
            this.weaving_main_button.Click += new System.EventHandler(this.weaving_main_button_Click);
            // 
            // panelchild
            // 
            this.panelchild.BackColor = System.Drawing.Color.Black;
            this.panelchild.Controls.Add(this.label2);
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.Location = new System.Drawing.Point(200, 29);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(800, 601);
            this.panelchild.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "NTS Textile";
            // 
            // Welcome_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.panelchild);
            this.Controls.Add(this.panel_side_Menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome_page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimized_btn)).EndInit();
            this.panel_side_Menu.ResumeLayout(false);
            this.panel_salary_rate.ResumeLayout(false);
            this.panel_new_emp.ResumeLayout(false);
            this.panel_winding.ResumeLayout(false);
            this.panel_weaving.ResumeLayout(false);
            this.panelchild.ResumeLayout(false);
            this.panelchild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox minimized_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Panel panel_side_Menu;
        private System.Windows.Forms.Button weaving_main_button;
        private System.Windows.Forms.Panel panel_weaving;
        private System.Windows.Forms.Button Weaving_entry_btn;
        private System.Windows.Forms.Panel panel_new_emp;
        private System.Windows.Forms.Button Winding_new_emp;
        private System.Windows.Forms.Button Weaving_new_emp;
        private System.Windows.Forms.Button new_emp_btn;
        private System.Windows.Forms.Panel panel_winding;
        private System.Windows.Forms.Button stock_view_btn;
        private System.Windows.Forms.Button stock_btn;
        private System.Windows.Forms.Button Winding_cal_btn;
        private System.Windows.Forms.Button Winding_entry_btn;
        private System.Windows.Forms.Button Winding_btn;
        private System.Windows.Forms.Button Weaving_cal_btn;
        private System.Windows.Forms.Panel panelchild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_salary_rate;
        private System.Windows.Forms.Button Winding_salary_bt;
        private System.Windows.Forms.Button weaving_salary_bt;
        private System.Windows.Forms.Button salary_bt;
        private System.Windows.Forms.Button weavingview_bt;
    }
}