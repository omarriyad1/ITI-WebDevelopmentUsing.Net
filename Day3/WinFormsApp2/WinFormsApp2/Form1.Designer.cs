namespace WinFormsApp2
{
    partial class Form1
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
            srch_btn = new Button();
            reset_btn = new Button();
            name_box = new TextBox();
            age_box = new TextBox();
            tbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            id_box = new TextBox();
            label4 = new Label();
            addd_btn = new Button();
            addd_txt = new Label();
            ((System.ComponentModel.ISupportInitialize)GV).BeginInit();
            SuspendLayout();
            // 
            // GV
            // 
            GV.BackgroundColor = SystemColors.ButtonFace;
            GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV.Location = new Point(38, 51);
            GV.Name = "GV";
            GV.RowHeadersWidth = 51;
            GV.RowTemplate.Height = 29;
            GV.Size = new Size(300, 374);
            GV.TabIndex = 0;
            GV.CellContentClick += GV_CellContentClick;
            // 
            // Search_box
            // 
            Search_box.Location = new Point(418, 75);
            Search_box.Name = "Search_box";
            Search_box.Size = new Size(197, 27);
            Search_box.TabIndex = 1;
            // 
            // srch_btn
            // 
            srch_btn.ForeColor = Color.CadetBlue;
            srch_btn.Location = new Point(418, 134);
            srch_btn.Name = "srch_btn";
            srch_btn.Size = new Size(92, 30);
            srch_btn.TabIndex = 2;
            srch_btn.Text = "Search";
            srch_btn.UseVisualStyleBackColor = true;
            srch_btn.Click += srch_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.ForeColor = Color.CadetBlue;
            reset_btn.Location = new Point(524, 134);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(91, 29);
            reset_btn.TabIndex = 3;
            reset_btn.Text = "reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += button2_Click;
            // 
            // name_box
            // 
            name_box.Location = new Point(463, 236);
            name_box.Name = "name_box";
            name_box.Size = new Size(125, 27);
            name_box.TabIndex = 4;
            // 
            // age_box
            // 
            age_box.Location = new Point(463, 280);
            age_box.Name = "age_box";
            age_box.Size = new Size(125, 27);
            age_box.TabIndex = 5;
            // 
            // tbox
            // 
            tbox.Location = new Point(463, 327);
            tbox.Name = "tbox";
            tbox.Size = new Size(125, 27);
            tbox.TabIndex = 6;
            tbox.TextChanged += tbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(362, 280);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 7;
            label1.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(355, 239);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(361, 330);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Track_id";
            // 
            // id_box
            // 
            id_box.Location = new Point(463, 195);
            id_box.Name = "id_box";
            id_box.Size = new Size(125, 27);
            id_box.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(355, 202);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 11;
            label4.Text = "National_ID";
            // 
            // addd_btn
            // 
            addd_btn.Location = new Point(479, 381);
            addd_btn.Name = "addd_btn";
            addd_btn.Size = new Size(94, 29);
            addd_btn.TabIndex = 12;
            addd_btn.Text = "ADD";
            addd_btn.UseVisualStyleBackColor = true;
            addd_btn.Click += addd_btn_Click;
            // 
            // addd_txt
            // 
            addd_txt.AutoSize = true;
            addd_txt.ForeColor = Color.Red;
            addd_txt.Location = new Point(392, 390);
            addd_txt.Name = "addd_txt";
            addd_txt.Size = new Size(0, 20);
            addd_txt.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(addd_txt);
            Controls.Add(addd_btn);
            Controls.Add(label4);
            Controls.Add(id_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbox);
            Controls.Add(age_box);
            Controls.Add(name_box);
            Controls.Add(reset_btn);
            Controls.Add(srch_btn);
            Controls.Add(Search_box);
            Controls.Add(GV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GV;
        private TextBox Search_box;
        private Button srch_btn;
        private Button reset_btn;
        private TextBox name_box;
        private TextBox age_box;
        private TextBox tbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox id_box;
        private Label label4;
        private Button addd_btn;
        private Label addd_txt;
    }
}