using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Seller
{
    public static float OilExchangeRate;
    public static float GasExchangeRate;

    public static Action<float> onSell;

    public static void ChangeExchangeRate(float oilRate, float gasRate)
    {
        OilExchangeRate = oilRate;
        GasExchangeRate = gasRate;
    }

    public static void Sell(Liquid liquid)
    {
        if (liquid.Type == LiquidType.Oil)
        {
            onSell?.Invoke(liquid.Volume * OilExchangeRate);
        }
        else if (liquid.Type == LiquidType.Gas)
        {
            onSell?.Invoke(liquid.Volume * GasExchangeRate);
        }
        else
        {
            throw new ArgumentException($"Wrong liquid: {liquid.Type}");
        }
    }
}
