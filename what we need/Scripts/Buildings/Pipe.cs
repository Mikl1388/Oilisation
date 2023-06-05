using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : Building
{
    public override void ExecuteOperation()
    {
        Liquid = nextBuilding.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"Труба хранит {Liquid.Volume}");
    }
}
