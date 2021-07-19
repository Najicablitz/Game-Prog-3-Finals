using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    private float distoPlayer;
    public float range;
    public float fireRate;
    public float nextFire;
    public Transform player;

    void Start()
    {
        
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        distoPlayer = Vector2.Distance(transform.position, player.position);
        //Debug.Log(distoPlayer);
        if (distoPlayer <= range)
        {
            CheckFire();
        }
        
    }

    public void CheckFire()
    {
        if(Time.time >= nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
        
    }
}
