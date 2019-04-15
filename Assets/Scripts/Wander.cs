using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Author: Templar2020 - https://gist.github.com/Templar2020/8e4f5296de96d8ccf03263bf1a9f277f
/// Reused for SWEN 5235 - HW 3 Cats
/// </summary>
public class Wander : MonoBehaviour
{
    public float wanderRadius;
    public float wanderTimer;

    private Transform target;
    private NavMeshAgent agent;
    private float timer;

    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    /// <summary>
    /// Calculate New Random Position
    /// </summary>
    /// <param name="origin"></param>
    /// <param name="dist"></param>
    /// <param name="layermask"></param>
    /// <returns>New Vector3 Position</returns>
    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
