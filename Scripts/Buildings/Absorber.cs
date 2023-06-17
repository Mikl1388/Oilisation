using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absorber : Building
{
    public override void ExecuteOperation()
    {
        Liquid = output.Transfuse(Liquid);
        onExecuteOperation?.Invoke($"Абсорбер осушил газ");
    }
}
