namespace FemtoHTTPServer
{
    partial class ServerSettings
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button BrowseRootButton;
            System.Windows.Forms.Button OKButton;
            System.Windows.Forms.Button CancelButton;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Button AddPortButton;
            System.Windows.Forms.Button DeletePortButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSettings));
            this.WebRoot = new System.Windows.Forms.TextBox();
            this.WebRootChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.Ports = new System.Windows.Forms.ListView();
            this.ResetSettings = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            label1 = new System.Windows.Forms.Label();
            BrowseRootButton = new System.Windows.Forms.Button();
            OKButton = new System.Windows.Forms.Button();
            CancelButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            AddPortButton = new System.Windows.Forms.Button();
            DeletePortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Web &Root:";
            label1.Click += new System.EventHandler(this.WebRootHighlight);
            label1.Enter += new System.EventHandler(this.WebRootHighlight);
            // 
            // BrowseRootButton
            // 
            BrowseRootButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            BrowseRootButton.Location = new System.Drawing.Point(297, 12);
            BrowseRootButton.Name = "BrowseRootButton";
            BrowseRootButton.Size = new System.Drawing.Size(75, 23);
            BrowseRootButton.TabIndex = 2;
            BrowseRootButton.Text = "&Browse...";
            this.toolTip.SetToolTip(BrowseRootButton, "Browse for the web root directory.");
            BrowseRootButton.UseVisualStyleBackColor = true;
            BrowseRootButton.Click += new System.EventHandler(this.ChooseWebRoot);
            // 
            // OKButton
            // 
            OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            OKButton.Location = new System.Drawing.Point(216, 126);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(75, 23);
            OKButton.TabIndex = 3;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += new System.EventHandler(this.CloseOK);
            // 
            // CancelButton
            // 
            CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            CancelButton.Location = new System.Drawing.Point(297, 126);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(75, 23);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += new System.EventHandler(this.CloseCancel);
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label2.Location = new System.Drawing.Point(12, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(360, 2);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 46);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 15);
            label3.TabIndex = 7;
            label3.Text = "&Listening ports:";
            // 
            // AddPortButton
            // 
            AddPortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            AddPortButton.Image = global::FemtoHTTPServer.Properties.Resources.UI_ADD;
            AddPortButton.Location = new System.Drawing.Point(349, 64);
            AddPortButton.Name = "AddPortButton";
            AddPortButton.Size = new System.Drawing.Size(23, 23);
            AddPortButton.TabIndex = 8;
            this.toolTip.SetToolTip(AddPortButton, "Add a new port.");
            AddPortButton.UseVisualStyleBackColor = true;
            AddPortButton.Click += new System.EventHandler(this.AddPort);
            // 
            // DeletePortButton
            // 
            DeletePortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            DeletePortButton.Image = global::FemtoHTTPServer.Properties.Resources.UI_REMOVE;
            DeletePortButton.Location = new System.Drawing.Point(349, 93);
            DeletePortButton.Name = "DeletePortButton";
            DeletePortButton.Size = new System.Drawing.Size(23, 23);
            DeletePortButton.TabIndex = 9;
            this.toolTip.SetToolTip(DeletePortButton, "Remove an existing port.");
            DeletePortButton.UseVisualStyleBackColor = true;
            DeletePortButton.Click += new System.EventHandler(this.DeletePort);
            // 
            // WebRoot
            // 
            this.WebRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebRoot.Location = new System.Drawing.Point(80, 12);
            this.WebRoot.Name = "WebRoot";
            this.WebRoot.Size = new System.Drawing.Size(211, 23);
            this.WebRoot.TabIndex = 1;
            this.toolTip.SetToolTip(this.WebRoot, "The root directory for the server.\r\nYou can use environment variables like %USERP" +
        "ROFILE%.");
            // 
            // Ports
            // 
            this.Ports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ports.LabelEdit = true;
            this.Ports.Location = new System.Drawing.Point(12, 64);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(331, 56);
            this.Ports.TabIndex = 10;
            this.Ports.UseCompatibleStateImageBehavior = false;
            this.Ports.View = System.Windows.Forms.View.List;
            this.Ports.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ValidateEdit);
            this.Ports.DoubleClick += new System.EventHandler(this.ChangePort);
            // 
            // ResetSettings
            // 
            this.ResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetSettings.Image = global::FemtoHTTPServer.Properties.Resources.UI_RESET;
            this.ResetSettings.Location = new System.Drawing.Point(12, 126);
            this.ResetSettings.Name = "ResetSettings";
            this.ResetSettings.Size = new System.Drawing.Size(23, 23);
            this.ResetSettings.TabIndex = 11;
            this.toolTip.SetToolTip(this.ResetSettings, "Reset all settings.");
            this.ResetSettings.UseVisualStyleBackColor = true;
            // 
            // ServerSettings
            // 
            this.AcceptButton = OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = CancelButton;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.ResetSettings);
            this.Controls.Add(this.Ports);
            this.Controls.Add(DeletePortButton);
            this.Controls.Add(AddPortButton);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(CancelButton);
            this.Controls.Add(OKButton);
            this.Controls.Add(BrowseRootButton);
            this.Controls.Add(this.WebRoot);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "ServerSettings";
            this.Text = "ServerSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ValidateData);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.Shown += new System.EventHandler(this.InitializeUserInterface);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WebRoot;
        private System.Windows.Forms.FolderBrowserDialog WebRootChooser;
        private System.Windows.Forms.ListView Ports;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button ResetSettings;
    }
}