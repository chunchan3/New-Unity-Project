using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject EnemyObject;

    public int xPos;
    public int yPos;
    public int zPos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        EnemySpawn();
    }

    private void EnemySpawn()
    {
        while(enemyCount < 7)
        {
            xPos = Random.Range(-5, 5);
            yPos = Random.Range(1, 3);
            zPos = Random.Range(1, 5);
            Instantiate(EnemyObject, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            enemyCount++;
        }

    }

    public void DecrementCount()
    {
        enemyCount--;
    }
}
