namespace RegistrationSimulation
{
	partial class SplashForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
			this.panelLogo = new System.Windows.Forms.Panel();
			this.panelText = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.panelLogo.SuspendLayout();
			this.panelText.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.labelVersion);
			this.panelLogo.Controls.Add(this.labelTitle);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelLogo.Location = new System.Drawing.Point(0, 357);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(589, 99);
			this.panelLogo.TabIndex = 0;
			// 
			// panelText
			// 
			this.panelText.Controls.Add(this.pbLogo);
			this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelText.Location = new System.Drawing.Point(0, 0);
			this.panelText.Name = "panelText";
			this.panelText.Size = new System.Drawing.Size(589, 357);
			this.panelText.TabIndex = 0;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
			this.labelTitle.Location = new System.Drawing.Point(12, 7);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(565, 45);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Convention Registration Simulation";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersion.Location = new System.Drawing.Point(12, 61);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(57, 19);
			this.labelVersion.TabIndex = 1;
			this.labelVersion.Text = "Version";
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 3500;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// pbLogo
			// 
			this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbLogo.Image = global::RegistrationSimulation.Properties.Resources.shield_logo;
			this.pbLogo.Location = new System.Drawing.Point(0, 0);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(589, 357);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogo.TabIndex = 1;
			this.pbLogo.TabStop = false;
			// 
			// SplashForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 456);
			this.Controls.Add(this.panelText);
			this.Controls.Add(this.panelLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SplashForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashForm";
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.Load += new System.EventHandler(this.SplashForm_Load);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			this.panelText.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelText;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Timer timer;
	}
}