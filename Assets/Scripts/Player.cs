using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject   bulletPrefab;
    public Camera       playerCamera;

    public  int         currentLives;
    private int         maxLives = 3;

    float               shootDelay = 0.5f;
    float               shootTimer;

    static AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        shootTimer = 0f;
        shootSound = GetComponent<AudioSource>();
        currentLives = maxLives;
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer -= Time.deltaTime;

        if(currentLives <= 0)
        {
            //adding to high scores goes here

            SceneManager.LoadScene("GameOverScene");
        }

        if(Input.GetMouseButtonDown(0) && shootTimer <= 0)
        {   
            GameObject bulletObject = Instantiate( bulletPrefab );
            Renderer rend = bulletObject.GetComponent<Renderer>();
            rend.material.color = Color.green;

            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;

            shootSound.Play();
            shootTimer = shootDelay;
            Debug.Log( "Fire" );
        }
    }
}
