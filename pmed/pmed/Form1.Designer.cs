namespace pmed
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.minimizebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.mainpnl = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.slidingpnl = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.helpbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.resbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.staffbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.doctorbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menubtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainpnlanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpnl.SuspendLayout();
            this.slidingpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // header
            // 
            this.header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("header.BackgroundImage")));
            this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.header.Controls.Add(this.minimizebtn);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.mainpnlanimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.header.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.header.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.header.GradientTopRight = System.Drawing.Color.DarkRed;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Quality = 10;
            this.header.Size = new System.Drawing.Size(847, 30);
            this.header.TabIndex = 1;
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.mainpnlanimator.SetDecoration(this.minimizebtn, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.minimizebtn, BunifuAnimatorNS.DecorationType.None);
            this.minimizebtn.Image = global::pmed.Properties.Resources.icons8_Minimize_Window_64;
            this.minimizebtn.ImageActive = null;
            this.minimizebtn.Location = new System.Drawing.Point(791, 0);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(28, 30);
            this.minimizebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizebtn.TabIndex = 3;
            this.minimizebtn.TabStop = false;
            this.minimizebtn.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.mainpnlanimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::pmed.Properties.Resources.icons8_Cancel_64;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(819, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(28, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pnlanimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.mainpnlanimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::pmed.Properties.Resources.icons8_Update_User_64;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.pnlanimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.mainpnlanimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 19);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "PMED System";
            // 
            // pnlanimator
            // 
            this.pnlanimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.pnlanimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.pnlanimator.DefaultAnimation = animation1;
            this.pnlanimator.Interval = 150;
            this.pnlanimator.MaxAnimationTime = 700;
            this.pnlanimator.TimeStep = 0.11F;
            // 
            // mainpnl
            // 
            this.mainpnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainpnl.BackgroundImage")));
            this.mainpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainpnl.Controls.Add(this.bunifuCustomLabel4);
            this.mainpnl.Controls.Add(this.bunifuCustomLabel3);
            this.mainpnl.Controls.Add(this.bunifuCustomLabel2);
            this.mainpnlanimator.SetDecoration(this.mainpnl, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.mainpnl, BunifuAnimatorNS.DecorationType.None);
            this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpnl.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.mainpnl.GradientBottomRight = System.Drawing.Color.Firebrick;
            this.mainpnl.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.mainpnl.GradientTopRight = System.Drawing.Color.Firebrick;
            this.mainpnl.Location = new System.Drawing.Point(234, 30);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Quality = 10;
            this.mainpnl.Size = new System.Drawing.Size(613, 491);
            this.mainpnl.TabIndex = 2;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.pnlanimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.mainpnlanimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("OCR A Extended", 17F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(249, 324);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(100, 24);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "System";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.pnlanimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.mainpnlanimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("OCR A Extended", 17F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(52, 282);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(505, 24);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Patient Medical Record Management";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.pnlanimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.mainpnlanimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(166, 183);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(278, 99);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "PMED";
            // 
            // slidingpnl
            // 
            this.slidingpnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slidingpnl.BackgroundImage")));
            this.slidingpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slidingpnl.Controls.Add(this.helpbtn);
            this.slidingpnl.Controls.Add(this.resbtn);
            this.slidingpnl.Controls.Add(this.staffbtn);
            this.slidingpnl.Controls.Add(this.doctorbtn);
            this.slidingpnl.Controls.Add(this.menubtn);
            this.mainpnlanimator.SetDecoration(this.slidingpnl, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.slidingpnl, BunifuAnimatorNS.DecorationType.None);
            this.slidingpnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingpnl.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.slidingpnl.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.slidingpnl.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.slidingpnl.GradientTopRight = System.Drawing.Color.Black;
            this.slidingpnl.Location = new System.Drawing.Point(0, 30);
            this.slidingpnl.Name = "slidingpnl";
            this.slidingpnl.Quality = 10;
            this.slidingpnl.Size = new System.Drawing.Size(234, 491);
            this.slidingpnl.TabIndex = 0;
            // 
            // helpbtn
            // 
            this.helpbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.helpbtn.BackColor = System.Drawing.Color.Transparent;
            this.helpbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpbtn.BorderRadius = 0;
            this.helpbtn.ButtonText = "    Help";
            this.helpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainpnlanimator.SetDecoration(this.helpbtn, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.helpbtn, BunifuAnimatorNS.DecorationType.None);
            this.helpbtn.DisabledColor = System.Drawing.Color.Gray;
            this.helpbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.helpbtn.Iconimage = global::pmed.Properties.Resources.icons8_online_support_50;
            this.helpbtn.Iconimage_right = null;
            this.helpbtn.Iconimage_right_Selected = null;
            this.helpbtn.Iconimage_Selected = null;
            this.helpbtn.IconMarginLeft = 0;
            this.helpbtn.IconMarginRight = 0;
            this.helpbtn.IconRightVisible = true;
            this.helpbtn.IconRightZoom = 0D;
            this.helpbtn.IconVisible = true;
            this.helpbtn.IconZoom = 70D;
            this.helpbtn.IsTab = false;
            this.helpbtn.Location = new System.Drawing.Point(-13, 393);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.helpbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.helpbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.helpbtn.selected = false;
            this.helpbtn.Size = new System.Drawing.Size(247, 86);
            this.helpbtn.TabIndex = 4;
            this.helpbtn.Text = "    Help";
            this.helpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpbtn.Textcolor = System.Drawing.Color.Gainsboro;
            this.helpbtn.TextFont = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // resbtn
            // 
            this.resbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.resbtn.BackColor = System.Drawing.Color.Transparent;
            this.resbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resbtn.BorderRadius = 0;
            this.resbtn.ButtonText = "     Researches";
            this.resbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainpnlanimator.SetDecoration(this.resbtn, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.resbtn, BunifuAnimatorNS.DecorationType.None);
            this.resbtn.DisabledColor = System.Drawing.Color.Gray;
            this.resbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.resbtn.Iconimage = global::pmed.Properties.Resources.icons8_microscope_64;
            this.resbtn.Iconimage_right = null;
            this.resbtn.Iconimage_right_Selected = null;
            this.resbtn.Iconimage_Selected = null;
            this.resbtn.IconMarginLeft = 0;
            this.resbtn.IconMarginRight = 0;
            this.resbtn.IconRightVisible = true;
            this.resbtn.IconRightZoom = 0D;
            this.resbtn.IconVisible = true;
            this.resbtn.IconZoom = 70D;
            this.resbtn.IsTab = false;
            this.resbtn.Location = new System.Drawing.Point(-13, 301);
            this.resbtn.Name = "resbtn";
            this.resbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.resbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.resbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.resbtn.selected = false;
            this.resbtn.Size = new System.Drawing.Size(247, 86);
            this.resbtn.TabIndex = 3;
            this.resbtn.Text = "     Researches";
            this.resbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resbtn.Textcolor = System.Drawing.Color.Gainsboro;
            this.resbtn.TextFont = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resbtn.Click += new System.EventHandler(this.resbtn_Click);
            // 
            // staffbtn
            // 
            this.staffbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.staffbtn.BackColor = System.Drawing.Color.Transparent;
            this.staffbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staffbtn.BorderRadius = 0;
            this.staffbtn.ButtonText = "     Medical staff";
            this.staffbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainpnlanimator.SetDecoration(this.staffbtn, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.staffbtn, BunifuAnimatorNS.DecorationType.None);
            this.staffbtn.DisabledColor = System.Drawing.Color.Gray;
            this.staffbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.staffbtn.Iconimage = global::pmed.Properties.Resources.icons8_nurse_50;
            this.staffbtn.Iconimage_right = null;
            this.staffbtn.Iconimage_right_Selected = null;
            this.staffbtn.Iconimage_Selected = null;
            this.staffbtn.IconMarginLeft = 0;
            this.staffbtn.IconMarginRight = 0;
            this.staffbtn.IconRightVisible = true;
            this.staffbtn.IconRightZoom = 0D;
            this.staffbtn.IconVisible = true;
            this.staffbtn.IconZoom = 70D;
            this.staffbtn.IsTab = false;
            this.staffbtn.Location = new System.Drawing.Point(-14, 186);
            this.staffbtn.Name = "staffbtn";
            this.staffbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.staffbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.staffbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.staffbtn.selected = false;
            this.staffbtn.Size = new System.Drawing.Size(248, 86);
            this.staffbtn.TabIndex = 2;
            this.staffbtn.Text = "     Medical staff";
            this.staffbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffbtn.Textcolor = System.Drawing.Color.Gainsboro;
            this.staffbtn.TextFont = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffbtn.Click += new System.EventHandler(this.staffbtn_Click);
            // 
            // doctorbtn
            // 
            this.doctorbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.doctorbtn.BackColor = System.Drawing.Color.Transparent;
            this.doctorbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doctorbtn.BorderRadius = 0;
            this.doctorbtn.ButtonText = "      Doctors";
            this.doctorbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainpnlanimator.SetDecoration(this.doctorbtn, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.doctorbtn, BunifuAnimatorNS.DecorationType.None);
            this.doctorbtn.DisabledColor = System.Drawing.Color.Gray;
            this.doctorbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.doctorbtn.Iconimage = global::pmed.Properties.Resources.icons8_medical_doctor_80__1_;
            this.doctorbtn.Iconimage_right = null;
            this.doctorbtn.Iconimage_right_Selected = null;
            this.doctorbtn.Iconimage_Selected = null;
            this.doctorbtn.IconMarginLeft = 0;
            this.doctorbtn.IconMarginRight = 0;
            this.doctorbtn.IconRightVisible = true;
            this.doctorbtn.IconRightZoom = 0D;
            this.doctorbtn.IconVisible = true;
            this.doctorbtn.IconZoom = 70D;
            this.doctorbtn.IsTab = false;
            this.doctorbtn.Location = new System.Drawing.Point(-14, 78);
            this.doctorbtn.Name = "doctorbtn";
            this.doctorbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.doctorbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.doctorbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.doctorbtn.selected = true;
            this.doctorbtn.Size = new System.Drawing.Size(248, 86);
            this.doctorbtn.TabIndex = 1;
            this.doctorbtn.Text = "      Doctors";
            this.doctorbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorbtn.Textcolor = System.Drawing.Color.Gainsboro;
            this.doctorbtn.TextFont = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorbtn.Click += new System.EventHandler(this.doctorbtn_Click);
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.Transparent;
            this.mainpnlanimator.SetDecoration(this.menubtn, BunifuAnimatorNS.DecorationType.None);
            this.pnlanimator.SetDecoration(this.menubtn, BunifuAnimatorNS.DecorationType.None);
            this.menubtn.Image = global::pmed.Properties.Resources.menu_alt_512;
            this.menubtn.ImageActive = null;
            this.menubtn.Location = new System.Drawing.Point(12, 4);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(31, 24);
            this.menubtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menubtn.TabIndex = 0;
            this.menubtn.TabStop = false;
            this.menubtn.Zoom = 10;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // mainpnlanimator
            // 
            this.mainpnlanimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.mainpnlanimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.mainpnlanimator.DefaultAnimation = animation2;
            this.mainpnlanimator.Interval = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 521);
            this.Controls.Add(this.mainpnl);
            this.Controls.Add(this.slidingpnl);
            this.Controls.Add(this.header);
            this.pnlanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.mainpnlanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpnl.ResumeLayout(false);
            this.mainpnl.PerformLayout();
            this.slidingpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel slidingpnl;
        private Bunifu.Framework.UI.BunifuGradientPanel header;
        private Bunifu.Framework.UI.BunifuImageButton menubtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton minimizebtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton doctorbtn;
        private Bunifu.Framework.UI.BunifuFlatButton resbtn;
        private Bunifu.Framework.UI.BunifuFlatButton staffbtn;
        private Bunifu.Framework.UI.BunifuFlatButton helpbtn;
        private Bunifu.Framework.UI.BunifuGradientPanel mainpnl;
        private BunifuAnimatorNS.BunifuTransition pnlanimator;
        private BunifuAnimatorNS.BunifuTransition mainpnlanimator;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}

