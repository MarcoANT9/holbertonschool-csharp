using System;


/// <summary>
/// This Delegate modifies the maxHp of Characters.
/// </summary>
/// <param name="baseValue">Base damage/heal value.</param>
/// <param name="modifier">Damage/heal modifier.</param>
/// <returns>Damage to apply to character.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Enum for the modifiers.
/// </summary>
public enum Modifier
{
    ///<summary>Enum for Weak (0.5 BaseHP).</summary>
    Weak,
    ///<summary>Enum for Base (1.0 BaseHP).</summary>
    Base,
    ///<summary>Enum for Strong (1.5 BaseHP).</summary>
    Strong
}

/// <summary>
/// This is the Base Character class.
/// </summary>
public class Player
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    /// <summary>Name Property.</summary>
    string name;
    /// <summary>Maximum Health Points Property.</summary>
    float maxHp;
    /// <summary>Current Health Points Property.</summary>
    float hp;
    /// <summary>Current Health Points Property.</summary>
    private string status;

    /// <summary>Event Handler.</summary>
    EventHandler<CurrentHPArgs> HPCheck;

    // ~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>
    /// Player class constructor.
    /// </summary>
    /// <param name="name">Plauer/Character Name.</param>
    /// <param name="maxHp">Maximum Health Points value.</param>
    public Player(string name = "Player", float maxHp = 100.0f)
    {
        status = $"{name} is ready to go!";
        if (maxHp <= 0)
        {
            maxHp = 100.0f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
        HPCheck += CheckStatus;
    }

    //=======================================================================
    //= Methods =============================================================
    //=======================================================================

    // ~ Delegates ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This is the delegate to calculate health.</summary>
    public delegate float CalculateHealth(float hp);

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>
    /// This is the method to display damage healed.
    /// </summary>
    /// <param name="baseValue">Base value to apply mod.</param>
    /// <param name="modifier">Modification factor.</param>
    /// <returns>New Damage/Heal points taken/healed.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue / 2.0f);
        if (modifier == Modifier.Strong)
            return (baseValue * 1.5f);
        return (baseValue);
    }

    /// <summary>
    /// This is the method to display damage healed.
    /// </summary>
    /// <param name="heal">Heal points restored.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// Method to print current and max health values.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// This is the method to display damage taken.
    /// </summary>
    /// <param name="damage">Damage taken.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        ValidateHP(this.hp - damage);
    }

    /// <summary>
    /// This is the method to display damage healed.
    /// </summary>
    /// <param name="newHp">New HP to assign to the Character.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;

        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>
    /// This method checks the status of the player.
    /// </summary>
    /// <param name="sender">Caller of the method.</param>
    /// <param name="e">Current HP Arguments</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == this.maxHp)
        {
            status = $"{this.name} is in perfect health!";
            Console.WriteLine(status);
        }
        if (e.currentHP >= this.maxHp / 2 && e.currentHP < this.maxHp)
        {
            status = $"{this.name} is doing well!";
            Console.WriteLine(status);
        }
        if (e.currentHP >= this.maxHp / 4 && e.currentHP < this.maxHp / 2)
        {
            status = $"{this.name} isn't doing too great...";
            Console.WriteLine(status);
        }
        if (e.currentHP > 0 && e.currentHP < this.maxHp / 4)
        {
            status = $"{this.name} needs help!";
            Console.WriteLine(status);
        }
        if (e.currentHP == 0)
        {
            status = $"{this.name} is knocked out!";
            Console.WriteLine(status);
        }
    }

    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

///<summary>This is the Current HP Arguments class.</summary>
public class CurrentHPArgs : EventArgs
{

    /// <summary>This is the current HP not to be modified.</summary>
    public float currentHP;

    // ~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>
    /// This is the constructor of the class.
    /// </summary>
    /// <param name="newHp">New HP.</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHP = newHp;
    }

    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

//###########################################################################
//######################### END OF FILE #####################################
//###########################################################################