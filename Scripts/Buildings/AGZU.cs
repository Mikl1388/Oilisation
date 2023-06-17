using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AGZU : Building
{
    public override void ExecuteOperation()
    {
        Liquid = output.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"АГЗУ проанализировала нефть");
    }
}
