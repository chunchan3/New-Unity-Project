using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   
    public Transform[] spawnPoints;
    public GameObject[] balloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(1);
        for (int i=0; i < 12 ;i++){
            Instantiate(balloons[i],spawnPoints[i].position ,Quaternion.identity);
        }
        //StartCoroutine(StartSpawning());
    }
}
