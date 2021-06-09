using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    [Header("Gameobject variables")]
    [SerializeField] private GameObject player;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private AudioSource source;

    [Header("Speed variables")]
    [SerializeField] private float normalSpeed = 3;
    [SerializeField] private float runningSpeed = 6;
    [SerializeField] private float runDistance = 4;

    [Header("Distance variables")]
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
            source.pitch = 0f;
        }
        else
        {
            agent.speed = normalSpeed;
            source.pitch = 1.3f;
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
