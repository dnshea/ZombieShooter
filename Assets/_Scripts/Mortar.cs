using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortar : MonoBehaviour
{
    public GameObject laserballPrefab;
    public float spawnRate;
    public int hp;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLaser", 1, spawnRate);
    }
    private void Update()
    {
        if (hp == 0)
        {
            player.GetComponent<PlayerController>().score += 100;
            Destroy(this.gameObject);
        }
    }
}
