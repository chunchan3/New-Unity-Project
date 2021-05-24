using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightingbullet : MonoBehaviour
{
    public Transform aimTarget;

    float bulletSpeed;

    void Start()
    {

        aimTarget = Camera.main.transform;
        transform.LookAt(aimTarget);
        bulletSpeed = 10;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        if (gameObject.transform.position.z < -1)
        {
            Destroy(gameObject);
        }
    }
}
