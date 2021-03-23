﻿using System;

abstract class Base
{
    //=======================================================================
    //= Variables ===========================================================
    //=======================================================================

    // - Public -------------------------------------------------------------
    ///<summary>This property represents the name.</summary>
    public string name = null;

    // - Private ------------------------------------------------------------


    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // - Public -------------------------------------------------------------


    // - Private ------------------------------------------------------------


    //=======================================================================
    //= Methods =============================================================
    //=======================================================================

    // - Public -------------------------------------------------------------
    ///<summary>This method overrides the ToString default method.</summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
    

    // - Private ------------------------------------------------------------


    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}
