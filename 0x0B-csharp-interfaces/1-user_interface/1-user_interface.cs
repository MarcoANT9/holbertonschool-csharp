using System;

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
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    //=======================================================================
    //= Properties ==========================================================
    //=======================================================================

    // ~ Public ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ///<summary>Property durability.</summary>
    public int durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    ///<summary>Property for collecting.</summary>
    public bool isCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



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
        throw new NotImplementedException();
    }
    
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
    
    // ~ Private ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================

}

//###########################################################################
//######################### END OF FILE #####################################
//###########################################################################
