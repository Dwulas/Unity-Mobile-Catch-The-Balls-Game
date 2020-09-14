using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool countingDown = false;
    public int currentSeconds = 30;
    public bool isZero = false;

    void Update()
    {
        if (countingDown == false && isZero == false)
        {
            countingDown = true;
            StartCoroutine(SubstractSecond());
        }
    }

    IEnumerator SubstractSecond()
    {
        yield return new WaitForSeconds(1);
        currentSeconds -= 1;
        if(currentSeconds == 0)
        {
            isZero = true;
        }
        timeDisplay.GetComponent<Text>().text = "TIME:" + currentSeconds;
        countingDown = false;
    }
}
