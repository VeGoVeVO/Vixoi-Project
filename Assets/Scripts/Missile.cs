using UnityEngine;

public class Missile : MonoBehaviour
{

	private Transform target;
	public float speed = 70f;
	public GameObject MissileImpactEffect;

	public void Seek(Transform _target)
	{
		target = _target;
	}

	void Update()
	{

		if (target == null)
		{
			Destroy(gameObject);
			return;
		}
		Vector3 dir = target.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distanceThisFrame)
        {
			OnTriggerEnter();
			return;
		}
		transform.Translate(dir.normalized * distanceThisFrame, Space.World);

	}

	void OnTriggerEnter()
	{
		
		GameObject effectIns = (GameObject)Instantiate(MissileImpactEffect, transform.position, transform.rotation);
		Destroy(effectIns, 5f);
		Destroy(target.gameObject);
		Destroy(gameObject);
	}
}