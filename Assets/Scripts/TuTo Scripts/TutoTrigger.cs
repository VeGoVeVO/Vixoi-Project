using UnityEngine;

public class TutoTrigger : MonoBehaviour
{
    public GameTutoLoader GameTutoLoader;
    public AudioSource TutoAudio;

    void OnTriggerEnter()
    {
        Destroy(gameObject);
        Time.timeScale = 0f;
        GameTutoLoader.CompleteLevel();
        TutoAudio.Play();
    }

}
