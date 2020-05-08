using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>type methods.</summary>
class Obj
{
    /// <summary>displays properties and methods.</summary>
    /// <param name="myObj">The obj.</param>
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();
        PropertyInfo[] p = t.GetProperties();
        MethodInfo[] m = t.GetMethods();

        Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo property in p)
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo method in m)
        {
            Console.WriteLine(method.Name);
        }

    }
}