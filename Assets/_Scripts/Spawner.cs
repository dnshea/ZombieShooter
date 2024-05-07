using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool levelOne;
    public GameObject Zombie;
    public GameObject Flying;
    public GameObject Range;
    public GameObject Bomber;
    public GameObject Boss;
    private int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
     if (levelOne)
        {
            WaveOne();
        }
     else
        {
            WaveFour();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
        enemyCount++;
    }
    private void SpawnEnemyAir(GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
        enemyCount++;
    }

    private void WaveOne()
    {
        SpawnEnemy(Zombie);
    }
    private void WaveTwo()
    {

    }
    private void WaveThree()
    {

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
