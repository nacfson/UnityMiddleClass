using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChangeAgentDestination : MonoBehaviour{
    public Vector3 destination = new Vector3(-3f, 5f, 2f);

    private NavMeshAgent _agent;

    private void Awake() {
        _agent = GetComponent<NavMeshAgent>();
    }

    public void Call(){
        _agent.SetDestination(destination);
    }
}