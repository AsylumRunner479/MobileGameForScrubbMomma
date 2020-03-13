using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAi : MonoBehaviour
{
    //desiginates who the player is
    public GameObject target;
    public float moveSpeed;
    public NavMeshAgent agent;
    


    public GameObject self;

    public float turnSpeed;





    public Rigidbody rigid;


    void Start()
    {


        agent = self.GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");


    }

    void Update()
    {

        if (TIlt.IsDead == true)
        {
            Destroy(self);
        }







        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.0001f);
            agent.destination = target.transform.position;
        }
           





        
    }
}