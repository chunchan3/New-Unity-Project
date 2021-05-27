using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Camera playerCamera;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void No_update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate( bulletPrefab );
            Renderer rend = bulletObject.GetComponent<Renderer>();
            rend.material.color = Color.green;
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;
            Debug.Log( "Fire" );
        }
    }
}
