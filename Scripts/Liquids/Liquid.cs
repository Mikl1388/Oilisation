using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liquid
{
    public float Volume;
    public LiquidType Type;

    public Liquid(float volume, LiquidType type)
    {
        Volume = volume;
        Type = type;
    }

    public static Liquid operator +(Liquid lhs, Liquid rhs)
    {
        LiquidType type;
        if (LiquidType.Liquid == lhs.Type && LiquidType.Liquid == rhs.Type)
        {
            type = LiquidType.Liquid;
        } else if (lhs.Type != LiquidType.Liquid)
        {
            type = lhs.Type;
        } else
        {
            type = rhs.Type;
        }
        return new Liquid(lhs.Volume + rhs.Volume, type);
    }

    public static Liquid operator *(Liquid lhs, float rhs)
    {
        return new Liquid(lhs.Volume * rhs, lhs.Type);
    }
}

public enum LiquidType
{
    Liquid,
    Oil,
    Gas,
    Water
}