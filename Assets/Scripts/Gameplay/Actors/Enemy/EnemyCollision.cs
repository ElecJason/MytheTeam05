using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private UnityEvent stopGame;
    [SerializeField] private string enemyTag = "Enemy";
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag(enemyTag))
        {
            Debug.LogError("De enemy heeft de player.");
            stopGame.Invoke();
        }
    }
}
