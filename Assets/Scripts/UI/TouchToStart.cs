using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToStart : MonoBehaviour
{
    public GameObject next_countdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            next_countdown.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
