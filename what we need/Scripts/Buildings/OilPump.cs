using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilPump : Building
{
    public float OilFlow;
    public float FlowReduction;

    public override void ExecuteOperation()
    {
        if (Liquid.Volume + OilFlow > MaxCapacity)
        {
            return;
        }
        Liquid += new Liquid(OilFlow);
        OilFlow *= 1 - FlowReduction;
        Liquid = nextBuilding.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"Насос качает со скоростью {OilFlow}, хранит {Liquid.Volume}");
    }
}
