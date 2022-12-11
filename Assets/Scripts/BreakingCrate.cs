using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingCrate : MonoBehaviour
{
    public GameObject destroyedVersion;
    public AudioSource collectingAudio;

    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 50;
        collectingAudio.Play();
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
