using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerScript : MonoBehaviour {

	public EnemyWaypointScript EnemytargetWaypoint;
	//public EnemyWaypointScript next;
	//public GameObject targetWaypoint;

	bool isTechnician = false;
	bool move = true;

	// Use this for initialization
	void Awake () {
	//	next = EnemytargetWaypoint;
	}
	
	// Update is called once per frame
	void Update () {
		if (move) {
			transform.LookAt (EnemytargetWaypoint.gameObject.transform.position + new Vector3(0, 0.5f, 0));
			transform.position += transform.forward * 20 * Time.deltaTime;
		}

		if (Vector3.Distance(gameObject.transform.position, EnemytargetWaypoint.gameObject.transform.position) < 1) {
			//Decide what to do next
			if (isTechnician && EnemytargetWaypoint.isTurretLocation) {
				move = false;
			} else if (EnemytargetWaypoint.EnemytargetWaypointNext != null) {
				EnemytargetWaypoint = EnemytargetWaypoint.EnemytargetWaypointNext;
			}			
		}
	}
}
