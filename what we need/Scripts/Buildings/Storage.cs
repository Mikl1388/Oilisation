using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : Building
{
    public override void ExecuteOperation()
    {
        onExecuteOperation?.Invoke($"��������� ������ {Liquid.Volume} �� {MaxCapacity} ��������");
    }


}
