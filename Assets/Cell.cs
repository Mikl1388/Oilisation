using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool IsExplored {  get; private set; }
    public uint Amount { get; private set; }
    public Building Building { get; private set; }

}
