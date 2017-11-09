using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float speed = 10f;

	private Transform target;
	private int wavepointIndex = 0;

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
