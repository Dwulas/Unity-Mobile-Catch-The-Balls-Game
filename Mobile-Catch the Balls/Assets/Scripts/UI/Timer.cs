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
    public GameObject splashBackground;
    public GameObject bgm;
    public GameObject globalScripts;
    public GameObject tapPlayButton;
    public GameObject finalScore;
    public GameObject finalOrbs;
    public GameObject tapToBeginText;

    void Update()
    {
        if (countingDown == false && isZero == false)
        {
            countingDown = true;
            StartCoroutine(SubstractSecond());
        }
        if(isZero == true)
        {
            finalScore.GetComponent<Text>().text = "SCORE: " + ScoreUpdater.orbScore;
            finalOrbs.GetComponent<Text>().text = "ORBS: " + ScoreUpdater.orbCount;
            StartCoroutine(GameOver());
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

    IEnumerator GameOver()
    {
        splashBackground.SetActive(true);
        splashBackground.GetComponent<Animator>().Play("SplashFadeIn");
        bgm.SetActive(false);
        globalScripts.GetComponent<OrbGenerate>().enabled = false;
        yield return new WaitForSeconds(1.2f);
        finalScore.SetActive(true);
        finalOrbs.SetActive(true);
        tapToBeginText.SetActive(true);
        tapPlayButton.SetActive(true);
        currentSeconds = 31;
        isZero = false;
        ScoreUpdater.orbCount = 0;
        ScoreUpdater.orbScore = 0;
        yield return new WaitForSeconds(0.1f);
        globalScripts.GetComponent<Timer>().enabled = false;
    }
}
