using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    [SerializeField] private GameObject ChildGameObject1;
    [SerializeField] private GameObject ChildGameObject2;


    private float rotation = -90f;


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

            if (inventory.gateKey == true)
            {
                Debug.Log("Open");

                ChildGameObject1.transform.Rotate(0, 0, -90);
                ChildGameObject2.transform.Rotate(0, 0, -90);
            }
        }
    }
}

