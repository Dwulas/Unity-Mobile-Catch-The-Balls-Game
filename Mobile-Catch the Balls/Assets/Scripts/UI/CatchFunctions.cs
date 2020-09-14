using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFunctions : MonoBehaviour
{
    public GameObject leftPlatform;
    public GameObject midPlatform;
    public GameObject rightPlatform;
    public bool activePlat = false;
    public AudioSource platActive;

    public void LeftPlat()
    {
        if (activePlat == false)
        {
            activePlat = true;
            platActive.Play();
            leftPlatform.SetActive(true);
            StartCoroutine(LeftReset());
        }
    }

    public void MidPlat()
    {
        if (activePlat == false)
        {
            activePlat = true;
            platActive.Play();
            midPlatform.SetActive(true);
            StartCoroutine(MidReset());
        }
    }

    public void RightPlat()
    {
        if (activePlat == false)
        {
            activePlat = true;
            platActive.Play();
            rightPlatform.SetActive(true);
            StartCoroutine(RightReset());
        }
    }

    IEnumerator LeftReset()
    {
        yield return new WaitForSeconds(0.5f);
        leftPlatform.SetActive(false);
        activePlat = false;
    }

    IEnumerator MidReset()
    {
        yield return new WaitForSeconds(0.5f);
        midPlatform.SetActive(false);
        activePlat = false;
    }

    IEnumerator RightReset()
    {
        yield return new WaitForSeconds(0.5f);
        rightPlatform.SetActive(false);
        activePlat = false;
    }
}
