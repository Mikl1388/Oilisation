using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : Liquid
{
    public Gas(float volume) : base(volume) { }

    public static Gas operator +(Gas lhs, Gas rhs)
    {
        return new Gas(lhs.Volume + rhs.Volume);
    }
}
