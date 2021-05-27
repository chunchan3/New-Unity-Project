using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbulletmovement : MonoBehaviour
{
    float bulletSpeed;
    float bulletTime;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpeed = 30;
        gameObject.transform.forward = Camera.main.transform.forward;
        bulletTime = 0;

    }

    // Update is called once per frame
    void Update()
    {
        bulletTime += Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        if (bulletTime > 4)
        {
            Destroy(gameObject);
        }
    }
}
