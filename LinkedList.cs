using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	// A simple C# program for traversal of a linked list 
	using System;

	public class LinkedList
	{
		Node head; // head of list 

		/* Linked list Node. This inner 
		class is made static so that 
		main() can access it */
		public class Node
		{
			public int data;
			public Node next;
			public Node(int d)
			{
				data = d;
				next = null;

			} // Constructor 
		}

		/* Inserts a new Node at front of the list. */
		public void push(int new_data) 
		{
			/* 1 & 2: Allocate the Node & 
								 Put in the data*/
			Node new_node = new Node(new_data);

			/* 3. Make next of new Node as head */
			new_node.next = head;

			/* 4. Move the head to point to new Node */
			head = new_node;
		}

		/* Inserts a new node after the given prev_node. */
		public void insertAfter(Node prev_node,
								int new_data)
		{
			/* 1. Check if the given Node is null */
			if (prev_node == null)
			{
				Console.WriteLine("The given previous node" +
										" cannot be null");
				return;
			}

			/* 2 & 3: Allocate the Node & 
					Put in the data*/
			Node new_node = new Node(new_data);

			/* 4. Make next of new Node as 
						next of prev_node */
			new_node.next = prev_node.next;

			/* 5. make next of prev_node 
							as new_node */
			prev_node.next = new_node;
		}

		/* Appends a new node at the end. This method is 
defined inside LinkedList class shown above */
		public void append(int new_data)
		{
			/* 1. Allocate the Node & 
			2. Put in the data 
			3. Set next as null */
			Node new_node = new Node(new_data);

			/* 4. If the Linked List is empty, 
			then make the new node as head */
			if (head == null)
			{
				head = new Node(new_data);
				return;
			}

			/* 4. This new node is going to be 
			the last node, so make next of it as null */
			new_node.next = null;

			/* 5. Else traverse till the last node */
			Node last = head;
			while (last.next != null)
				last = last.next;

			/* 6. Change the next of last node */
			last.next = new_node;
			return;
		}



		/* This function prints contents of 
		linked list starting from head */
		public void printList()
		{
			Node n = head;
			while (n != null)
			{
				Console.Write(n.data + " ");
				n = n.next;
			}
		}

		/* method to create a simple linked list with 3 nodes*/
		//public static void Main(String[] args)
		//{
		//	/* Start with the empty list. */
		//	LinkedList llist = new LinkedList();

		//	llist.head = new Node(1);
		//	Node second = new Node(2);
		//	Node third = new Node(3);

		//	llist.head.next = second; // Link first node with the second node 
		//	second.next = third; // Link second node with the third node 

		//	llist.printList();

		//	Console.WriteLine("C# LINKED LIST IMPLEMENTATION!!!");
		//	LinkedList<string> l = new LinkedList<string>();

		//	l.AddLast("one");
		//	l.AddLast("two");
		//	l.AddLast("three");

		//	foreach (var ele in l)
		//	{
		//		Console.WriteLine(ele);
		//	}
			
		//	l.AddAfter(l.Find("one"), "four");

			

		//	foreach (var ele in l)
		//	{
		//		Console.WriteLine(ele);
		//	}

		//}
	}

	/* This code contributed by PrinciRaj1992 */

}
