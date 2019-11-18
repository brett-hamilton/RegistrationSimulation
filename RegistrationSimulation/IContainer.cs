///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         IContainer.cs
//	Description:       Defines the interface that represents the container for the implementation of
//						the Priority Queue data structure
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
	/// Interface for the container of the Priority Queue implementation
	/// </summary>
	/// <typeparam name="T">A generic data type; defined when interface used</typeparam>
	public interface IContainer<T>
	{
		#region Clear
		/// <summary>
		/// Remove all objects from the container
		/// </summary>
		void Clear ( );
		#endregion

		#region ISEmpty
		/// <summary>
		/// Determines whether this container is empty
		/// </summary>
		/// <returns>
		///   <c>true</c> if this container is empty; otherwise, <c>false</c>.
		/// </returns>
		bool IsEmpty ( );
		#endregion

		#region Count
		/// <summary>
		/// Gets or sets the number of entries in the container
		/// </summary>
		/// <value>
		/// The number of entries in the container
		/// </value>
		int Count { get; set; }
		#endregion
	} // end IContainer
}
