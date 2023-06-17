using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKPN : Building
{
    public override void ExecuteOperation()
    {
        Liquid = output.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"УКПН подготовила нефть");
    }
}
