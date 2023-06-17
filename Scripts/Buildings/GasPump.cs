using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPump : Building
{
    public override void ExecuteOperation()
    {
        Liquid = output.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"Газоперекачивающий аппарат передал газ");
    }
}
