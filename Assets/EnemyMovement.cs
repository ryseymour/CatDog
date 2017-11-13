using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float speed = 10f;

	private Transform target;
	private int wavepointIndex = 0;

	public float radius = 0f;
	public Collider[] colliders;
	public LayerMask mask;
	public int health = 50;
	private int herohealth;

	private int enemyhealth;

	//public static int gate;

	void Awake()
	{
		var randomInt = Random.Range (0, 100);
		Debug.Log (randomInt);
		if (randomInt >= 50) {
			target = EnemyWaypoints.Enemypoints [0];
		}

		if (randomInt <= 49) {

			target = EnemyWaypoints2.Enemypoints2 [0];
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
			WaveSpawner.currency = WaveSpawner.currency + 1;
			//currencyPlus = GameObject.Find ("GameMaster").GetComponent<WaveSpawner> ().gameObject.currency = currency + 1;
			return;

		}

		if (colliders.Length >= 1) {
			speed = 0f;
			//Debug.Log ("stop");

		} else {
			speed = 5f;

		}


			
	}

	void FixedUpdate ()
	{
		colliders = Physics.OverlapSphere (transform.position, radius, mask);


			foreach (Collider col in colliders) {
				herohealth = col.gameObject.GetComponent<Enemy> ().health = col.gameObject.GetComponent<Enemy> ().health- 1;
				//enemyhealth = EnemyMovement.health - 1;
			return;
			}

		if (enemyhealth == null) {
			return;
		}

		//if (colliders.Length ==1) {
		//speed = 0f;
		//Debug.Log ("stop");

		//}
	}

	void GetNextWaypoint()
	{

		if(wavepointIndex >= EnemyWaypoints.Enemypoints.Length - 1)
		{
			Destroy(gameObject);
			return;
		}

		
		wavepointIndex++;
		target = EnemyWaypoints.Enemypoints [wavepointIndex];
}
}
