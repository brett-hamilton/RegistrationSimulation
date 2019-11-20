///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         SimulationDriver.cs
//	Description:       Launches and runs the registration simulator, allowing the user to decide certain
//						parameters and run the simulation
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Sunday, November 17, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSimulation
{
	public static class SimulationDriver
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main ( )
		{
			Application.EnableVisualStyles ( );
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new SettingsForm ( ));
		} // end Main
	} // end SimulationDriver
}
