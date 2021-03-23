﻿using System;

//###########################################################################
//# CLASSES #################################################################
//###########################################################################
///<summary>This is the Base class.</summary>
public abstract class Base
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>Name Property.</summary>
    public string name { get; set; }

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= Methods =============================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>ToString Method Override.</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }


    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

//###########################################################################
//# INTERFACES ##############################################################
//###########################################################################

///<summary>This interface determines if an object is interactable.</summary>
public interface IInteractive
{
    /// <summary>Method Interact.</summary>
    void Interact();
}

///<summary>This interface determines if an object is breakable.</summary>
public interface IBreakable
{
    ///<summary>Property durability.</summary>
    int durability { get; set; }
    ///<summary>Method Break.</summary>
    void Break();
}

///<summary>This interface determines if an object is collectable.</summary>
public interface ICollectable
{
    /// <summary>Property isCollected.</summary>
    bool isCollected { get; set; }
    /// <summary>Method Collect.</summary>
    void Collect();
}


///<summary>This class correponds to a test object.</summary>
public class Door : Base, IInteractive
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This assigns the name to the door.</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= Methods =============================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This method allows interaction with objects.</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }


    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================

}

///<summary>This class correponds to a test object.</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This property determines if an item is a Quest Item.</summary>
    public bool isQuestItem;

    ///<summary>This property determines if an item is a Quest Item.</summary>
    public int durability { get; set; }

    ///<summary>Class Constructor.</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }


    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= Methods =============================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This method allows interaction with objects.</summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {this.name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        else if (isQuestItem == false)
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
    }

    ///<summary>This method allows breaking of an object.</summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        if (durability == 0)
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        if (durability < 0)
            Console.WriteLine($"The {this.name} is already broken.");
    }


    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================

}
//###########################################################################
//######################### END OF FILE #####################################
//###########################################################################
