using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fightingbullet : MonoBehaviour
{
    public Transform aimTarget;

    float bulletSpeed;

    public GameObject smoke;
    Player_inf Player;

    void Start()
    {
        Player = FindObjectOfType<Player_inf>();

        aimTarget = Camera.main.transform;
        transform.LookAt(aimTarget);
        bulletSpeed = 10;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
    }
    

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "AR Camera"){
            Debug.Log("Hit collider! ");
            Destroy(gameObject);
            Player.player_health = Player.player_health - 1;
            Debug.Log(Player.player_health);
            if (Player.player_health < 1)
            {
                SceneManager.LoadScene(2);
            }
        }
        if(col.gameObject.name == "Bomb(Clone)")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            Instantiate(smoke, gameObject.transform.position, Quaternion.identity);

        }

    }
    
}
