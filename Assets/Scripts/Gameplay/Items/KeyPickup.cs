using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPickup : ItemBase
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<InventoryManager>().PickupKey();
            Destroy(this.gameObject);
            Debug.Log("Key Found");
        }
    }
}
