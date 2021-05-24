using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    public float lifeDuration = 4f;

    private float aliveTime;
    // Start is called before the first frame update
    void Start()
    {
        aliveTime = lifeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        //bullet movement;
        transform.position += this.transform.forward * speed * Time.deltaTime;

        aliveTime -= Time.deltaTime;

        if (aliveTime <= 0f)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " Was Triggered by " + other.gameObject.name);
        Destroy(this.gameObject);
    }
}
