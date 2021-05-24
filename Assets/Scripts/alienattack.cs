using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class alienattack : MonoBehaviour
{
    public Transform[] shootingPoints;
    public GameObject bullet;

    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(Startshooting());
    }

    IEnumerator Startshooting()
    {

        yield return new WaitForSeconds(1);

        int randint = Random.Range(0, 13);


        Instantiate(bullet, shootingPoints[randint].position, Quaternion.identity);

        StartCoroutine(Startshooting());
    }

}
