using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liquid
{
    public float Volume;

    public Liquid(float volume)
    {
        Volume = volume;
    }

    public static Liquid operator +(Liquid lhs, Liquid rhs)
    {
        return new Liquid(lhs.Volume + rhs.Volume);
    }
}
