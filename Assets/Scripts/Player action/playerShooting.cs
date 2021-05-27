using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public GameObject player_bullet;

    public void shoot()
    {
        Instantiate(player_bullet,Camera.main.transform.position, Quaternion.identity);
        Debug.Log("Player Shoot!");
    }
}
