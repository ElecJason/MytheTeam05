using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    [SerializeField] public bool gateKey = false;

    public void PickupKey()
    {
        gateKey = true;
    }
}
