namespace Caro
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.SettingButton = new Guna.UI.WinForms.GunaButton();
            this.SaveButton = new Guna.UI.WinForms.GunaButton();
            this.PauseButton = new Guna.UI.WinForms.GunaButton();
            this.BackButton = new Guna.UI.WinForms.GunaButton();
            this.ExitButton = new Guna.UI.WinForms.GunaButton();
            this.NewButton = new Guna.UI.WinForms.GunaButton();
            this.UndoButton = new Guna.UI.WinForms.GunaButton();
            this.LogoPanel = new Guna.UI.WinForms.GunaPanel();
            this.Logo = new Guna.UI.WinForms.GunaPictureBox();
            this.Player2Panel = new Guna.UI.WinForms.GunaPanel();
            this.Player1Mark = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Player1NameLabel = new Guna.UI.WinForms.GunaLabel();
            this.Player1Avatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.ClockPanelP2 = new Guna.UI.WinForms.GunaPanel();
            this.Player2Clockicon = new Guna.UI.WinForms.GunaPictureBox();
            this.Player1Timer = new Guna.UI.WinForms.GunaLabel();
            this.Player2NameLabel = new Guna.UI.WinForms.GunaLabel();
            this.Player2Avatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Player1Panel = new Guna.UI.WinForms.GunaPanel();
            this.Player2Mark = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.ClockPanelP1 = new Guna.UI.WinForms.GunaPanel();
            this.Player1Clockicon = new Guna.UI.WinForms.GunaPictureBox();
            this.Player2Timer = new Guna.UI.WinForms.GunaLabel();
            this.PlayPanel = new Guna.UI.WinForms.GunaPanel();
            this.CurPlayerAvatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.CurPlayerMark = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.PanelPlayer1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.Score = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Player2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Avatar)).BeginInit();
            this.ClockPanelP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Clockicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Avatar)).BeginInit();
            this.Player1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Mark)).BeginInit();
            this.ClockPanelP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Clockicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurPlayerAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurPlayerMark)).BeginInit();
            this.PanelPlayer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(219)))));
            this.gunaPanel1.Controls.Add(this.SettingButton);
            this.gunaPanel1.Controls.Add(this.SaveButton);
            this.gunaPanel1.Controls.Add(this.PauseButton);
            this.gunaPanel1.Controls.Add(this.BackButton);
            this.gunaPanel1.Controls.Add(this.ExitButton);
            this.gunaPanel1.Controls.Add(this.NewButton);
            this.gunaPanel1.Controls.Add(this.UndoButton);
            this.gunaPanel1.Controls.Add(this.LogoPanel);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(185, 700);
            this.gunaPanel1.TabIndex = 0;
            // 
            // SettingButton
            // 
            this.SettingButton.AnimationHoverSpeed = 0.07F;
            this.SettingButton.AnimationSpeed = 0.03F;
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.BaseColor = System.Drawing.Color.Transparent;
            this.SettingButton.BorderColor = System.Drawing.Color.Black;
            this.SettingButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingButton.FocusedColor = System.Drawing.Color.Empty;
            this.SettingButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageSize = new System.Drawing.Size(27, 27);
            this.SettingButton.Location = new System.Drawing.Point(20, 410);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.SettingButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingButton.OnHoverForeColor = System.Drawing.Color.DarkBlue;
            this.SettingButton.OnHoverImage = null;
            this.SettingButton.OnPressedColor = System.Drawing.Color.Black;
            this.SettingButton.Size = new System.Drawing.Size(150, 50);
            this.SettingButton.TabIndex = 4;
            this.SettingButton.TabStop = false;
            this.SettingButton.Text = "SETTING";
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AnimationHoverSpeed = 0.07F;
            this.SaveButton.AnimationSpeed = 0.03F;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BaseColor = System.Drawing.Color.Transparent;
            this.SaveButton.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageSize = new System.Drawing.Size(27, 27);
            this.SaveButton.Location = new System.Drawing.Point(20, 350);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverForeColor = System.Drawing.Color.DarkBlue;
            this.SaveButton.OnHoverImage = null;
            this.SaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButton.Size = new System.Drawing.Size(150, 50);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.AnimationHoverSpeed = 0.07F;
            this.PauseButton.AnimationSpeed = 0.03F;
            this.PauseButton.BackColor = System.Drawing.Color.Transparent;
            this.PauseButton.BaseColor = System.Drawing.Color.Transparent;
            this.PauseButton.BorderColor = System.Drawing.Color.Black;
            this.PauseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PauseButton.FocusedColor = System.Drawing.Color.Empty;
            this.PauseButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.ImageSize = new System.Drawing.Size(25, 25);
            this.PauseButton.Location = new System.Drawing.Point(20, 230);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.PauseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PauseButton.OnHoverForeColor = System.Drawing.Color.DarkBlue;
            this.PauseButton.OnHoverImage = null;
            this.PauseButton.OnPressedColor = System.Drawing.Color.Black;
            this.PauseButton.Size = new System.Drawing.Size(150, 50);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.TabStop = false;
            this.PauseButton.Text = "PAUSE";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
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
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageSize = new System.Drawing.Size(25, 25);
            this.BackButton.Location = new System.Drawing.Point(20, 470);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BackButton.OnHoverForeColor = System.Drawing.Color.DarkBlue;
            this.BackButton.OnHoverImage = null;
            this.BackButton.OnPressedColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 0;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "MAIN MENU";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AnimationHoverSpeed = 0.07F;
            this.ExitButton.AnimationSpeed = 0.03F;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.FocusedColor = System.Drawing.Color.Empty;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageSize = new System.Drawing.Size(25, 25);
            this.ExitButton.Location = new System.Drawing.Point(20, 530);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitButton.OnHoverForeColor = System.Drawing.Color.DarkBlue;
            this.ExitButton.OnHoverImage = null;
            this.ExitButton.OnPressedColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(150, 50);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.AnimationHoverSpeed = 0.07F;
            this.NewButton.AnimationSpeed = 0.03F;
            this.NewButton.BackColor = System.Drawing.Color.Transparent;
            this.NewButton.BaseColor = System.Drawing.Color.Transparent;
            this.NewButton.BorderColor = System.Drawing.Color.Black;
            this.NewButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NewButton.FocusedColor = System.Drawing.Color.Empty;
            this.NewButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageSize = new System.Drawing.Size(27, 27);
            this.NewButton.Location = new System.Drawing.Point(20, 170);
            this.NewButton.Name = "NewButton";
            this.NewButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.NewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.NewButton.OnHoverForeColor = System.Drawing.Color.DarkBlue;
            this.NewButton.OnHoverImage = null;
            this.NewButton.OnPressedColor = System.Drawing.Color.Black;
            this.NewButton.Size = new System.Drawing.Size(150, 50);
            this.NewButton.TabIndex = 0;
            this.NewButton.TabStop = false;
            this.NewButton.Text = "NEW ";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.AnimationHoverSpeed = 0.07F;
            this.UndoButton.AnimationSpeed = 0.03F;
            this.UndoButton.BackColor = System.Drawing.Color.Transparent;
            this.UndoButton.BaseColor = System.Drawing.Color.Transparent;
            this.UndoButton.BorderColor = System.Drawing.Color.Black;
            this.UndoButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UndoButton.FocusedColor = System.Drawing.Color.Empty;
            this.UndoButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageSize = new System.Drawing.Size(25, 25);
            this.UndoButton.Location = new System.Drawing.Point(20, 290);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.UndoButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UndoButton.OnHoverForeColor = System.Drawing.Color.DarkBlue;
            this.UndoButton.OnHoverImage = null;
            this.UndoButton.OnPressedColor = System.Drawing.Color.Black;
            this.UndoButton.Size = new System.Drawing.Size(150, 50);
            this.UndoButton.TabIndex = 0;
            this.UndoButton.TabStop = false;
            this.UndoButton.Text = "UNDO";
            this.UndoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(185, 163);
            this.LogoPanel.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.BaseColor = System.Drawing.Color.White;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(20, 15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(148, 133);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            this.Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseMove);
            this.Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseUp);
            // 
            // Player2Panel
            // 
            this.Player2Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Player2Panel.BackColor = System.Drawing.Color.Transparent;
            this.Player2Panel.Controls.Add(this.Player1Mark);
            this.Player2Panel.Controls.Add(this.Player1NameLabel);
            this.Player2Panel.Controls.Add(this.Player1Avatar);
            this.Player2Panel.Controls.Add(this.ClockPanelP2);
            this.Player2Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Player2Panel.Location = new System.Drawing.Point(185, 0);
            this.Player2Panel.Name = "Player2Panel";
            this.Player2Panel.Size = new System.Drawing.Size(698, 100);
            this.Player2Panel.TabIndex = 1;
            // 
            // Player1Mark
            // 
            this.Player1Mark.BackColor = System.Drawing.Color.Transparent;
            this.Player1Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1Mark.BaseColor = System.Drawing.Color.Transparent;
            this.Player1Mark.Location = new System.Drawing.Point(420, 33);
            this.Player1Mark.Name = "Player1Mark";
            this.Player1Mark.Size = new System.Drawing.Size(28, 29);
            this.Player1Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1Mark.TabIndex = 14;
            this.Player1Mark.TabStop = false;
            this.Player1Mark.UseTransfarantBackground = true;
            // 
            // Player1NameLabel
            // 
            this.Player1NameLabel.AutoSize = true;
            this.Player1NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.Player1NameLabel.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.Player1NameLabel.Location = new System.Drawing.Point(134, 43);
            this.Player1NameLabel.Name = "Player1NameLabel";
            this.Player1NameLabel.Size = new System.Drawing.Size(86, 17);
            this.Player1NameLabel.TabIndex = 5;
            this.Player1NameLabel.Text = "PLAYER 1";
            // 
            // Player1Avatar
            // 
            this.Player1Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1Avatar.BaseColor = System.Drawing.Color.Transparent;
            this.Player1Avatar.Location = new System.Drawing.Point(34, 12);
            this.Player1Avatar.Name = "Player1Avatar";
            this.Player1Avatar.Size = new System.Drawing.Size(75, 75);
            this.Player1Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1Avatar.TabIndex = 3;
            this.Player1Avatar.TabStop = false;
            this.Player1Avatar.UseTransfarantBackground = false;
            // 
            // ClockPanelP2
            // 
            this.ClockPanelP2.Controls.Add(this.Player2Clockicon);
            this.ClockPanelP2.Controls.Add(this.Player1Timer);
            this.ClockPanelP2.Location = new System.Drawing.Point(454, 4);
            this.ClockPanelP2.Name = "ClockPanelP2";
            this.ClockPanelP2.Size = new System.Drawing.Size(166, 83);
            this.ClockPanelP2.TabIndex = 3;
            // 
            // Player2Clockicon
            // 
            this.Player2Clockicon.BaseColor = System.Drawing.Color.White;
            this.Player2Clockicon.Image = ((System.Drawing.Image)(resources.GetObject("Player2Clockicon.Image")));
            this.Player2Clockicon.Location = new System.Drawing.Point(14, 15);
            this.Player2Clockicon.Name = "Player2Clockicon";
            this.Player2Clockicon.Size = new System.Drawing.Size(60, 61);
            this.Player2Clockicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2Clockicon.TabIndex = 2;
            this.Player2Clockicon.TabStop = false;
            // 
            // Player1Timer
            // 
            this.Player1Timer.AutoSize = true;
            this.Player1Timer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.Player1Timer.Location = new System.Drawing.Point(80, 39);
            this.Player1Timer.Name = "Player1Timer";
            this.Player1Timer.Size = new System.Drawing.Size(44, 17);
            this.Player1Timer.TabIndex = 1;
            this.Player1Timer.Text = "00:00";
            // 
            // Player2NameLabel
            // 
            this.Player2NameLabel.AutoSize = true;
            this.Player2NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.Player2NameLabel.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.Player2NameLabel.Location = new System.Drawing.Point(134, 47);
            this.Player2NameLabel.Name = "Player2NameLabel";
            this.Player2NameLabel.Size = new System.Drawing.Size(86, 17);
            this.Player2NameLabel.TabIndex = 4;
            this.Player2NameLabel.Text = "PLAYER 2";
            // 
            // Player2Avatar
            // 
            this.Player2Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2Avatar.BaseColor = System.Drawing.Color.Transparent;
            this.Player2Avatar.Location = new System.Drawing.Point(34, 9);
            this.Player2Avatar.Name = "Player2Avatar";
            this.Player2Avatar.Size = new System.Drawing.Size(75, 75);
            this.Player2Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2Avatar.TabIndex = 0;
            this.Player2Avatar.TabStop = false;
            this.Player2Avatar.UseTransfarantBackground = false;
            // 
            // Player1Panel
            // 
            this.Player1Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Player1Panel.BackColor = System.Drawing.Color.Transparent;
            this.Player1Panel.Controls.Add(this.Player2Mark);
            this.Player1Panel.Controls.Add(this.Player2Avatar);
            this.Player1Panel.Controls.Add(this.Player2NameLabel);
            this.Player1Panel.Controls.Add(this.ClockPanelP1);
            this.Player1Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Player1Panel.Location = new System.Drawing.Point(185, 600);
            this.Player1Panel.Name = "Player1Panel";
            this.Player1Panel.Size = new System.Drawing.Size(698, 100);
            this.Player1Panel.TabIndex = 2;
            // 
            // Player2Mark
            // 
            this.Player2Mark.BackColor = System.Drawing.Color.Transparent;
            this.Player2Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2Mark.BaseColor = System.Drawing.Color.Transparent;
            this.Player2Mark.Location = new System.Drawing.Point(420, 38);
            this.Player2Mark.Name = "Player2Mark";
            this.Player2Mark.Size = new System.Drawing.Size(28, 29);
            this.Player2Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2Mark.TabIndex = 15;
            this.Player2Mark.TabStop = false;
            this.Player2Mark.UseTransfarantBackground = true;
            // 
            // ClockPanelP1
            // 
            this.ClockPanelP1.Controls.Add(this.Player1Clockicon);
            this.ClockPanelP1.Controls.Add(this.Player2Timer);
            this.ClockPanelP1.Location = new System.Drawing.Point(454, 9);
            this.ClockPanelP1.Name = "ClockPanelP1";
            this.ClockPanelP1.Size = new System.Drawing.Size(166, 83);
            this.ClockPanelP1.TabIndex = 4;
            // 
            // Player1Clockicon
            // 
            this.Player1Clockicon.BaseColor = System.Drawing.Color.White;
            this.Player1Clockicon.Image = ((System.Drawing.Image)(resources.GetObject("Player1Clockicon.Image")));
            this.Player1Clockicon.Location = new System.Drawing.Point(14, 15);
            this.Player1Clockicon.Name = "Player1Clockicon";
            this.Player1Clockicon.Size = new System.Drawing.Size(60, 61);
            this.Player1Clockicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1Clockicon.TabIndex = 2;
            this.Player1Clockicon.TabStop = false;
            // 
            // Player2Timer
            // 
            this.Player2Timer.AutoSize = true;
            this.Player2Timer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.Player2Timer.Location = new System.Drawing.Point(80, 39);
            this.Player2Timer.Name = "Player2Timer";
            this.Player2Timer.Size = new System.Drawing.Size(44, 17);
            this.Player2Timer.TabIndex = 1;
            this.Player2Timer.Text = "00:00";
            // 
            // PlayPanel
            // 
            this.PlayPanel.BackColor = System.Drawing.Color.White;
            this.PlayPanel.Location = new System.Drawing.Point(219, 100);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(500, 500);
            this.PlayPanel.TabIndex = 0;
            this.PlayPanel.TabStop = true;
            // 
            // CurPlayerAvatar
            // 
            this.CurPlayerAvatar.BackColor = System.Drawing.Color.Transparent;
            this.CurPlayerAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurPlayerAvatar.BaseColor = System.Drawing.Color.Transparent;
            this.CurPlayerAvatar.Location = new System.Drawing.Point(13, 19);
            this.CurPlayerAvatar.Name = "CurPlayerAvatar";
            this.CurPlayerAvatar.Size = new System.Drawing.Size(58, 61);
            this.CurPlayerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurPlayerAvatar.TabIndex = 4;
            this.CurPlayerAvatar.TabStop = false;
            this.CurPlayerAvatar.UseTransfarantBackground = true;
            // 
            // CurPlayerMark
            // 
            this.CurPlayerMark.BackColor = System.Drawing.Color.Transparent;
            this.CurPlayerMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurPlayerMark.BaseColor = System.Drawing.Color.Transparent;
            this.CurPlayerMark.Location = new System.Drawing.Point(77, 39);
            this.CurPlayerMark.Name = "CurPlayerMark";
            this.CurPlayerMark.Size = new System.Drawing.Size(28, 29);
            this.CurPlayerMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurPlayerMark.TabIndex = 5;
            this.CurPlayerMark.TabStop = false;
            this.CurPlayerMark.UseTransfarantBackground = true;
            // 
            // PanelPlayer1
            // 
            this.PanelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.PanelPlayer1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(176)))), ((int)(((byte)(219)))));
            this.PanelPlayer1.Controls.Add(this.CurPlayerAvatar);
            this.PanelPlayer1.Controls.Add(this.CurPlayerMark);
            this.PanelPlayer1.Location = new System.Drawing.Point(740, 313);
            this.PanelPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPlayer1.Name = "PanelPlayer1";
            this.PanelPlayer1.Radius = 6;
            this.PanelPlayer1.ShadowColor = System.Drawing.Color.DimGray;
            this.PanelPlayer1.Size = new System.Drawing.Size(119, 97);
            this.PanelPlayer1.TabIndex = 13;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Black;
            this.Score.Location = new System.Drawing.Point(723, 261);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(160, 50);
            this.Score.TabIndex = 15;
            this.Score.Text = "0:0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 700);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.PanelPlayer1);
            this.Controls.Add(this.PlayPanel);
            this.Controls.Add(this.Player1Panel);
            this.Controls.Add(this.Player2Panel);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro";
            this.gunaPanel1.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Player2Panel.ResumeLayout(false);
            this.Player2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Avatar)).EndInit();
            this.ClockPanelP2.ResumeLayout(false);
            this.ClockPanelP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Clockicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Avatar)).EndInit();
            this.Player1Panel.ResumeLayout(false);
            this.Player1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Mark)).EndInit();
            this.ClockPanelP1.ResumeLayout(false);
            this.ClockPanelP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Clockicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurPlayerAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurPlayerMark)).EndInit();
            this.PanelPlayer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton UndoButton;
        private Guna.UI.WinForms.GunaButton NewButton;
        private Guna.UI.WinForms.GunaButton ExitButton;
        private Guna.UI.WinForms.GunaPanel Player2Panel;
        private Guna.UI.WinForms.GunaPanel Player1Panel;
        private Guna.UI.WinForms.GunaCirclePictureBox Player2Avatar;
        private Guna.UI.WinForms.GunaCirclePictureBox Player1Avatar;
        private Guna.UI.WinForms.GunaPanel ClockPanelP2;
        private Guna.UI.WinForms.GunaPictureBox Player2Clockicon;
        private Guna.UI.WinForms.GunaLabel Player1Timer;
        private Guna.UI.WinForms.GunaButton BackButton;
        private Guna.UI.WinForms.GunaPanel ClockPanelP1;
        private Guna.UI.WinForms.GunaPictureBox Player1Clockicon;
        private Guna.UI.WinForms.GunaLabel Player2Timer;
        private Guna.UI.WinForms.GunaLabel Player2NameLabel;
        private Guna.UI.WinForms.GunaLabel Player1NameLabel;
        private Guna.UI.WinForms.GunaPanel PlayPanel;
        private Guna.UI.WinForms.GunaPanel LogoPanel;
        public Guna.UI.WinForms.GunaCirclePictureBox CurPlayerAvatar;
        public Guna.UI.WinForms.GunaCirclePictureBox CurPlayerMark;
        private Guna.UI.WinForms.GunaPictureBox Logo;
        private Guna.UI.WinForms.GunaButton PauseButton;
        private Guna.UI.WinForms.GunaShadowPanel PanelPlayer1;
        public Guna.UI.WinForms.GunaCirclePictureBox Player1Mark;
        public Guna.UI.WinForms.GunaCirclePictureBox Player2Mark;
        public Guna.UI.WinForms.GunaLabel Score;
        private Guna.UI.WinForms.GunaButton SaveButton;
        private Guna.UI.WinForms.GunaButton SettingButton;
    }
}

