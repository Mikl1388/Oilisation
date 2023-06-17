using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : Building
{
    private Liquid oil;
    private Liquid gas;

    public override Liquid Transfuse(Liquid liquid)
    {
        if (liquid.Type == LiquidType.Gas) 
        {
            gas += liquid;
            return new Liquid(0, liquid.Type); 
        } else if (liquid.Type == LiquidType.Oil)
        {
            oil += liquid;
            return new Liquid(0, liquid.Type);
        } else
        {
            return liquid;
        }
    }

    public override void ExecuteOperation()
    {
        Seller.Sell(oil);
        Seller.Sell(gas);
        onExecuteOperation?.Invoke($"Офис продал {oil.Volume} нефти и {gas.Volume} газа");
        oil = new Liquid(0,LiquidType.Oil);
        gas = new Liquid(0,LiquidType.Gas);
    }

    private void Start()
    {
        oil = new Liquid(0, LiquidType.Oil);
        gas = new Liquid(0, LiquidType.Gas);
    }
}
