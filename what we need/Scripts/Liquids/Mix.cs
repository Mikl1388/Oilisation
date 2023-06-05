using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mix : Liquid
{
    public Mix(Water water, Oil oil, Gas gas) : base(water.Volume + oil.Volume + gas.Volume)
    {
        Water = water;
        Oil = oil;
        Gas = gas;
    }

    public Water Water { get; private set; }
    public Oil Oil { get; private set; }
    public Gas Gas { get; private set; }
    //public override float Volume { get { return Water.Volume + Oil.Volume + Gas.Volume; } }

    public static Mix operator +(Mix lhs, Mix rhs)
    {
        return new Mix(lhs.Water + rhs.Water, lhs.Oil + rhs.Oil, lhs.Gas + rhs.Gas);
    }
}
