namespace RegistrationSimulation
{
	partial class SimulationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
			this.panelSimulation = new System.Windows.Forms.Panel();
			this.tbSimulationOutput = new System.Windows.Forms.TextBox();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panelStats = new System.Windows.Forms.Panel();
			this.tbNumDepartures = new System.Windows.Forms.TextBox();
			this.tbNumArrivals = new System.Windows.Forms.TextBox();
			this.tbNumEvents = new System.Windows.Forms.TextBox();
			this.tbLongestQueue = new System.Windows.Forms.TextBox();
			this.labelNumDepartures = new System.Windows.Forms.Label();
			this.labelNumArrivals = new System.Windows.Forms.Label();
			this.labelAvgWait = new System.Windows.Forms.Label();
			this.labelNumEvents = new System.Windows.Forms.Label();
			this.labelLongestQueue = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.labelMinWait = new System.Windows.Forms.Label();
			this.labelMaxWait = new System.Windows.Forms.Label();
			this.panelSimulation.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panelStats.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSimulation
			// 
			this.panelSimulation.BackColor = System.Drawing.SystemColors.Control;
			this.panelSimulation.Controls.Add(this.btnStart);
			this.panelSimulation.Controls.Add(this.tbSimulationOutput);
			this.panelSimulation.Controls.Add(this.panelTitle);
			this.panelSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSimulation.Location = new System.Drawing.Point(0, 0);
			this.panelSimulation.Name = "panelSimulation";
			this.panelSimulation.Size = new System.Drawing.Size(1060, 483);
			this.panelSimulation.TabIndex = 0;
			// 
			// tbSimulationOutput
			// 
			this.tbSimulationOutput.BackColor = System.Drawing.SystemColors.Info;
			this.tbSimulationOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbSimulationOutput.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSimulationOutput.Location = new System.Drawing.Point(0, 58);
			this.tbSimulationOutput.Multiline = true;
			this.tbSimulationOutput.Name = "tbSimulationOutput";
			this.tbSimulationOutput.ReadOnly = true;
			this.tbSimulationOutput.Size = new System.Drawing.Size(1060, 425);
			this.tbSimulationOutput.TabIndex = 0;
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1060, 58);
			this.panelTitle.TabIndex = 1;
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.IndianRed;
			this.labelTitle.Location = new System.Drawing.Point(347, 15);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(367, 29);
			this.labelTitle.TabIndex = 3;
			this.labelTitle.Text = "Convention Registration Simulation";
			// 
			// panelStats
			// 
			this.panelStats.BackColor = System.Drawing.SystemColors.Control;
			this.panelStats.Controls.Add(this.tbNumDepartures);
			this.panelStats.Controls.Add(this.tbNumArrivals);
			this.panelStats.Controls.Add(this.tbNumEvents);
			this.panelStats.Controls.Add(this.tbLongestQueue);
			this.panelStats.Controls.Add(this.labelNumDepartures);
			this.panelStats.Controls.Add(this.labelNumArrivals);
			this.panelStats.Controls.Add(this.labelMaxWait);
			this.panelStats.Controls.Add(this.labelMinWait);
			this.panelStats.Controls.Add(this.labelAvgWait);
			this.panelStats.Controls.Add(this.labelNumEvents);
			this.panelStats.Controls.Add(this.labelLongestQueue);
			this.panelStats.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelStats.Location = new System.Drawing.Point(0, 483);
			this.panelStats.Name = "panelStats";
			this.panelStats.Size = new System.Drawing.Size(1060, 108);
			this.panelStats.TabIndex = 0;
			// 
			// tbNumDepartures
			// 
			this.tbNumDepartures.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbNumDepartures.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumDepartures.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbNumDepartures.Location = new System.Drawing.Point(786, 30);
			this.tbNumDepartures.Name = "tbNumDepartures";
			this.tbNumDepartures.ReadOnly = true;
			this.tbNumDepartures.Size = new System.Drawing.Size(63, 22);
			this.tbNumDepartures.TabIndex = 1;
			this.tbNumDepartures.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbNumArrivals
			// 
			this.tbNumArrivals.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbNumArrivals.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumArrivals.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbNumArrivals.Location = new System.Drawing.Point(786, 4);
			this.tbNumArrivals.Name = "tbNumArrivals";
			this.tbNumArrivals.ReadOnly = true;
			this.tbNumArrivals.Size = new System.Drawing.Size(63, 22);
			this.tbNumArrivals.TabIndex = 1;
			this.tbNumArrivals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbNumEvents
			// 
			this.tbNumEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbNumEvents.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumEvents.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbNumEvents.Location = new System.Drawing.Point(490, 30);
			this.tbNumEvents.Name = "tbNumEvents";
			this.tbNumEvents.ReadOnly = true;
			this.tbNumEvents.Size = new System.Drawing.Size(63, 22);
			this.tbNumEvents.TabIndex = 1;
			this.tbNumEvents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbLongestQueue
			// 
			this.tbLongestQueue.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbLongestQueue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLongestQueue.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbLongestQueue.Location = new System.Drawing.Point(490, 4);
			this.tbLongestQueue.Name = "tbLongestQueue";
			this.tbLongestQueue.ReadOnly = true;
			this.tbLongestQueue.Size = new System.Drawing.Size(63, 22);
			this.tbLongestQueue.TabIndex = 1;
			this.tbLongestQueue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelNumDepartures
			// 
			this.labelNumDepartures.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelNumDepartures.AutoSize = true;
			this.labelNumDepartures.Location = new System.Drawing.Point(679, 33);
			this.labelNumDepartures.Name = "labelNumDepartures";
			this.labelNumDepartures.Size = new System.Drawing.Size(96, 16);
			this.labelNumDepartures.TabIndex = 0;
			this.labelNumDepartures.Text = "Departures:";
			// 
			// labelNumArrivals
			// 
			this.labelNumArrivals.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelNumArrivals.AutoSize = true;
			this.labelNumArrivals.Location = new System.Drawing.Point(695, 7);
			this.labelNumArrivals.Name = "labelNumArrivals";
			this.labelNumArrivals.Size = new System.Drawing.Size(80, 16);
			this.labelNumArrivals.TabIndex = 0;
			this.labelNumArrivals.Text = "Arrivals:";
			// 
			// labelAvgWait
			// 
			this.labelAvgWait.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelAvgWait.AutoSize = true;
			this.labelAvgWait.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAvgWait.ForeColor = System.Drawing.Color.DodgerBlue;
			this.labelAvgWait.Location = new System.Drawing.Point(306, 87);
			this.labelAvgWait.Name = "labelAvgWait";
			this.labelAvgWait.Size = new System.Drawing.Size(448, 16);
			this.labelAvgWait.TabIndex = 0;
			this.labelAvgWait.Text = "The average service time for 1000 Registrants was 00:00";
			this.labelAvgWait.Visible = false;
			// 
			// labelNumEvents
			// 
			this.labelNumEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelNumEvents.AutoSize = true;
			this.labelNumEvents.Location = new System.Drawing.Point(283, 33);
			this.labelNumEvents.Name = "labelNumEvents";
			this.labelNumEvents.Size = new System.Drawing.Size(200, 16);
			this.labelNumEvents.TabIndex = 0;
			this.labelNumEvents.Text = "Events Processed So Far:";
			// 
			// labelLongestQueue
			// 
			this.labelLongestQueue.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelLongestQueue.AutoSize = true;
			this.labelLongestQueue.Location = new System.Drawing.Point(211, 7);
			this.labelLongestQueue.Name = "labelLongestQueue";
			this.labelLongestQueue.Size = new System.Drawing.Size(272, 16);
			this.labelLongestQueue.TabIndex = 0;
			this.labelLongestQueue.Text = "Longest Queue Encountered So Far:";
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStart.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnStart.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.SystemColors.Window;
			this.btnStart.Location = new System.Drawing.Point(452, 237);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(156, 59);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// labelMinWait
			// 
			this.labelMinWait.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMinWait.AutoSize = true;
			this.labelMinWait.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMinWait.ForeColor = System.Drawing.Color.DodgerBlue;
			this.labelMinWait.Location = new System.Drawing.Point(306, 55);
			this.labelMinWait.Name = "labelMinWait";
			this.labelMinWait.Size = new System.Drawing.Size(304, 16);
			this.labelMinWait.TabIndex = 0;
			this.labelMinWait.Text = "The minimum service time was 00:00:00";
			this.labelMinWait.Visible = false;
			// 
			// labelMaxWait
			// 
			this.labelMaxWait.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMaxWait.AutoSize = true;
			this.labelMaxWait.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMaxWait.ForeColor = System.Drawing.Color.DodgerBlue;
			this.labelMaxWait.Location = new System.Drawing.Point(306, 71);
			this.labelMaxWait.Name = "labelMaxWait";
			this.labelMaxWait.Size = new System.Drawing.Size(304, 16);
			this.labelMaxWait.TabIndex = 0;
			this.labelMaxWait.Text = "The maximum service time was 00:00:00";
			this.labelMaxWait.Visible = false;
			// 
			// SimulationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1060, 591);
			this.Controls.Add(this.panelSimulation);
			this.Controls.Add(this.panelStats);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SimulationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Convention Registration Simulation, Micah DePetro & Brett Hamilton";
			this.panelSimulation.ResumeLayout(false);
			this.panelSimulation.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.panelStats.ResumeLayout(false);
			this.panelStats.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSimulation;
		private System.Windows.Forms.TextBox tbSimulationOutput;
		private System.Windows.Forms.Panel panelStats;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelLongestQueue;
		private System.Windows.Forms.Label labelNumDepartures;
		private System.Windows.Forms.Label labelNumArrivals;
		private System.Windows.Forms.Label labelNumEvents;
		private System.Windows.Forms.TextBox tbLongestQueue;
		private System.Windows.Forms.TextBox tbNumDepartures;
		private System.Windows.Forms.TextBox tbNumArrivals;
		private System.Windows.Forms.TextBox tbNumEvents;
		private System.Windows.Forms.Label labelAvgWait;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label labelMaxWait;
		private System.Windows.Forms.Label labelMinWait;
	}
}