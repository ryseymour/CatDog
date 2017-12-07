using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour {
	public static int Zone1;
	public static int Zone2;
	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown () {
		if (gameObject.name == "WaypointC.1") {
			Zone1 = 2;
			Debug.Log ("Zone"+ Zone1);
		}

		if (gameObject.name == "WaypointR.1") {
			Zone1 = 1;
			Debug.Log ("Zone"+ Zone1);
		}

		if (gameObject.name == "WaypointL.1") {
			Zone1 = 3;
			Debug.Log ("Zone"+ Zone1);
		}

		if (gameObject.name == "WaypointR.2") {
			Zone2 = 1;
			Debug.Log ("Zone2"+ Zone2);
		}

		if (gameObject.name == "WaypointC.2") {
			Zone2 = 2;
			Debug.Log ("Zone2"+ Zone2);
		}

		if (gameObject.name == "WaypointL.2") {
			Zone2 = 3;
			Debug.Log ("Zone2"+ Zone2);
		}

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
