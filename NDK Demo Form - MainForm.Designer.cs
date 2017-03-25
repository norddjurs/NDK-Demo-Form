namespace NDK.DemoForm {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pluginPanel = new System.Windows.Forms.GroupBox();
			this.pluginRun = new System.Windows.Forms.Button();
			this.pluginList = new System.Windows.Forms.ListBox();
			this.logPanel = new System.Windows.Forms.GroupBox();
			this.logText = new System.Windows.Forms.RichTextBox();
			this.pluginPanel.SuspendLayout();
			this.logPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pluginPanel
			// 
			this.pluginPanel.Controls.Add(this.pluginRun);
			this.pluginPanel.Controls.Add(this.pluginList);
			this.pluginPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.pluginPanel.Location = new System.Drawing.Point(0, 0);
			this.pluginPanel.Margin = new System.Windows.Forms.Padding(4);
			this.pluginPanel.Name = "pluginPanel";
			this.pluginPanel.Padding = new System.Windows.Forms.Padding(4);
			this.pluginPanel.Size = new System.Drawing.Size(984, 123);
			this.pluginPanel.TabIndex = 0;
			this.pluginPanel.TabStop = false;
			this.pluginPanel.Text = "Plugins";
			// 
			// pluginRun
			// 
			this.pluginRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pluginRun.Location = new System.Drawing.Point(872, 22);
			this.pluginRun.Name = "pluginRun";
			this.pluginRun.Size = new System.Drawing.Size(100, 23);
			this.pluginRun.TabIndex = 1;
			this.pluginRun.Text = "Run";
			this.pluginRun.UseVisualStyleBackColor = true;
			this.pluginRun.Click += new System.EventHandler(this.PluginRunClick);
			// 
			// pluginList
			// 
			this.pluginList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pluginList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pluginList.FormattingEnabled = true;
			this.pluginList.ItemHeight = 16;
			this.pluginList.Location = new System.Drawing.Point(4, 19);
			this.pluginList.Name = "pluginList";
			this.pluginList.Size = new System.Drawing.Size(862, 100);
			this.pluginList.TabIndex = 0;
			// 
			// logPanel
			// 
			this.logPanel.Controls.Add(this.logText);
			this.logPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logPanel.Location = new System.Drawing.Point(0, 123);
			this.logPanel.Margin = new System.Windows.Forms.Padding(4);
			this.logPanel.Name = "logPanel";
			this.logPanel.Padding = new System.Windows.Forms.Padding(4);
			this.logPanel.Size = new System.Drawing.Size(984, 438);
			this.logPanel.TabIndex = 1;
			this.logPanel.TabStop = false;
			this.logPanel.Text = "Log";
			// 
			// logText
			// 
			this.logText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.logText.Cursor = System.Windows.Forms.Cursors.Default;
			this.logText.DetectUrls = false;
			this.logText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logText.Location = new System.Drawing.Point(4, 19);
			this.logText.Margin = new System.Windows.Forms.Padding(4);
			this.logText.Name = "logText";
			this.logText.ReadOnly = true;
			this.logText.Size = new System.Drawing.Size(976, 415);
			this.logText.TabIndex = 0;
			this.logText.Text = "";
			this.logText.WordWrap = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.logPanel);
			this.Controls.Add(this.pluginPanel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "*** Design Mode ***";
			this.pluginPanel.ResumeLayout(false);
			this.logPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox pluginPanel;
		private System.Windows.Forms.GroupBox logPanel;
		private System.Windows.Forms.RichTextBox logText;
		private System.Windows.Forms.Button pluginRun;
		private System.Windows.Forms.ListBox pluginList;
	}
}