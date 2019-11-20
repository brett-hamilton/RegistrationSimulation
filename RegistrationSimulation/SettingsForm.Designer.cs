namespace RegistrationSimulation
{
	partial class SettingsForm
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
			this.labelOpeningTime = new System.Windows.Forms.Label();
			this.labelClosingTime = new System.Windows.Forms.Label();
			this.labelExpNumRegistrants = new System.Windows.Forms.Label();
			this.labelNumWindows = new System.Windows.Forms.Label();
			this.labelAvgWaitTime = new System.Windows.Forms.Label();
			this.tbExpNumRegistrants = new System.Windows.Forms.TextBox();
			this.tbNumWindows = new System.Windows.Forms.TextBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.dateTimePickerOpen = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerClose = new System.Windows.Forms.DateTimePicker();
			this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
			this.labelMinutes = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.labelSeconds = new System.Windows.Forms.Label();
			this.btnSimulate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelOpeningTime
			// 
			this.labelOpeningTime.AutoSize = true;
			this.labelOpeningTime.Location = new System.Drawing.Point(203, 83);
			this.labelOpeningTime.Name = "labelOpeningTime";
			this.labelOpeningTime.Size = new System.Drawing.Size(183, 19);
			this.labelOpeningTime.TabIndex = 0;
			this.labelOpeningTime.Text = "Registration Opening Time";
			// 
			// labelClosingTime
			// 
			this.labelClosingTime.AutoSize = true;
			this.labelClosingTime.Location = new System.Drawing.Point(212, 120);
			this.labelClosingTime.Name = "labelClosingTime";
			this.labelClosingTime.Size = new System.Drawing.Size(176, 19);
			this.labelClosingTime.TabIndex = 0;
			this.labelClosingTime.Text = "Registration Closing Time";
			// 
			// labelExpNumRegistrants
			// 
			this.labelExpNumRegistrants.AutoSize = true;
			this.labelExpNumRegistrants.Location = new System.Drawing.Point(168, 194);
			this.labelExpNumRegistrants.Name = "labelExpNumRegistrants";
			this.labelExpNumRegistrants.Size = new System.Drawing.Size(218, 19);
			this.labelExpNumRegistrants.TabIndex = 0;
			this.labelExpNumRegistrants.Text = "Expected Number of Registrants";
			// 
			// labelNumWindows
			// 
			this.labelNumWindows.AutoSize = true;
			this.labelNumWindows.Location = new System.Drawing.Point(123, 231);
			this.labelNumWindows.Name = "labelNumWindows";
			this.labelNumWindows.Size = new System.Drawing.Size(263, 19);
			this.labelNumWindows.TabIndex = 0;
			this.labelNumWindows.Text = "Number of Registration Windows Open";
			// 
			// labelAvgWaitTime
			// 
			this.labelAvgWaitTime.AutoSize = true;
			this.labelAvgWaitTime.Location = new System.Drawing.Point(64, 157);
			this.labelAvgWaitTime.Name = "labelAvgWaitTime";
			this.labelAvgWaitTime.Size = new System.Drawing.Size(322, 19);
			this.labelAvgWaitTime.TabIndex = 0;
			this.labelAvgWaitTime.Text = "Expected Average Registration Process Duration";
			// 
			// tbExpNumRegistrants
			// 
			this.tbExpNumRegistrants.Location = new System.Drawing.Point(445, 190);
			this.tbExpNumRegistrants.Name = "tbExpNumRegistrants";
			this.tbExpNumRegistrants.Size = new System.Drawing.Size(100, 27);
			this.tbExpNumRegistrants.TabIndex = 1;
			this.tbExpNumRegistrants.Text = "1000";
			this.tbExpNumRegistrants.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbExpNumRegistrants.Click += new System.EventHandler(this.tb_Enter);
			this.tbExpNumRegistrants.Enter += new System.EventHandler(this.tb_Enter);
			// 
			// tbNumWindows
			// 
			this.tbNumWindows.Location = new System.Drawing.Point(445, 227);
			this.tbNumWindows.Name = "tbNumWindows";
			this.tbNumWindows.Size = new System.Drawing.Size(100, 27);
			this.tbNumWindows.TabIndex = 1;
			this.tbNumWindows.Text = "6";
			this.tbNumWindows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbNumWindows.Click += new System.EventHandler(this.tb_Enter);
			this.tbNumWindows.Enter += new System.EventHandler(this.tb_Enter);
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.IndianRed;
			this.labelTitle.Location = new System.Drawing.Point(196, 32);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(367, 29);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Convention Registration Simulation";
			// 
			// dateTimePickerOpen
			// 
			this.dateTimePickerOpen.CustomFormat = "hh : mm tt";
			this.dateTimePickerOpen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerOpen.Location = new System.Drawing.Point(445, 79);
			this.dateTimePickerOpen.Name = "dateTimePickerOpen";
			this.dateTimePickerOpen.ShowUpDown = true;
			this.dateTimePickerOpen.Size = new System.Drawing.Size(100, 27);
			this.dateTimePickerOpen.TabIndex = 7;
			this.dateTimePickerOpen.Value = new System.DateTime(2019, 11, 18, 8, 0, 0, 0);
			// 
			// dateTimePickerClose
			// 
			this.dateTimePickerClose.CustomFormat = "hh : mm tt";
			this.dateTimePickerClose.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerClose.Location = new System.Drawing.Point(445, 116);
			this.dateTimePickerClose.Name = "dateTimePickerClose";
			this.dateTimePickerClose.ShowUpDown = true;
			this.dateTimePickerClose.Size = new System.Drawing.Size(100, 27);
			this.dateTimePickerClose.TabIndex = 7;
			this.dateTimePickerClose.Value = new System.DateTime(2019, 11, 18, 18, 0, 0, 0);
			// 
			// numericUpDownMin
			// 
			this.numericUpDownMin.Location = new System.Drawing.Point(445, 153);
			this.numericUpDownMin.Name = "numericUpDownMin";
			this.numericUpDownMin.Size = new System.Drawing.Size(54, 27);
			this.numericUpDownMin.TabIndex = 8;
			this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDownMin.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// labelMinutes
			// 
			this.labelMinutes.AutoSize = true;
			this.labelMinutes.Location = new System.Drawing.Point(505, 157);
			this.labelMinutes.Name = "labelMinutes";
			this.labelMinutes.Size = new System.Drawing.Size(62, 19);
			this.labelMinutes.TabIndex = 9;
			this.labelMinutes.Text = "Minutes";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(573, 153);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(54, 27);
			this.numericUpDown1.TabIndex = 8;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// labelSeconds
			// 
			this.labelSeconds.AutoSize = true;
			this.labelSeconds.Location = new System.Drawing.Point(633, 157);
			this.labelSeconds.Name = "labelSeconds";
			this.labelSeconds.Size = new System.Drawing.Size(62, 19);
			this.labelSeconds.TabIndex = 9;
			this.labelSeconds.Text = "Seconds";
			// 
			// btnSimulate
			// 
			this.btnSimulate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSimulate.Location = new System.Drawing.Point(170, 273);
			this.btnSimulate.Name = "btnSimulate";
			this.btnSimulate.Size = new System.Drawing.Size(157, 45);
			this.btnSimulate.TabIndex = 10;
			this.btnSimulate.Text = "Run Simulation";
			this.btnSimulate.UseVisualStyleBackColor = true;
			this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(431, 273);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(157, 45);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 339);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSimulate);
			this.Controls.Add(this.labelSeconds);
			this.Controls.Add(this.labelMinutes);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.numericUpDownMin);
			this.Controls.Add(this.dateTimePickerClose);
			this.Controls.Add(this.dateTimePickerOpen);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.tbNumWindows);
			this.Controls.Add(this.tbExpNumRegistrants);
			this.Controls.Add(this.labelExpNumRegistrants);
			this.Controls.Add(this.labelAvgWaitTime);
			this.Controls.Add(this.labelNumWindows);
			this.Controls.Add(this.labelClosingTime);
			this.Controls.Add(this.labelOpeningTime);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Convention Registration Simulation";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelOpeningTime;
		private System.Windows.Forms.Label labelClosingTime;
		private System.Windows.Forms.Label labelExpNumRegistrants;
		private System.Windows.Forms.Label labelNumWindows;
		private System.Windows.Forms.Label labelAvgWaitTime;
		private System.Windows.Forms.TextBox tbExpNumRegistrants;
		private System.Windows.Forms.TextBox tbNumWindows;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DateTimePicker dateTimePickerOpen;
		private System.Windows.Forms.DateTimePicker dateTimePickerClose;
		private System.Windows.Forms.NumericUpDown numericUpDownMin;
		private System.Windows.Forms.Label labelMinutes;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label labelSeconds;
		private System.Windows.Forms.Button btnSimulate;
		private System.Windows.Forms.Button btnExit;
	}
}

