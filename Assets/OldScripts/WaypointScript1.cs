using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript1 : MonoBehaviour {

	public WaypointScript1 next;
	public bool isTurretLocation = false;



	void OnDrawGizmos() {
		if (next != null) {
			Gizmos.color = Color.red;

			Gizmos.DrawLine (transform.position, next.gameObject.transform.position);
		}
			
	}

	// Use this for initialization
	void Start () {
		//nextR1 = gameObject("WaypointR.1(WaypointScript)");

	}



	// Update is called once per frame
	void Update () {

			

			//next = WaypointScript.Instantiate("WaypointR.1(WaypointScript)");
			//Debug.Log ("next");
			//next = gameObject.name ("WaypointR.1(WaypointScript));
			//next=GetComponent(WaypointScript);
			//find = GameObject.("WaypointR.1"(WaypointScript));
			//next = find;
			//next = GameObject.Find ("WaypointR.1(WaypointScript)");
			//next = find.GetComponent (WaypointScript);
		}


	}

