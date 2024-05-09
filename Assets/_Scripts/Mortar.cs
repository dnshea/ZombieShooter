using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortar : MonoBehaviour
{
    public GameObject laserballPrefab;
    public float spawnRate;
    public int hp;
    public GameObject player;
    public Transform mortarBase;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLaserBall", 1, spawnRate);

    }
    private void SpawnLaserBall()
    {
        GameObject newLaser = Instantiate(laserballPrefab, mortarBase.transform.position, mortarBase.transform.rotation);
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
