using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Colision health;

    Animator anim;

    void Awake()
    {

        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health.Health <= 0)
        {
            anim.SetTrigger("GameOver");
        }
        
    }
}
