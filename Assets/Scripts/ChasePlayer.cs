using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private float normalSpeed = 3;
    [SerializeField] private float runningSpeed = 6;
    [SerializeField] private float runDistance = 4;

    [SerializeField] private float minFloat = -1;
    [SerializeField] private float maxFloat = 1;

    private bool isWandering = false;
    private Vector3 randomVector;

    private void Start()
    {
        agent.speed = normalSpeed;
    }

    void Update()
    {
        if(isWandering == false)
        {
            FollowPlayer();
        }

        float dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist >= runDistance) {
            agent.speed = runningSpeed;
        }
        else
        {
            agent.speed = normalSpeed;
        }
    }

    void FollowPlayer()
    {
        agent.SetDestination(player.transform.position);
    }

    public void StartWander()
    {
        isWandering = true;
        randomVector = new Vector3(Random.Range(minFloat, maxFloat), Random.Range(minFloat, maxFloat), Random.Range(minFloat, maxFloat));
    }

    public void StayWander()
    {
        agent.SetDestination(transform.position +  randomVector);
    }

    public void StopWander()
    {
        isWandering = false;
    }
}
