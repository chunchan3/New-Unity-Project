using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class alienattack : MonoBehaviour
{
    public Transform[] shootingPoints;
    public GameObject bullet;
    public int current_alien_num;

    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(Startshooting());
    }

    IEnumerator Startshooting()
    {

        yield return new WaitForSeconds(1);
        current_alien_num = GameObject.FindGameObjectsWithTag("AlienShip").Length - 1;

        int randint = Random.Range(0, current_alien_num);


        Instantiate(bullet, shootingPoints[randint].position, Quaternion.identity);

        StartCoroutine(Startshooting());
    }

}
