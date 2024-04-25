using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Flying;
    public GameObject Range;

    private int oneCount = 20; //Enenmies required to beat Wave 1
    private int twoCount = 25; //Enenmies required to beat Wave 2
    private int threeCount = 30; //Enenmies required to beat Wave 3
    // Start is called before the first frame update
    void Start()
    {
        WaveOne();
    }

    // Update is called once per frame
    void Update()
    {
        if (oneCount == 0)
        {
            oneCount--;
            WaveTwo();
        }
        if (twoCount == 0)
        {
            twoCount--;
            WaveThree();
        }
        if (threeCount == 0)
        {
            //Next Level Script here
        }

    }
    private void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
    private void WaveOne()
    {

    }
    private void WaveTwo()
    {

    }
    private void WaveThree()
    {

    }
}
