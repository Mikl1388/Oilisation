using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool IsExplored;
    public float Amount;
    public float Debit;

    public Building Building;

    public void Explore() 
    { 
        IsExplored = true;
    }

}
