namespace Caro

{
    partial class WinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.WinnerAvatar = new Guna.UI.WinForms.GunaPictureBox();
            this.WinnerNameBox = new Guna.UI.WinForms.GunaTextBox();
            this.BackButton = new Guna.UI.WinForms.GunaCircleButton();
            this.PlayerMark = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMark)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // WinnerAvatar
            // 
            this.WinnerAvatar.BackColor = System.Drawing.Color.Transparent;
            this.WinnerAvatar.BaseColor = System.Drawing.Color.White;
            this.WinnerAvatar.Image = ((System.Drawing.Image)(resources.GetObject("WinnerAvatar.Image")));
            this.WinnerAvatar.Location = new System.Drawing.Point(21, 9);
            this.WinnerAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WinnerAvatar.Name = "WinnerAvatar";
            this.WinnerAvatar.Size = new System.Drawing.Size(107, 92);
            this.WinnerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WinnerAvatar.TabIndex = 0;
            this.WinnerAvatar.TabStop = false;
            this.WinnerAvatar.Click += new System.EventHandler(this.WinnerAvatar_Click);
            // 
            // WinnerNameBox
            // 
            this.WinnerNameBox.BackColor = System.Drawing.Color.Transparent;
            this.WinnerNameBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.WinnerNameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(166)))), ((int)(((byte)(88)))));
            this.WinnerNameBox.BorderSize = 3;
            this.WinnerNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WinnerNameBox.Enabled = false;
            this.WinnerNameBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.WinnerNameBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(166)))), ((int)(((byte)(88)))));
            this.WinnerNameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.WinnerNameBox.Font = new System.Drawing.Font("Century", 10F);
            this.WinnerNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.WinnerNameBox.Location = new System.Drawing.Point(144, 22);
            this.WinnerNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WinnerNameBox.Name = "WinnerNameBox";
            this.WinnerNameBox.PasswordChar = '\0';
            this.WinnerNameBox.Radius = 6;
            this.WinnerNameBox.SelectedText = "";
            this.WinnerNameBox.Size = new System.Drawing.Size(246, 35);
            this.WinnerNameBox.TabIndex = 1;
            this.WinnerNameBox.Text = "PLAYER 1";
            this.WinnerNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            this.BackButton.AnimationHoverSpeed = 0.07F;
            this.BackButton.AnimationSpeed = 0.03F;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BaseColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderColor = System.Drawing.Color.Black;
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackButton.FocusedColor = System.Drawing.Color.Empty;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageSize = new System.Drawing.Size(52, 52);
            this.BackButton.Location = new System.Drawing.Point(403, 292);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BackButton.OnHoverForeColor = System.Drawing.Color.White;
            this.BackButton.OnHoverImage = null;
            this.BackButton.OnPressedColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(83, 75);
            this.BackButton.TabIndex = 2;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PlayerMark
            // 
            this.PlayerMark.BackColor = System.Drawing.Color.Transparent;
            this.PlayerMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerMark.BaseColor = System.Drawing.Color.Transparent;
            this.PlayerMark.InitialImage = null;
            this.PlayerMark.Location = new System.Drawing.Point(420, 34);
            this.PlayerMark.Name = "PlayerMark";
            this.PlayerMark.Size = new System.Drawing.Size(46, 42);
            this.PlayerMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerMark.TabIndex = 7;
            this.PlayerMark.TabStop = false;
            this.PlayerMark.UseTransfarantBackground = true;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 376);
            this.Controls.Add(this.PlayerMark);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.WinnerNameBox);
            this.Controls.Add(this.WinnerAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WinForm";
            ((System.ComponentModel.ISupportInitialize)(this.WinnerAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox WinnerNameBox;
        private Guna.UI.WinForms.GunaPictureBox WinnerAvatar;
        private Guna.UI.WinForms.GunaCircleButton BackButton;
        public Guna.UI.WinForms.GunaCirclePictureBox PlayerMark;
    }
}