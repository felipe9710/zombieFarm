using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<player>().transform;
        
    }

    // Update is called once per frame
    void Update()
    {

        agent.destination = player.position;
        anim.SetFloat("speed",agent.velocity.magnitude / agent.speed);
        
    }
}
