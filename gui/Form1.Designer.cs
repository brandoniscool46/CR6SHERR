<<<<<<< HEAD
﻿namespace gui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topbar = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topbar_minimize = new System.Windows.Forms.Label();
            this.topbar_exit = new System.Windows.Forms.Label();
            this.sidebar2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sidebar = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.creationpanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.creationpanel_input = new System.Windows.Forms.TextBox();
            this.creationpanel_inputlabel = new System.Windows.Forms.Label();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar2.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.creationpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.topbar.Controls.Add(this.linkLabel1);
            this.topbar.Controls.Add(this.pictureBox1);
            this.topbar.Controls.Add(this.topbar_minimize);
            this.topbar.Controls.Add(this.topbar_exit);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(696, 34);
            this.topbar.TabIndex = 0;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Filson Pro", 7.68932F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.linkLabel1.Location = new System.Drawing.Point(137, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(426, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dummy application, functionality is not added. Please use the batch version.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CR6SHER.Properties.Resources.guilogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // topbar_minimize
            // 
            this.topbar_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topbar_minimize.AutoSize = true;
            this.topbar_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topbar_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.07767F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topbar_minimize.Location = new System.Drawing.Point(626, 0);
            this.topbar_minimize.Name = "topbar_minimize";
            this.topbar_minimize.Size = new System.Drawing.Size(32, 29);
            this.topbar_minimize.TabIndex = 1;
            this.topbar_minimize.Text = "🗕";
            this.topbar_minimize.Click += new System.EventHandler(this.AppMinimizeAction);
            // 
            // topbar_exit
            // 
            this.topbar_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topbar_exit.AutoSize = true;
            this.topbar_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topbar_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.07767F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topbar_exit.Location = new System.Drawing.Point(664, 0);
            this.topbar_exit.Name = "topbar_exit";
            this.topbar_exit.Size = new System.Drawing.Size(32, 29);
            this.topbar_exit.TabIndex = 0;
            this.topbar_exit.Text = "🗙";
            this.topbar_exit.Click += new System.EventHandler(this.AppExitAction);
            // 
            // sidebar2
            // 
            this.sidebar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.sidebar2.Controls.Add(this.richTextBox1);
            this.sidebar2.Controls.Add(this.progressBar1);
            this.sidebar2.Controls.Add(this.sidebar);
            this.sidebar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar2.Location = new System.Drawing.Point(0, 34);
            this.sidebar2.Name = "sidebar2";
            this.sidebar2.Size = new System.Drawing.Size(221, 474);
            this.sidebar2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 7.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(58, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(157, 431);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Log will appear here.";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(58, 443);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(157, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.sidebar.Controls.Add(this.pictureBox5);
            this.sidebar.Controls.Add(this.pictureBox4);
            this.sidebar.Controls.Add(this.pictureBox3);
            this.sidebar.Controls.Add(this.pictureBox2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(51, 474);
            this.sidebar.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CR6SHER.Properties.Resources.setting;
            this.pictureBox5.Location = new System.Drawing.Point(5, 94);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CR6SHER.Properties.Resources.information;
            this.pictureBox4.Location = new System.Drawing.Point(5, 428);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CR6SHER.Properties.Resources.download;
            this.pictureBox3.Location = new System.Drawing.Point(5, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CR6SHER.Properties.Resources.create;
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // creationpanel
            // 
            this.creationpanel.Controls.Add(this.button3);
            this.creationpanel.Controls.Add(this.comboBox1);
            this.creationpanel.Controls.Add(this.label3);
            this.creationpanel.Controls.Add(this.textBox2);
            this.creationpanel.Controls.Add(this.label2);
            this.creationpanel.Controls.Add(this.button2);
            this.creationpanel.Controls.Add(this.textBox1);
            this.creationpanel.Controls.Add(this.label1);
            this.creationpanel.Controls.Add(this.button1);
            this.creationpanel.Controls.Add(this.creationpanel_input);
            this.creationpanel.Controls.Add(this.creationpanel_inputlabel);
            this.creationpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creationpanel.Location = new System.Drawing.Point(221, 34);
            this.creationpanel.Name = "creationpanel";
            this.creationpanel.Size = new System.Drawing.Size(475, 474);
            this.creationpanel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("FOT-NewRodin Pro UB", 11.18447F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(7, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(456, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "START THE CR6SHERR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MPEG 4",
            "WebM",
            "Quicktime MOV",
            "Matroska MKV",
            "GIF (soon™)"});
            this.comboBox1.Location = new System.Drawing.Point(113, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Video Format";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(9, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(454, 24);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "My Crashing Video";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Video Name";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Filson Pro", 9.087378F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(9, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "BROWSE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(373, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Path";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Video Path";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Filson Pro", 9.087378F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(9, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "BROWSE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // creationpanel_input
            // 
            this.creationpanel_input.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationpanel_input.Location = new System.Drawing.Point(90, 29);
            this.creationpanel_input.Name = "creationpanel_input";
            this.creationpanel_input.ReadOnly = true;
            this.creationpanel_input.Size = new System.Drawing.Size(373, 24);
            this.creationpanel_input.TabIndex = 1;
            this.creationpanel_input.Text = "Path";
            this.creationpanel_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // creationpanel_inputlabel
            // 
            this.creationpanel_inputlabel.AutoSize = true;
            this.creationpanel_inputlabel.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creationpanel_inputlabel.Location = new System.Drawing.Point(6, 10);
            this.creationpanel_inputlabel.Name = "creationpanel_inputlabel";
            this.creationpanel_inputlabel.Size = new System.Drawing.Size(87, 16);
            this.creationpanel_inputlabel.TabIndex = 0;
            this.creationpanel_inputlabel.Text = "Input Video";
            // 
            // cr6sherrgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(696, 508);
            this.Controls.Add(this.creationpanel);
            this.Controls.Add(this.sidebar2);
            this.Controls.Add(this.topbar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cr6sherrgui";
            this.Text = "CR6SHERR GUI";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar2.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.creationpanel.ResumeLayout(false);
            this.creationpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label topbar_minimize;
        private System.Windows.Forms.Label topbar_exit;
        private System.Windows.Forms.Panel sidebar2;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel creationpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox creationpanel_input;
        private System.Windows.Forms.Label creationpanel_inputlabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

=======
﻿namespace gui
{
    partial class cr6sherrgui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cr6sherrgui));
            this.topbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topbar_minimize = new System.Windows.Forms.Label();
            this.topbar_exit = new System.Windows.Forms.Label();
            this.sidebar2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sidebar = new System.Windows.Forms.Panel();
            this.creationpanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.creationpanel_input = new System.Windows.Forms.TextBox();
            this.creationpanel_inputlabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar2.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.creationpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.topbar.Controls.Add(this.linkLabel1);
            this.topbar.Controls.Add(this.pictureBox1);
            this.topbar.Controls.Add(this.topbar_minimize);
            this.topbar.Controls.Add(this.topbar_exit);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(696, 34);
            this.topbar.TabIndex = 0;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
            this.topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CR6SHER.Properties.Resources.guilogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // topbar_minimize
            // 
            this.topbar_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topbar_minimize.AutoSize = true;
            this.topbar_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topbar_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.07767F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topbar_minimize.Location = new System.Drawing.Point(626, 0);
            this.topbar_minimize.Name = "topbar_minimize";
            this.topbar_minimize.Size = new System.Drawing.Size(32, 29);
            this.topbar_minimize.TabIndex = 1;
            this.topbar_minimize.Text = "🗕";
            this.topbar_minimize.Click += new System.EventHandler(this.label2_Click);
            // 
            // topbar_exit
            // 
            this.topbar_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topbar_exit.AutoSize = true;
            this.topbar_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topbar_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.07767F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topbar_exit.Location = new System.Drawing.Point(664, 0);
            this.topbar_exit.Name = "topbar_exit";
            this.topbar_exit.Size = new System.Drawing.Size(32, 29);
            this.topbar_exit.TabIndex = 0;
            this.topbar_exit.Text = "🗙";
            this.topbar_exit.Click += new System.EventHandler(this.label1_Click);
            // 
            // sidebar2
            // 
            this.sidebar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.sidebar2.Controls.Add(this.richTextBox1);
            this.sidebar2.Controls.Add(this.progressBar1);
            this.sidebar2.Controls.Add(this.sidebar);
            this.sidebar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar2.Location = new System.Drawing.Point(0, 34);
            this.sidebar2.Name = "sidebar2";
            this.sidebar2.Size = new System.Drawing.Size(221, 474);
            this.sidebar2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 7.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(58, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(157, 431);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Log will appear here.";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(58, 443);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(157, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.sidebar.Controls.Add(this.pictureBox4);
            this.sidebar.Controls.Add(this.pictureBox3);
            this.sidebar.Controls.Add(this.pictureBox2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(52, 474);
            this.sidebar.TabIndex = 0;
            // 
            // creationpanel
            // 
            this.creationpanel.Controls.Add(this.button3);
            this.creationpanel.Controls.Add(this.comboBox1);
            this.creationpanel.Controls.Add(this.label3);
            this.creationpanel.Controls.Add(this.textBox2);
            this.creationpanel.Controls.Add(this.label2);
            this.creationpanel.Controls.Add(this.button2);
            this.creationpanel.Controls.Add(this.textBox1);
            this.creationpanel.Controls.Add(this.label1);
            this.creationpanel.Controls.Add(this.button1);
            this.creationpanel.Controls.Add(this.creationpanel_input);
            this.creationpanel.Controls.Add(this.creationpanel_inputlabel);
            this.creationpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creationpanel.Location = new System.Drawing.Point(221, 34);
            this.creationpanel.Name = "creationpanel";
            this.creationpanel.Size = new System.Drawing.Size(475, 474);
            this.creationpanel.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MPEG 4",
            "WebM",
            "Quicktime MOV",
            "Matroska MKV",
            "GIF (soon™)"});
            this.comboBox1.Location = new System.Drawing.Point(113, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Video Format";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(9, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(454, 24);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "My Crashing Video";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Video Name";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Filson Pro", 9.087378F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(9, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "BROWSE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(373, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Path";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Video Path";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Filson Pro", 9.087378F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(9, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "BROWSE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // creationpanel_input
            // 
            this.creationpanel_input.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationpanel_input.Location = new System.Drawing.Point(90, 29);
            this.creationpanel_input.Name = "creationpanel_input";
            this.creationpanel_input.ReadOnly = true;
            this.creationpanel_input.Size = new System.Drawing.Size(373, 24);
            this.creationpanel_input.TabIndex = 1;
            this.creationpanel_input.Text = "Path";
            this.creationpanel_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // creationpanel_inputlabel
            // 
            this.creationpanel_inputlabel.AutoSize = true;
            this.creationpanel_inputlabel.Font = new System.Drawing.Font("Filson Pro", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creationpanel_inputlabel.Location = new System.Drawing.Point(6, 10);
            this.creationpanel_inputlabel.Name = "creationpanel_inputlabel";
            this.creationpanel_inputlabel.Size = new System.Drawing.Size(87, 16);
            this.creationpanel_inputlabel.TabIndex = 0;
            this.creationpanel_inputlabel.Text = "Input Video";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CR6SHER.Properties.Resources.create;
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CR6SHER.Properties.Resources.download;
            this.pictureBox3.Location = new System.Drawing.Point(5, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CR6SHER.Properties.Resources.information;
            this.pictureBox4.Location = new System.Drawing.Point(5, 428);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("FOT-NewRodin Pro UB", 11.18447F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(7, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(456, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "START THE CR6SHERR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Filson Pro", 7.68932F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.linkLabel1.Location = new System.Drawing.Point(137, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(426, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dummy application, functionality is not added. Please use the batch version.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cr6sherrgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(696, 508);
            this.Controls.Add(this.creationpanel);
            this.Controls.Add(this.sidebar2);
            this.Controls.Add(this.topbar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cr6sherrgui";
            this.Text = "CR6SHERR GUI";
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar2.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.creationpanel.ResumeLayout(false);
            this.creationpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label topbar_minimize;
        private System.Windows.Forms.Label topbar_exit;
        private System.Windows.Forms.Panel sidebar2;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel creationpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox creationpanel_input;
        private System.Windows.Forms.Label creationpanel_inputlabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;
    }
}

>>>>>>> 1f1131a5cdf9904f085678a435819cf58688151a
