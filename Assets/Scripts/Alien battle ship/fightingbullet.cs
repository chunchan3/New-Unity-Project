using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class fightingbullet : MonoBehaviour
{
    public Transform aimTarget;

    float bulletSpeed;

    public GameObject smoke;

    public GameObject image_gotHitScreen;
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
        if(GameObject.Find("gothit_BG").GetComponent<Image>().color.a > 0)
        {
            var color = GameObject.Find("gothit_BG").GetComponent<Image>().color;
            color.a -= 0.05f;
            GameObject.Find("gothit_BG").GetComponent<Image>().color = color;
        }
    }
    

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "AR Camera"){
            Debug.Log("Hit collider! ");
            Destroy(gameObject);
            GotHit();
            Player.player_health = Player.player_health - 1;
            if (Player.player_health < 1)
            {
                SceneManager.LoadScene(2);
            }
        }
        if(col.gameObject.name == "Bomb(Clone)")
        {
            //Destroy(gameObject);
            Debug.Log("Destroy(gameObject)");
            Destroy(col.gameObject);
            Debug.Log("Destroy(col.gameObject)");
            Instantiate(smoke, gameObject.transform.position, Quaternion.identity);

        }

    }

    void GotHit()
    {
        var color =GameObject.Find("gothit_BG").GetComponent<Image>().color;
        color.a = 0.8f;
        GameObject.Find("gothit_BG").GetComponent<Image>().color = color;
    }
    
}
