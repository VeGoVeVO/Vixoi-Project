using UnityEngine;

public class TutoResume : MonoBehaviour
{
    public GameTutoResume GameTutoResume;
    public GameObject LoadPannel;
    public AudioSource TutoAudio;
    public AudioSource RobotAudio;

    public void Resume()
    {
        LoadPannel.SetActive(false);
        Time.timeScale = 1f;
        TutoAudio.Stop();
        RobotAudio.Play();
    }

}
