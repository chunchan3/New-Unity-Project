using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateScene : MonoBehaviour
{
    public void SwitchScene(string sceneName)
    {
        Debug.Log("button clicked");
        SceneManager.LoadScene(sceneName);
        
    }
}
