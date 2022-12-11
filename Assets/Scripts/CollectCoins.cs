using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{

    public AudioSource collectingAudio;

    void OnTriggerEnter(Collider other)
    {
        collectingAudio.Play();
        ScoringSystem.theScore += 50;
    }
}
