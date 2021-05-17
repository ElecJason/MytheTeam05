using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject destination;

    [SerializeField] private float normalSpeed = 3;
    [SerializeField] private float runningSpeed = 6;

    private void Start()
    {
        agent.speed = normalSpeed;
    }

    void Update()
    {
        //agent.SetDestination(player.transform.position);

        if (Input.GetKey(KeyCode.E))
        {
            agent.SetDestination(destination.transform.position);
        }
        else
        {
            agent.SetDestination(player.transform.position);
        }

        float dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist >= 6) {
            agent.speed = runningSpeed;
        }
        else
        {
            agent.speed = normalSpeed;
        }
        //Debug.Log(dist);
        //Debug.Log(agent.speed);
    }
}
