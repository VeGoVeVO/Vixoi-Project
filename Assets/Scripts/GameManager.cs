using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 0.5f;

	public GameObject completeLevelUI;
	public GameObject skinUI;
	public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);
	}
	public void SkinUI()
	{
		skinUI.SetActive(true);
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Invoke("Restart", restartDelay);
		}
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
