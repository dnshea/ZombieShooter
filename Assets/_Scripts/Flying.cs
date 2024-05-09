using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public int speed;
    public int hp;
    private GameObject player;
    private GameObject spawner;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
        spawner = FindObjectOfType<Spawner>().gameObject;
    }
    void Update()
    {
            transform.LookAt(player.transform);
            transform.position += transform.forward * speed * Time.deltaTime;
        if (hp <= 0)
        {
            player.GetComponent<PlayerController>().score += 75;
            spawner.GetComponent<Spawner>().enemyCount--;
            Destroy(this.gameObject);
        }
    }
}
