using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory inventory = GameObject.Find("Player").GetComponent<Inventory>();

            if (inventory.gateKey == true)
            {
                Debug.Log("Open");
                Destroy(this.gameObject);
            }
        }
    }
}

