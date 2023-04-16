using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : Building
{
    private Pipe nextPipe;

    public bool Transfuse(Liquid liquid)
    {
        return nextPipe.Transfuse(liquid);
    }
}
