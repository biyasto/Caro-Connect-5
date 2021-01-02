namespace Caro
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Player1NameBox = new Guna.UI.WinForms.GunaTextBox();
            this.Player2NameBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaCirclePictureBox3 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.BackButton = new Guna.UI.WinForms.GunaCircleButton();
            this.StartButton = new Guna.UI.WinForms.GunaCircleButton();
            this.avap1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.avap2 = new System.Windows.Forms.PictureBox();
            this.PanelPlayer1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.PanelPlayer2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.Player1Mark = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Player2Mark = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Logo = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avap2)).BeginInit();
            this.PanelPlayer1.SuspendLayout();
            this.PanelPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // Player1NameBox
            // 
            this.Player1NameBox.BackColor = System.Drawing.Color.Transparent;
            this.Player1NameBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.Player1NameBox.BorderColor = System.Drawing.Color.Transparent;
            this.Player1NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Player1NameBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.Player1NameBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.Player1NameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Player1NameBox.Font = new System.Drawing.Font("Century", 9F);
            this.Player1NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.Player1NameBox.Location = new System.Drawing.Point(115, 45);
            this.Player1NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player1NameBox.MaxLength = 20;
            this.Player1NameBox.Name = "Player1NameBox";
            this.Player1NameBox.PasswordChar = '\0';
            this.Player1NameBox.Radius = 6;
            this.Player1NameBox.SelectedText = "";
            this.Player1NameBox.Size = new System.Drawing.Size(196, 42);
            this.Player1NameBox.TabIndex = 1;
            this.Player1NameBox.Text = "PLAYER 1";
            this.Player1NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Player1NameBox.Enter += new System.EventHandler(this.PlayerNameBox_Enter);
            this.Player1NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerNameBox_KeyPress);
            // 
            // Player2NameBox
            // 
            this.Player2NameBox.BackColor = System.Drawing.Color.Transparent;
            this.Player2NameBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.Player2NameBox.BorderColor = System.Drawing.Color.Transparent;
            this.Player2NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Player2NameBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.Player2NameBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.Player2NameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Player2NameBox.Font = new System.Drawing.Font("Century", 9F);
            this.Player2NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.Player2NameBox.Location = new System.Drawing.Point(115, 45);
            this.Player2NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player2NameBox.MaxLength = 20;
            this.Player2NameBox.Name = "Player2NameBox";
            this.Player2NameBox.PasswordChar = '\0';
            this.Player2NameBox.Radius = 6;
            this.Player2NameBox.SelectedText = "";
            this.Player2NameBox.Size = new System.Drawing.Size(196, 42);
            this.Player2NameBox.TabIndex = 1;
            this.Player2NameBox.Text = "PLAYER 2";
            this.Player2NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Player2NameBox.Enter += new System.EventHandler(this.PlayerNameBox_Enter);
            this.Player2NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerNameBox_KeyPress);
            // 
            // gunaCirclePictureBox3
            // 
            this.gunaCirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox3.Image")));
            this.gunaCirclePictureBox3.Location = new System.Drawing.Point(434, 106);
            this.gunaCirclePictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCirclePictureBox3.Name = "gunaCirclePictureBox3";
            this.gunaCirclePictureBox3.Size = new System.Drawing.Size(131, 117);
            this.gunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox3.TabIndex = 2;
            this.gunaCirclePictureBox3.TabStop = false;
            this.gunaCirclePictureBox3.UseTransfarantBackground = false;
            // 
            // BackButton
            // 
            this.BackButton.AnimationHoverSpeed = 0.07F;
            this.BackButton.AnimationSpeed = 0.03F;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.BaseColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderSize = 1;
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackButton.FocusedColor = System.Drawing.Color.Empty;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.BackButton.Image = null;
            this.BackButton.ImageSize = new System.Drawing.Size(52, 52);
            this.BackButton.Location = new System.Drawing.Point(11, 416);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BackButton.OnHoverForeColor = System.Drawing.Color.White;
            this.BackButton.OnHoverImage = null;
            this.BackButton.OnPressedColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(98, 89);
            this.BackButton.TabIndex = 4;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.AnimationHoverSpeed = 0.07F;
            this.StartButton.AnimationSpeed = 0.03F;
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.BaseColor = System.Drawing.Color.Transparent;
            this.StartButton.BorderColor = System.Drawing.Color.Transparent;
            this.StartButton.BorderSize = 1;
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartButton.FocusedColor = System.Drawing.Color.Empty;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.StartButton.Image = null;
            this.StartButton.ImageSize = new System.Drawing.Size(52, 52);
            this.StartButton.Location = new System.Drawing.Point(877, 416);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.StartButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.StartButton.OnHoverForeColor = System.Drawing.Color.White;
            this.StartButton.OnHoverImage = null;
            this.StartButton.OnPressedColor = System.Drawing.Color.Black;
            this.StartButton.Size = new System.Drawing.Size(92, 89);
            this.StartButton.TabIndex = 0;
            this.StartButton.Click += new System.EventHandler(this.NewPlayForm);
            // 
            // avap1
            // 
            this.avap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avap1.ErrorImage = null;
            this.avap1.Image = ((System.Drawing.Image)(resources.GetObject("avap1.Image")));
            this.avap1.Location = new System.Drawing.Point(20, 20);
            this.avap1.Margin = new System.Windows.Forms.Padding(0);
            this.avap1.Name = "avap1";
            this.avap1.Size = new System.Drawing.Size(89, 82);
            this.avap1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avap1.TabIndex = 2;
            this.avap1.TabStop = false;
            this.avap1.Click += new System.EventHandler(this.avap1_Click);
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 8;
            this.gunaElipse2.TargetControl = this;
            // 
            // avap2
            // 
            this.avap2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avap2.ErrorImage = null;
            this.avap2.Image = ((System.Drawing.Image)(resources.GetObject("avap2.Image")));
            this.avap2.InitialImage = null;
            this.avap2.Location = new System.Drawing.Point(20, 20);
            this.avap2.Margin = new System.Windows.Forms.Padding(0);
            this.avap2.Name = "avap2";
            this.avap2.Size = new System.Drawing.Size(89, 82);
            this.avap2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avap2.TabIndex = 3;
            this.avap2.TabStop = false;
            this.avap2.Click += new System.EventHandler(this.avap2_Click);
            // 
            // PanelPlayer1
            // 
            this.PanelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.PanelPlayer1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(118)))), ((int)(((byte)(152)))));
            this.PanelPlayer1.Controls.Add(this.Player1NameBox);
            this.PanelPlayer1.Controls.Add(this.avap1);
            this.PanelPlayer1.Location = new System.Drawing.Point(46, 106);
            this.PanelPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPlayer1.Name = "PanelPlayer1";
            this.PanelPlayer1.Radius = 6;
            this.PanelPlayer1.ShadowColor = System.Drawing.Color.DimGray;
            this.PanelPlayer1.Size = new System.Drawing.Size(330, 128);
            this.PanelPlayer1.TabIndex = 11;
            // 
            // PanelPlayer2
            // 
            this.PanelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.PanelPlayer2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(118)))), ((int)(((byte)(152)))));
            this.PanelPlayer2.Controls.Add(this.Player2NameBox);
            this.PanelPlayer2.Controls.Add(this.avap2);
            this.PanelPlayer2.Location = new System.Drawing.Point(623, 106);
            this.PanelPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPlayer2.Name = "PanelPlayer2";
            this.PanelPlayer2.Radius = 6;
            this.PanelPlayer2.ShadowColor = System.Drawing.Color.DimGray;
            this.PanelPlayer2.Size = new System.Drawing.Size(330, 128);
            this.PanelPlayer2.TabIndex = 12;
            // 
            // Player1Mark
            // 
            this.Player1Mark.BackColor = System.Drawing.Color.Transparent;
            this.Player1Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1Mark.BaseColor = System.Drawing.Color.Transparent;
            this.Player1Mark.InitialImage = null;
            this.Player1Mark.Location = new System.Drawing.Point(382, 145);
            this.Player1Mark.Name = "Player1Mark";
            this.Player1Mark.Size = new System.Drawing.Size(46, 42);
            this.Player1Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1Mark.TabIndex = 13;
            this.Player1Mark.TabStop = false;
            this.Player1Mark.UseTransfarantBackground = true;
            // 
            // Player2Mark
            // 
            this.Player2Mark.BackColor = System.Drawing.Color.Transparent;
            this.Player2Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2Mark.BaseColor = System.Drawing.Color.Transparent;
            this.Player2Mark.InitialImage = null;
            this.Player2Mark.Location = new System.Drawing.Point(571, 145);
            this.Player2Mark.Name = "Player2Mark";
            this.Player2Mark.Size = new System.Drawing.Size(46, 42);
            this.Player2Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2Mark.TabIndex = 14;
            this.Player2Mark.TabStop = false;
            this.Player2Mark.UseTransfarantBackground = true;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BaseColor = System.Drawing.Color.White;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(11, 2);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(110, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 15;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            this.Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseMove);
            this.Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseUp);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 677);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Player2Mark);
            this.Controls.Add(this.Player1Mark);
            this.Controls.Add(this.PanelPlayer2);
            this.Controls.Add(this.PanelPlayer1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.gunaCirclePictureBox3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avap2)).EndInit();
            this.PanelPlayer1.ResumeLayout(false);
            this.PanelPlayer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player1Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox Player1NameBox;
        private Guna.UI.WinForms.GunaTextBox Player2NameBox;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox3;
        private Guna.UI.WinForms.GunaCircleButton BackButton;
        private Guna.UI.WinForms.GunaCircleButton StartButton;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        public System.Windows.Forms.PictureBox avap2;
        public System.Windows.Forms.PictureBox avap1;
        private Guna.UI.WinForms.GunaShadowPanel PanelPlayer2;
        private Guna.UI.WinForms.GunaShadowPanel PanelPlayer1;
        public Guna.UI.WinForms.GunaCirclePictureBox Player2Mark;
        public Guna.UI.WinForms.GunaCirclePictureBox Player1Mark;
        private Guna.UI.WinForms.GunaPictureBox Logo;
    }
}

