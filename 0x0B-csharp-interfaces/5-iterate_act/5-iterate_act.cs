﻿using System;
using System.Collections.Generic;

//###########################################################################
//# BASE CLASS ##############################################################
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

    // ~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

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

//###########################################################################
//# CLASSES #################################################################
//###########################################################################

///<summary>This class correponds to a Door object.</summary>
public class Door : Base, IInteractive
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // ~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This assigns the name to the door.</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

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

///<summary>This class correponds to a Decoration Object.</summary>
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

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // ~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>Class Constructor.</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

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
        else if (durability == 0)
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        else
            Console.WriteLine($"The {this.name} is already broken.");
    }

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

///<summary>This class correponds to a Door object.</summary>
public class Key : Base, ICollectable
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>Property that determines if the item has been collected.</summary>
    public bool isCollected { get; set; }
    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // ~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>Class Constructor.</summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= Methods =============================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This method allows collection of key items.</summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else
            Console.WriteLine($"You have already picked up the {this.name}.");
    }

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

///<summary>This class correponds to a Door object.</summary>
public class RoomObjects
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // ~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= Methods =============================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>This method allows iteraction with the methods within the objects.</summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var element in roomObjects)
        {
            if (type.ToString() == "IInteractive")
            {
                if (element is IInteractive)
                {
                    IInteractive tmp = element as IInteractive;
                    tmp.Interact();
                }
            }
            else if (type.ToString() == "IBreakable")
            {
                if (element is IBreakable)
                {
                    IBreakable tmp = element as IBreakable;
                    tmp.Break();
                }
            }
            else if (type.ToString() == "ICollectable")
            {
                if (element is ICollectable)
                {
                    ICollectable tmp = element as ICollectable;
                    tmp.Collect();
                }
            }
        }
    }

    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

//###########################################################################
//######################### END OF FILE #####################################
//###########################################################################
