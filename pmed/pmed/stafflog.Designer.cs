namespace pmed
{
    partial class stafflog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stafflog));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.stfloginPnl = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.stfloginPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // stfloginPnl
            // 
            this.stfloginPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stfloginPnl.BackgroundImage")));
            this.stfloginPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stfloginPnl.Controls.Add(this.bunifuImageButton2);
            this.stfloginPnl.Controls.Add(this.bunifuImageButton1);
            this.stfloginPnl.Controls.Add(this.bunifuTextbox2);
            this.stfloginPnl.Controls.Add(this.bunifuTextbox1);
            this.stfloginPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stfloginPnl.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.stfloginPnl.GradientBottomRight = System.Drawing.Color.Firebrick;
            this.stfloginPnl.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.stfloginPnl.GradientTopRight = System.Drawing.Color.Firebrick;
            this.stfloginPnl.Location = new System.Drawing.Point(0, 0);
            this.stfloginPnl.Name = "stfloginPnl";
            this.stfloginPnl.Quality = 10;
            this.stfloginPnl.Size = new System.Drawing.Size(797, 491);
            this.stfloginPnl.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::pmed.Properties.Resources.icons8_back_26;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::pmed.Properties.Resources.icons8_Sent_64;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(321, 312);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 57);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuTextbox2
            // 
            this.bunifuTextbox2.AutoSize = true;
            this.bunifuTextbox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuTextbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.BackgroundImage")));
            this.bunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextbox2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuTextbox2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.Icon")));
            this.bunifuTextbox2.Location = new System.Drawing.Point(261, 220);
            this.bunifuTextbox2.Name = "bunifuTextbox2";
            this.bunifuTextbox2.Size = new System.Drawing.Size(186, 54);
            this.bunifuTextbox2.TabIndex = 5;
            this.bunifuTextbox2.text = "Password";
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.AutoSize = true;
            this.bunifuTextbox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(261, 138);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(186, 54);
            this.bunifuTextbox1.TabIndex = 4;
            this.bunifuTextbox1.text = "User name";
            // 
            // stafflog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 491);
            this.Controls.Add(this.stfloginPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stafflog";
            this.Text = "stafflog";
            this.stfloginPnl.ResumeLayout(false);
            this.stfloginPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel stfloginPnl;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox2;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}