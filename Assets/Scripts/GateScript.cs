using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    [SerializeField] private GameObject ChildGameObject1;
    [SerializeField] private GameObject ChildGameObject2;
    [SerializeField] private bool hasOpened = false;

    private void Start()
    {
        ChildGameObject1 = this.transform.GetChild(0).gameObject;
        ChildGameObject2 = this.transform.GetChild(1).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory inventory = GameObject.Find("Player").GetComponent<Inventory>();

            if (inventory.gateKey == true && hasOpened == false)
            {
                Debug.Log("Open");
                hasOpened = true;

                ChildGameObject1.transform.Rotate(0, 0, 90);
                ChildGameObject2.transform.Rotate(0, 0, 90);
            }
        }
    }
}

