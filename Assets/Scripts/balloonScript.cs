using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonScript : MonoBehaviour
{   
 
    // Update is called once per frame
    void Update()
    {
        int counter = 0;
        int nowTime = Time.frameCount;
        //transform.Translate(Vector3.left * Time.deltaTime * 0.2f);
        int answer = nowTime % 400;
        print(answer);
        if (nowTime < 50)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 70f);
        }

        if (answer > 0 & answer < 185)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 0.2f);
        }
        else if (answer > 186 & answer < 200)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 0.2f);
        }
        else if (answer > 200 & answer < 385)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 0.2f);
        }
        else if (answer > 386)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 0.2f);
        }
        
    }
}
