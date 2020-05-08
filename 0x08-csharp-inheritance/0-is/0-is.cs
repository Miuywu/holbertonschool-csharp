using System;
using System.Collections.Generic;

/// <summary>Checks obj type.</summary>
class Obj
{
    /// <summary>Check if int.</summary>
    /// <param name="obj">obj.</param>
    /// <returns>True if the object is int.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
