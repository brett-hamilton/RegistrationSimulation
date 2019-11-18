///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 4 - Convention Registration Simulation
//	File Name:         PriorityQueue.cs
//	Description:       Represents the Priority Queue (PQ) data structure; implements appropriate interfaces giving
//						proper functionality to the PQ allowing it to be used for data types in this project
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
	/// The implementation of the Priority Queue data structure; defines how the Priority Queue
	///		functions and includes the Node class
	/// </summary>
	/// <typeparam name="T">A generic data type; defined when PriorityQueue is used</typeparam>
	/// <seealso cref="global::RegistrationSimulation.IPriorityQueue{T}" />
	public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable
	{
		#region Properties and Fields
		private Node first;          // Reference to the first item of PQ

		/// <summary>
		/// Gets or sets the number of entries in the Priority Queue
		/// </summary>
		/// <value>The number of entries in the PQ</value>
		public int Count { get; set; }
		#endregion

		#region Enqueue and Dequeue
		/// <summary>
		/// Inserts item into the Priority Queue based on its priority level
		/// </summary>
		/// <param name="item">Item to be inserted</param>
		public void Enqueue (T item)
		{
			if (Count == 0)						// If this is first item added to PQ
				first = new Node (item, null);
			else
			{
				Node current	= first;
				Node previous	= null;

				// Step through Nodes until lower priority item is found
				while (current != null && current.Item.CompareTo (item) >= 0)
				{
					previous	= current;
					current		= current.Next;
				}

				// Once place to insert new Node is found, create the Node
				Node newNode = new Node (item, current);

				// Insert the new Node
				if (previous != null)
					previous.Next = newNode;
				else
					first = newNode;
			}
			Count++;			// Add 1 to the count because a new Node was added
		} // end Enqueue

		/// <summary>
		/// Removes the first item in the Priority Queue
		/// </summary>
		/// <exception cref="InvalidOperationException">Cannot remove from empty queue.</exception>
		public void Dequeue ( )
		{
			if (IsEmpty ( ))
				throw new InvalidOperationException ("Cannot remove from empty queue.");
			else
			{
				Node oldNode	= first;
				first			= first.Next;
				Count--;
				oldNode			= null;
			}
		} // end Dequeue
		#endregion

		#region Clear
		public void Clear ( )
		{
			first = null;		// Nodes will be garbage collected
			Count = 0;			// Count reset since PQ is empty
		} // end Clear
		#endregion

		#region Peek		
		/// <summary>
		/// Gets the first item in the Priority Queue without removing it
		/// </summary>
		/// <returns>The first item in the Priority Queue</returns>
		/// <exception cref="InvalidOperationException">Cannot obtain first of empty priority queue.</exception>
		public T Peek ( )
		{
			if (!IsEmpty ( ))
				return first.Item;
			else
				throw new InvalidOperationException ("Cannot obtain first of empty priority queue.");
		} // end Peek
		#endregion

		#region IsEmpty		
		/// <summary>
		/// Determines whether this Priority Queue is empty
		/// </summary>
		/// <returns>
		/// <c>true</c> if this container is empty; otherwise, <c>false</c>.
		/// </returns>
		public bool IsEmpty ( )
		{
			return Count == 0;
		} // end IsEmpty
		#endregion

		#region Priority Queue Node Class
		/// <summary>
		/// Represents the Node part of the Priority Queue implementation; responsible for holding
		///		the value of the item and a reference to the next item in the Priority Queue
		/// </summary>
		private class Node
		{
			#region Properties			
			/// <summary>
			/// Gets or sets the item of the Node
			/// </summary>
			/// <value>The item of type T</value>
			public T Item { get; set; }

			/// <summary>
			/// Gets or sets the next Node
			/// </summary>
			/// <value>Reference to the next Node in the Priority Queue</value>
			public Node Next { get; set; }
			#endregion

			#region Constructor			
			/// <summary>
			/// Initializes a new Node instance with a reference to the next Node in the 
			///		Priority Queue
			/// </summary>
			/// <param name="value">The value of the Node item</param>
			/// <param name="link">The reference to the next Node</param>
			public Node (T value, Node link)
			{
				Item = value;
				Next = link;
			} // end Node
			#endregion
		} // end Node
		#endregion
	} // end PriorityQueue
}
