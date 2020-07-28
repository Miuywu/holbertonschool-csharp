using System;

///<summary>Class for que</summary>
class Queue<T>
{
	//Setting node
	public class Node
	{
		private T value = default(T);
		public Node next = null;

		public Node(T input)
		{
			value = input;
		}
	}

	public Node head;
	public Node tail;
	public int c;
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
		c++;
	}

	///<summary>Add new node</summary>
	public int Count()
	{
		return c;
	}

	///<summary>Check que</summary>
	///<return>returns a que</return>
	public Type CheckType()
	{
		return typeof(T);
	}
}
