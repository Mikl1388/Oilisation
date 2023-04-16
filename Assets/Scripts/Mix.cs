using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mix : MonoBehaviour
{
    public Water Water { get; private set; }
    public Oil Oil { get; private set; }
    public Gas Gas { get; private set; }
    public uint Amount { get { return Water.Amount + Oil.Amount + Gas.Amount; } }
}
