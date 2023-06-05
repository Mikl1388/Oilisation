using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : Liquid
{
    public Oil(float volume) : base(volume) { }

    public static Oil operator +(Oil lhs, Oil rhs)
    {
        return new Oil(lhs.Volume + rhs.Volume);
    }
}
