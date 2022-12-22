namespace E_Girl_Bounce
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.startBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.stopBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.AllowAnimations = true;
            this.startBtn.AllowMouseEffects = true;
            this.startBtn.AllowToggling = false;
            this.startBtn.AnimationSpeed = 200;
            this.startBtn.AutoGenerateColors = false;
            this.startBtn.AutoRoundBorders = true;
            this.startBtn.AutoSizeLeftIcon = true;
            this.startBtn.AutoSizeRightIcon = true;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BackColor1 = System.Drawing.Color.Transparent;
            this.startBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startBtn.BackgroundImage")));
            this.startBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.ButtonText = "Start";
            this.startBtn.ButtonTextMarginLeft = 0;
            this.startBtn.ColorContrastOnClick = 45;
            this.startBtn.ColorContrastOnHover = 45;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.startBtn.CustomizableEdges = borderEdges7;
            this.startBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.startBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.startBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.startBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.startBtn.IconMarginLeft = 11;
            this.startBtn.IconPadding = 10;
            this.startBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.startBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.startBtn.IconSize = 25;
            this.startBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.startBtn.IdleBorderRadius = 37;
            this.startBtn.IdleBorderThickness = 1;
            this.startBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.startBtn.IdleIconLeftImage = null;
            this.startBtn.IdleIconRightImage = null;
            this.startBtn.IndicateFocus = false;
            this.startBtn.Location = new System.Drawing.Point(8, 25);
            this.startBtn.Name = "startBtn";
            this.startBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.startBtn.OnDisabledState.BorderRadius = 1;
            this.startBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.OnDisabledState.BorderThickness = 1;
            this.startBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.startBtn.OnDisabledState.IconLeftImage = null;
            this.startBtn.OnDisabledState.IconRightImage = null;
            this.startBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.startBtn.onHoverState.BorderRadius = 1;
            this.startBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.onHoverState.BorderThickness = 1;
            this.startBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.startBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.startBtn.onHoverState.IconLeftImage = null;
            this.startBtn.onHoverState.IconRightImage = null;
            this.startBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.startBtn.OnIdleState.BorderRadius = 1;
            this.startBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.OnIdleState.BorderThickness = 1;
            this.startBtn.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.startBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.startBtn.OnIdleState.IconLeftImage = null;
            this.startBtn.OnIdleState.IconRightImage = null;
            this.startBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.startBtn.OnPressedState.BorderRadius = 1;
            this.startBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.OnPressedState.BorderThickness = 1;
            this.startBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.startBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.startBtn.OnPressedState.IconLeftImage = null;
            this.startBtn.OnPressedState.IconRightImage = null;
            this.startBtn.Size = new System.Drawing.Size(150, 39);
            this.startBtn.TabIndex = 0;
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.startBtn.TextMarginLeft = 0;
            this.startBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.startBtn.UseDefaultRadiusAndThickness = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.AllowAnimations = true;
            this.stopBtn.AllowMouseEffects = true;
            this.stopBtn.AllowToggling = false;
            this.stopBtn.AnimationSpeed = 200;
            this.stopBtn.AutoGenerateColors = false;
            this.stopBtn.AutoRoundBorders = true;
            this.stopBtn.AutoSizeLeftIcon = true;
            this.stopBtn.AutoSizeRightIcon = true;
            this.stopBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopBtn.BackColor1 = System.Drawing.Color.Transparent;
            this.stopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopBtn.BackgroundImage")));
            this.stopBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopBtn.ButtonText = "Stop";
            this.stopBtn.ButtonTextMarginLeft = 0;
            this.stopBtn.ColorContrastOnClick = 45;
            this.stopBtn.ColorContrastOnHover = 45;
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.stopBtn.CustomizableEdges = borderEdges8;
            this.stopBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.stopBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.stopBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.stopBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.stopBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.stopBtn.IconMarginLeft = 11;
            this.stopBtn.IconPadding = 10;
            this.stopBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.stopBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.stopBtn.IconSize = 25;
            this.stopBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.stopBtn.IdleBorderRadius = 37;
            this.stopBtn.IdleBorderThickness = 1;
            this.stopBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.stopBtn.IdleIconLeftImage = null;
            this.stopBtn.IdleIconRightImage = null;
            this.stopBtn.IndicateFocus = false;
            this.stopBtn.Location = new System.Drawing.Point(8, 178);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.stopBtn.OnDisabledState.BorderRadius = 1;
            this.stopBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopBtn.OnDisabledState.BorderThickness = 1;
            this.stopBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.stopBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.stopBtn.OnDisabledState.IconLeftImage = null;
            this.stopBtn.OnDisabledState.IconRightImage = null;
            this.stopBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.stopBtn.onHoverState.BorderRadius = 1;
            this.stopBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopBtn.onHoverState.BorderThickness = 1;
            this.stopBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.stopBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.stopBtn.onHoverState.IconLeftImage = null;
            this.stopBtn.onHoverState.IconRightImage = null;
            this.stopBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.stopBtn.OnIdleState.BorderRadius = 1;
            this.stopBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopBtn.OnIdleState.BorderThickness = 1;
            this.stopBtn.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.stopBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.stopBtn.OnIdleState.IconLeftImage = null;
            this.stopBtn.OnIdleState.IconRightImage = null;
            this.stopBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.stopBtn.OnPressedState.BorderRadius = 1;
            this.stopBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopBtn.OnPressedState.BorderThickness = 1;
            this.stopBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.stopBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.stopBtn.OnPressedState.IconLeftImage = null;
            this.stopBtn.OnPressedState.IconRightImage = null;
            this.stopBtn.Size = new System.Drawing.Size(150, 39);
            this.stopBtn.TabIndex = 0;
            this.stopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopBtn.TextMarginLeft = 0;
            this.stopBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.stopBtn.UseDefaultRadiusAndThickness = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(162, 217);
            this.ControlBox = false;
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton startBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton stopBtn;
        public System.Windows.Forms.Timer timer1;
    }
}

