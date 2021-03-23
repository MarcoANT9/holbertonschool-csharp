using System;

//###########################################################################
//# INTERFACES ##############################################################
//###########################################################################
///<summary>This interface determines if an object is breakable.</summary>
public interface IBreakable
{
    ///<summary>This property determines the durability of an object.</summary>
    int durability { get; set;}
    ///<summary>Method to break something.</summary>
    void Break();
}

///<summary>This interface determines if an object is collectable.</summary>
public interface ICollectable
{
    ///<summary>This property determines if an object has been colected.</summary>
    bool isCollected { get; set;}
    ///<summary>Method to collect items.</summary>
    void Collect();
}

///<summary>This interface determines if an object is interactable.</summary>
public interface IInteractive
{
    ///<summary>This method allows interaction with objects.</summary>
    void Interact();
}

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
    ///<summary>This property represents the name.</summary>
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
    ///<summary>This method overrides the ToString default method.</summary>
    public override string ToString() => $"{name} is a {this.GetType()}";


    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

///<summary>This class correponds to a test object.</summary>
public class TestObject : Base, IBreakable, ICollectable, IInteractive
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>Property for collecting.</summary>
    public bool isCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    ///<summary>Property durability.</summary>
    public int durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


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
    ///<summary>Method to break something.</summary>
    public void Break()
    {
        throw new NotImplementedException();
    }
    ///<summary>Method to collect items.</summary>
    public void Collect()
    {
        throw new NotImplementedException();
    }
    ///<summary>This method allows interaction with objects.</summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }



    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================

}

//###########################################################################
//######################### END OF FILE #####################################
//###########################################################################
