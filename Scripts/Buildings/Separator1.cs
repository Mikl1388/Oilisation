using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Separator1 : Building
{
    [SerializeField]
    protected Building secondOutput;
    [SerializeField]
    private float gasRatio;

    public override void ExecuteOperation()
    {
        Liquid oil = Liquid * (1 - gasRatio);
        oil.Type = LiquidType.Liquid;
        Liquid gas = Liquid * gasRatio;
        gas.Type = LiquidType.Gas;
        Liquid = output.Transfuse(oil);
        Liquid = secondOutput.Transfuse(gas);
        onExecuteOperation?.Invoke($"Сепаратор разделил жидкость на газ ({gas.Volume}) и нефть ({oil.Volume})");
    }
}
