using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShootScript : MonoBehaviour
{
    public Camera playerCamera;
    public GameObject enemyBullet;
    public float shootDelay = 3f;
    public float timeSinceLastShot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastShot <= 0)
        {
            timeSinceLastShot = shootDelay;
            GameObject bulletObject = Instantiate(enemyBullet);
            enemyBullet.
        }

        timeSinceLastShot -= Time.deltaTime;
    }
}
