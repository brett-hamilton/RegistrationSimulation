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

 /* Todo:
  *	 - Write ToString method for display in windows form text box as simulation runs
  *	 - Finish commenting
  *	 - Finish GUI (almost there - just have to connect all the data/buttons/text/etc.)
  *	 - Write summary paper
  *
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
		private Random R	= new Random ( );		// Used to generate random numbers

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

		/// <summary>
		/// counter for the largest queue
		/// </summary>
		public int LargestQueue { get; set; }

		/// <summary>
		/// counter for total arrivals
		/// </summary>
		public int TotalArrivals { get; set; }

		/// <summary>
		/// counter for total departures
		/// </summary>
		public int TotalDepartures { get; set; }

		/// <summary>
		/// counter for total events, arrival and departure
		/// </summary>
		public int TotalEvents { get; set; }

		/// <summary>
		/// Gets or sets the shortest wait time that a registrant experienced
		/// </summary>
		/// <value>The shortest wait time</value>
		public TimeSpan ShortestWait { get; set; }

		/// <summary>
		/// Gets or sets the longest wait time that a registrant experienced
		/// </summary>
		/// <value>The longest wait time</value>
		public TimeSpan LongestWait { get; set; }

		/// <summary>
		/// Gets or sets the total wait time of all registrants; used for calculating average
		/// </summary>
		/// <value>The total wait time</value>
		public TimeSpan TotalWait { get; set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default constructor
		/// </summary>
		public Simulation ( )
		{
			NumRegistrants		= 0;
			NumWindows			= 0;
			LargestQueue		= 0;
			TotalArrivals		= 0;
			TotalDepartures		= 0;
			TotalEvents			= 0;
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
			AvgRegistrationTime = avgRegistrationTime;

			LargestQueue	= 0;
			TotalArrivals	= 0;
			TotalDepartures = 0;
			TotalEvents		= 0;

			SetupSimulation ( );
		} // end Simulation
		#endregion

		/// <summary>
		/// Creates windows, creates registrants, adds them to a list, to later be distributed
		/// </summary>
		private void SetupSimulation ( )
		{
			//creates queues based on number of windows
			for(int window = 0; window < NumWindows; window++)
			{
				WaitLines.Add(new Queue<Registrant> ( ));
			}

			GenerateArrivalEvents ( );
		} // end SetupSimulation

		#region Generate Arrival and Departure Events		
		/// <summary>
		/// Generates the arrival events for registrants and adds them to event Priority Queue
		/// </summary>
		private void GenerateArrivalEvents ( )
		{
			TimeSpan start;
			TimeSpan timeOpen = EndTime - StartTime;

			for (int registrant = 1; registrant <= NumRegistrants; registrant++)
			{
				// Generate random amount of time between 0 and registration open period
				start = new TimeSpan (R.Next (timeOpen.Hours), R.Next (timeOpen.Minutes), 
					R.Next (timeOpen.Seconds));

				// Create arrival event
				Event newEvent = new Event (EventType.ARRIVAL, (StartTime + start));

				// Create registrant
				Registrant newRegistrant = new Registrant (registrant, newEvent);

				// Associate registrant with event
				newEvent.Registrant		= newRegistrant;
				newRegistrant.Arrival	= newEvent;

				// Add arrival event to Priority Queue of events
				EventPQ.Enqueue (newEvent);
			}
		} // end GenerateArrivalEvents

		private void GenerateDepartureEvent (Registrant registrant)
		{
			// generates a random interval for how long the person takes, with a minimum of 1 minute
			// and 30 seconds
			TimeSpan wait = new TimeSpan (0, (int) (1.5 + NegExp (AvgRegistrationTime.TotalMinutes)), 0);

			// Creates departure event based on the time interval plus the time we are currently
			// at in the Priority Queue
			Event newDepartureEvent = new Event (EventType.DEPARTURE, ((EventPQ.Peek ( ).Time + wait)));

			//Associates departure event with registrant
			newDepartureEvent.Registrant = registrant;
			registrant.Departure = newDepartureEvent;

			// Adds departure event to the queue
			EventPQ.Enqueue (newDepartureEvent);

			// Update wait times for statistic counters
			TotalWait += wait;

			if (wait > LongestWait)
				LongestWait = wait;

			if (wait < ShortestWait)
				ShortestWait = wait;
		}// end GenerateDepartureEvents
		#endregion

		public void RunSimulation( )
		{
			Queue<Registrant> shortestLine	= null;
			Queue<Registrant> currentLine	= null;


			if (EventPQ.Peek ( ).Type == EventType.ARRIVAL)	// If the event is an arrival
			{
				// Find shortest line and add registrant
				shortestLine = FindShortestLine ( );
				shortestLine.Enqueue (EventPQ.Peek ( ).Registrant);

				// Increment if new largest queue found
				if (shortestLine.Count > LargestQueue)
					LargestQueue++;

				// Generate departure event if this customer is at the front of the line
				if (shortestLine.Count == 1)
					GenerateDepartureEvent (shortestLine.Peek ( ));

				// Event completely handled; remove the event and add to counter
				EventPQ.Dequeue ( );
				TotalArrivals++;
				TotalEvents++;
			}
			else	// If the event is a departure
			{
				// Get the line that registrant is about to leave
				for (int i = 0; i < WaitLines.Count; i++)
				{
					if (WaitLines[i].Peek ( ).ID == EventPQ.Peek ( ).Registrant.ID)
					{
						currentLine = WaitLines[i];
						break;
					}
				}

				// Remove registrant from wait line
				currentLine.Dequeue ( );
				TotalDepartures++;
				TotalEvents++;

				// If the wait line is not empty, generate a departure event for the next registrant
				if (currentLine.Count > 0)
					GenerateDepartureEvent (currentLine.Peek ( ));
			}
		} // end RunSimulation

		/// <summary>
		/// Finds the shortest line.
		/// </summary>
		/// <returns></returns>
		private Queue<Registrant> FindShortestLine ( )
		{
			Queue<Registrant> shortestLine = WaitLines[0];

			// Search for the shortest line
			for (int i = 1; i < WaitLines.Count && WaitLines.Count > 1; i++)
			{
				if (shortestLine.Count > WaitLines[i].Count)
					shortestLine = WaitLines[i];
			}

			return shortestLine;
		}// end FindShortestLine

		#region Random Distribution Methods
		/// <summary>
		/// Uses the Poisson distribution model to randomize the number of registrants
		///		at the convention
		/// </summary>
		/// <param name="expRegistrants">The expected number of registrants</param>
		/// <returns>Number of registrants</returns>
		private int Poisson (int expRegistrants)
		{
			double dLimit = -expRegistrants;
			double dSum = Math.Log (R.NextDouble ( ));

			int count;
			for (count = 0; dSum > dLimit; count++)
				dSum += Math.Log (R.NextDouble ( ));

			return count;
		} // end Poisson

		private double NegExp (double ExpectedValue)
		{
			return -ExpectedValue * Math.Log (R.NextDouble ( ), Math.E);
		}
		#endregion

		#region To String
		public override string ToString ( )
		{
			return base.ToString ( );
		}
		#endregion

	} // end Simulation
}
