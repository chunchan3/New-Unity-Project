using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_state : MonoBehaviour
{
    public int alien_length;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("AlienGroup").activeSelf== true)
        {
            alien_length = GameObject.FindGameObjectsWithTag("AlienShip").Length;
            if (alien_length == 0)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
