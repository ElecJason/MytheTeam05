using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private UnityEvent stopGame;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Debug.LogError("De enemy heeft de player.");
            stopGame.Invoke();
        }
    }
}
