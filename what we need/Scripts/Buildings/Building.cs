using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    public Liquid Liquid { get; protected set; }
    public float MaxCapacity;
    public float Cost;

    [SerializeField]
    protected Building previousBuilding;
    [SerializeField]
    protected Building nextBuilding;

    public static Action<string> onExecuteOperation;

    public abstract void ExecuteOperation();

    public Liquid Transfuse(Liquid liquid)
    {
        Liquid += liquid;
        if (Liquid.Volume > MaxCapacity)
        {
            liquid.Volume = Liquid.Volume - MaxCapacity;
            Liquid.Volume = MaxCapacity;
            return new Liquid(liquid.Volume);
        }
        return new Liquid(0);
    }

    private void Awake()
    {
        Liquid = new Liquid(0);
    }
}
