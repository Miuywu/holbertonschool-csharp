using System;

class Character
{
    public static bool IsLower(char a)
    {
        if (a >= 'a' && a <= 'z')
            return true;
        return false;
    }
}