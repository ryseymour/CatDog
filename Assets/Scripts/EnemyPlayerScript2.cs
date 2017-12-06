using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerScript2 : MonoBehaviour {

	public EnemyWaypointScript2 EnemytargetWaypoint2;
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
			Debug.Log (randomInt+"test");
			if (randomInt >= 75) {
				//target = EnemyWaypoints.Enemypoints [0];
				//target = gameObject.name "
			EnemyWaypointScript2.R2 = true;
			EnemyWaypointScript2.L2 = false;
			EnemyWaypointScript2.C2 = false;
			}

			if (randomInt <= 25) {
			EnemyWaypointScript2.L2 = true;

			EnemyWaypointScript2.R2 = false;
				EnemyWaypointScript2.C2 = false;

				//target = EnemyWaypoints2.Enemypoints2 [0];
			}

			if (randomInt >= 50 && randomInt < 75) {
			EnemyWaypointScript2.C2 = true;
			EnemyWaypointScript2.R2 = false;
			EnemyWaypointScript2.L2 = false;
			}
	}
	
	// Update is called once per frame
	void Update () {
		Ecollision = gameObject.GetComponent<EnemyMovement2> ().stopCollider;
		if (move && Ecollision ==0) {
			transform.LookAt (EnemytargetWaypoint2.gameObject.transform.position + new Vector3(0, 0.5f, 0));
			transform.position += transform.forward * 5 * Time.deltaTime;
		}

		if (EnemytargetWaypoint2 == null) {
			return;
		}

		if (Vector3.Distance(gameObject.transform.position, EnemytargetWaypoint2.gameObject.transform.position) < 1) {
			//Decide what to do next
			if (isTechnician && EnemytargetWaypoint2.isTurretLocation) {
				move = false;
			} if (EnemytargetWaypoint2.isCastle) {
				move = false;
				castleHealth = GameObject.Find ("PlayerCastle").GetComponent<CastleHealth> ().updateHealth = GameObject.Find ("PlayerCastle").GetComponent<CastleHealth> ().updateHealth - 1f;
					//col.gameObject.GetComponent<Enemy> ().updateHealth = col.gameObject.GetComponent<Enemy> ().updateHealth- 1f;
			}
			if (Ecollision == 1) {
				move = false;
			}
			if (EnemytargetWaypoint2.isEnemyTurret) {
				move = false;
				//turretHealth = col.gameObject.GetComponent<Turret> ().updateHealth = col.gameObject.GetComponent<Turret> ().updateHealth - 1f;

			}
			else if (EnemytargetWaypoint2.EnemyNext2 != null) {
				EnemytargetWaypoint2 = EnemytargetWaypoint2.EnemyNext2;
			}			
		}
	}
}
