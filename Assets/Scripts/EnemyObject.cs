using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("GenerateEnemies");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " Was Triggered by " + other.gameObject.name);
        Destroy(this.gameObject);
        obj.GetComponent<GenerateEnemies>().DecrementCount();
    }
}
