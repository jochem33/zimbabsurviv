using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Movement : MonoBehaviour {

    public GameObject player;
    public NavMeshAgent agent;
    public float Triggerzone = 100;

	// Update is called once per frame
	void Update () {
        transform.LookAt(player.transform.position);
        if (Vector3.Distance(transform.position, player.transform.position) < Triggerzone)
        {
            agent.SetDestination(player.transform.position);
        }

    }
}
