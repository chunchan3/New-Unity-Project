using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform ARcamera;

    // Start is called before the first frame update

    
    public void moveLeft()
    {
        if (ARcamera.transform.position.x > -10)
        {
            ARcamera.transform.Translate(Vector3.left * Time.deltaTime * 5);
            Debug.Log("Left button");
        }
    }

    public void moveRight()
    {
        if (ARcamera.transform.position.x < 10) { 
            ARcamera.transform.Translate(Vector3.right * Time.deltaTime * 5);
        Debug.Log("right button");
    }
}

}
