using System;

/// <summary>
/// Player class.
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="name">Player name.</param>
	/// <param name="maxHp">Player max hit points.</param>
	public Player(string name = "Player", float maxHp = 100f)
	{
		if (maxHp <= 0f)
		{
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		else
			this.maxHp = maxHp;
		this.name = name;
		this.hp = this.maxHp;
	}
	/// <summary>
	/// Delegate modify HP.
	/// </summary>
	/// <param name="amt">Delta HP.</param>
	delegate void CalculateHealth(float amt);
	/// <summary>
	/// Prints hp.
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
	}

	/// <summary>
	/// Player lose hp.
	/// </summary>
	/// <param name="damage">delta hp.</param>
	public void TakeDamage(float damage)
	{
		Console.WriteLine("{0} takes {1} damage!", this.name, damage);
		if (damage < 0f)
			damage = 0f;
		this.hp -= damage;
	}

	/// <summary>
	/// Player gain hp.
	/// </summary>
	/// <param name="heal">delta hp.</param>
	public void HealDamage(float heal)
	{
		Console.WriteLine("{0} heals {1} HP!", this.name, heal);
		if (heal < 0f)
			heal = 0f;
		this.hp += heal;
	}

}
