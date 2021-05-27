using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class number_of_alien : MonoBehaviour
{
    public Text alien_num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alien_num.text = GameObject.FindGameObjectsWithTag("AlienShip").Length.ToString();
    }
}
