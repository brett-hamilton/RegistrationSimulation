///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         Event.cs
//	Description:       Represents an event with information such as the time, type, and registrant associated
//						with the event; also defines how events are compared
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Sunday, November 17, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSimulation
{
	/// <summary>
	/// Contains information about an event and determines how they are compared for use in the
	///		Priority Queue implementation
	/// </summary>
	/// <seealso cref="System.IComparable" />
	public class Event : IComparable
	{
		#region Properties		
		/// <summary>
		/// Gets or sets the type of event, arrival or departure
		/// </summary>
		/// <value>Either arrival or departure</value>
		public EventType Type { get; set; }

		/// <summary>
		/// Gets or sets the time of the event
		/// </summary>
		/// <value>The time of the event</value>
		public DateTime Time { get; set; }

		/// <summary>
		/// Gets or sets the registrant associated with the event
		/// </summary>
		/// <value>The registrant</value>
		public Registrant Registrant { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor
		/// </summary>
		public Event ( )
		{
			Type		= EventType.ARRIVAL;
			Time		= DateTime.Now;
			Registrant	= null;
		} // end Event

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="type">The type of event, either an arrival and a departure</param>
		/// <param name="time">The time of the event</param>
		public Event (EventType type, DateTime time)
		{
			Type		= type;
			Time		= time;
			Registrant	= null;
		} // end Event
		#endregion

		#region IComparable Implementation		
		/// <summary>
		/// Compares the current event with another event and returns an integer that indicates 
		///		whether the current event precedes, follows, or occurs in the same position 
		///		in the sort order as the other event; uses the time of the event to compare events
		/// </summary>
		/// <param name="obj">An object to compare with this instance</param>
		/// <returns>
		/// A negative integer if the current event precedes the event argument; a 0 if the events
		///		occur at the same time (meaning equal); a positive integer if the current event
		///		occurs later than the event
		/// </returns>
		/// <exception cref="ArgumentException">The argument is not an Event object.</exception>
		public int CompareTo (object obj)
		{
			if (!(obj is Event))
				throw new ArgumentException ("The argument is not an Event object.");

			Event e = (Event) obj;
			return e.Time.CompareTo (Time);		// Use DateTime to compare events
		} // end CompareTo
		#endregion
	} // end Event
}
