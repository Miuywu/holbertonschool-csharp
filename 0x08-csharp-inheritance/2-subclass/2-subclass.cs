using System;

/// <summary>check object type.</summary>
class Obj
{
    /// <summary>Checks if is subclass of another type.</summary>
    /// <param name="derivedType">d type.</param>
    /// <param name="baseType">b type.</param>
    /// <returns>True if the derived type is a subclass.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
