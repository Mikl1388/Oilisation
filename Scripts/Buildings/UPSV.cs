using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPSV : Building
{
    [SerializeField]
    protected Building secondOutput;
    [SerializeField]
    private float gasRatio;

    public override void ExecuteOperation()
    {
        Liquid water = Liquid * (1 - gasRatio);
        water.Type = LiquidType.Liquid;
        Liquid gas = Liquid * gasRatio;
        gas.Type = LiquidType.Gas;
        Liquid = output.Transfuse(water);
        Liquid = secondOutput.Transfuse(gas);
        onExecuteOperation?.Invoke($"УПСВ подготовила воду ({water.Volume}), убрав ({gas.Volume}) газа");
    }
}
