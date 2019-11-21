///////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         SimulationForm.cs
//	Description:       Form that contains the simulation display as it runs and the resulting
//							statistics
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Sunday, November 17, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSimulation
{
	/// <summary>
	/// Displays the simulation interface, running the simulation in the text box and updating 
	///		the statistics
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class SimulationForm : Form
	{
		private Simulation simulation;

		#region Constructors
		/// <summary>
		/// Default constructor
		/// </summary>
		public SimulationForm ( )
		{
			InitializeComponent ( );
		} // end SimulationForm

		/// <summary>
		/// Parameterized constructor; creates the simulation
		/// </summary>
		/// <param name="expRegistrants">The number of expected registrants</param>
		/// <param name="numWindows">The number windows open</param>
		/// <param name="start">The starting time</param>
		/// <param name="end">The ending time</param>
		/// <param name="avgRegistrationTime">The average registration time</param>
		public SimulationForm (int expRegistrants, int numWindows, DateTime start, DateTime end,
			TimeSpan avgRegistrationTime)
		{
			InitializeComponent ( );
			this.simulation = new Simulation (expRegistrants, numWindows, start, end,
				avgRegistrationTime);
		} // end Simulation
		#endregion

		#region Click Events		
		/// <summary>
		/// Runs the simulation, displaying the current state one step a time; updates the counters
		///		in the text boxes and calculates program statistics after it is finished
		/// </summary>
		/// <param name="sender">The start button sending the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void btnStart_Click (object sender, EventArgs e)
		{
			btnStart.Visible = false;		// Make button disappear from window

			// Step through simulation until finished
			while (!simulation.Complete)
			{
				simulation.RunSimulation ( );		// Do one step

				tbSimulationOutput.Text = simulation.ToString ( );

				tbLongestQueue.Text = simulation.LargestQueue.ToString ( );
				tbNumEvents.Text = simulation.TotalEvents.ToString ( );
				tbNumArrivals.Text = simulation.TotalArrivals.ToString ( );
				tbNumDepartures.Text = simulation.TotalDepartures.ToString ( );

				this.Refresh ( );					// Update text fields with current info
				Thread.Sleep (100);					// 100milliseconds recommended thread time
			}

			// Calculate and display ending statistics
			labelMinWait.Text = $"The minimum service time was {simulation.ShortestWait}";
			labelMaxWait.Text = $"The maximum service time was {simulation.LongestWait}";

			// Get the average wait time based on total wait time / total registrants
			double avgWait = (simulation.TotalWait.TotalSeconds / simulation.NumRegistrants);
			TimeSpan avgWaitTime = new TimeSpan (0, 0, (int) avgWait);
			labelAvgWait.Text = $"The average service time for {simulation.NumRegistrants} " +
				$"Registrants was {avgWaitTime}";

			// Make labels with statistics visible
			labelMinWait.Visible = true;
			labelMaxWait.Visible = true;
			labelAvgWait.Visible = true;
		} // end btnStart_Click
		#endregion
	} // end SimulationForm
}
