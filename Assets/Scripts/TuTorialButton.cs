using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialButton : MonoBehaviour
{

    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TutorialL");
    }
}
