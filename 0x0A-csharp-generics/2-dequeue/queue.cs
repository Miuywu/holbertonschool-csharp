using System;

///<summary>Class for que</summary>
class Queue<T>
{
	//Setting node
	public class Node
	{
		public T value = default(T);
		public Node next = null;

		public Node(T input)
		{
			value = input;
		}
	}

	public Node head;
	public Node tail;
	public int count;

	///<summary>Add new node end</summary>
	public void Enqueue(T value)
	{
		Node node = new Node(value);
		if (head == null)
		{
			head = node;
			tail = node;
		}
		else
		{
			tail.next = node;
			tail = node;
		}
		count++;
	}

	///<summary>del last node</summary>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			T value = head.value;
			head = head.next;
			count--;
			return value;
		}
	}

	///<summary>Add new node end</summary>
	public int Count()
	{
		return count;
	}

	///<summary>Check que</summary>
	///<return>returns que</return>
	public Type CheckType()
	{
		return typeof(T);
	}
}
