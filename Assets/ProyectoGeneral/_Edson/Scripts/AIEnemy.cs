using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIEnemy : MonoBehaviour
{
	
	[SerializeField] Transform target;
	[SerializeField] float Speed;
	[SerializeField] NavMeshAgent AI;
    private void Awake()
    {
	    var goal = GameObject.FindGameObjectWithTag("Target");
	    target = goal.transform;
    }
    
    // Update is called once per frame
    void Update()
    {
	    AI.speed = Speed;
	    AI.SetDestination(target.position);
    }
}
