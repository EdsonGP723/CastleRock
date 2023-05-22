using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    [SerializeField] Transform target;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
       var goal = GameObject.FindGameObjectWithTag("Target");
        target = goal.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += target.position * 2f * Time.deltaTime;
    }
}
