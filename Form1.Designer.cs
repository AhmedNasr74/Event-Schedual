namespace WindowsFormsApplication9
{
    partial class ev_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ev_app));
            this.title = new System.Windows.Forms.Label();
            this.bu_Save = new System.Windows.Forms.Button();
            this.bu_Delete = new System.Windows.Forms.Button();
            this.bu_Cancel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.rad_StartTime = new System.Windows.Forms.RadioButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bu_Detail = new System.Windows.Forms.Button();
            this.name_of_event = new System.Windows.Forms.Label();
            this.place_of_event = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Place = new System.Windows.Forms.TextBox();
            this.bu_Add = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.bu_Edit = new System.Windows.Forms.Button();
            this.rad_Name = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bu_Search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRemind = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Curlz MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(282, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(278, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Event’s Scheduler\r\n";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label);
            // 
            // bu_Save
            // 
            this.bu_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bu_Save.Font = new System.Drawing.Font("Perpetua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bu_Save.Location = new System.Drawing.Point(656, 456);
            this.bu_Save.Name = "bu_Save";
            this.bu_Save.Size = new System.Drawing.Size(80, 41);
            this.bu_Save.TabIndex = 22;
            this.bu_Save.Text = "Save";
            this.bu_Save.UseVisualStyleBackColor = false;
            this.bu_Save.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // bu_Delete
            // 
            this.bu_Delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bu_Delete.Font = new System.Drawing.Font("Perpetua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bu_Delete.Location = new System.Drawing.Point(480, 455);
            this.bu_Delete.Name = "bu_Delete";
            this.bu_Delete.Size = new System.Drawing.Size(80, 41);
            this.bu_Delete.TabIndex = 5;
            this.bu_Delete.Text = "Delete";
            this.bu_Delete.UseVisualStyleBackColor = false;
            this.bu_Delete.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // bu_Cancel
            // 
            this.bu_Cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bu_Cancel.Font = new System.Drawing.Font("Perpetua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Cancel.Location = new System.Drawing.Point(742, 456);
            this.bu_Cancel.Name = "bu_Cancel";
            this.bu_Cancel.Size = new System.Drawing.Size(80, 41);
            this.bu_Cancel.TabIndex = 27;
            this.bu_Cancel.Text = "Cancel";
            this.bu_Cancel.UseVisualStyleBackColor = false;
            this.bu_Cancel.Click += new System.EventHandler(this.cancel_button_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(394, 130);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(428, 320);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.select_element);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 2;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start Date";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Start Time";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(478, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sort :";
            // 
            // rad_StartTime
            // 
            this.rad_StartTime.AutoSize = true;
            this.rad_StartTime.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_StartTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rad_StartTime.Location = new System.Drawing.Point(636, 99);
            this.rad_StartTime.Name = "rad_StartTime";
            this.rad_StartTime.Size = new System.Drawing.Size(114, 28);
            this.rad_StartTime.TabIndex = 35;
            this.rad_StartTime.Text = "Start Date";
            this.rad_StartTime.UseVisualStyleBackColor = true;
            this.rad_StartTime.CheckedChanged += new System.EventHandler(this.rad_StartTime_CheckedChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 42);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move_fprm);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication9.Properties.Resources.White_minimize3;
            this.pictureBox4.Location = new System.Drawing.Point(752, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication9.Properties.Resources.Close2;
            this.pictureBox3.Location = new System.Drawing.Point(790, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication9.Properties.Resources.Green4;
            this.pictureBox2.Location = new System.Drawing.Point(27, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // bu_Detail
            // 
            this.bu_Detail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bu_Detail.Font = new System.Drawing.Font("Perpetua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Detail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bu_Detail.Location = new System.Drawing.Point(394, 457);
            this.bu_Detail.Name = "bu_Detail";
            this.bu_Detail.Size = new System.Drawing.Size(80, 39);
            this.bu_Detail.TabIndex = 5;
            this.bu_Detail.Text = "Detail";
            this.bu_Detail.UseVisualStyleBackColor = false;
            this.bu_Detail.Click += new System.EventHandler(this.list_button_Click);
            this.bu_Detail.Enter += new System.EventHandler(this.view_list);
            // 
            // name_of_event
            // 
            this.name_of_event.AutoSize = true;
            this.name_of_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(156)))), ((int)(((byte)(136)))));
            this.name_of_event.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_event.ForeColor = System.Drawing.Color.Transparent;
            this.name_of_event.Location = new System.Drawing.Point(41, 99);
            this.name_of_event.Name = "name_of_event";
            this.name_of_event.Size = new System.Drawing.Size(61, 24);
            this.name_of_event.TabIndex = 1;
            this.name_of_event.Text = "Name";
            this.name_of_event.Click += new System.EventHandler(this.name_of_event_Click);
            // 
            // place_of_event
            // 
            this.place_of_event.AutoSize = true;
            this.place_of_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(156)))), ((int)(((byte)(136)))));
            this.place_of_event.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place_of_event.ForeColor = System.Drawing.Color.Transparent;
            this.place_of_event.Location = new System.Drawing.Point(41, 130);
            this.place_of_event.Name = "place_of_event";
            this.place_of_event.Size = new System.Drawing.Size(59, 24);
            this.place_of_event.TabIndex = 2;
            this.place_of_event.Text = "Place";
            this.place_of_event.Click += new System.EventHandler(this.place_of_event_Click);
            // 
            // start_date
            // 
            this.start_date.AutoSize = true;
            this.start_date.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.start_date.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.ForeColor = System.Drawing.Color.Black;
            this.start_date.Location = new System.Drawing.Point(41, 187);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(102, 24);
            this.start_date.TabIndex = 3;
            this.start_date.Text = "Start Date";
            // 
            // end_date
            // 
            this.end_date.AutoSize = true;
            this.end_date.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.end_date.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.ForeColor = System.Drawing.Color.Black;
            this.end_date.Location = new System.Drawing.Point(41, 260);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(95, 24);
            this.end_date.TabIndex = 4;
            this.end_date.Text = "End Date";
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.start_time.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_time.ForeColor = System.Drawing.Color.Black;
            this.start_time.Location = new System.Drawing.Point(41, 222);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(106, 24);
            this.start_time.TabIndex = 6;
            this.start_time.Text = "Start Time";
            this.start_time.Click += new System.EventHandler(this.start_time_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Name.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Name.Location = new System.Drawing.Point(106, 99);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(199, 24);
            this.txt_Name.TabIndex = 8;
            this.txt_Name.Text = "Name";
            this.txt_Name.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            this.txt_Name.Enter += new System.EventHandler(this.txt_Name_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.txt_Name_Leave);
            // 
            // txt_Place
            // 
            this.txt_Place.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Place.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Place.Location = new System.Drawing.Point(106, 130);
            this.txt_Place.Name = "txt_Place";
            this.txt_Place.Size = new System.Drawing.Size(199, 24);
            this.txt_Place.TabIndex = 9;
            this.txt_Place.Text = "Place";
            this.txt_Place.TextChanged += new System.EventHandler(this.place_TextChanged);
            this.txt_Place.Enter += new System.EventHandler(this.place_enter);
            this.txt_Place.Leave += new System.EventHandler(this.place_leave);
            // 
            // bu_Add
            // 
            this.bu_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bu_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bu_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bu_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bu_Add.Font = new System.Drawing.Font("Perpetua", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bu_Add.Location = new System.Drawing.Point(127, 346);
            this.bu_Add.Name = "bu_Add";
            this.bu_Add.Size = new System.Drawing.Size(82, 42);
            this.bu_Add.TabIndex = 21;
            this.bu_Add.Text = "Add";
            this.bu_Add.UseVisualStyleBackColor = false;
            this.bu_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StartDate.Location = new System.Drawing.Point(153, 187);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(137, 24);
            this.StartDate.TabIndex = 39;
            this.StartDate.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            this.StartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EndDate.Location = new System.Drawing.Point(153, 260);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(137, 24);
            this.EndDate.TabIndex = 40;
            this.EndDate.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "hh:mm tt";
            this.StartTime.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.Location = new System.Drawing.Point(153, 222);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(90, 24);
            this.StartTime.TabIndex = 41;
            this.StartTime.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            this.StartTime.ValueChanged += new System.EventHandler(this.StartTime_ValueChanged);
            // 
            // bu_Edit
            // 
            this.bu_Edit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bu_Edit.Font = new System.Drawing.Font("Perpetua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Edit.Location = new System.Drawing.Point(566, 456);
            this.bu_Edit.Name = "bu_Edit";
            this.bu_Edit.Size = new System.Drawing.Size(84, 41);
            this.bu_Edit.TabIndex = 42;
            this.bu_Edit.Text = "Edit";
            this.bu_Edit.UseVisualStyleBackColor = false;
            this.bu_Edit.Click += new System.EventHandler(this.bu_Edit_Click);
            // 
            // rad_Name
            // 
            this.rad_Name.AutoSize = true;
            this.rad_Name.Checked = true;
            this.rad_Name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rad_Name.Location = new System.Drawing.Point(553, 99);
            this.rad_Name.Name = "rad_Name";
            this.rad_Name.Size = new System.Drawing.Size(77, 28);
            this.rad_Name.TabIndex = 43;
            this.rad_Name.TabStop = true;
            this.rad_Name.Text = "Name";
            this.rad_Name.UseVisualStyleBackColor = true;
            this.rad_Name.CheckedChanged += new System.EventHandler(this.rad_Name_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "End Time";
            // 
            // EndTime
            // 
            this.EndTime.CustomFormat = "hh:mm tt";
            this.EndTime.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTime.Location = new System.Drawing.Point(153, 300);
            this.EndTime.Name = "EndTime";
            this.EndTime.ShowUpDown = true;
            this.EndTime.Size = new System.Drawing.Size(90, 24);
            this.EndTime.TabIndex = 45;
            this.EndTime.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            this.EndTime.ValueChanged += new System.EventHandler(this.EndTime_ValueChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Search.Location = new System.Drawing.Point(503, 64);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(199, 24);
            this.txt_Search.TabIndex = 47;
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
            this.label3.Location = new System.Drawing.Point(426, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Search";
            // 
            // bu_Search
            // 
            this.bu_Search.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Search.Location = new System.Drawing.Point(708, 64);
            this.bu_Search.Name = "bu_Search";
            this.bu_Search.Size = new System.Drawing.Size(93, 24);
            this.bu_Search.TabIndex = 48;
            this.bu_Search.Text = "Search";
            this.bu_Search.UseVisualStyleBackColor = true;
            this.bu_Search.Click += new System.EventHandler(this.bu_Search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication9.Properties.Resources.green3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblRemind);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(50, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 78);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reminder";
            // 
            // lblRemind
            // 
            this.lblRemind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemind.BackColor = System.Drawing.Color.Transparent;
            this.lblRemind.Font = new System.Drawing.Font("Curlz MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemind.Location = new System.Drawing.Point(6, 19);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(243, 48);
            this.lblRemind.TabIndex = 0;
            this.lblRemind.Text = "No Event Selected";
            this.lblRemind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ev_app
            // 
            this.AcceptButton = this.bu_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(837, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.bu_Add);
            this.Controls.Add(this.txt_Place);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.place_of_event);
            this.Controls.Add(this.name_of_event);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bu_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rad_Name);
            this.Controls.Add(this.bu_Edit);
            this.Controls.Add(this.bu_Detail);
            this.Controls.Add(this.rad_StartTime);
            this.Controls.Add(this.bu_Cancel);
            this.Controls.Add(this.bu_Delete);
            this.Controls.Add(this.bu_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ev_app";
            this.Text = "Event’s application";
            this.Load += new System.EventHandler(this.ev_app_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button bu_Save;
        private System.Windows.Forms.Button bu_Delete;
        private System.Windows.Forms.Button bu_Cancel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_StartTime;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bu_Detail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bu_Add;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.TextBox txt_Place;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label start_time;
        private System.Windows.Forms.Label end_date;
        private System.Windows.Forms.Label start_date;
        private System.Windows.Forms.Label place_of_event;
        private System.Windows.Forms.Label name_of_event;
        private System.Windows.Forms.Button bu_Edit;
        private System.Windows.Forms.RadioButton rad_Name;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bu_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemind;
    }
}

