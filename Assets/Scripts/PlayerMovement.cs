using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Joystick joystick;
	public float forwardForce = 6000f;
	public float moveSpeed = 20f;
	float velX;
	float velY;
	public Rigidbody Rigidbody;
	void Start()
    {
		Rigidbody = GetComponent<Rigidbody>();

	}
	void FixedUpdate()
	{
		// Add a forward force
		Rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);
		velX = joystick.Horizontal;
		velY = Rigidbody.velocity.y;
		Rigidbody.velocity = new Vector2(velX * moveSpeed, velY);

		if (Rigidbody.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
