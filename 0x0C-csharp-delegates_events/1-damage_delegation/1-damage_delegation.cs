﻿using System;


///<summary>This is the Base Character class.</summary>
public class Player
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>Name Property.</summary>
    string name;
    /// <summary>Maximum Health Points Property.</summary>
    float maxHp;
    /// <summary>Current Health Points Property.</summary>
    float hp;

    // ~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>Player class constructor.</summary>
    public Player(string name = "Player", float maxHp = 100.0f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100.0f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    // ~ Delegates ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This is the delegate to calculate health.</summary>
    public delegate float CalculateHealth(float hp);

    // ~ Public Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>Method to print current and max health values.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    ///<summary>This is the method to display damage taken.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{this.name} takes {damage} damage!");
    }

    ///<summary>This is the method to display damage healed.</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{this.name} heals {heal} HP!");
    }

    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

//###########################################################################
//######################### END OF FILE #####################################
//###########################################################################