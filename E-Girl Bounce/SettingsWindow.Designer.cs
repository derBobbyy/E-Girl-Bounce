namespace E_Girl_Bounce
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.closeBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.windowMoveCB = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.closeBtn);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Location = new System.Drawing.Point(-4, -2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(446, 37);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AllowAnimations = true;
            this.closeBtn.AllowMouseEffects = true;
            this.closeBtn.AllowToggling = false;
            this.closeBtn.AnimationSpeed = 200;
            this.closeBtn.AutoGenerateColors = false;
            this.closeBtn.AutoRoundBorders = true;
            this.closeBtn.AutoSizeLeftIcon = true;
            this.closeBtn.AutoSizeRightIcon = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackColor1 = System.Drawing.Color.Maroon;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBtn.ButtonText = "X";
            this.closeBtn.ButtonTextMarginLeft = 0;
            this.closeBtn.ColorContrastOnClick = 45;
            this.closeBtn.ColorContrastOnHover = 45;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.closeBtn.CustomizableEdges = borderEdges3;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.closeBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.closeBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.closeBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.closeBtn.IconMarginLeft = 11;
            this.closeBtn.IconPadding = 10;
            this.closeBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.closeBtn.IconSize = 25;
            this.closeBtn.IdleBorderColor = System.Drawing.Color.Red;
            this.closeBtn.IdleBorderRadius = 21;
            this.closeBtn.IdleBorderThickness = 1;
            this.closeBtn.IdleFillColor = System.Drawing.Color.Maroon;
            this.closeBtn.IdleIconLeftImage = null;
            this.closeBtn.IdleIconRightImage = null;
            this.closeBtn.IndicateFocus = false;
            this.closeBtn.Location = new System.Drawing.Point(414, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.closeBtn.OnDisabledState.BorderRadius = 1;
            this.closeBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBtn.OnDisabledState.BorderThickness = 1;
            this.closeBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.closeBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.closeBtn.OnDisabledState.IconLeftImage = null;
            this.closeBtn.OnDisabledState.IconRightImage = null;
            this.closeBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.closeBtn.onHoverState.BorderRadius = 1;
            this.closeBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBtn.onHoverState.BorderThickness = 1;
            this.closeBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.closeBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.closeBtn.onHoverState.IconLeftImage = null;
            this.closeBtn.onHoverState.IconRightImage = null;
            this.closeBtn.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.closeBtn.OnIdleState.BorderRadius = 1;
            this.closeBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBtn.OnIdleState.BorderThickness = 1;
            this.closeBtn.OnIdleState.FillColor = System.Drawing.Color.Maroon;
            this.closeBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.closeBtn.OnIdleState.IconLeftImage = null;
            this.closeBtn.OnIdleState.IconRightImage = null;
            this.closeBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.closeBtn.OnPressedState.BorderRadius = 1;
            this.closeBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBtn.OnPressedState.BorderThickness = 1;
            this.closeBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.closeBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.closeBtn.OnPressedState.IconLeftImage = null;
            this.closeBtn.OnPressedState.IconRightImage = null;
            this.closeBtn.Size = new System.Drawing.Size(22, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.closeBtn.TextMarginLeft = 0;
            this.closeBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.closeBtn.UseDefaultRadiusAndThickness = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Integral CF", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // windowMoveCB
            // 
            this.windowMoveCB.AllowBindingControlAnimation = true;
            this.windowMoveCB.AllowBindingControlColorChanges = false;
            this.windowMoveCB.AllowBindingControlLocation = true;
            this.windowMoveCB.AllowCheckBoxAnimation = false;
            this.windowMoveCB.AllowCheckmarkAnimation = true;
            this.windowMoveCB.AllowOnHoverStates = true;
            this.windowMoveCB.AutoCheck = true;
            this.windowMoveCB.BackColor = System.Drawing.Color.Transparent;
            this.windowMoveCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("windowMoveCB.BackgroundImage")));
            this.windowMoveCB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.windowMoveCB.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.windowMoveCB.BorderRadius = 12;
            this.windowMoveCB.Checked = true;
            this.windowMoveCB.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.windowMoveCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.windowMoveCB.CustomCheckmarkImage = null;
            this.windowMoveCB.Location = new System.Drawing.Point(12, 28);
            this.windowMoveCB.MinimumSize = new System.Drawing.Size(17, 17);
            this.windowMoveCB.Name = "windowMoveCB";
            this.windowMoveCB.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.windowMoveCB.OnCheck.BorderRadius = 12;
            this.windowMoveCB.OnCheck.BorderThickness = 2;
            this.windowMoveCB.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.windowMoveCB.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.windowMoveCB.OnCheck.CheckmarkThickness = 2;
            this.windowMoveCB.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.windowMoveCB.OnDisable.BorderRadius = 12;
            this.windowMoveCB.OnDisable.BorderThickness = 2;
            this.windowMoveCB.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.windowMoveCB.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.windowMoveCB.OnDisable.CheckmarkThickness = 2;
            this.windowMoveCB.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.windowMoveCB.OnHoverChecked.BorderRadius = 12;
            this.windowMoveCB.OnHoverChecked.BorderThickness = 2;
            this.windowMoveCB.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.windowMoveCB.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.windowMoveCB.OnHoverChecked.CheckmarkThickness = 2;
            this.windowMoveCB.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.windowMoveCB.OnHoverUnchecked.BorderRadius = 12;
            this.windowMoveCB.OnHoverUnchecked.BorderThickness = 1;
            this.windowMoveCB.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.windowMoveCB.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.windowMoveCB.OnUncheck.BorderRadius = 12;
            this.windowMoveCB.OnUncheck.BorderThickness = 1;
            this.windowMoveCB.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.windowMoveCB.Size = new System.Drawing.Size(21, 21);
            this.windowMoveCB.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.windowMoveCB.TabIndex = 1;
            this.windowMoveCB.ThreeState = false;
            this.windowMoveCB.ToolTipText = null;
            this.windowMoveCB.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.windowMoveCB_CheckedChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(38, 32);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(82, 15);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Move Windows";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.domainUpDown1);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel1);
            this.bunifuGroupBox1.Controls.Add(this.windowMoveCB);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(12, 41);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(176, 222);
            this.bunifuGroupBox1.TabIndex = 3;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Window Settings";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("11");
            this.domainUpDown1.Location = new System.Drawing.Point(12, 77);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(108, 23);
            this.domainUpDown1.TabIndex = 3;
            this.domainUpDown1.Text = "11";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 272);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(437, 272);
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton closeBtn;
        private Bunifu.UI.WinForms.BunifuCheckBox windowMoveCB;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}