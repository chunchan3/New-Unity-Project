using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject   bulletPrefab;
    public Camera       playerCamera;
    float               shootDelay = 0.5f;
    float               shootTimer;

    // Start is called before the first frame update
    void Start()
    {
        shootTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer -= Time.deltaTime;
        if(Input.GetMouseButtonDown(0) && shootTimer <= 0)
        {   
            GameObject bulletObject = Instantiate( bulletPrefab );
            Renderer rend = bulletObject.GetComponent<Renderer>();
            rend.material.color = Color.green;

            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;

            shootTimer = shootDelay;
            Debug.Log( "Fire" );
        }
    }
}
