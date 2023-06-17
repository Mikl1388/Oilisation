using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    public Liquid Liquid;
    public Cell Cell;
    public float MaxCapacity;
    public float Cost;

    [SerializeField]
    protected Building input;
    [SerializeField]
    protected Building output;

    public static Action<string> onExecuteOperation;

    public abstract void ExecuteOperation();

    public void Build(Cell cell, Building prev, Building next) 
    {
        Cell = cell;
        input = prev;
        output = next;
        Cell.Building = this;
    }

    public virtual Liquid Transfuse(Liquid liquid)
    {
        Liquid += liquid;
        if (Liquid.Volume > MaxCapacity)
        {
            liquid.Volume = Liquid.Volume - MaxCapacity;
            Liquid.Volume = MaxCapacity;
            return new Liquid(liquid.Volume, liquid.Type);
        }
        return new Liquid(0, LiquidType.Liquid);
    }

    private void Start()
    {
        Liquid = new Liquid(0, LiquidType.Liquid);
        //gameObject.transform.position = Cell.transform.position;
    }
}
