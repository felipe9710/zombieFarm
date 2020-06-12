using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;
    Animator anim;
    Transform zombie;

    public float attackDistance = 0.5f;
    private bool attacking;
    public float attackduration = 1f;
    public string attackAnimation;
    public float attackTransition = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        zombie = FindObjectOfType<ZombieController>().transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!attacking) {
            agent.destination = player.position;
            anim.SetFloat("speed", agent.velocity.magnitude / agent.speed);

            if(Vector3.Distance(player.position, zombie.position) <= attackDistance)
            {
                StartCoroutine(attackPlayer());
            }
        }
        IEnumerator attackPlayer()
        {
            agent.isStopped = true;
            attacking = true;
            float d = 0f;
            while (d < attackTransition)
            {
                d += Time.deltaTime;
                yield return null;
            }
            anim.CrossFade(attackAnimation, 0.1f);
            yield return new WaitForSeconds(attackduration);
            attacking = false;
            agent.isStopped = false;
        }
    }
}
