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
			this.panelSimulation = new System.Windows.Forms.Panel();
			this.panelStats = new System.Windows.Forms.Panel();
			this.tbSimulationOutput = new System.Windows.Forms.TextBox();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelLongestQueue = new System.Windows.Forms.Label();
			this.labelNumEvents = new System.Windows.Forms.Label();
			this.labelNumArrivals = new System.Windows.Forms.Label();
			this.labelNumDepartures = new System.Windows.Forms.Label();
			this.tbLongestQueue = new System.Windows.Forms.TextBox();
			this.tbNumEvents = new System.Windows.Forms.TextBox();
			this.tbNumArrivals = new System.Windows.Forms.TextBox();
			this.tbNumDepartures = new System.Windows.Forms.TextBox();
			this.labelMinWait = new System.Windows.Forms.Label();
			this.tbMinWait = new System.Windows.Forms.TextBox();
			this.labelMaxWait = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelAvgWait = new System.Windows.Forms.Label();
			this.panelSimulation.SuspendLayout();
			this.panelStats.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSimulation
			// 
			this.panelSimulation.BackColor = System.Drawing.SystemColors.Control;
			this.panelSimulation.Controls.Add(this.tbSimulationOutput);
			this.panelSimulation.Controls.Add(this.panelTitle);
			this.panelSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSimulation.Location = new System.Drawing.Point(0, 0);
			this.panelSimulation.Name = "panelSimulation";
			this.panelSimulation.Size = new System.Drawing.Size(912, 350);
			this.panelSimulation.TabIndex = 0;
			// 
			// panelStats
			// 
			this.panelStats.BackColor = System.Drawing.SystemColors.Control;
			this.panelStats.Controls.Add(this.textBox1);
			this.panelStats.Controls.Add(this.tbNumDepartures);
			this.panelStats.Controls.Add(this.tbNumArrivals);
			this.panelStats.Controls.Add(this.tbMinWait);
			this.panelStats.Controls.Add(this.tbNumEvents);
			this.panelStats.Controls.Add(this.tbLongestQueue);
			this.panelStats.Controls.Add(this.labelNumDepartures);
			this.panelStats.Controls.Add(this.labelNumArrivals);
			this.panelStats.Controls.Add(this.labelMaxWait);
			this.panelStats.Controls.Add(this.labelAvgWait);
			this.panelStats.Controls.Add(this.labelMinWait);
			this.panelStats.Controls.Add(this.labelNumEvents);
			this.panelStats.Controls.Add(this.labelLongestQueue);
			this.panelStats.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelStats.Location = new System.Drawing.Point(0, 350);
			this.panelStats.Name = "panelStats";
			this.panelStats.Size = new System.Drawing.Size(912, 108);
			this.panelStats.TabIndex = 0;
			// 
			// tbSimulationOutput
			// 
			this.tbSimulationOutput.BackColor = System.Drawing.SystemColors.Info;
			this.tbSimulationOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbSimulationOutput.Location = new System.Drawing.Point(0, 58);
			this.tbSimulationOutput.Multiline = true;
			this.tbSimulationOutput.Name = "tbSimulationOutput";
			this.tbSimulationOutput.ReadOnly = true;
			this.tbSimulationOutput.Size = new System.Drawing.Size(912, 292);
			this.tbSimulationOutput.TabIndex = 0;
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(912, 58);
			this.panelTitle.TabIndex = 1;
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.IndianRed;
			this.labelTitle.Location = new System.Drawing.Point(273, 15);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(367, 29);
			this.labelTitle.TabIndex = 3;
			this.labelTitle.Text = "Convention Registration Simulation";
			// 
			// labelLongestQueue
			// 
			this.labelLongestQueue.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelLongestQueue.AutoSize = true;
			this.labelLongestQueue.Location = new System.Drawing.Point(137, 7);
			this.labelLongestQueue.Name = "labelLongestQueue";
			this.labelLongestQueue.Size = new System.Drawing.Size(272, 16);
			this.labelLongestQueue.TabIndex = 0;
			this.labelLongestQueue.Text = "Longest Queue Encountered So Far:";
			// 
			// labelNumEvents
			// 
			this.labelNumEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelNumEvents.AutoSize = true;
			this.labelNumEvents.Location = new System.Drawing.Point(209, 33);
			this.labelNumEvents.Name = "labelNumEvents";
			this.labelNumEvents.Size = new System.Drawing.Size(200, 16);
			this.labelNumEvents.TabIndex = 0;
			this.labelNumEvents.Text = "Events Processed So Far:";
			// 
			// labelNumArrivals
			// 
			this.labelNumArrivals.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelNumArrivals.AutoSize = true;
			this.labelNumArrivals.Location = new System.Drawing.Point(621, 7);
			this.labelNumArrivals.Name = "labelNumArrivals";
			this.labelNumArrivals.Size = new System.Drawing.Size(80, 16);
			this.labelNumArrivals.TabIndex = 0;
			this.labelNumArrivals.Text = "Arrivals:";
			// 
			// labelNumDepartures
			// 
			this.labelNumDepartures.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelNumDepartures.AutoSize = true;
			this.labelNumDepartures.Location = new System.Drawing.Point(605, 33);
			this.labelNumDepartures.Name = "labelNumDepartures";
			this.labelNumDepartures.Size = new System.Drawing.Size(96, 16);
			this.labelNumDepartures.TabIndex = 0;
			this.labelNumDepartures.Text = "Departures:";
			// 
			// tbLongestQueue
			// 
			this.tbLongestQueue.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbLongestQueue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLongestQueue.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbLongestQueue.Location = new System.Drawing.Point(416, 4);
			this.tbLongestQueue.Name = "tbLongestQueue";
			this.tbLongestQueue.ReadOnly = true;
			this.tbLongestQueue.Size = new System.Drawing.Size(63, 22);
			this.tbLongestQueue.TabIndex = 1;
			this.tbLongestQueue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbNumEvents
			// 
			this.tbNumEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbNumEvents.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumEvents.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbNumEvents.Location = new System.Drawing.Point(416, 30);
			this.tbNumEvents.Name = "tbNumEvents";
			this.tbNumEvents.ReadOnly = true;
			this.tbNumEvents.Size = new System.Drawing.Size(63, 22);
			this.tbNumEvents.TabIndex = 1;
			this.tbNumEvents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbNumArrivals
			// 
			this.tbNumArrivals.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbNumArrivals.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumArrivals.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbNumArrivals.Location = new System.Drawing.Point(712, 4);
			this.tbNumArrivals.Name = "tbNumArrivals";
			this.tbNumArrivals.ReadOnly = true;
			this.tbNumArrivals.Size = new System.Drawing.Size(63, 22);
			this.tbNumArrivals.TabIndex = 1;
			this.tbNumArrivals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbNumDepartures
			// 
			this.tbNumDepartures.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbNumDepartures.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumDepartures.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbNumDepartures.Location = new System.Drawing.Point(712, 30);
			this.tbNumDepartures.Name = "tbNumDepartures";
			this.tbNumDepartures.ReadOnly = true;
			this.tbNumDepartures.Size = new System.Drawing.Size(63, 22);
			this.tbNumDepartures.TabIndex = 1;
			this.tbNumDepartures.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelMinWait
			// 
			this.labelMinWait.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMinWait.AutoSize = true;
			this.labelMinWait.Location = new System.Drawing.Point(233, 59);
			this.labelMinWait.Name = "labelMinWait";
			this.labelMinWait.Size = new System.Drawing.Size(176, 16);
			this.labelMinWait.TabIndex = 0;
			this.labelMinWait.Text = "Minimum Service Time:";
			this.labelMinWait.Visible = false;
			// 
			// tbMinWait
			// 
			this.tbMinWait.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbMinWait.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMinWait.ForeColor = System.Drawing.Color.DodgerBlue;
			this.tbMinWait.Location = new System.Drawing.Point(416, 56);
			this.tbMinWait.Name = "tbMinWait";
			this.tbMinWait.ReadOnly = true;
			this.tbMinWait.Size = new System.Drawing.Size(63, 22);
			this.tbMinWait.TabIndex = 1;
			this.tbMinWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbMinWait.Visible = false;
			// 
			// labelMaxWait
			// 
			this.labelMaxWait.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMaxWait.AutoSize = true;
			this.labelMaxWait.Location = new System.Drawing.Point(525, 59);
			this.labelMaxWait.Name = "labelMaxWait";
			this.labelMaxWait.Size = new System.Drawing.Size(176, 16);
			this.labelMaxWait.TabIndex = 0;
			this.labelMaxWait.Text = "Maximum Service Time:";
			this.labelMaxWait.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.textBox1.Location = new System.Drawing.Point(712, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(63, 22);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox1.Visible = false;
			// 
			// labelAvgWait
			// 
			this.labelAvgWait.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelAvgWait.AutoSize = true;
			this.labelAvgWait.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAvgWait.ForeColor = System.Drawing.Color.DodgerBlue;
			this.labelAvgWait.Location = new System.Drawing.Point(232, 83);
			this.labelAvgWait.Name = "labelAvgWait";
			this.labelAvgWait.Size = new System.Drawing.Size(448, 16);
			this.labelAvgWait.TabIndex = 0;
			this.labelAvgWait.Text = "The average service time for 1000 Registrants was 00:00";
			this.labelAvgWait.Visible = false;
			// 
			// SimulationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 458);
			this.Controls.Add(this.panelSimulation);
			this.Controls.Add(this.panelStats);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "SimulationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Convention Registration Simulation";
			this.panelSimulation.ResumeLayout(false);
			this.panelSimulation.PerformLayout();
			this.panelStats.ResumeLayout(false);
			this.panelStats.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
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
		private System.Windows.Forms.TextBox tbMinWait;
		private System.Windows.Forms.Label labelMinWait;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelMaxWait;
		private System.Windows.Forms.Label labelAvgWait;
	}
}