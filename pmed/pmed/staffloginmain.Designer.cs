namespace pmed
{
    partial class staffloginmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffloginmain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.stfmainPnl = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dctrRegBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.stflogBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.stfmainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dctrRegBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stflogBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // stfmainPnl
            // 
            this.stfmainPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stfmainPnl.BackgroundImage")));
            this.stfmainPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stfmainPnl.Controls.Add(this.bunifuCustomLabel2);
            this.stfmainPnl.Controls.Add(this.bunifuCustomLabel1);
            this.stfmainPnl.Controls.Add(this.dctrRegBtn);
            this.stfmainPnl.Controls.Add(this.stflogBtn);
            this.stfmainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stfmainPnl.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.stfmainPnl.GradientBottomRight = System.Drawing.Color.Firebrick;
            this.stfmainPnl.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.stfmainPnl.GradientTopRight = System.Drawing.Color.Firebrick;
            this.stfmainPnl.Location = new System.Drawing.Point(0, 0);
            this.stfmainPnl.Name = "stfmainPnl";
            this.stfmainPnl.Quality = 10;
            this.stfmainPnl.Size = new System.Drawing.Size(797, 491);
            this.stfmainPnl.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(388, 273);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(117, 29);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "SIGN UP";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(161, 273);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 29);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "LOGIN";
            // 
            // dctrRegBtn
            // 
            this.dctrRegBtn.BackColor = System.Drawing.Color.Transparent;
            this.dctrRegBtn.Image = global::pmed.Properties.Resources.icons8_sign_up_50;
            this.dctrRegBtn.ImageActive = null;
            this.dctrRegBtn.Location = new System.Drawing.Point(393, 159);
            this.dctrRegBtn.Name = "dctrRegBtn";
            this.dctrRegBtn.Size = new System.Drawing.Size(118, 99);
            this.dctrRegBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dctrRegBtn.TabIndex = 5;
            this.dctrRegBtn.TabStop = false;
            this.dctrRegBtn.Zoom = 10;
            this.dctrRegBtn.Click += new System.EventHandler(this.dctrRegBtn_Click);
            // 
            // stflogBtn
            // 
            this.stflogBtn.BackColor = System.Drawing.Color.Transparent;
            this.stflogBtn.Image = global::pmed.Properties.Resources.icons8_lock_80;
            this.stflogBtn.ImageActive = null;
            this.stflogBtn.Location = new System.Drawing.Point(155, 159);
            this.stflogBtn.Name = "stflogBtn";
            this.stflogBtn.Size = new System.Drawing.Size(111, 99);
            this.stflogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stflogBtn.TabIndex = 4;
            this.stflogBtn.TabStop = false;
            this.stflogBtn.Zoom = 10;
            this.stflogBtn.Click += new System.EventHandler(this.stflogBtn_Click);
            // 
            // staffloginmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 491);
            this.Controls.Add(this.stfmainPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffloginmain";
            this.Text = "staffloginmain";
            this.stfmainPnl.ResumeLayout(false);
            this.stfmainPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dctrRegBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stflogBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel stfmainPnl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton dctrRegBtn;
        private Bunifu.Framework.UI.BunifuImageButton stflogBtn;
    }
}