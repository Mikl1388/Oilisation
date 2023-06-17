using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DKS : Building
{
    public override void ExecuteOperation()
    {
        Liquid = output.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"ДКС обработала газ");
    }
}
