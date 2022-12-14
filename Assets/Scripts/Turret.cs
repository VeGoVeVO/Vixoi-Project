using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{
	private Transform target;
	public float range = 15f;
	public float fireRate = 1f;
	private float fireCountdown = 0f;
	public string enemyTag = "Enemy";
	public Transform RotatePart;
	public float turnSpeed = 200f;
	public GameObject MissilePrefab;
	public Transform firePoint;
	void Start()
	{
		InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}

	void UpdateTarget()
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
		float shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;
		foreach (GameObject enemy in enemies)
		{
			float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}

		if (nearestEnemy != null && shortestDistance <= range)
		{
			target = nearestEnemy.transform;
		}
		else
		{
			target = null;
		}

	}

	// Update is called once per frame
	void Update()
	{
		if (target == null)
			return;
		Vector3 dir = target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation(dir);
		Vector3 rotation = Quaternion.Lerp(RotatePart.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		RotatePart.rotation = Quaternion.Euler(rotation.x, rotation.y, 0f);
		if (fireCountdown <= 0f)
		{
			Shoot();
			fireCountdown = 1f / fireRate;
		}
		fireCountdown -= Time.deltaTime;
	}
	void Shoot ()
	{	
		GameObject missileGO = (GameObject) Instantiate(MissilePrefab, firePoint.position, firePoint.rotation);
		Missile missile = missileGO.GetComponent<Missile>();

		if (missile != null)
			missile.Seek(target);
	}
	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}