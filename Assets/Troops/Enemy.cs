using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float speed = 10f;

	private Transform target;
	private int wavepointIndex = 0;

	public static int gate;

	public float radius = 0f;
	public Collider[] colliders;
	public Collider[] selfColliders;
	public LayerMask mask;
	public LayerMask maskSelf;
	private float enemyhealth;
	public float health = 600;
	public float updateHealth;

	public Image healthbar;

	void Awake()
	{
		updateHealth = health;
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

		healthbar.fillAmount = updateHealth/health;

		if (updateHealth <=0f) {
			Destroy(gameObject);
			return;

		}
		if (colliders.Length >= 1 || selfColliders.Length>2) {
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
			enemyhealth = col.gameObject.GetComponent<EnemyMovement> ().health = col.gameObject.GetComponent<EnemyMovement> ().health- 1.0f;

			return;
			//enemyhealth = EnemyMovement.health - 1;
		}
			if (enemyhealth == null) {
				return;
			}

		selfColliders = Physics.OverlapSphere (transform.position, radius, maskSelf);

		



		//int healthhit = 




		//if (colliders.Length ==1) {
			//speed = 0f;
			//Debug.Log ("stop");

		//}
	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag("Minion"))
			Debug.Log ("wait");
			speed = 0f;
			
	
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
