using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowScript : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 5f;

    public float minspeed = 2f;
    public float maxspeed = 8f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        speed = Random.Range(minspeed, maxspeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2 (transform.right.x, transform.right.y);
        rb.MovePosition(rb.position);
    }
}
