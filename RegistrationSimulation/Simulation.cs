///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         Simulation.cs
//	Description:       Simulates registration at a convention
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Sunday, November 17, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* For this class all I've done so far is make some properties, the default constructor, and just started the real
 * constructor. My thinking is the SetupSimulation method will fill the WaitLines and maybe call another method to
 * generate the arrival events, since from the assignment sheet it looks like that should be done before the simulation
 * starts. That's about as far I thought through it. Other than that, I think there should be maybe a Step method that
 * steps through the simulation that we use to display the simulation actually running. Let me know if you need
 * anything!
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSimulation
{
	/// <summary>
	/// Runs the simulation using other classes to form events based around different probability
	///		models
	/// </summary>
	public class Simulation
	{
		#region Properties and Fields
		private int ID = 0;						// Used to track registrant ID's
		private Random R = new Random ( );		// Used to generate random numbers

		/// <summary>
		/// Gets or sets the number of registrants
		/// </summary>
		/// <value>The number of registrants</value>
		public int NumRegistrants { get; set; }

		/// <summary>
		/// Gets or sets the number of registration windows
		/// </summary>
		/// <value>The number of registration windows</value>
		public int NumWindows { get; set; }

		/// <summary>
		/// Gets or sets the start time for the registration period
		/// </summary>
		/// <value>The start time of the registration period</value>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// Gets or sets the ending time for the registration period
		/// </summary>
		/// <value>The ending time of the registration period</value>
		public DateTime EndTime { get; set; }

		/// <summary>
		/// Gets or sets the average time it takes to complete registration
		/// </summary>
		/// <value>The average time it takes to complete registration</value>
		public TimeSpan AvgRegistrationTime { get; set; }

		/// <summary>
		/// List of queues of registrants representing the waiting lines at the windows
		/// </summary>
		public List<Queue <Registrant>> WaitLines { get; set; }

		/// <summary>
		/// Priority Queue that manages the events, ensuring they are placed in order based
		///		on the event time
		/// </summary>
		public PriorityQueue<Event> EventPQ { get; set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default constructor
		/// </summary>
		public Simulation ( )
		{
			NumRegistrants		= 0;
			NumWindows			= 0;
			StartTime			= DateTime.Now;
			EndTime				= DateTime.Now;
			AvgRegistrationTime	= new TimeSpan (0, 0, 0);
			WaitLines			= new List<Queue<Registrant>> ( );
			EventPQ				= new PriorityQueue<Event> ( );
		} // end Simulation

		public Simulation (int expRegistrants, int numWindows, DateTime start, DateTime end,
			TimeSpan avgRegistrationTime)
		{
			NumRegistrants		= Poisson (expRegistrants);
			NumWindows			= numWindows;
			StartTime			= start;
			EndTime				= end;
			AvgRegistrationTime	= avgRegistrationTime;
			// WaitLines = ?

			SetupSimulation ( );
		} // end Simulation
		#endregion

		private void SetupSimulation ( )
		{

		} // end SetupSimulation

		private int Poisson (int expRegistrants)
		{
			return -1;
		} // end Poisson
	} // end Simulation
}
