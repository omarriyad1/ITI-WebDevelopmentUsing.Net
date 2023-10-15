namespace WinFormsApp1
{
    partial class add_btn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GV = new DataGridView();
            Search_box = new TextBox();
            Search_btn = new Button();
            reset_btn = new Button();
            id_box = new TextBox();
            name_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            add_box = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            addd_btn = new Button();
            label4 = new Label();
            status_txt = new Label();
            addd_txt = new Label();
            label5 = new Label();
            dept_box = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GV).BeginInit();
            SuspendLayout();
            // 
            // GV
            // 
            GV.BackgroundColor = SystemColors.ButtonFace;
            GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV.GridColor = SystemColors.Menu;
            GV.Location = new Point(46, 28);
            GV.Name = "GV";
            GV.RowHeadersWidth = 51;
            GV.RowTemplate.Height = 29;
            GV.Size = new Size(418, 410);
            GV.TabIndex = 0;
            GV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Search_box
            // 
            Search_box.ForeColor = Color.Olive;
            Search_box.Location = new Point(520, 28);
            Search_box.Multiline = true;
            Search_box.Name = "Search_box";
            Search_box.RightToLeft = RightToLeft.No;
            Search_box.Size = new Size(255, 27);
            Search_box.TabIndex = 1;
            Search_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Search_btn
            // 
            Search_btn.BackColor = SystemColors.InactiveBorder;
            Search_btn.ForeColor = Color.Olive;
            Search_btn.Location = new Point(544, 61);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(94, 29);
            Search_btn.TabIndex = 2;
            Search_btn.Text = "Search";
            Search_btn.TextAlign = ContentAlignment.TopCenter;
            Search_btn.UseVisualStyleBackColor = false;
            Search_btn.Click += button1_Click;
            // 
            // reset_btn
            // 
            reset_btn.ForeColor = Color.Olive;
            reset_btn.Location = new Point(653, 61);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(94, 29);
            reset_btn.TabIndex = 3;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // id_box
            // 
            id_box.Location = new Point(605, 131);
            id_box.Name = "id_box";
            id_box.Size = new Size(170, 27);
            id_box.TabIndex = 4;
            // 
            // name_box
            // 
            name_box.Location = new Point(605, 185);
            name_box.Name = "name_box";
            name_box.Size = new Size(170, 27);
            name_box.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(495, 134);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 8;
            label1.Text = "National ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(513, 188);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(513, 244);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 10;
            label3.Text = "Address";
            // 
            // add_box
            // 
            add_box.Location = new Point(605, 237);
            add_box.Name = "add_box";
            add_box.Size = new Size(170, 27);
            add_box.TabIndex = 11;
            // 
            // addd_btn
            // 
            addd_btn.Location = new Point(644, 332);
            addd_btn.Name = "addd_btn";
            addd_btn.Size = new Size(94, 29);
            addd_btn.TabIndex = 12;
            addd_btn.Text = "ADD";
            addd_btn.UseVisualStyleBackColor = true;
            addd_btn.Click += addd_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(540, 296);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 13;
            // 
            // status_txt
            // 
            status_txt.AutoSize = true;
            status_txt.ForeColor = Color.Red;
            status_txt.Location = new Point(563, 292);
            status_txt.Name = "status_txt";
            status_txt.Size = new Size(0, 20);
            status_txt.TabIndex = 14;
            // 
            // addd_txt
            // 
            addd_txt.AutoSize = true;
            addd_txt.ForeColor = Color.Red;
            addd_txt.Location = new Point(540, 341);
            addd_txt.Name = "addd_txt";
            addd_txt.Size = new Size(0, 20);
            addd_txt.TabIndex = 16;
            addd_txt.Click += addd_txt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(513, 292);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 17;
            label5.Text = "DeptID";
            // 
            // dept_box
            // 
            dept_box.FormattingEnabled = true;
            dept_box.Location = new Point(605, 293);
            dept_box.Name = "dept_box";
            dept_box.Size = new Size(170, 28);
            dept_box.TabIndex = 18;
            // 
            // add_btn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(dept_box);
            Controls.Add(label5);
            Controls.Add(addd_txt);
            Controls.Add(status_txt);
            Controls.Add(label4);
            Controls.Add(addd_btn);
            Controls.Add(add_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name_box);
            Controls.Add(id_box);
            Controls.Add(reset_btn);
            Controls.Add(Search_btn);
            Controls.Add(Search_box);
            Controls.Add(GV);
            ForeColor = Color.Olive;
            Name = "add_btn";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void addd_txt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dept_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void add_box_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView GV;
        private TextBox Search_box;
        private Button Search_btn;
        private Button reset_btn;
        private TextBox id_box;
        private TextBox name_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox add_box;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button addd_btn;
        private Label label4;
        private Label status_txt;
        private Label addd_txt;
        private Label label5;
        private ComboBox dept_box;
    }
}