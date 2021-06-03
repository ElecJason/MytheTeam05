using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class mudPoolScript : MonoBehaviour
{
    [SerializeField] private UnityEvent EndGame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EndGame.Invoke();
            Debug.Log("De speler heeft de enemy gedood.");
        }
    }
}