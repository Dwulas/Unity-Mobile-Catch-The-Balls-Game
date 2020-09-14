using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCatch : MonoBehaviour
{
    public AudioSource orbCatch;
    private void OnTriggerEnter(Collider other)
    {
        orbCatch.Play();
        if (other.tag == "Orb1")
        {
            ScoreUpdater.orbScore += 1;
        }
        if (other.tag == "Orb2")
        {
            ScoreUpdater.orbScore += 2;
        }
        if (other.tag == "Orb3")
        {
            ScoreUpdater.orbScore += 3;
        }
        ScoreUpdater.orbCount += 1;
        other.gameObject.SetActive(false);
    }
}
