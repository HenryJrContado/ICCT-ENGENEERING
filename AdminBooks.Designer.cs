namespace ICCT_ENGENEERING
{
    partial class AdminBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBooks));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Box1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle44;
            this.dgv1.Location = new System.Drawing.Point(676, 132);
            this.dgv1.Name = "dgv1";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(923, 610);
            this.dgv1.TabIndex = 10;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.Color.Transparent;
            this.Box1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Box1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Box1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Box1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Box1.ItemHeight = 30;
            this.Box1.Items.AddRange(new object[] {
            "AVAILABLE",
            "NOT AVAILABLE"});
            this.Box1.Location = new System.Drawing.Point(171, 450);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(346, 36);
            this.Box1.TabIndex = 56;
            this.Box1.SelectedIndexChanged += new System.EventHandler(this.Box1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 57;
            this.label6.Text = "STATUS";
            // 
            // TextBox2
            // 
            this.TextBox2.BorderColor = System.Drawing.Color.Black;
            this.TextBox2.BorderThickness = 2;
            this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2.DefaultText = "";
            this.TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.ForeColor = System.Drawing.Color.Black;
            this.TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.Location = new System.Drawing.Point(171, 371);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '\0';
            this.TextBox2.PlaceholderText = "ENTER  AUTHOR";
            this.TextBox2.SelectedText = "";
            this.TextBox2.Size = new System.Drawing.Size(346, 35);
            this.TextBox2.TabIndex = 58;
            // 
            // TextBox1
            // 
            this.TextBox1.BorderColor = System.Drawing.Color.Black;
            this.TextBox1.BorderThickness = 2;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DefaultText = "";
            this.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.Black;
            this.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.Location = new System.Drawing.Point(171, 292);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderText = "ENTER  BOOKS NAMES";
            this.TextBox1.SelectedText = "";
            this.TextBox1.Size = new System.Drawing.Size(346, 35);
            this.TextBox1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 60;
            this.label1.Text = "AUTHOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 61;
            this.label2.Text = "BOOKS";
            // 
            // guna2Button9
            // 
            this.guna2Button9.BorderRadius = 12;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.Blue;
            this.guna2Button9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Location = new System.Drawing.Point(171, 517);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(156, 45);
            this.guna2Button9.TabIndex = 62;
            this.guna2Button9.Text = "ADD";
            this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
            this.guna2Button9.MouseEnter += new System.EventHandler(this.guna2Button9_MouseEnter);
            this.guna2Button9.MouseLeave += new System.EventHandler(this.guna2Button9_MouseLeave);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 12;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Blue;
            this.guna2Button3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(361, 517);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(156, 45);
            this.guna2Button3.TabIndex = 63;
            this.guna2Button3.Text = "RESET";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            this.guna2Button3.MouseEnter += new System.EventHandler(this.guna2Button3_MouseEnter);
            this.guna2Button3.MouseLeave += new System.EventHandler(this.guna2Button3_MouseLeave);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button5.BorderRadius = 12;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Blue;
            this.guna2Button5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(676, 748);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(152, 45);
            this.guna2Button5.TabIndex = 64;
            this.guna2Button5.Text = "UPDATE";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            this.guna2Button5.MouseEnter += new System.EventHandler(this.guna2Button5_MouseEnter);
            this.guna2Button5.MouseLeave += new System.EventHandler(this.guna2Button5_MouseLeave);
            // 
            // guna2Button6
            // 
            this.guna2Button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button6.BorderRadius = 12;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Blue;
            this.guna2Button6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(867, 748);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(152, 45);
            this.guna2Button6.TabIndex = 65;
            this.guna2Button6.Text = "DELETE";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            this.guna2Button6.MouseEnter += new System.EventHandler(this.guna2Button6_MouseEnter);
            this.guna2Button6.MouseLeave += new System.EventHandler(this.guna2Button6_MouseLeave);
            // 
            // guna2Button7
            // 
            this.guna2Button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button7.BorderRadius = 12;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.Blue;
            this.guna2Button7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Location = new System.Drawing.Point(1056, 748);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(186, 45);
            this.guna2Button7.TabIndex = 66;
            this.guna2Button7.Text = "REFRESH";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            this.guna2Button7.MouseEnter += new System.EventHandler(this.guna2Button7_MouseEnter);
            this.guna2Button7.MouseLeave += new System.EventHandler(this.guna2Button7_MouseLeave);
            // 
            // guna2Button8
            // 
            this.guna2Button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button8.BorderRadius = 12;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Blue;
            this.guna2Button8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Location = new System.Drawing.Point(676, 71);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(129, 45);
            this.guna2Button8.TabIndex = 67;
            this.guna2Button8.Text = "RESET";
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            this.guna2Button8.MouseEnter += new System.EventHandler(this.guna2Button8_MouseEnter);
            this.guna2Button8.MouseLeave += new System.EventHandler(this.guna2Button8_MouseLeave);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button4.BorderRadius = 12;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Blue;
            this.guna2Button4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(820, 71);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(169, 45);
            this.guna2Button4.TabIndex = 68;
            this.guna2Button4.Text = "SEARCH";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            this.guna2Button4.MouseEnter += new System.EventHandler(this.guna2Button4_MouseEnter);
            this.guna2Button4.MouseLeave += new System.EventHandler(this.guna2Button4_MouseLeave);
            // 
            // TextBox3
            // 
            this.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox3.BorderColor = System.Drawing.Color.Black;
            this.TextBox3.BorderThickness = 2;
            this.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox3.DefaultText = "";
            this.TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.ForeColor = System.Drawing.Color.Black;
            this.TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox3.IconLeft")));
            this.TextBox3.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TextBox3.Location = new System.Drawing.Point(1014, 71);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.PasswordChar = '\0';
            this.TextBox3.PlaceholderText = " BOOKS NAME";
            this.TextBox3.SelectedText = "";
            this.TextBox3.Size = new System.Drawing.Size(390, 45);
            this.TextBox3.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // AdminBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.dgv1);
            this.Name = "AdminBooks";
            this.Size = new System.Drawing.Size(1973, 828);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private Guna.UI2.WinForms.Guna2ComboBox Box1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
