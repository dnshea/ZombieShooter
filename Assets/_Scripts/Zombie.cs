using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int speed;
    public int hp;
    Rigidbody rb;
    public bool bomber;

    private GameObject player;
    private GameObject spawner;
    private void Start()
    {
            rb = GetComponent<Rigidbody>();
            player = FindObjectOfType<PlayerController>().gameObject;
            spawner = FindObjectOfType<Spawner>().gameObject;
    }
    void Update()
    {
        Vector3 lookPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.LookAt(lookPosition);
        rb.AddForce(speed * 20 * Time.deltaTime * transform.forward);
        if (hp <= 0)
        {
            player.GetComponent<PlayerController>().score += 50;
            spawner.GetComponent<Spawner>().enemyCount--;
            Destroy(this.gameObject);
        }
    }
    
}
