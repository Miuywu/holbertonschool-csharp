﻿using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Base class</summary>
abstract class Base
{
	public string name = "";

	public override string ToString()
	{
		return String.Format("{0} is a {1}", name, this.GetType().Name);
	}
}

interface IInteractive
{
	void Interact();
}

interface IBreakable
{
	int durability { get; set; }
	void Break();
}

interface ICollectable
{
	bool isCollected { get; set; }
	void Collect();
}

class Door : Base, IInteractive
{
	public Door(string na = "Door")
	{
		this.name = na;
	}
	public void Interact()
	{
		Console.WriteLine("You try to open the {0}. It's locked.", this.name);
	}
}

class Decoration : Base, IInteractive, IBreakable
{
	public bool isQuestItem;
	public int durability { get; set; }

	public Decoration(string na = "Decoration", int dura = 1, bool iQ = false)
	{
		if (dura < 0)
		{
			throw new Exception("Durability must be greater than 0");
		}
		this.name = na;
		this.durability = dura;
		this.isQuestItem = iQ;
	}
	public void Interact()
	{
		if (this.durability <= 0)
		{
			Console.WriteLine("The {0} has been broken.", this.name);
		}
		else if (iQ)
		{
			Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
		}
		else
		{
			Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
		}
	}
	public void Break()
	{
		this.durability--;
		if (this.durability > 0)
		{
			Console.WriteLine("You hit the {0}. It cracks.", this.name);
		}
		else if (this.durability == 0)
		{
			Console.WriteLine("You smash the {0}. What a mess.", this.name);
		}
		else
		{
			Console.WriteLine("The {0} is already broken.", this.name);
		}
	}
}