
namespace MLDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SubmitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectImageBtn = new System.Windows.Forms.Button();
            this.PrintBox = new System.Windows.Forms.Label();
            this.DebugBox = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.ResourcesBtn = new System.Windows.Forms.Button();
            this.DropBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.ReadMore = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.introBox = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ContactPanel = new System.Windows.Forms.Panel();
            this.contact = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResourcesPanel = new System.Windows.Forms.Panel();
            this.resbtn = new System.Windows.Forms.Button();
            this.resInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dropPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ContactPanel.SuspendLayout();
            this.ResourcesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SubmitButton.Location = new System.Drawing.Point(124, 47);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 26);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectImageBtn
            // 
            this.SelectImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SelectImageBtn.FlatAppearance.BorderSize = 0;
            this.SelectImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectImageBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectImageBtn.Location = new System.Drawing.Point(124, 15);
            this.SelectImageBtn.Name = "SelectImageBtn";
            this.SelectImageBtn.Size = new System.Drawing.Size(75, 26);
            this.SelectImageBtn.TabIndex = 2;
            this.SelectImageBtn.Text = "Select";
            this.SelectImageBtn.UseVisualStyleBackColor = false;
            this.SelectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // PrintBox
            // 
            this.PrintBox.AutoSize = true;
            this.PrintBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.PrintBox.Location = new System.Drawing.Point(18, 185);
            this.PrintBox.Name = "PrintBox";
            this.PrintBox.Size = new System.Drawing.Size(53, 19);
            this.PrintBox.TabIndex = 3;
            this.PrintBox.Text = "Report:";
            // 
            // DebugBox
            // 
            this.DebugBox.AutoSize = true;
            this.DebugBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DebugBox.ForeColor = System.Drawing.Color.Silver;
            this.DebugBox.Location = new System.Drawing.Point(18, 140);
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.Size = new System.Drawing.Size(101, 25);
            this.DebugBox.TabIndex = 4;
            this.DebugBox.Text = "Overview:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel3.Controls.Add(this.QuitBtn);
            this.panel3.Controls.Add(this.ResourcesBtn);
            this.panel3.Controls.Add(this.DropBtn);
            this.panel3.Controls.Add(this.ContactBtn);
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(100)))));
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.MinimumSize = new System.Drawing.Size(180, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 500);
            this.panel3.TabIndex = 8;
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.QuitBtn.FlatAppearance.BorderSize = 0;
            this.QuitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.QuitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.Font = new System.Drawing.Font("Raleway Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuitBtn.Image = ((System.Drawing.Image)(resources.GetObject("QuitBtn.Image")));
            this.QuitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuitBtn.Location = new System.Drawing.Point(0, 145);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.QuitBtn.Size = new System.Drawing.Size(180, 35);
            this.QuitBtn.TabIndex = 1;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.Quit_Click);
            // 
            // ResourcesBtn
            // 
            this.ResourcesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ResourcesBtn.FlatAppearance.BorderSize = 0;
            this.ResourcesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.ResourcesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.ResourcesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResourcesBtn.Font = new System.Drawing.Font("Raleway Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResourcesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResourcesBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResourcesBtn.Image")));
            this.ResourcesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResourcesBtn.Location = new System.Drawing.Point(0, 70);
            this.ResourcesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ResourcesBtn.Name = "ResourcesBtn";
            this.ResourcesBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ResourcesBtn.Size = new System.Drawing.Size(180, 35);
            this.ResourcesBtn.TabIndex = 1;
            this.ResourcesBtn.Text = "Resources";
            this.ResourcesBtn.UseVisualStyleBackColor = false;
            this.ResourcesBtn.Click += new System.EventHandler(this.ResourcesBtn_Click);
            // 
            // DropBtn
            // 
            this.DropBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.DropBtn.FlatAppearance.BorderSize = 0;
            this.DropBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.DropBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.DropBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropBtn.Font = new System.Drawing.Font("Raleway Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DropBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DropBtn.Image = ((System.Drawing.Image)(resources.GetObject("DropBtn.Image")));
            this.DropBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DropBtn.Location = new System.Drawing.Point(0, 35);
            this.DropBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DropBtn.Name = "DropBtn";
            this.DropBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.DropBtn.Size = new System.Drawing.Size(180, 35);
            this.DropBtn.TabIndex = 1;
            this.DropBtn.Text = "Drop";
            this.DropBtn.UseVisualStyleBackColor = false;
            this.DropBtn.Click += new System.EventHandler(this.DropBtn_Click);
            // 
            // ContactBtn
            // 
            this.ContactBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.ContactBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Raleway Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ContactBtn.Image = ((System.Drawing.Image)(resources.GetObject("ContactBtn.Image")));
            this.ContactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactBtn.Location = new System.Drawing.Point(0, 110);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ContactBtn.Size = new System.Drawing.Size(180, 35);
            this.ContactBtn.TabIndex = 1;
            this.ContactBtn.Text = "Contact";
            this.ContactBtn.UseVisualStyleBackColor = false;
            this.ContactBtn.Click += new System.EventHandler(this.ContactBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Raleway Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(180, 35);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 80);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(43, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "ML Doctor";
            // 
            // dropPanel
            // 
            this.dropPanel.Controls.Add(this.ReadMore);
            this.dropPanel.Controls.Add(this.pictureBox1);
            this.dropPanel.Controls.Add(this.SelectImageBtn);
            this.dropPanel.Controls.Add(this.SubmitButton);
            this.dropPanel.Controls.Add(this.DebugBox);
            this.dropPanel.Controls.Add(this.PrintBox);
            this.dropPanel.Location = new System.Drawing.Point(180, 0);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(600, 490);
            this.dropPanel.TabIndex = 11;
            // 
            // ReadMore
            // 
            this.ReadMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ReadMore.FlatAppearance.BorderSize = 0;
            this.ReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadMore.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadMore.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ReadMore.Location = new System.Drawing.Point(25, 392);
            this.ReadMore.Name = "ReadMore";
            this.ReadMore.Size = new System.Drawing.Size(111, 22);
            this.ReadMore.TabIndex = 5;
            this.ReadMore.Text = "Read More";
            this.ReadMore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReadMore.UseVisualStyleBackColor = false;
            this.ReadMore.Click += new System.EventHandler(this.ReadMore_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.introBox);
            this.homePanel.Controls.Add(this.info);
            this.homePanel.Controls.Add(this.label3);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.pictureBox2);
            this.homePanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homePanel.Location = new System.Drawing.Point(180, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(600, 490);
            this.homePanel.TabIndex = 10;
            // 
            // introBox
            // 
            this.introBox.AutoSize = true;
            this.introBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.introBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.introBox.Location = new System.Drawing.Point(33, 150);
            this.introBox.Name = "introBox";
            this.introBox.Size = new System.Drawing.Size(40, 20);
            this.introBox.TabIndex = 4;
            this.introBox.Text = "intro";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.info.Location = new System.Drawing.Point(31, 244);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(37, 21);
            this.info.TabIndex = 3;
            this.info.Text = "info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "I\'m Dr.ML";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello, Welcome !";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(400, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ContactPanel
            // 
            this.ContactPanel.Controls.Add(this.contact);
            this.ContactPanel.Controls.Add(this.copyright);
            this.ContactPanel.Controls.Add(this.label4);
            this.ContactPanel.Location = new System.Drawing.Point(180, 0);
            this.ContactPanel.Name = "ContactPanel";
            this.ContactPanel.Size = new System.Drawing.Size(600, 490);
            this.ContactPanel.TabIndex = 5;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contact.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.contact.Location = new System.Drawing.Point(25, 160);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(53, 15);
            this.contact.TabIndex = 2;
            this.contact.Text = "contact:";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyright.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.copyright.Location = new System.Drawing.Point(25, 93);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(59, 15);
            this.copyright.TabIndex = 1;
            this.copyright.Text = "copyright";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(25, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Developer Contact";
            // 
            // ResourcesPanel
            // 
            this.ResourcesPanel.AutoScroll = true;
            this.ResourcesPanel.Controls.Add(this.resbtn);
            this.ResourcesPanel.Controls.Add(this.resInfo);
            this.ResourcesPanel.Controls.Add(this.label5);
            this.ResourcesPanel.Location = new System.Drawing.Point(180, 0);
            this.ResourcesPanel.Name = "ResourcesPanel";
            this.ResourcesPanel.Size = new System.Drawing.Size(600, 490);
            this.ResourcesPanel.TabIndex = 4;
            // 
            // resbtn
            // 
            this.resbtn.BackColor = System.Drawing.Color.Black;
            this.resbtn.FlatAppearance.BorderSize = 0;
            this.resbtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.resbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resbtn.Location = new System.Drawing.Point(35, 413);
            this.resbtn.Name = "resbtn";
            this.resbtn.Size = new System.Drawing.Size(102, 32);
            this.resbtn.TabIndex = 2;
            this.resbtn.Text = "Read More";
            this.resbtn.UseVisualStyleBackColor = false;
            this.resbtn.Click += new System.EventHandler(this.resbtn_Click);
            // 
            // resInfo
            // 
            this.resInfo.AutoSize = true;
            this.resInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.resInfo.Location = new System.Drawing.Point(33, 71);
            this.resInfo.Name = "resInfo";
            this.resInfo.Size = new System.Drawing.Size(32, 19);
            this.resInfo.TabIndex = 1;
            this.resInfo.Text = "info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Additional Resources";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ResourcesPanel);
            this.Controls.Add(this.ContactPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.dropPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "ML Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dropPanel.ResumeLayout(false);
            this.dropPanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ContactPanel.ResumeLayout(false);
            this.ContactPanel.PerformLayout();
            this.ResourcesPanel.ResumeLayout(false);
            this.ResourcesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectImageBtn;
        private System.Windows.Forms.Label PrintBox;
        private System.Windows.Forms.Label DebugBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button ResourcesBtn;
        private System.Windows.Forms.Button DropBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel ContactPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel ResourcesPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label resInfo;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label introBox;
        private System.Windows.Forms.Button ReadMore;
        private System.Windows.Forms.Button resbtn;
    }
}

