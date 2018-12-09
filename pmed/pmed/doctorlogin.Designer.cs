namespace pmed
{
    partial class doctorlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctorlogin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dctrRegBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.dctrloginBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dctrRegBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctrloginBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.dctrRegBtn);
            this.bunifuGradientPanel1.Controls.Add(this.dctrloginBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Firebrick;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Firebrick;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(797, 491);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(361, 285);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(117, 29);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "SIGN UP";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(134, 285);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 29);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "LOGIN";
            // 
            // dctrRegBtn
            // 
            this.dctrRegBtn.BackColor = System.Drawing.Color.Transparent;
            this.dctrRegBtn.Image = global::pmed.Properties.Resources.icons8_sign_up_50;
            this.dctrRegBtn.ImageActive = null;
            this.dctrRegBtn.Location = new System.Drawing.Point(366, 171);
            this.dctrRegBtn.Name = "dctrRegBtn";
            this.dctrRegBtn.Size = new System.Drawing.Size(118, 99);
            this.dctrRegBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dctrRegBtn.TabIndex = 1;
            this.dctrRegBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.dctrRegBtn, "Create account");
            this.dctrRegBtn.Zoom = 10;
            this.dctrRegBtn.Click += new System.EventHandler(this.dctrRegBtn_Click);
            // 
            // dctrloginBtn
            // 
            this.dctrloginBtn.BackColor = System.Drawing.Color.Transparent;
            this.dctrloginBtn.Image = global::pmed.Properties.Resources.icons8_lock_80;
            this.dctrloginBtn.ImageActive = null;
            this.dctrloginBtn.Location = new System.Drawing.Point(139, 171);
            this.dctrloginBtn.Name = "dctrloginBtn";
            this.dctrloginBtn.Size = new System.Drawing.Size(111, 99);
            this.dctrloginBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dctrloginBtn.TabIndex = 0;
            this.dctrloginBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.dctrloginBtn, "For registered users..");
            this.dctrloginBtn.Zoom = 10;
            this.dctrloginBtn.Click += new System.EventHandler(this.dctrloginBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Click!!";
            // 
            // doctorlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 491);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doctorlogin";
            this.Text = "doctorlogin";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dctrRegBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctrloginBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton dctrloginBtn;
        private Bunifu.Framework.UI.BunifuImageButton dctrRegBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}