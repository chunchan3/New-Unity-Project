using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class balloonScript : MonoBehaviour
{
    float speed;
    float width;
    float height;
    public int time;
    public int counter;
    public bool movingDown;
    int alien_length;


    public Transform target;

    private void Start()
    {
        movingDown = true;

        speed = 2f;
        counter = 2;
        width = 4;
        height = 7;
        transform.Rotate(0, 180, 0);

        float add_distanceZ = 5;
        float Startingx = gameObject.transform.position.x;
        float Startingy = gameObject.transform.position.y;
        float startingz = gameObject.transform.position.z;

        startingz += add_distanceZ;
        transform.position = new Vector3(Startingx, Startingy, startingz);

    }

    // Update is called once per frame
    void Update()
    {
        int nowTime = Time.frameCount;
        float timeCounter = 0;
        
        time = Time.frameCount;

        int timecycle = time % 400;

        //transform.Translate(Vector3.left * Time.deltaTime * 0.2f);

        //Debug.Log(transform.localRotation.z);
        transform.LookAt(target);

        string ObjectName = gameObject.name;
        if (ObjectName == "1 (1)")
        {

            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
            float z = gameObject.transform.position.z;
            if (timecycle < 200)
            {
                z -= 0.1f;
            }
            else
            {
                z += 0.1f;
            }

            transform.position = new Vector3(x, y, z);

        }

        float nowX = gameObject.transform.position.x;
        float nowY = gameObject.transform.position.y;
        float nowZ = gameObject.transform.position.z;

        float nowRotateX = gameObject.transform.rotation.x;
        float nowRotateY = gameObject.transform.rotation.y;
        float nowRotateZ = gameObject.transform.rotation.z;



        //Debug.Log(counter);
        if (timecycle == 1)
        {
            counter++;
        }

        if (timecycle < 95)
        {
            nowX += speed * Time.deltaTime;
            nowRotateY -= 1;
        }
        if (timecycle > 95 & timecycle < 105)
        {
            if (movingDown==false)
            {
                nowY += speed * Time.deltaTime;
            }
            else
            {
                nowY -= speed * Time.deltaTime;
            }
        }
        if (timecycle > 105 & timecycle < 295)
        {
            nowX -= speed * Time.deltaTime;
        }
        if (timecycle > 295& timecycle < 305)
        {
            if (movingDown == false)
            {
                nowY += speed * Time.deltaTime;
            }
            else
            {
                nowY -= speed * Time.deltaTime;
                nowZ -= speed * Time.deltaTime;
            }
        }
        if (timecycle > 305){
            nowX += speed * Time.deltaTime;
        }


        transform.position = new Vector3(nowX, nowY, nowZ);


    }
}