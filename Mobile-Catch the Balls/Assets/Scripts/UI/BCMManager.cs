using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BCMManager : MonoBehaviour
{
    public GameObject mainLogo;
    public GameObject[] menuText;
    public GameObject splashBackground;
    public GameObject bgm;
    public GameObject globalScripts;
    public GameObject countdownText;
    public GameObject tapButton;
    public GameObject[] finalText;

    void Start()
    {
        StartCoroutine(StartupGame());
    }

    IEnumerator StartupGame()
    {
        yield return new WaitForSeconds(1);
        mainLogo.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        mainLogo.SetActive(false);
        menuText[0].SetActive(true);
        menuText[1].SetActive(true);
        tapButton.SetActive(true);
    }

    public void TapToStart()
    {
        tapButton.SetActive(false);
        menuText[0].SetActive(false);
        menuText[1].SetActive(false);
        splashBackground.GetComponent<Animator>().Play("SplashFadeOut");
        StartCoroutine(BeginTheGame());
    }

    IEnumerator BeginTheGame()
    {
        finalText[0].SetActive(false);
        finalText[1].SetActive(false);
        yield return new WaitForSeconds(1);
        countdownText.SetActive(true);
        yield return new WaitForSeconds(1);
        countdownText.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1);
        countdownText.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1);
        countdownText.SetActive(false);
        countdownText.GetComponent<Text>().text = "3";
        bgm.SetActive(true);
        splashBackground.SetActive(false);
        globalScripts.GetComponent<Timer>().enabled = true;
        globalScripts.GetComponent<OrbGenerate>().enabled = true;
    }
}
