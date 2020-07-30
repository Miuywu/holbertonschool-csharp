using System;

/// <summary>
/// Att multiplier.
/// </summary>
public enum Modifier
{
	/// <summary> Half strong attack. </summary>
	Weak,
	/// <summary> Normal attack. </summary>
	Base,
	/// <summary> 1.5 times stronger attack. </summary>
	Strong
}

/// <summary>
/// multiplier value.
/// </summary>
/// <param name="baseValue">Normal attack.</param>
/// <param name="modifier">Modifier to apply to baseValue.</param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// modify hp.
/// </summary>
/// <param name="amt">The amount of health to be changed.</param>
public delegate void CalculateHealth(float amt);



/// <summary>
/// Player class.
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;
	private string status;
	EventHandler<CurrentHPArgs> HPCheck;

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="name">The name of the player.</param>
	/// <param name="maxHp">The player's maximum hit points.</param>
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
		this.status = $"{this.name} is ready to go!";
		HPCheck += CheckStatus;
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
		HPCheck(this, new CurrentHPArgs(this.hp));
	}

	/// <summary>
	/// total att.
	/// </summary>
	/// <param name="baseValue">base att.</param>
	/// <param name="modifier">multiplier.</param>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak)
			return baseValue * 0.5f;
		else if (modifier == Modifier.Base)
			return baseValue;
		else
			return baseValue * 1.5f;
	}

	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == this.maxHp)
			this.status = $"{this.name} is in perfect health!";
		else if (e.currentHp >= (this.maxHp * 0.5f) && e.currentHp < this.maxHp)
			this.status = $"{this.name} is doing well!";
		else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp * 0.5f))
			this.status = $"{this.name} isn't doing too great...";
		else if (e.currentHp > 0f && e.currentHp < (this.maxHp * 0.5f))
			this.status = $"{this.name} needs help!";
		else
			this.status = $"{this.name} is knocked out!";
		Console.WriteLine(this.status);
	}
}

class CurrentHPArgs : EventArgs
{
	public readonly float currentHp;

	public CurrentHPArgs(float newHp)
	{
		this.currentHp = newHp;
	}
}