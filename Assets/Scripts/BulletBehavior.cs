﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior: MonoBehaviour
{
    public float speed = 100f; //bullet movement speed
    public Rigidbody2D rb;
    public GameObject target;//needs to be assigned when constructed

    void Start()
    {
        Vector3 vectorToTarget = target.transform.position - transform.position;
        transform.LookAt(transform.position + new Vector3(0, 0, 1), vectorToTarget);
        //transform.LookAt(target.transform.position, Vector3.forward);//look towards target
        rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
