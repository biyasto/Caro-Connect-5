namespace Caro
{
    partial class DrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Player1Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.Player1Name = new Guna.UI.WinForms.GunaTextBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.PLayer2Name = new Guna.UI.WinForms.GunaTextBox();
            this.Player2Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BackButton = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Avatar)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // Player1Avatar
            // 
            this.Player1Avatar.BaseColor = System.Drawing.Color.White;
            this.Player1Avatar.Image = ((System.Drawing.Image)(resources.GetObject("Player1Avatar.Image")));
            this.Player1Avatar.Location = new System.Drawing.Point(16, 18);
            this.Player1Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player1Avatar.Name = "Player1Avatar";
            this.Player1Avatar.Size = new System.Drawing.Size(87, 72);
            this.Player1Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1Avatar.TabIndex = 0;
            this.Player1Avatar.TabStop = false;
            // 
            // Player1Name
            // 
            this.Player1Name.BackColor = System.Drawing.Color.Transparent;
            this.Player1Name.BaseColor = System.Drawing.Color.White;
            this.Player1Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(28)))));
            this.Player1Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Player1Name.Enabled = false;
            this.Player1Name.FocusedBaseColor = System.Drawing.Color.White;
            this.Player1Name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Player1Name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Player1Name.Font = new System.Drawing.Font("Century", 9F);
            this.Player1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(28)))));
            this.Player1Name.Location = new System.Drawing.Point(109, 42);
            this.Player1Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.PasswordChar = '\0';
            this.Player1Name.Radius = 6;
            this.Player1Name.ReadOnly = true;
            this.Player1Name.SelectedText = "";
            this.Player1Name.Size = new System.Drawing.Size(216, 29);
            this.Player1Name.TabIndex = 1;
            this.Player1Name.Text = "PLAYER 1";
            this.Player1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(103)))), ((int)(((byte)(128)))));
            this.gunaShadowPanel1.Controls.Add(this.Player1Name);
            this.gunaShadowPanel1.Controls.Add(this.Player1Avatar);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(1, 66);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 6;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(340, 105);
            this.gunaShadowPanel1.TabIndex = 2;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(103)))), ((int)(((byte)(128)))));
            this.gunaShadowPanel2.Controls.Add(this.PLayer2Name);
            this.gunaShadowPanel2.Controls.Add(this.Player2Avatar);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(397, 66);
            this.gunaShadowPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 6;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(340, 105);
            this.gunaShadowPanel2.TabIndex = 3;
            // 
            // PLayer2Name
            // 
            this.PLayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.PLayer2Name.BaseColor = System.Drawing.Color.White;
            this.PLayer2Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(28)))));
            this.PLayer2Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PLayer2Name.Enabled = false;
            this.PLayer2Name.FocusedBaseColor = System.Drawing.Color.White;
            this.PLayer2Name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PLayer2Name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PLayer2Name.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLayer2Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(28)))));
            this.PLayer2Name.Location = new System.Drawing.Point(109, 42);
            this.PLayer2Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PLayer2Name.Name = "PLayer2Name";
            this.PLayer2Name.PasswordChar = '\0';
            this.PLayer2Name.Radius = 6;
            this.PLayer2Name.ReadOnly = true;
            this.PLayer2Name.SelectedText = "";
            this.PLayer2Name.Size = new System.Drawing.Size(216, 27);
            this.PLayer2Name.TabIndex = 1;
            this.PLayer2Name.Text = "PLAYER 2";
            this.PLayer2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player2Avatar
            // 
            this.Player2Avatar.BaseColor = System.Drawing.Color.White;
            this.Player2Avatar.Image = ((System.Drawing.Image)(resources.GetObject("Player2Avatar.Image")));
            this.Player2Avatar.Location = new System.Drawing.Point(16, 18);
            this.Player2Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player2Avatar.Name = "Player2Avatar";
            this.Player2Avatar.Size = new System.Drawing.Size(87, 72);
            this.Player2Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2Avatar.TabIndex = 0;
            this.Player2Avatar.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(203, 340);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(354, 67);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "TIE GAME";
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
            this.BackButton.Location = new System.Drawing.Point(639, 340);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BackButton.OnHoverForeColor = System.Drawing.Color.White;
            this.BackButton.OnHoverImage = null;
            this.BackButton.OnPressedColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(83, 75);
            this.BackButton.TabIndex = 5;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 438);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DrawForm";
            ((System.ComponentModel.ISupportInitialize)(this.Player1Avatar)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player2Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox Player1Name;
        private Guna.UI.WinForms.GunaPictureBox Player1Avatar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaTextBox PLayer2Name;
        private Guna.UI.WinForms.GunaPictureBox Player2Avatar;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton BackButton;
    }
}