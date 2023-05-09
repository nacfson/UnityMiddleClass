using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomAgentSpeedRatio : MonoBehaviour{
    public float min = .8f;
    public float max = 1.5f;
    private NavMeshAgent _agent;

    private void Awake() {
        _agent = GetComponent<NavMeshAgent>();
    }
    public void Call(){
        _agent.speed = Random.Range(min,max);

    }
}