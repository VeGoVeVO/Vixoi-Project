using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // a "Vector3" stores 3 numbers instead of 1 like "Float"
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
