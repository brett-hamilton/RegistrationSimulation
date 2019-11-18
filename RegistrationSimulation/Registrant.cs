///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         Registrant.cs
//	Description:       Represents a registrant that is registering at the convention
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
	/// Provides properties and methods for storing information about each registrant
	/// </summary>
	public class Registrant
	{
		#region Properties
		/// <summary>
		/// Gets or sets the identifier number
		/// </summary>
		/// <value>The identifying number</value>
		public int ID { get; set; }

		/// <summary>
		/// Gets or sets the arrival event for this registrant
		/// </summary>
		/// <value>The arrival event</value>
		public Event Arrival { get; set; }

		/// <summary>
		/// Gets or sets the departure event for this registrant
		/// </summary>
		/// <value>The departure event</value>
		public Event Departure { get; set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default constructor
		/// </summary>
		public Registrant ( )
		{
			ID			= -1;
			Arrival		= null;
			Departure	= null;
		} // end Registrant

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="id">The identifier for this registrant</param>
		/// <param name="arrival">The arrival event</param>
		public Registrant (int id, Event arrival)
		{
			ID			= id;
			Arrival		= arrival;
			Departure	= null;
		} // end Registrant
		#endregion

		#region To String
		/// <summary>
		/// Converts this registrant instance to a string using the ID
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this registrant; uses the ID
		///		and sets its width to 4 and pads with 0's, ensuring all ID's are the same width
		/// </returns>
		public override string ToString ( )
		{
			return ID.ToString ( ).PadLeft (4, '0');
		} // end ToString
		#endregion
	} // end Registrant
}
