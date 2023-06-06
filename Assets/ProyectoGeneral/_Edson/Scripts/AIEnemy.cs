using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIEnemy : MonoBehaviour
{
	
	[SerializeField] private Transform target;
	[SerializeField] private float Speed;
	[SerializeField] private NavMeshAgent AI;
	[SerializeField] private float life = 30;
    private void Awake()
    {
	    var goal = GameObject.FindGameObjectWithTag("Target");
	    target = goal.transform;
    }
    
    void Update()
    {
	    AI.speed = Speed;
	    AI.SetDestination(target.position);
	    
	    if(life <= 0){
	    	this.gameObject.SetActive(false);
	    	GameGlobals.Coins += 15;
	    }
    }
    
	// OnTriggerEnter is called when the Collider other enters the trigger.
	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Ball1")){
			life -= 3;
			other.gameObject.SetActive(false);
		}
		if (other.CompareTag("Ball2")){
			life -= 6;
			other.gameObject.SetActive(false);
		}
		if (other.CompareTag("Ball3")){
			life -= 8;
			other.gameObject.SetActive(false);
		}
		if (other.CompareTag("Ball4")){
			life -= 12;
			other.gameObject.SetActive(false);
		}
		if (other.CompareTag("Ball5")){
			life -= 15;
			other.gameObject.SetActive(false);
		}
	}
    
}
