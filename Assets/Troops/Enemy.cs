using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed = 10f;

	private Transform target;
	private int wavepointIndex = 0;

	public static int gate;

	public float radius = 0f;
	public Collider[] colliders;
	public LayerMask mask;
	private int enemyhealth;
	public int health = 50;



	void Awake()
	{
		if (gate == 1) {
			target = Waypoints.points [0];
		}

		if (gate == 4) {
			target = Waypoints2.points2 [0];
		}

	}

	void Update ()
	{
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);

		if (Vector3.Distance (transform.position, target.position) <= 0.2f) {
			GetNextWaypoint();
		}

		if (health <=0) {
			Destroy(gameObject);
			return;

		}
		if (colliders.Length >= 1) {
			speed = 0f;
			Debug.Log ("stop");
			//ColliderHealth ();

		} else {
			speed = 5f;

		}
			
	}

	void FixedUpdate ()

	//void ColliderHealth()
	{
		//speed = 0f;
		colliders = Physics.OverlapSphere (transform.position, radius, mask);

		foreach (Collider col in colliders) {
			enemyhealth = col.gameObject.GetComponent<EnemyMovement> ().health = col.gameObject.GetComponent<EnemyMovement> ().health- 1;

			return;
			//enemyhealth = EnemyMovement.health - 1;
		}
			if (enemyhealth == null) {
				return;
			}



		//int healthhit = 




		//if (colliders.Length ==1) {
			//speed = 0f;
			//Debug.Log ("stop");

		//}
	}

	void GetNextWaypoint()
	{

		if(wavepointIndex >= Waypoints.points.Length - 1)
		{
			Destroy(gameObject);
			return;
		}

		
		wavepointIndex++;
		target = Waypoints.points [wavepointIndex];
}
}
