using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemKey : ItemBase
{
    [SerializeField] private UnityEvent GetKey;

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (other.gameObject.CompareTag("Player"))
        {
            Inventory inventory = GameObject.Find("Player").GetComponent<Inventory>();
            inventory.PickupKey();
            Destroy(this.gameObject);
            Debug.Log("Key Found");
        }
    }
}
