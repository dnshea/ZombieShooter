using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerTwo : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Flying;
    public GameObject Range;
    public GameObject Meteor;
    public GameObject Bomber;
    public GameObject Boss;
    private int fourCount = 30; //Enenmies required to beat Wave 4
    private int fiveCount = 40; //Enenmies required to beat Wave 5
    private int sixCount = 50; //Enenmies required to beat Wave 6
    // Start is called before the first frame update
    void Start()
    {
        WaveFour();
    }

    // Update is called once per frame
    void Update()
    {
        if (fourCount == 0)
        {
            fourCount--;
            WaveFive(); 
        }
        if (fiveCount == 0)
        {
            fiveCount--;
            WaveSix();
        }
        if (sixCount == 0)
        {
            //Game Win Scene Script here
        }

    }
    private void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
    private void WaveFour()
    {

    }
    private void WaveFive()
    {

    }
    private void WaveSix()
    {

    }
}
