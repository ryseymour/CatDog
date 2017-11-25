using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript1 : MonoBehaviour {

	public WaypointScript1 targetWaypoint;
	//public GameObject targetWaypoint;

	bool isTechnician = true;
	bool move = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (move) {
			transform.LookAt (targetWaypoint.gameObject.transform.position + new Vector3(0, 0.5f, 0));
			transform.position += transform.forward * 20 * Time.deltaTime;
		}

		if (Vector3.Distance(gameObject.transform.position, targetWaypoint.gameObject.transform.position) < 1) {
			//Decide what to do next
			if (isTechnician && targetWaypoint.isTurretLocation) {
				move = false;
			} else if (targetWaypoint.next != null) {
				targetWaypoint = targetWaypoint.next;
			}			
		}
	}
}
