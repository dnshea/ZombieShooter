using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int speed;
    public int hp;
    public GameObject player;
    Rigidbody rb;
    private void Start()
    {
            rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 lookPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.LookAt(lookPosition);
        rb.AddForce(speed * 20 * Time.deltaTime * transform.forward);
    }
   
}
