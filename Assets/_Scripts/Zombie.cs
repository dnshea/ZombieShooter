using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int speed;
    public GameObject player;
    Rigidbody rb;
    private bool seePlayer;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (seePlayer)
        transform.LookAt(player.transform);
        rb.AddForce(speed * Time.deltaTime * transform.forward);
    }
   
}
