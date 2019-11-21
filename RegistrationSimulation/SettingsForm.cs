///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         SettingsForm.cs
//	Description:       Displays the settings form that allows the user to set the simulation parameters and
//							start the simulation
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Sunday, November 17, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace RegistrationSimulation
{
	/// <summary>
	/// Opens the settings form and handles user input and validates information
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class SettingsForm : Form
	{
		#region Fields
		private DateTime start;				// Convention starting time
		private DateTime end;				// Convention closing time
		private TimeSpan expWaitTime;		// Expected average time to register
		private int expNumRegistrants;		// Expected number of registrants
		private int numWindows;             // Number of registration windows open
		#endregion

		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public SettingsForm ( )
		{
			InitializeComponent ( );
		} // end SettingsForm
		#endregion

		#region Event Handlers
		/// <summary>
		/// If input is valid, open the simulation window to run
		/// </summary>
		/// <param name="sender">The button that generated the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void btnSimulate_Click (object sender, EventArgs e)
		{
			if (!ValidateConstraints ( ))		// Do nothing if input invalid
				return;

			SimulationForm sim = new SimulationForm (expNumRegistrants, numWindows, start,
				end, expWaitTime);
			sim.ShowDialog ( );
		} // end btnSimulate_Click

		/// <summary>
		/// Closes the form if exit button is clicked
		/// </summary>
		/// <param name="sender">The exit button sending the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void btnExit_Click (object sender, EventArgs e)
		{
			this.Close ( );
		} // end btnExit_Click

		/// <summary>
		/// Validates the constraints of the simulation
		/// </summary>
		/// <returns>True if everything is valid, false if there is a problem</returns>
		/// <exception cref="Exception">Error: Opening time must precede closing time.</exception>
		private bool ValidateConstraints ( )
		{
			bool valid = true;					// Assume valid until otherwise

			try
			{
				start = dateTimePickerOpen.Value;
				expNumRegistrants = (int) numericUpDownNumRegistrants.Value;
				numWindows = (int) numericUpDownNumWindows.Value;
				expWaitTime = new TimeSpan (0, (int) numericUpDownMin.Value,
					(int) numericUpDownSecs.Value);

				// Validates the opening time is before closing time
				if (dateTimePickerClose.Value <= dateTimePickerOpen.Value)
					throw new Exception ("Error: Opening time must precede closing time.");
				else
					end = dateTimePickerClose.Value;
			}
			catch (Exception e)
			{
				MessageBox.Show (this, e.Message, "Input Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				valid = false;
			}

			return valid;
		}// end ValidateConstraints
		#endregion
	} // end SettingsForm
}
