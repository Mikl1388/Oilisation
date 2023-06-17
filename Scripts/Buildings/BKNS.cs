using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKNS : Building
{
    public override void ExecuteOperation()
    {
        float waterAmount = Liquid.Volume;
        Liquid = new Liquid(0, LiquidType.Liquid);
        onExecuteOperation?.Invoke($"БКНС закачала {waterAmount} воды");
    }
}
