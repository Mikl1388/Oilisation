using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    public Liquid Liquid { get; private set; }
    public uint MaxCapacity { get; private set; }
    public uint Cost { get; private set; }

    public abstract bool Transfuse(Liquid liquid);
}
