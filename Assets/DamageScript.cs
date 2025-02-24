﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public Health health;
    public GameObject Player;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        health = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            health.TakeDamage(30, gameObject);
        }
        else if (other.tag == "Terrain")
        {
            Destroy(bullet);
        }

    }
}
