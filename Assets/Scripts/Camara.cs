﻿using UnityEngine;

public class Camara : MonoBehaviour
{

    public Transform player;
    public Vector3 offSet;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offSet;
    }
}
