using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public GameObject scoreDisplay;
    public GameObject orbDisplay;
    public static int orbScore;
    public static int orbCount;

    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "SCORE: " + orbScore;
        orbDisplay.GetComponent<Text>().text = "ORBS: " + orbCount;
    }


}
