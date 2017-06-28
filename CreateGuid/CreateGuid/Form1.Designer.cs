namespace CreateGuid
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ProgDescription = new System.Windows.Forms.Label();
			this.GuidTextBox = new System.Windows.Forms.TextBox();
			this.guidGen = new System.Windows.Forms.Button();
			this.copyToClipboard = new System.Windows.Forms.Button();
			this.quitBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ProgDescription
			// 
			this.ProgDescription.AutoSize = true;
			this.ProgDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.ProgDescription.Location = new System.Drawing.Point(13, 13);
			this.ProgDescription.Name = "ProgDescription";
			this.ProgDescription.Size = new System.Drawing.Size(270, 24);
			this.ProgDescription.TabIndex = 0;
			this.ProgDescription.Text = "Create an Infinity Friendly Guid.";
			// 
			// GuidTextBox
			// 
			this.GuidTextBox.Location = new System.Drawing.Point(12, 195);
			this.GuidTextBox.Name = "GuidTextBox";
			this.GuidTextBox.Size = new System.Drawing.Size(266, 20);
			this.GuidTextBox.TabIndex = 1;
			// 
			// guidGen
			// 
			this.guidGen.Location = new System.Drawing.Point(289, 12);
			this.guidGen.Name = "guidGen";
			this.guidGen.Size = new System.Drawing.Size(107, 23);
			this.guidGen.TabIndex = 2;
			this.guidGen.Text = "New Guid";
			this.guidGen.UseVisualStyleBackColor = true;
			this.guidGen.Click += new System.EventHandler(this.genGuid_Click);
			// 
			// copyToClipboard
			// 
			this.copyToClipboard.Location = new System.Drawing.Point(290, 41);
			this.copyToClipboard.Name = "copyToClipboard";
			this.copyToClipboard.Size = new System.Drawing.Size(106, 23);
			this.copyToClipboard.TabIndex = 3;
			this.copyToClipboard.Text = "Copy to Clipboard";
			this.copyToClipboard.UseVisualStyleBackColor = true;
			this.copyToClipboard.Click += new System.EventHandler(this.copyToClipboard_Click);
			// 
			// quitBtn
			// 
			this.quitBtn.Location = new System.Drawing.Point(290, 192);
			this.quitBtn.Name = "quitBtn";
			this.quitBtn.Size = new System.Drawing.Size(106, 23);
			this.quitBtn.TabIndex = 4;
			this.quitBtn.Text = "Quit";
			this.quitBtn.UseVisualStyleBackColor = true;
			this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 227);
			this.Controls.Add(this.quitBtn);
			this.Controls.Add(this.copyToClipboard);
			this.Controls.Add(this.guidGen);
			this.Controls.Add(this.GuidTextBox);
			this.Controls.Add(this.ProgDescription);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Generate an Inifnity Friendly Guid";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ProgDescription;
		private System.Windows.Forms.TextBox GuidTextBox;
		private System.Windows.Forms.Button guidGen;
		private System.Windows.Forms.Button copyToClipboard;
		private System.Windows.Forms.Button quitBtn;
	}
}

