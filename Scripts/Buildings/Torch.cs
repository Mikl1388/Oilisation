using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : Building
{
    public override void ExecuteOperation()
    {
        float burnAmount = Liquid.Volume;
        Liquid = new Liquid(0, LiquidType.Liquid);
        onExecuteOperation?.Invoke($"‘акел сжЄг {burnAmount} газа");
    }
}
