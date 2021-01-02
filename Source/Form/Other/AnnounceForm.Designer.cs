namespace Caro
{
    partial class AnnounceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnounceForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.NameBox = new Guna.UI.WinForms.GunaTextBox();
            this.StartButton = new Guna.UI.WinForms.GunaImageButton();
            this.PlayerMark = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMark)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Cooper Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(43)))), ((int)(((byte)(102)))));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(526, 42);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "THE FIRST MOVE PLAYER";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.Transparent;
            this.Avatar.BaseColor = System.Drawing.Color.Transparent;
            this.Avatar.Image = ((System.Drawing.Image)(resources.GetObject("Avatar.Image")));
            this.Avatar.Location = new System.Drawing.Point(51, 81);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(124, 113);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 1;
            this.Avatar.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.Transparent;
            this.NameBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(164)))), ((int)(((byte)(223)))));
            this.NameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(112)))));
            this.NameBox.BorderSize = 3;
            this.NameBox.CausesValidation = false;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.Enabled = false;
            this.NameBox.FocusedBaseColor = System.Drawing.Color.White;
            this.NameBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.NameBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(73)))));
            this.NameBox.Location = new System.Drawing.Point(181, 112);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.Radius = 6;
            this.NameBox.ReadOnly = true;
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(277, 43);
            this.NameBox.TabIndex = 3;
            this.NameBox.Text = "PLAYER 1";
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageSize = new System.Drawing.Size(75, 75);
            this.StartButton.Location = new System.Drawing.Point(469, 274);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.OnHoverImage = null;
            this.StartButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.StartButton.Size = new System.Drawing.Size(116, 69);
            this.StartButton.TabIndex = 4;
            this.StartButton.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // PlayerMark
            // 
            this.PlayerMark.BackColor = System.Drawing.Color.Transparent;
            this.PlayerMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerMark.BaseColor = System.Drawing.Color.Transparent;
            this.PlayerMark.InitialImage = null;
            this.PlayerMark.Location = new System.Drawing.Point(486, 112);
            this.PlayerMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerMark.Name = "PlayerMark";
            this.PlayerMark.Size = new System.Drawing.Size(45, 42);
            this.PlayerMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerMark.TabIndex = 6;
            this.PlayerMark.TabStop = false;
            this.PlayerMark.UseTransfarantBackground = true;
            // 
            // AnnounceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 354);
            this.Controls.Add(this.PlayerMark);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnnounceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AnnounceForm";
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageButton StartButton;
        private Guna.UI.WinForms.GunaTextBox NameBox;
        private Guna.UI.WinForms.GunaPictureBox Avatar;
        public Guna.UI.WinForms.GunaCirclePictureBox PlayerMark;
    }
}