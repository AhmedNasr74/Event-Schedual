namespace WindowsFormsApplication9
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.second_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bu_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rad_Name = new System.Windows.Forms.RadioButton();
            this.rad_StartTime = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radFinished = new System.Windows.Forms.RadioButton();
            this.radUpcoming = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // second_list
            // 
            this.second_list.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.second_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Name_Column,
            this.Place,
            this.Start_Date,
            this.Start_Time,
            this.End_Date,
            this.EndTime});
            this.second_list.Font = new System.Drawing.Font("Tahoma", 10F);
            this.second_list.FullRowSelect = true;
            this.second_list.GridLines = true;
            this.second_list.Location = new System.Drawing.Point(12, 84);
            this.second_list.MultiSelect = false;
            this.second_list.Name = "second_list";
            this.second_list.Size = new System.Drawing.Size(842, 384);
            this.second_list.TabIndex = 0;
            this.second_list.UseCompatibleStateImageBehavior = false;
            this.second_list.View = System.Windows.Forms.View.Details;
            this.second_list.SelectedIndexChanged += new System.EventHandler(this.second_list_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 8;
            // 
            // Name_Column
            // 
            this.Name_Column.Text = "Name";
            this.Name_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Column.Width = 166;
            // 
            // Place
            // 
            this.Place.Text = "Place";
            this.Place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Place.Width = 151;
            // 
            // Start_Date
            // 
            this.Start_Date.Text = "Start Date";
            this.Start_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Start_Date.Width = 120;
            // 
            // Start_Time
            // 
            this.Start_Time.Text = "Start Time";
            this.Start_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Start_Time.Width = 165;
            // 
            // End_Date
            // 
            this.End_Date.Text = "End Date";
            this.End_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.End_Date.Width = 108;
            // 
            // EndTime
            // 
            this.EndTime.Text = "End Time";
            this.EndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndTime.Width = 128;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 39);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moving_form);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Curlz MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(259, -2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(401, 45);
            this.title.TabIndex = 46;
            this.title.Text = "Event’s Scheduler\r\n";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movelabel);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication9.Properties.Resources.White_minimize3;
            this.pictureBox4.Location = new System.Drawing.Point(786, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication9.Properties.Resources.Close2;
            this.pictureBox3.Location = new System.Drawing.Point(824, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication9.Properties.Resources.if_exit2_216622_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Home";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bu_Search
            // 
            this.bu_Search.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Search.Location = new System.Drawing.Point(379, 54);
            this.bu_Search.Name = "bu_Search";
            this.bu_Search.Size = new System.Drawing.Size(93, 24);
            this.bu_Search.TabIndex = 55;
            this.bu_Search.Text = "Search";
            this.bu_Search.UseVisualStyleBackColor = true;
            this.bu_Search.Click += new System.EventHandler(this.bu_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Search.Location = new System.Drawing.Point(157, 54);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(216, 24);
            this.txt_Search.TabIndex = 54;
            this.txt_Search.Text = "By Name";
            this.txt_Search.Enter += new System.EventHandler(this.Search_Enter);
            this.txt_Search.Leave += new System.EventHandler(this.Search_leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(80, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Search";
            // 
            // rad_Name
            // 
            this.rad_Name.AutoSize = true;
            this.rad_Name.Checked = true;
            this.rad_Name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rad_Name.Location = new System.Drawing.Point(605, 52);
            this.rad_Name.Name = "rad_Name";
            this.rad_Name.Size = new System.Drawing.Size(77, 28);
            this.rad_Name.TabIndex = 52;
            this.rad_Name.TabStop = true;
            this.rad_Name.Text = "Name";
            this.rad_Name.UseVisualStyleBackColor = true;
            this.rad_Name.CheckedChanged += new System.EventHandler(this.rad_Name_CheckedChanged);
            // 
            // rad_StartTime
            // 
            this.rad_StartTime.AutoSize = true;
            this.rad_StartTime.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_StartTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rad_StartTime.Location = new System.Drawing.Point(688, 53);
            this.rad_StartTime.Name = "rad_StartTime";
            this.rad_StartTime.Size = new System.Drawing.Size(114, 28);
            this.rad_StartTime.TabIndex = 51;
            this.rad_StartTime.Text = "Start Date";
            this.rad_StartTime.UseVisualStyleBackColor = true;
            this.rad_StartTime.CheckedChanged += new System.EventHandler(this.rad_StartTime_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(527, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "Sort :";
            // 
            // radFinished
            // 
            this.radFinished.AutoSize = true;
            this.radFinished.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFinished.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radFinished.Location = new System.Drawing.Point(102, 7);
            this.radFinished.Name = "radFinished";
            this.radFinished.Size = new System.Drawing.Size(103, 28);
            this.radFinished.TabIndex = 61;
            this.radFinished.Text = "Finished";
            this.radFinished.UseVisualStyleBackColor = true;
            this.radFinished.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radUpcoming
            // 
            this.radUpcoming.AutoSize = true;
            this.radUpcoming.Checked = true;
            this.radUpcoming.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUpcoming.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radUpcoming.Location = new System.Drawing.Point(211, 7);
            this.radUpcoming.Name = "radUpcoming";
            this.radUpcoming.Size = new System.Drawing.Size(113, 28);
            this.radUpcoming.TabIndex = 60;
            this.radUpcoming.TabStop = true;
            this.radUpcoming.Text = "Upcoming";
            this.radUpcoming.UseVisualStyleBackColor = true;
            this.radUpcoming.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 59;
            this.label4.Text = "Show :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radFinished);
            this.panel2.Controls.Add(this.radUpcoming);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(288, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 42);
            this.panel2.TabIndex = 62;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(866, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bu_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rad_Name);
            this.Controls.Add(this.rad_StartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.second_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView second_list;
        private System.Windows.Forms.ColumnHeader Name_Column;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.ColumnHeader Start_Date;
        private System.Windows.Forms.ColumnHeader End_Date;
        private System.Windows.Forms.ColumnHeader Start_Time;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radFinished;
        private System.Windows.Forms.RadioButton radUpcoming;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bu_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rad_Name;
        private System.Windows.Forms.RadioButton rad_StartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ColumnHeader columnHeader1;


    }
}