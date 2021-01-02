namespace Caro
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ModeButton = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.SettingButton = new Guna.UI.WinForms.GunaButton();
            this.ContinueButton = new Guna.UI.WinForms.GunaButton();
            this.Exit_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.StartPvPButton = new Guna.UI.WinForms.GunaButton();
            this.StartPvCButton = new Guna.UI.WinForms.GunaButton();
            this.Logo = new Guna.UI.WinForms.GunaPictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // ModeButton
            // 
            this.ModeButton.AnimationHoverSpeed = 0.07F;
            this.ModeButton.AnimationSpeed = 0.03F;
            this.ModeButton.BackColor = System.Drawing.Color.Transparent;
            this.ModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ModeButton.BaseColor = System.Drawing.Color.Transparent;
            this.ModeButton.BorderColor = System.Drawing.Color.Transparent;
            this.ModeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModeButton.FocusedColor = System.Drawing.Color.Empty;
            this.ModeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.ModeButton.Image = ((System.Drawing.Image)(resources.GetObject("ModeButton.Image")));
            this.ModeButton.ImageSize = new System.Drawing.Size(35, 35);
            this.ModeButton.Location = new System.Drawing.Point(0, 0);
            this.ModeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.ModeButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ModeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ModeButton.OnHoverImage = null;
            this.ModeButton.OnPressedColor = System.Drawing.Color.Black;
            this.ModeButton.Radius = 5;
            this.ModeButton.Size = new System.Drawing.Size(146, 37);
            this.ModeButton.TabIndex = 1;
            this.ModeButton.Text = "PLAY MODE";
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.SettingButton);
            this.gunaPanel1.Controls.Add(this.ContinueButton);
            this.gunaPanel1.Controls.Add(this.Exit_Button);
            this.gunaPanel1.Controls.Add(this.gunaButton3);
            this.gunaPanel1.Controls.Add(this.gunaButton2);
            this.gunaPanel1.Controls.Add(this.ModeButton);
            this.gunaPanel1.Location = new System.Drawing.Point(26, 132);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(153, 295);
            this.gunaPanel1.TabIndex = 2;
            // 
            // SettingButton
            // 
            this.SettingButton.AnimationHoverSpeed = 0.07F;
            this.SettingButton.AnimationSpeed = 0.03F;
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingButton.BaseColor = System.Drawing.Color.Transparent;
            this.SettingButton.BorderColor = System.Drawing.Color.Black;
            this.SettingButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingButton.FocusedColor = System.Drawing.Color.Empty;
            this.SettingButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.SettingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageSize = new System.Drawing.Size(35, 35);
            this.SettingButton.Location = new System.Drawing.Point(0, 202);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.SettingButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SettingButton.OnHoverImage = null;
            this.SettingButton.OnPressedColor = System.Drawing.Color.Black;
            this.SettingButton.Radius = 6;
            this.SettingButton.Size = new System.Drawing.Size(146, 37);
            this.SettingButton.TabIndex = 7;
            this.SettingButton.Text = "SETTING";
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.AnimationHoverSpeed = 0.07F;
            this.ContinueButton.AnimationSpeed = 0.03F;
            this.ContinueButton.BackColor = System.Drawing.Color.Transparent;
            this.ContinueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContinueButton.BaseColor = System.Drawing.Color.Transparent;
            this.ContinueButton.BorderColor = System.Drawing.Color.Black;
            this.ContinueButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ContinueButton.FocusedColor = System.Drawing.Color.Empty;
            this.ContinueButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ContinueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.ContinueButton.Image = ((System.Drawing.Image)(resources.GetObject("ContinueButton.Image")));
            this.ContinueButton.ImageSize = new System.Drawing.Size(35, 35);
            this.ContinueButton.Location = new System.Drawing.Point(0, 50);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.ContinueButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ContinueButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ContinueButton.OnHoverImage = null;
            this.ContinueButton.OnPressedColor = System.Drawing.Color.Black;
            this.ContinueButton.Radius = 5;
            this.ContinueButton.Size = new System.Drawing.Size(146, 37);
            this.ContinueButton.TabIndex = 6;
            this.ContinueButton.Text = "CONTINUE";
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.AnimationHoverSpeed = 0.07F;
            this.Exit_Button.AnimationSpeed = 0.03F;
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Exit_Button.BorderColor = System.Drawing.Color.Black;
            this.Exit_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Exit_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Exit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Button.Image")));
            this.Exit_Button.ImageSize = new System.Drawing.Size(35, 35);
            this.Exit_Button.Location = new System.Drawing.Point(0, 249);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.Exit_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Exit_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.Exit_Button.OnHoverImage = null;
            this.Exit_Button.OnPressedColor = System.Drawing.Color.Black;
            this.Exit_Button.Radius = 6;
            this.Exit_Button.Size = new System.Drawing.Size(146, 37);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.Text = "EXIT";
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaButton3.Location = new System.Drawing.Point(0, 154);
            this.gunaButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 5;
            this.gunaButton3.Size = new System.Drawing.Size(146, 37);
            this.gunaButton3.TabIndex = 5;
            this.gunaButton3.Text = "CREDIT";
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaButton2.Location = new System.Drawing.Point(0, 102);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(146, 37);
            this.gunaButton2.TabIndex = 4;
            this.gunaButton2.Text = "RULE";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // StartPvPButton
            // 
            this.StartPvPButton.AnimationHoverSpeed = 0.07F;
            this.StartPvPButton.AnimationSpeed = 0.03F;
            this.StartPvPButton.BackColor = System.Drawing.Color.Transparent;
            this.StartPvPButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.StartPvPButton.BorderColor = System.Drawing.Color.Black;
            this.StartPvPButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartPvPButton.FocusedColor = System.Drawing.Color.Empty;
            this.StartPvPButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPvPButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.StartPvPButton.Image = null;
            this.StartPvPButton.ImageSize = new System.Drawing.Size(20, 20);
            this.StartPvPButton.Location = new System.Drawing.Point(183, 110);
            this.StartPvPButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartPvPButton.Name = "StartPvPButton";
            this.StartPvPButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.StartPvPButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.StartPvPButton.OnHoverForeColor = System.Drawing.Color.White;
            this.StartPvPButton.OnHoverImage = null;
            this.StartPvPButton.OnPressedColor = System.Drawing.Color.Black;
            this.StartPvPButton.Radius = 8;
            this.StartPvPButton.Size = new System.Drawing.Size(150, 44);
            this.StartPvPButton.TabIndex = 2;
            this.StartPvPButton.Text = "PLAY WITH FRIEND";
            this.StartPvPButton.Visible = false;
            this.StartPvPButton.Click += new System.EventHandler(this.StartPvPButton_Click);
            // 
            // StartPvCButton
            // 
            this.StartPvCButton.AnimationHoverSpeed = 0.07F;
            this.StartPvCButton.AnimationSpeed = 0.03F;
            this.StartPvCButton.BackColor = System.Drawing.Color.Transparent;
            this.StartPvCButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.StartPvCButton.BorderColor = System.Drawing.Color.Black;
            this.StartPvCButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartPvCButton.FocusedColor = System.Drawing.Color.Empty;
            this.StartPvCButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPvCButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.StartPvCButton.Image = null;
            this.StartPvCButton.ImageSize = new System.Drawing.Size(20, 20);
            this.StartPvCButton.Location = new System.Drawing.Point(183, 158);
            this.StartPvCButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartPvCButton.Name = "StartPvCButton";
            this.StartPvCButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.StartPvCButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.StartPvCButton.OnHoverForeColor = System.Drawing.Color.White;
            this.StartPvCButton.OnHoverImage = null;
            this.StartPvCButton.OnPressedColor = System.Drawing.Color.Black;
            this.StartPvCButton.Radius = 8;
            this.StartPvCButton.Size = new System.Drawing.Size(150, 44);
            this.StartPvCButton.TabIndex = 3;
            this.StartPvCButton.Text = "PLAY WITH COMPUTER";
            this.StartPvCButton.Visible = false;
            this.StartPvCButton.Click += new System.EventHandler(this.StartPvCButton_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BaseColor = System.Drawing.Color.White;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(26, 7);
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(129, 123);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            this.Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseMove);
            this.Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseUp);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(664, 449);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 490);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.StartPvCButton);
            this.Controls.Add(this.StartPvPButton);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro";
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        public Guna.UI.WinForms.GunaButton ModeButton;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton Exit_Button;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton StartPvCButton;
        private Guna.UI.WinForms.GunaButton StartPvPButton;
        private Guna.UI.WinForms.GunaPictureBox Logo;
        private Guna.UI.WinForms.GunaButton ContinueButton;
        private Guna.UI.WinForms.GunaButton SettingButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

