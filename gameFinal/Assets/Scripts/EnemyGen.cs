using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGen : MonoBehaviour
{
    public GameObject enemy;

    public int enemycount = 350;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < enemycount ; i++)
        {
            spawnPosition.y += Random.Range(10f, 20f);
            spawnPosition.x = Random.Range(-8f, 8f);
            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
	
    }
}
