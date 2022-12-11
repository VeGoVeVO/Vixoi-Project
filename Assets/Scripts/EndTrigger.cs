using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource End;
    public PlayerMovement movement;
    public GameObject destroyedVersion;
    void OnTriggerEnter()
    {
        Destroy(gameObject);
        movement.enabled = false; 
        gameManager.CompleteLevel();
        End.Play();
    }

}
