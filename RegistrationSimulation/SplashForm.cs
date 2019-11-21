///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         SplashForm.cs
//	Description:       Displays the splash form for the program
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSimulation
{
	/// <summary>
	/// Displays the splash screen with logo, title, and version number
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class SplashForm : Form
	{
		#region Constructor and Form Load
		/// <summary>
		/// Default constructor
		/// </summary>
		public SplashForm ( )
		{
			InitializeComponent ( );
		} // end SplashForm

		/// <summary>
		/// When the splash screen loads, set the current product version to the label
		/// </summary>
		/// <param name="sender">The splash form sending the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void SplashForm_Load (object sender, EventArgs e)
		{
			this.labelVersion.Text = $"Version {Application.ProductVersion}";
		} // end SplashForm_Load
		#endregion

		#region Timer		
		/// <summary>
		/// Once a tick occurs, the window closes
		/// </summary>
		/// <param name="sender">The timer generating this event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void timer_Tick (object sender, EventArgs e)
		{
			this.Close ( );
		} // end timer_Tick
		#endregion
	} // end SplashForm
}
