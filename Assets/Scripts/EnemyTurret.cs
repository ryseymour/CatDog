using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTurret : MonoBehaviour {

	public Transform target;

	[Header("Attributes")]
	public float range = 15f;

	public float fireRate = 1f;
	private float fireCountdown = 0f;

	public GameObject bulletPrefab;
	public Transform firePoint;
	private float enemyhealth;

	public float health;
	public float updateHealth;
	public Image healthbar;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("UpdateTarget", 0f, 0.5f);
	}

	void UpdateTarget ()
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Player");
		float shortestDistance = Mathf.Infinity;

		GameObject nearestEnemy = null;
		foreach (GameObject enemy in enemies) {
			float distanceToEnemy = Vector3.Distance (transform.position, enemy.transform.position);
			if (distanceToEnemy < shortestDistance) {
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}

		if (nearestEnemy != null && shortestDistance <= range) {
			target = nearestEnemy.transform;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
			return;

		if (fireCountdown <= 0f) {
			Shoot ();
			fireCountdown = 1f / fireRate;
		}

		fireCountdown -= Time.deltaTime;
	}

	void Shoot ()
	{
		enemyhealth = target.GetComponent<Enemy> ().updateHealth = target.GetComponent<Enemy> ().updateHealth - 20f;
		Debug.Log ("Shoot!");
		GameObject bulletGo = (GameObject)Instantiate (bulletPrefab, firePoint.position, firePoint.rotation);
		bullet bullt = bulletGo.GetComponent<bullet> ();

		if (bullt != null)
			bullt.Seek(target);
	}

	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, range);
	}
}
