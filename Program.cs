using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank_Day_24_More_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
			Node head = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				head = insert(head, data);
			}
			head = removeDuplicates(head);
			display(head);
			Console.ReadKey();
		}

		public static Node removeDuplicates(Node head)
		{
			//Write your code here
			Node curNode = head;

			while(curNode != null && curNode.next != null)
            {
				while (curNode.next != null && curNode.data == curNode.next.data)
				{
					curNode.next = curNode.next.next;			
				}
				curNode = curNode.next;
			}
			return head;			
		}

		public static Node insert(Node head, int data)
		{
			Node p = new Node(data);


			if (head == null)
				head = p;
			else if (head.next == null)
				head.next = p;
			else
			{
				Node start = head;
				while (start.next != null)
					start = start.next;
				start.next = p;

			}
			return head;
		}

		public static void display(Node head)
		{
			Node start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
			}
		}
	}
	class Node
	{
		public int data;
		public Node next;
		public Node(int d)
		{
			data = d;
			next = null;
		}

	}
		
}
