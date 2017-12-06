using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerScript : MonoBehaviour {

	public EnemyWaypointScript EnemytargetWaypoint;
	//public EnemyWaypointScript next;
	//public GameObject targetWaypoint;

	bool isTechnician = false;
	bool castle = false;
	bool move = true;
	private float castleHealth;
	private float turretHealth;
	public Collider[] colliders;


	public int Ecollision;

	// Use this for initialization
	//	next = EnemytargetWaypoint;

		void Awake()
		{
			var randomInt = Random.Range (0, 100);
			Debug.Log (randomInt);
			if (randomInt >= 75) {
				//target = EnemyWaypoints.Enemypoints [0];
				//target = gameObject.name "
				EnemyWaypointScript.ER1 = true;
				EnemyWaypointScript.EL1 = false;
				EnemyWaypointScript.EC1 = false;
			}

			if (randomInt <= 25) {
				EnemyWaypointScript.EL1 = true;

				EnemyWaypointScript.ER1 = false;
				EnemyWaypointScript.EC1 = false;

				//target = EnemyWaypoints2.Enemypoints2 [0];
			}

			if (randomInt >= 50 && randomInt < 75) {
				EnemyWaypointScript.EC1 = true;
				EnemyWaypointScript.ER1 = false;
				EnemyWaypointScript.EL1 = false;
			}
	}
	
	// Update is called once per frame
	void Update () {
		Ecollision = gameObject.GetComponent<EnemyMovement> ().stopCollider;
		if (move && Ecollision ==0) {
			transform.LookAt (EnemytargetWaypoint.gameObject.transform.position + new Vector3(0, 0.5f, 0));
			transform.position += transform.forward * 5 * Time.deltaTime;
		}

		if (EnemytargetWaypoint == null) {
			return;
		}

		if (Vector3.Distance(gameObject.transform.position, EnemytargetWaypoint.gameObject.transform.position) < 1) {
			//Decide what to do next
			if (isTechnician && EnemytargetWaypoint.isTurretLocation) {
				move = false;
			} if (EnemytargetWaypoint.isCastle) {
				move = false;
				castleHealth = GameObject.Find ("PlayerCastle").GetComponent<CastleHealth> ().updateHealth = GameObject.Find ("PlayerCastle").GetComponent<CastleHealth> ().updateHealth - 1f;
					//col.gameObject.GetComponent<Enemy> ().updateHealth = col.gameObject.GetComponent<Enemy> ().updateHealth- 1f;
			}
			if (Ecollision == 1) {
				move = false;
			}
			if (EnemytargetWaypoint.isEnemyTurret) {
				move = false;
				//turretHealth = col.gameObject.GetComponent<Turret> ().updateHealth = col.gameObject.GetComponent<Turret> ().updateHealth - 1f;

			}
			else if (EnemytargetWaypoint.EnemyNext != null) {
				EnemytargetWaypoint = EnemytargetWaypoint.EnemyNext;
			}			
		}
	}
}
