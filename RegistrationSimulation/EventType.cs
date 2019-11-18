///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         EventType.cs
//	Description:       Enum that represents the Arrival and Departure events for registrants
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
	/// Defines the two event types that a registrant may have: Arrival and Departure
	/// </summary>
	public enum EventType
	{
		ARRIVAL,
		DEPARTURE
	} // end EventType
}
