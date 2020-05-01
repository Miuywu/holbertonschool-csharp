using System;

namespace Enemies
{
	///<summary>zombie class.</summary>
	public class Zombie
	{
		///<summary>public field.</summary>
		private int health;
		///<summary>public constructor.</summary>
		public Zombie()
		{
			health = 0;
		}
		///<summary>public constructor.</summary>
		public Zombie(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
			else
			{
				health = value;
			}
		}
		///<summary>public method.</summary>
		public int GetHealth()
		{
			return health;
		}
		///<summary>public field.</summary>
		private string name = "(No name)";
		///<summary>public property.</summary>
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
	}
}
