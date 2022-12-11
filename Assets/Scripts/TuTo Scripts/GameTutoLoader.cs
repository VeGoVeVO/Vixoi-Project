using UnityEngine;


public class GameTutoLoader : MonoBehaviour {

	public GameObject LoadPannel;

	public void CompleteLevel ()
	{
		LoadPannel.SetActive(true);
	}
}
