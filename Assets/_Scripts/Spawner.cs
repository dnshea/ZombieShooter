using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool levelOne;
    public GameObject Zombie;
    public GameObject Flying;
    public GameObject Range;
    public GameObject Meteor;
    public GameObject Bomber;
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
