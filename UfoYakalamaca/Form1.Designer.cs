namespace UfoYakalamaca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lYakalanan = new System.Windows.Forms.Label();
            this.lKacan = new System.Windows.Forms.Label();
            this.ufolar = new System.Windows.Forms.ImageList(this.components);
            this.mermi1 = new System.Windows.Forms.Timer(this.components);
            this.mermi2 = new System.Windows.Forms.Timer(this.components);
            this.mermi3 = new System.Windows.Forms.Timer(this.components);
            this.mermi4 = new System.Windows.Forms.Timer(this.components);
            this.yildirim = new System.Windows.Forms.Timer(this.components);
            this.label_cephane = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_para = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_yildirim = new System.Windows.Forms.PictureBox();
            this.oyuncu = new System.Windows.Forms.Button();
            this.ates3 = new System.Windows.Forms.PictureBox();
            this.ates4 = new System.Windows.Forms.PictureBox();
            this.ates1 = new System.Windows.Forms.PictureBox();
            this.ates2 = new System.Windows.Forms.PictureBox();
            this.mermi_kontrol = new System.Windows.Forms.Timer(this.components);
            this.Mermi_hakki = new System.Windows.Forms.RadioButton();
            this.Yildirim_at = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_hakki = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.y_hakki = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yildirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ates3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ates4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ates1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ates2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vurulan    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kaçan     :";
            // 
            // lYakalanan
            // 
            this.lYakalanan.AutoSize = true;
            this.lYakalanan.BackColor = System.Drawing.Color.Transparent;
            this.lYakalanan.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lYakalanan.ForeColor = System.Drawing.Color.White;
            this.lYakalanan.Location = new System.Drawing.Point(89, 4);
            this.lYakalanan.Name = "lYakalanan";
            this.lYakalanan.Size = new System.Drawing.Size(15, 16);
            this.lYakalanan.TabIndex = 3;
            this.lYakalanan.Text = "0";
            // 
            // lKacan
            // 
            this.lKacan.AutoSize = true;
            this.lKacan.BackColor = System.Drawing.Color.Transparent;
            this.lKacan.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKacan.ForeColor = System.Drawing.Color.White;
            this.lKacan.Location = new System.Drawing.Point(89, 17);
            this.lKacan.Name = "lKacan";
            this.lKacan.Size = new System.Drawing.Size(15, 16);
            this.lKacan.TabIndex = 3;
            this.lKacan.Text = "0";
            // 
            // ufolar
            // 
            this.ufolar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ufolar.ImageStream")));
            this.ufolar.TransparentColor = System.Drawing.Color.Transparent;
            this.ufolar.Images.SetKeyName(0, "1.gif");
            this.ufolar.Images.SetKeyName(1, "2.gif");
            this.ufolar.Images.SetKeyName(2, "3.gif");
            this.ufolar.Images.SetKeyName(3, "4.png");
            this.ufolar.Images.SetKeyName(4, "5.png");
            this.ufolar.Images.SetKeyName(5, "6.png");
            this.ufolar.Images.SetKeyName(6, "7.png");
            // 
            // mermi1
            // 
            this.mermi1.Tick += new System.EventHandler(this.mermi1_Tick);
            // 
            // mermi2
            // 
            this.mermi2.Tick += new System.EventHandler(this.mermi2_Tick);
            // 
            // mermi3
            // 
            this.mermi3.Tick += new System.EventHandler(this.mermi3_Tick);
            // 
            // mermi4
            // 
            this.mermi4.Tick += new System.EventHandler(this.mermi4_Tick);
            // 
            // yildirim
            // 
            this.yildirim.Tick += new System.EventHandler(this.yildirim_Tick);
            // 
            // label_cephane
            // 
            this.label_cephane.AutoSize = true;
            this.label_cephane.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cephane.ForeColor = System.Drawing.Color.White;
            this.label_cephane.Location = new System.Drawing.Point(89, 33);
            this.label_cephane.Name = "label_cephane";
            this.label_cephane.Size = new System.Drawing.Size(22, 16);
            this.label_cephane.TabIndex = 11;
            this.label_cephane.Text = "00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Yildirim_at);
            this.panel2.Controls.Add(this.Mermi_hakki);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label_para);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label_cephane);
            this.panel2.Controls.Add(this.lKacan);
            this.panel2.Controls.Add(this.lYakalanan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(648, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 516);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(72, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Para       :";
            // 
            // label_para
            // 
            this.label_para.AutoSize = true;
            this.label_para.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_para.ForeColor = System.Drawing.Color.White;
            this.label_para.Location = new System.Drawing.Point(89, 49);
            this.label_para.Name = "label_para";
            this.label_para.Size = new System.Drawing.Size(22, 16);
            this.label_para.TabIndex = 11;
            this.label_para.Text = "00";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(83, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Yıldırım 500$";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UfoYakalamaca.Properties.Resources.yıldırım;
            this.pictureBox2.Location = new System.Drawing.Point(8, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(83, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Mermi 50$";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UfoYakalamaca.Properties.Resources._41556;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cephane   :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(234, 514);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -2;
            this.lineShape2.X2 = 213;
            this.lineShape2.Y1 = 235;
            this.lineShape2.Y2 = 235;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 215;
            this.lineShape1.Y1 = 89;
            this.lineShape1.Y2 = 89;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pb_yildirim);
            this.panel1.Controls.Add(this.oyuncu);
            this.panel1.Controls.Add(this.ates3);
            this.panel1.Controls.Add(this.ates4);
            this.panel1.Controls.Add(this.ates1);
            this.panel1.Controls.Add(this.ates2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 516);
            this.panel1.TabIndex = 10;
            // 
            // pb_yildirim
            // 
            this.pb_yildirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_yildirim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_yildirim.Image = ((System.Drawing.Image)(resources.GetObject("pb_yildirim.Image")));
            this.pb_yildirim.Location = new System.Drawing.Point(3, 432);
            this.pb_yildirim.Name = "pb_yildirim";
            this.pb_yildirim.Size = new System.Drawing.Size(640, 26);
            this.pb_yildirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_yildirim.TabIndex = 11;
            this.pb_yildirim.TabStop = false;
            this.pb_yildirim.Visible = false;
            // 
            // oyuncu
            // 
            this.oyuncu.BackColor = System.Drawing.Color.Transparent;
            this.oyuncu.BackgroundImage = global::UfoYakalamaca.Properties.Resources.cutcaster_photo_100532685_gel_button_set;
            this.oyuncu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oyuncu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oyuncu.ForeColor = System.Drawing.Color.Transparent;
            this.oyuncu.Location = new System.Drawing.Point(285, 480);
            this.oyuncu.Name = "oyuncu";
            this.oyuncu.Size = new System.Drawing.Size(68, 31);
            this.oyuncu.TabIndex = 10;
            this.oyuncu.UseVisualStyleBackColor = false;
            this.oyuncu.Click += new System.EventHandler(this.oyuncu_Click);
            // 
            // ates3
            // 
            this.ates3.BackColor = System.Drawing.Color.MediumBlue;
            this.ates3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ates3.Location = new System.Drawing.Point(319, 464);
            this.ates3.Name = "ates3";
            this.ates3.Size = new System.Drawing.Size(10, 10);
            this.ates3.TabIndex = 9;
            this.ates3.TabStop = false;
            this.ates3.Visible = false;
            // 
            // ates4
            // 
            this.ates4.BackColor = System.Drawing.Color.Aqua;
            this.ates4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ates4.Location = new System.Drawing.Point(335, 464);
            this.ates4.Name = "ates4";
            this.ates4.Size = new System.Drawing.Size(10, 10);
            this.ates4.TabIndex = 7;
            this.ates4.TabStop = false;
            this.ates4.Visible = false;
            // 
            // ates1
            // 
            this.ates1.BackColor = System.Drawing.Color.Lime;
            this.ates1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ates1.Location = new System.Drawing.Point(287, 464);
            this.ates1.Name = "ates1";
            this.ates1.Size = new System.Drawing.Size(10, 10);
            this.ates1.TabIndex = 6;
            this.ates1.TabStop = false;
            this.ates1.Visible = false;
            // 
            // ates2
            // 
            this.ates2.BackColor = System.Drawing.Color.Crimson;
            this.ates2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ates2.Location = new System.Drawing.Point(303, 464);
            this.ates2.Name = "ates2";
            this.ates2.Size = new System.Drawing.Size(10, 10);
            this.ates2.TabIndex = 8;
            this.ates2.TabStop = false;
            this.ates2.Visible = false;
            // 
            // mermi_kontrol
            // 
            this.mermi_kontrol.Interval = 1000;
            this.mermi_kontrol.Tick += new System.EventHandler(this.mermi_kontrol_Tick);
            // 
            // Mermi_hakki
            // 
            this.Mermi_hakki.AutoSize = true;
            this.Mermi_hakki.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.Mermi_hakki.ForeColor = System.Drawing.Color.White;
            this.Mermi_hakki.Location = new System.Drawing.Point(3, 260);
            this.Mermi_hakki.Name = "Mermi_hakki";
            this.Mermi_hakki.Size = new System.Drawing.Size(73, 20);
            this.Mermi_hakki.TabIndex = 18;
            this.Mermi_hakki.TabStop = true;
            this.Mermi_hakki.Text = "Memi At";
            this.Mermi_hakki.UseVisualStyleBackColor = true;
            this.Mermi_hakki.CheckedChanged += new System.EventHandler(this.Mermi_hakki_CheckedChanged);
            // 
            // Yildirim_at
            // 
            this.Yildirim_at.AutoSize = true;
            this.Yildirim_at.Enabled = false;
            this.Yildirim_at.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.Yildirim_at.ForeColor = System.Drawing.Color.White;
            this.Yildirim_at.Location = new System.Drawing.Point(0, 331);
            this.Yildirim_at.Name = "Yildirim_at";
            this.Yildirim_at.Size = new System.Drawing.Size(83, 20);
            this.Yildirim_at.TabIndex = 18;
            this.Yildirim_at.TabStop = true;
            this.Yildirim_at.Text = "Yıldırım At";
            this.Yildirim_at.UseVisualStyleBackColor = true;
            this.Yildirim_at.CheckedChanged += new System.EventHandler(this.Yildirim_hakki_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::UfoYakalamaca.Properties.Resources._41556;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.m_hakki);
            this.panel3.Location = new System.Drawing.Point(84, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 43);
            this.panel3.TabIndex = 19;
            // 
            // m_hakki
            // 
            this.m_hakki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_hakki.AutoSize = true;
            this.m_hakki.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.m_hakki.Location = new System.Drawing.Point(23, 13);
            this.m_hakki.Name = "m_hakki";
            this.m_hakki.Size = new System.Drawing.Size(25, 19);
            this.m_hakki.TabIndex = 0;
            this.m_hakki.Text = "50";
            this.m_hakki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::UfoYakalamaca.Properties.Resources.yıldırım;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.y_hakki);
            this.panel4.Location = new System.Drawing.Point(86, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(65, 37);
            this.panel4.TabIndex = 20;
            // 
            // y_hakki
            // 
            this.y_hakki.AutoSize = true;
            this.y_hakki.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y_hakki.ForeColor = System.Drawing.Color.Yellow;
            this.y_hakki.Location = new System.Drawing.Point(26, 6);
            this.y_hakki.Name = "y_hakki";
            this.y_hakki.Size = new System.Drawing.Size(17, 19);
            this.y_hakki.TabIndex = 0;
            this.y_hakki.Text = "0";
            this.y_hakki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 297);
            this.progressBar1.Maximum = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(145, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UfoYakalamaca.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_yildirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ates3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ates4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ates1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ates2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lYakalanan;
        public System.Windows.Forms.Label lKacan;
        public System.Windows.Forms.ImageList ufolar;
        public System.Windows.Forms.PictureBox ates3;
        public System.Windows.Forms.PictureBox ates1;
        public System.Windows.Forms.PictureBox ates2;
        public System.Windows.Forms.PictureBox ates4;
        private System.Windows.Forms.Timer mermi1;
        private System.Windows.Forms.Timer mermi2;
        private System.Windows.Forms.Timer mermi3;
        private System.Windows.Forms.Timer mermi4;
        private System.Windows.Forms.Timer yildirim;
        public System.Windows.Forms.Button oyuncu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label_cephane;
        public System.Windows.Forms.Label label_para;
        private System.Windows.Forms.Timer mermi_kontrol;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pb_yildirim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label y_hakki;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label m_hakki;
        private System.Windows.Forms.RadioButton Yildirim_at;
        private System.Windows.Forms.RadioButton Mermi_hakki;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

