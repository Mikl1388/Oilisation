using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Liquid
{
    public Water(float volume) : base(volume) { }

    public static Water operator +(Water lhs, Water rhs)
    {
        return new Water(lhs.Volume + rhs.Volume);
    }
}
