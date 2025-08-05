namespace Lucent_V2
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimizeAppBTN = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CloseAppBTN = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LogoWebsiteBTN = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ProfilePictureIMG = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ExtraMenuBTN = new Guna.UI2.WinForms.Guna2PictureBox();
            this.VisionMenuBTN = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AIMenuBTN = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.aiMenu1 = new Lucent_V2.AIMenu();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeAppBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseAppBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoWebsiteBTN)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraMenuBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisionMenuBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIMenuBTN)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationInterval = 250;
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragEndTransparencyValue = 0.9D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BorderRadius = 15;
            this.TopPanel.Controls.Add(this.MinimizeAppBTN);
            this.TopPanel.Controls.Add(this.CloseAppBTN);
            this.TopPanel.Controls.Add(this.LogoWebsiteBTN);
            this.TopPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(19)))));
            this.TopPanel.Location = new System.Drawing.Point(12, 12);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(776, 56);
            this.TopPanel.TabIndex = 0;
            // 
            // MinimizeAppBTN
            // 
            this.MinimizeAppBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeAppBTN.Image = global::Lucent_V2.Properties.Resources.Minimize;
            this.MinimizeAppBTN.ImageRotate = 0F;
            this.MinimizeAppBTN.Location = new System.Drawing.Point(703, 3);
            this.MinimizeAppBTN.Name = "MinimizeAppBTN";
            this.MinimizeAppBTN.Size = new System.Drawing.Size(26, 50);
            this.MinimizeAppBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeAppBTN.TabIndex = 2;
            this.MinimizeAppBTN.TabStop = false;
            // 
            // CloseAppBTN
            // 
            this.CloseAppBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAppBTN.Image = global::Lucent_V2.Properties.Resources.Close1;
            this.CloseAppBTN.ImageRotate = 0F;
            this.CloseAppBTN.Location = new System.Drawing.Point(735, 3);
            this.CloseAppBTN.Name = "CloseAppBTN";
            this.CloseAppBTN.Size = new System.Drawing.Size(26, 50);
            this.CloseAppBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseAppBTN.TabIndex = 1;
            this.CloseAppBTN.TabStop = false;
            // 
            // LogoWebsiteBTN
            // 
            this.LogoWebsiteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoWebsiteBTN.Image = global::Lucent_V2.Properties.Resources.LucentLogo;
            this.LogoWebsiteBTN.ImageRotate = 0F;
            this.LogoWebsiteBTN.Location = new System.Drawing.Point(3, 3);
            this.LogoWebsiteBTN.Name = "LogoWebsiteBTN";
            this.LogoWebsiteBTN.Size = new System.Drawing.Size(112, 50);
            this.LogoWebsiteBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoWebsiteBTN.TabIndex = 0;
            this.LogoWebsiteBTN.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Transparent;
            this.SidePanel.BorderRadius = 15;
            this.SidePanel.Controls.Add(this.ProfilePictureIMG);
            this.SidePanel.Controls.Add(this.ExtraMenuBTN);
            this.SidePanel.Controls.Add(this.VisionMenuBTN);
            this.SidePanel.Controls.Add(this.AIMenuBTN);
            this.SidePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(19)))));
            this.SidePanel.Location = new System.Drawing.Point(732, 74);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(56, 406);
            this.SidePanel.TabIndex = 1;
            // 
            // ProfilePictureIMG
            // 
            this.ProfilePictureIMG.Image = global::Lucent_V2.Properties.Resources.user;
            this.ProfilePictureIMG.ImageRotate = 0F;
            this.ProfilePictureIMG.Location = new System.Drawing.Point(8, 363);
            this.ProfilePictureIMG.Name = "ProfilePictureIMG";
            this.ProfilePictureIMG.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfilePictureIMG.Size = new System.Drawing.Size(40, 40);
            this.ProfilePictureIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureIMG.TabIndex = 7;
            this.ProfilePictureIMG.TabStop = false;
            // 
            // ExtraMenuBTN
            // 
            this.ExtraMenuBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtraMenuBTN.Image = global::Lucent_V2.Properties.Resources.deep_learning;
            this.ExtraMenuBTN.ImageRotate = 0F;
            this.ExtraMenuBTN.Location = new System.Drawing.Point(8, 99);
            this.ExtraMenuBTN.Name = "ExtraMenuBTN";
            this.ExtraMenuBTN.Size = new System.Drawing.Size(40, 40);
            this.ExtraMenuBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExtraMenuBTN.TabIndex = 6;
            this.ExtraMenuBTN.TabStop = false;
            // 
            // VisionMenuBTN
            // 
            this.VisionMenuBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisionMenuBTN.Image = global::Lucent_V2.Properties.Resources.vision;
            this.VisionMenuBTN.ImageRotate = 0F;
            this.VisionMenuBTN.Location = new System.Drawing.Point(8, 53);
            this.VisionMenuBTN.Name = "VisionMenuBTN";
            this.VisionMenuBTN.Size = new System.Drawing.Size(40, 40);
            this.VisionMenuBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VisionMenuBTN.TabIndex = 5;
            this.VisionMenuBTN.TabStop = false;
            // 
            // AIMenuBTN
            // 
            this.AIMenuBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AIMenuBTN.Image = global::Lucent_V2.Properties.Resources.objectives;
            this.AIMenuBTN.ImageRotate = 0F;
            this.AIMenuBTN.Location = new System.Drawing.Point(8, 7);
            this.AIMenuBTN.Name = "AIMenuBTN";
            this.AIMenuBTN.Size = new System.Drawing.Size(40, 40);
            this.AIMenuBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AIMenuBTN.TabIndex = 3;
            this.AIMenuBTN.TabStop = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.BorderRadius = 15;
            this.MenuPanel.Controls.Add(this.aiMenu1);
            this.MenuPanel.FillColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Location = new System.Drawing.Point(12, 74);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(714, 406);
            this.MenuPanel.TabIndex = 2;
            // 
            // aiMenu1
            // 
            this.aiMenu1.BackColor = System.Drawing.Color.Transparent;
            this.aiMenu1.ForeColor = System.Drawing.Color.White;
            this.aiMenu1.Location = new System.Drawing.Point(0, 0);
            this.aiMenu1.Name = "aiMenu1";
            this.aiMenu1.Size = new System.Drawing.Size(714, 406);
            this.aiMenu1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragEndTransparencyValue = 0.9D;
            this.guna2DragControl1.TargetControl = this.TopPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.DragEndTransparencyValue = 0.9D;
            this.guna2DragControl2.TargetControl = this.SidePanel;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Protected8b1h45v6s7z1m";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeAppBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseAppBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoWebsiteBTN)).EndInit();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraMenuBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisionMenuBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIMenuBTN)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Panel SidePanel;
        private Guna.UI2.WinForms.Guna2PictureBox LogoWebsiteBTN;
        private Guna.UI2.WinForms.Guna2PictureBox CloseAppBTN;
        private Guna.UI2.WinForms.Guna2PictureBox MinimizeAppBTN;
        private Guna.UI2.WinForms.Guna2Panel MenuPanel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2PictureBox AIMenuBTN;
        private Guna.UI2.WinForms.Guna2PictureBox ExtraMenuBTN;
        private Guna.UI2.WinForms.Guna2PictureBox VisionMenuBTN;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfilePictureIMG;
        private AIMenu aiMenu1;
    }
}

