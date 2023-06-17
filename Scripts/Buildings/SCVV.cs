using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCVV : Building
{
    public override void ExecuteOperation()
    {
        Liquid = output.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"СЦВВ очистил газ");
    }

}
