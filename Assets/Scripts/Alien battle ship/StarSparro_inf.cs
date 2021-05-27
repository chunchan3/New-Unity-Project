using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarSparro_inf : MonoBehaviour
{
    int alien_length;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Bomb(Clone)")
        {
            Debug.Log("StarSparrow got hit ");
            Destroy(gameObject);
        }
    }
}
