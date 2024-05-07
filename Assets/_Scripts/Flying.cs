using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public int speed;
    public int hp;
    public GameObject player;
    void Update()
    {
            transform.LookAt(player.transform);
            transform.position += transform.forward * speed * Time.deltaTime;
        if (hp <= 0)
        {
            player.GetComponent<PlayerController>().score += 75;
            Destroy(this.gameObject);
        }
    }
}
