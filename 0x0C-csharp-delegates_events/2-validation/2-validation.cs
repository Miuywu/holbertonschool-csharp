using System;

/// <summary>
/// modify hp.
/// </summary>
/// <param name="amt">delta hp.</param>
delegate void CalculateHealth(float amt);

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
	/// <param name="maxHp">player max hit points.</param>
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
		float newHp = this.hp;
		if (damage < 0f)
			damage = 0f;
		Console.WriteLine("{0} takes {1} damage!", this.name, damage);
		newHp -= damage;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Player gain hp.
	/// </summary>
	/// <param name="heal">delta hp.</param>
	public void HealDamage(float heal)
	{
		float newHp = this.hp;
		if (heal < 0f)
			heal = 0f;
		Console.WriteLine("{0} heals {1} HP!", this.name, heal);
		newHp += heal;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Changes player hp.
	/// </summary>
	/// <param name="newHp">Resulting player hp.</param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0f)
			this.hp = 0f;
		else if (newHp > this.maxHp)
			this.hp = this.maxHp;
		else
			this.hp = newHp;
	}
}
