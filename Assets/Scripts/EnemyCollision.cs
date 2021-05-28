using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private UnityEvent startWander;
    [SerializeField] private UnityEvent stayWander;
    [SerializeField] private UnityEvent stopWander;
    [SerializeField] private UnityEvent stopGame;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Debug.LogError("De enemy heeft de player.");
            stopGame.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grass"))
        {
            startWander.Invoke();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Grass"))
        {
           stayWander.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Grass"))
        {
            stopWander.Invoke();
        }
    }
}
