using UnityEngine;


public class GameTutoResume : MonoBehaviour {

	public GameObject LoadPannel;

	public void CompleteLevel ()
	{
		LoadPannel.SetActive(false);
	}
}
