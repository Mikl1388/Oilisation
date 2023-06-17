using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : Building
{
    public override void ExecuteOperation()
    {
        Liquid = output.Transfuse(Liquid);
        //onExecuteOperation?.Invoke($"Труба хранит {Liquid.Volume}");
    }
}
