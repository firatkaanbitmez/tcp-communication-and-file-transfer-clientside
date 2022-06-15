namespace TCP_CLIENT
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portProblemSolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxRcv = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new MaterialSkin.Controls.MaterialCard();
            this.buttonSendToClients = new MaterialSkin.Controls.MaterialButton();
            this.labelStatusInfo = new MaterialSkin.Controls.MaterialLabel();
            this.btnFileSend = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(72, 717);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 53);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Select Server";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(105, 32);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reCToolStripMenuItem,
            this.userIToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 25);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reCToolStripMenuItem
            // 
            this.reCToolStripMenuItem.Name = "reCToolStripMenuItem";
            this.reCToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.reCToolStripMenuItem.Text = "Reconnect";
            this.reCToolStripMenuItem.Click += new System.EventHandler(this.reCToolStripMenuItem_Click);
            // 
            // userIToolStripMenuItem
            // 
            this.userIToolStripMenuItem.Name = "userIToolStripMenuItem";
            this.userIToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.userIToolStripMenuItem.Text = "User Information";
            this.userIToolStripMenuItem.Click += new System.EventHandler(this.userIToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.portProblemSolverToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.UserManualToolStripMenuItem_Click);
            // 
            // portProblemSolverToolStripMenuItem
            // 
            this.portProblemSolverToolStripMenuItem.Name = "portProblemSolverToolStripMenuItem";
            this.portProblemSolverToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.portProblemSolverToolStripMenuItem.Text = "Port Problem Solver";
            this.portProblemSolverToolStripMenuItem.Click += new System.EventHandler(this.portProblemSolverToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.aboutToolStripMenuItem.Text = "Update";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(579, 64);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(46, 24);
            this.materialSwitch1.TabIndex = 96;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(3, 131);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(622, 157);
            this.textBoxText.TabIndex = 97;
            // 
            // textBoxRcv
            // 
            this.textBoxRcv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxRcv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRcv.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxRcv.Depth = 0;
            this.textBoxRcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxRcv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxRcv.HideSelection = false;
            this.textBoxRcv.Location = new System.Drawing.Point(3, 329);
            this.textBoxRcv.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRcv.Name = "textBoxRcv";
            this.textBoxRcv.ReadOnly = true;
            this.textBoxRcv.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxRcv.ShowSelectionMargin = true;
            this.textBoxRcv.Size = new System.Drawing.Size(622, 159);
            this.textBoxRcv.TabIndex = 105;
            this.textBoxRcv.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(16, 301);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(102, 19);
            this.materialLabel2.TabIndex = 106;
            this.materialLabel2.Text = "Incoming Text";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(436, 491);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 108;
            this.materialLabel1.Text = "File Drop";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Depth = 0;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(338, 513);
            this.panel1.Margin = new System.Windows.Forms.Padding(14);
            this.panel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14);
            this.panel1.Size = new System.Drawing.Size(271, 122);
            this.panel1.TabIndex = 107;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFileDropArea_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFileDropArea_DragEnter);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSendToClients
            // 
            this.buttonSendToClients.AutoSize = false;
            this.buttonSendToClients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSendToClients.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSendToClients.Depth = 0;
            this.buttonSendToClients.HighEmphasis = true;
            this.buttonSendToClients.Icon = null;
            this.buttonSendToClients.Location = new System.Drawing.Point(236, 295);
            this.buttonSendToClients.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSendToClients.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSendToClients.Name = "buttonSendToClients";
            this.buttonSendToClients.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSendToClients.Size = new System.Drawing.Size(120, 25);
            this.buttonSendToClients.TabIndex = 109;
            this.buttonSendToClients.Text = "Send";
            this.buttonSendToClients.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSendToClients.UseAccentColor = false;
            this.buttonSendToClients.UseVisualStyleBackColor = true;
            this.buttonSendToClients.Click += new System.EventHandler(this.buttonSendToClients_Click);
            // 
            // labelStatusInfo
            // 
            this.labelStatusInfo.AutoSize = true;
            this.labelStatusInfo.Depth = 0;
            this.labelStatusInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelStatusInfo.Location = new System.Drawing.Point(147, 106);
            this.labelStatusInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStatusInfo.Name = "labelStatusInfo";
            this.labelStatusInfo.Size = new System.Drawing.Size(223, 19);
            this.labelStatusInfo.TabIndex = 110;
            this.labelStatusInfo.Text = "Click \'Connect to Server\'  button";
            // 
            // btnFileSend
            // 
            this.btnFileSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFileSend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFileSend.Depth = 0;
            this.btnFileSend.HighEmphasis = true;
            this.btnFileSend.Icon = null;
            this.btnFileSend.Location = new System.Drawing.Point(120, 588);
            this.btnFileSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFileSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFileSend.Name = "btnFileSend";
            this.btnFileSend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFileSend.Size = new System.Drawing.Size(91, 36);
            this.btnFileSend.TabIndex = 114;
            this.btnFileSend.Text = "Fıle Send";
            this.btnFileSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFileSend.UseAccentColor = false;
            this.btnFileSend.UseVisualStyleBackColor = true;
            this.btnFileSend.Click += new System.EventHandler(this.btnFileSend_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(123, 563);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(88, 19);
            this.materialLabel5.TabIndex = 111;
            this.materialLabel5.Text = "to \'File Drop\'";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(77, 537);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(190, 19);
            this.materialLabel4.TabIndex = 112;
            this.materialLabel4.Text = " want to send or Drag Drop";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(85, 513);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(177, 19);
            this.materialLabel3.TabIndex = 113;
            this.materialLabel3.Text = "Please Select the file you";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(75, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmClient
            // 
            this.AcceptButton = this.buttonSendToClients;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(632, 644);
            this.Controls.Add(this.btnFileSend);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.labelStatusInfo);
            this.Controls.Add(this.buttonSendToClients);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBoxRcv);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DrawerAutoShow = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.Windows.Forms.TextBox textBoxText;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textBoxRcv;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialCard panel1;
        private MaterialSkin.Controls.MaterialButton buttonSendToClients;
        private MaterialSkin.Controls.MaterialLabel labelStatusInfo;
        private MaterialSkin.Controls.MaterialButton btnFileSend;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portProblemSolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reCToolStripMenuItem;
    }
}

