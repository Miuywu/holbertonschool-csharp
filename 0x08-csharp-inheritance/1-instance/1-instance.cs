using System;
using System.Collections.Generic;

/// <summary> check obj type</summary>
class Obj
{
    /// <summary>Check if instance of an Array.</summary>
    /// <param name="obj">obj</param>
    /// <returns>True if is instance.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
