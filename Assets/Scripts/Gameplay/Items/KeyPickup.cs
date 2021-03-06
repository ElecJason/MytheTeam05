using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPickup : ItemBase
{
    private GameObject player;
    [SerializeField] private string playerTag = "Player";

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag(playerTag);
    }

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (other.gameObject.CompareTag(playerTag))
        {
            player.GetComponent<InventoryManager>().PickupKey();
            Destroy(this.gameObject);
            Debug.Log("Key Found");
        }
    }
}
