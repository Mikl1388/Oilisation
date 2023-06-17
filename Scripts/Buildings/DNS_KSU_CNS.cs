using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNS_KSU_CNS : Building
{
    [SerializeField]
    protected Building secondOutput;
    [SerializeField]
    private float waterRatio;

    public override void ExecuteOperation()
    {
        Liquid oil = Liquid * (1 - waterRatio);
        oil.Type = LiquidType.Oil;
        Liquid water = Liquid * waterRatio;
        water.Type = LiquidType.Liquid;
        Liquid = output.Transfuse(oil);
        Liquid = secondOutput.Transfuse(water);
        onExecuteOperation?.Invoke($"ДНС отделила воду({water.Volume}) от нефти({oil.Volume})");
    }
}
