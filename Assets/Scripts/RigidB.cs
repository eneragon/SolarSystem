using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidB : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 pozisyon;
    public Vector3 hiz;
    void Start()
    {
        pozisyon = new Vector3(1, 1, 1);
        hiz = new Vector3(1, 1, 1);
    }

    void Update()
    {
        rb.MovePosition(pozisyon);
        rb.velocity = hiz * 10;
    }
}
