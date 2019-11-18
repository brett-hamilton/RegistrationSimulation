///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         IPriorityQueue.cs
//	Description:       Defines the interface that allows the Priority Queue to add, remove, and "peek"
//						items in the data structure
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
	/// Represents interface for adding items, removing items, and "peeking" at items in a
	///		Priority Queue data structure
	/// </summary>
	/// <typeparam name="T">A generic data type; defined when interface used</typeparam>
	/// <seealso cref="global::RegistrationSimulation.IContainer{T}" />
	public interface IPriorityQueue<T> : IContainer<T> where T : IComparable
	{
		#region Enqueue
		/// <summary>
		/// Inserts item based on its priority
		/// </summary>
		/// <param name="item">Item in queue to be inserted</param>
		void Enqueue (T item);
		#endregion

		#region Dequeue
		/// <summary>
		/// Removes the first item in the queue
		/// </summary>
		void Dequeue ( );
		#endregion

		#region Peek
		/// <summary>
		/// Gets the first item in the queue without removing it
		/// </summary>
		/// <returns>The first item in the queue</returns>
		T Peek ( );
		#endregion
	} // end IPriorityQueue
}
