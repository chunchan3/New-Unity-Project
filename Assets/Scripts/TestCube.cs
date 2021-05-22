using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCube : MonoBehaviour
{
    public GameObject Testbox;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Testbox, new Vector3(1, 0, 0), Quaternion.identity);
        Testbox.gameObject.tag = "enemy";
    }

    // Update is called once per frame--
    void Update()
    {
        
    }
}
