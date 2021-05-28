using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public int countDownTime;
    public Text countDownDisplay;
    public GameObject GamePlayGroup;

    private void Start()
    {
        StartCoroutine(StartCountDown());
    }

    IEnumerator StartCountDown()
    {

        yield return new WaitForSeconds(1f);
        countDownDisplay.text = "SET";
            yield return new WaitForSeconds(1f);
        countDownDisplay.text = "GO!";
        yield return new WaitForSeconds(0.5f);
        GamePlayGroup.SetActive(true);
        gameObject.SetActive(false);

    }
}
