using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> liz = list2.FindAll(elem => !list1.Contains(elem));
		List<int> lizz = list1.FindAll(elem => !list2.Contains(elem));
        lizz.AddRange(liz);
		lizz.Sort();
		return lizz;
    }
}
