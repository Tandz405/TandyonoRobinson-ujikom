using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float ms;


    [SerializeField]
    private GameObject Player_Bullet;

    [SerializeField]
    private GameObject Attack_Point;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        rb .velocity = new Vector2 (horiz*ms,rb.velocity.y);
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

           
        }
    }

    private void Instantiate(GameObject player_Bullet, object position, Quaternion identity)
    {
        throw new NotImplementedException();
    }
}
