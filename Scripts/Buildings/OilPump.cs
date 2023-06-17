using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilPump : Building
{
    public float OilFlow;
    public float FlowReduction;
    public override void ExecuteOperation()
    {
        OilFlow = Cell.Debit;
        if (Liquid.Volume + OilFlow > MaxCapacity)
        {
            return;
        }
        Liquid += new Liquid(OilFlow, LiquidType.Liquid);
        Cell.Amount -= OilFlow;
        Cell.Debit *= (1 - FlowReduction);
        Liquid = output.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"Насос качает со скоростью {OilFlow}, хранит {Liquid.Volume}");
    }
}
