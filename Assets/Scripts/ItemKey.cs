using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemKey : ItemBase
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<Inventory>().PickupKey();
            Destroy(this.gameObject);
            Debug.Log("Key Found");
        }
    }
}
