using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();

    }

    // Update is called once per frame
    void NavigateScene(string sceneName)
    {

    }
}
