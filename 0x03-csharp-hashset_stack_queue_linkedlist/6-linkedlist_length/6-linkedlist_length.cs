﻿using System;
using System.Collections.Generic;
class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int a = 0;
        foreach (var item in myLList)
        {
            a++;
        }
        return a;
    }
}
