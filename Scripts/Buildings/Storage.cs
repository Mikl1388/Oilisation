using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : Building
{
    public override void ExecuteOperation()
    {
        if (output != null)
        {
            Liquid = output.Transfuse(Liquid);
        }
        onExecuteOperation?.Invoke($"Резервуар хранит {Liquid.Volume} из {MaxCapacity} жидкости ({Liquid.Type})");
    }


}
